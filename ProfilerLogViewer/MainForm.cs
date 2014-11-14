using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using DarkTech.Engine.Debug;
using DarkTech.Common.IO;

namespace ProfilerLogViewer
{
    public partial class MainForm : Form
    {
        private delegate void LoadProgressUpdate(double progress);

        private List<FrameResult> frames = new List<FrameResult>();
        private FrameResult selectedFrame = null;
        private int selectedIndex = 0;
        private SectionResult selectedSection = null;
        private bool suppressSelectedFrame = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 1 && File.Exists(args[1]))
            {
                string logPath = args[1];

                LoadLog(logPath, ((double d) => {}));
            }

            SelectFrame(0);
            lblToolStrip.Text = "Idle";
        }

        private void LoadLog(string path, LoadProgressUpdate progressCallback)
        {
            // Caller must check that path is a valid file location.
            frames.Clear();

            try
            {
                progressCallback(0d);

                using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    DataStream dataStream = new DataStream(stream);

                    while (stream.Position < stream.Length)
                    {
                        FrameResult result = FrameResult.Deserialize(dataStream);
                        frames.Add(result);

                        progressCallback((double)stream.Position / (double)stream.Length);
                    }
                }

                progressCallback(1d);
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Failed to load file {0} -> {1}", path, e.Message), "Profiler log viewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectFrame(int index)
        {
            selectedFrame = frames.Count > index ? frames[index] : null;
            selectedIndex = index;
            selectedSection = null;

            UpdateGUI();
        }

        private void UpdateGUI()
        {
            UpdateSelectedFrameGUI();
            UpdateFrameTraversalGUI();
            UpdateFrameGUI();
            UpdateSectionGUI();
            UpdateSectionChildrenGUI();
        }

        private void UpdateSelectedFrameGUI()
        {
            suppressSelectedFrame = true;

            int frameCount = frames.Count - 1;

            numSelectedFrame.Maximum = frameCount == -1 ? 0 : frameCount;
            numSelectedFrame.Value = selectedIndex;
            numFrameCount.Maximum = frameCount == -1 ? 0 : frameCount;
            numFrameCount.Value = frameCount == -1 ? 0 : frameCount;
            tbSelectedFrame.Maximum = frameCount == -1 ? 0 : frameCount;
            tbSelectedFrame.Value = selectedIndex;
            int tickFreq = frames.Count / 100;
            tbSelectedFrame.TickFrequency = tickFreq == 0 ? 1 : tickFreq;

            suppressSelectedFrame = false;
        }

        private void UpdateFrameTraversalGUI()
        {
            tvFrames.Nodes.Clear();

            if (selectedFrame == null)
                return;

            foreach (SectionResult section in selectedFrame.Sections)
            {
                TreeNode node = new TreeNode(section.Name);

                node.Tag = section;

                foreach (SectionResult child in section.Children)
                {
                    AddChildSection(node, child);
                }

                tvFrames.Nodes.Add(node);
            }
        }

        private void UpdateFrameGUI()
        {
            if (selectedFrame == null)
            {
                tbIndex.Text = string.Empty;
                tbTotalDuration.Text = string.Empty;
            }
            else
            {
                tbIndex.Text = selectedFrame.FrameIndex.ToString();
                tbTotalDuration.Text = selectedFrame.TotalDuration.ToString();
            }
        }

        private void UpdateSectionGUI()
        {
            if (selectedSection == null)
            {
                tbName.Text = string.Empty;
                tbDuration.Text = string.Empty;
                lblSiblingFrac.Text = "Sibling fraction (0%):";
                pbSiblingFrac.Value = 0;
                lblTotalFrac.Text = "Sibling fraction (0%):";
                pbTotalFrac.Value = 0;
            }
            else
            {
                tbName.Text = selectedSection.Name;
                tbDuration.Text = selectedSection.Duration.ToString();
                decimal siblingFrac = new decimal(selectedSection.SiblingFraction * 100f);
                siblingFrac = Decimal.Round(siblingFrac, 2, MidpointRounding.AwayFromZero);
                lblSiblingFrac.Text = string.Format("Sibling fraction ({0}%):", siblingFrac.ToString());
                pbSiblingFrac.Value = (int)siblingFrac;
                decimal totalFrac = new decimal(selectedSection.TotalFraction * 100f);
                totalFrac = Decimal.Round(totalFrac, 2, MidpointRounding.AwayFromZero);
                lblTotalFrac.Text = string.Format("Total fraction ({0}%):", totalFrac.ToString());
                pbTotalFrac.Value = (int)totalFrac;
            }
        }

        private void UpdateSectionChildrenGUI()
        {
            tlChildSections.Controls.Clear();

            if (selectedSection == null || selectedSection.Children.Count == 0)
                return;

            tlChildSections.RowCount = selectedSection.Children.Count;
            tlChildSections.Controls.Clear();
            tlChildSections.RowStyles.Clear();
            tlChildSections.ColumnStyles.Clear();

            tlChildSections.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 138));
            tlChildSections.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            for (int i = 0; i < selectedSection.Children.Count; i++)
            {
                SectionResult child = selectedSection.Children[i];

                tlChildSections.RowStyles.Add(new RowStyle(SizeType.Absolute, 29));

                decimal childFrac = new decimal(child.SiblingFraction * 100f);
                childFrac = Decimal.Round(childFrac, 2, MidpointRounding.AwayFromZero);
                LinkLabel label = new LinkLabel();
                label.Text = string.Format("{0} ({1}%):", child.Name, childFrac.ToString());

                label.LinkBehavior = LinkBehavior.HoverUnderline;
                TreeNode linkDestination = null;

                if (tvFrames.SelectedNode != null)
                {
                    foreach (TreeNode childNode in tvFrames.SelectedNode.Nodes)
                    {
                        if (childNode.Text == child.Name)
                        {
                            linkDestination = childNode;

                            break;
                        }
                    }
                }

                if (linkDestination != null)
                {
                    LinkLabel.Link link = new LinkLabel.Link();
                    link.LinkData = linkDestination;
                    label.Links.Add(link);
                    label.LinkClicked += label_LinkClicked;
                }

                ProgressBar progressBar = new ProgressBar();
                progressBar.Style = ProgressBarStyle.Continuous;
                progressBar.Width = 125;
                progressBar.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                progressBar.Value = (int)(child.SiblingFraction * 100f);

                tlChildSections.Controls.Add(label, 0, i);
                tlChildSections.Controls.Add(progressBar, 1, i);
            }
        }

        private void AddChildSection(TreeNode parent, SectionResult section)
        {
            TreeNode sectionNode = new TreeNode(section.Name);

            sectionNode.Tag = section;

            foreach (SectionResult subSection in section.Children)
            {
                AddChildSection(sectionNode, subSection);
            }

            parent.Nodes.Add(sectionNode);
        }

        private void UpdateProgress(double progress)
        {
            pbToolStrip.Value = (int)(progress * 100d);

            Application.DoEvents();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.CheckFileExists = true;
            dialog.Multiselect = false;
            dialog.RestoreDirectory = true;
            dialog.Title = "Select a profiler log file to open";

            DialogResult dialogResult = dialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                lblToolStrip.Text = "Loading log";
                LoadLog(dialog.FileName, UpdateProgress);
                SelectFrame(0);
                lblToolStrip.Text = "Idle";
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frames.Clear();
            selectedIndex = 0;
            selectedFrame = null;
            selectedSection = null;
            UpdateGUI();
        }

        private void tvFrames_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedSection = (SectionResult)e.Node.Tag;

            UpdateSectionGUI();
            UpdateSectionChildrenGUI();
        }

        private void label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tvFrames.SelectedNode = (TreeNode)e.Link.LinkData;
            tvFrames.Focus();
        }

        private void numSelectedFrame_ValueChanged(object sender, EventArgs e)
        {
            if (suppressSelectedFrame)
                return;

            SelectFrame((int)numSelectedFrame.Value);
        }

        private void tbSelectedFrame_Scroll(object sender, EventArgs e)
        {
            if (suppressSelectedFrame)
                return;

            SelectFrame(tbSelectedFrame.Value);
        }
    }
}
