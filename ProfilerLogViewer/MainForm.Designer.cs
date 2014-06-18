namespace ProfilerLogViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvFrames = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tlChildSections = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbTotalFrac = new System.Windows.Forms.ProgressBar();
            this.pbSiblingFrac = new System.Windows.Forms.ProgressBar();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblTotalFrac = new System.Windows.Forms.Label();
            this.lblSiblingFrac = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTotalDuration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbToolStrip = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numSelectedFrame = new System.Windows.Forms.NumericUpDown();
            this.lblActiveFrame = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numFrameCount = new System.Windows.Forms.NumericUpDown();
            this.tbSelectedFrame = new System.Windows.Forms.TrackBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSelectedFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrameCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSelectedFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 57);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvFrames);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(434, 384);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.TabIndex = 1;
            // 
            // tvFrames
            // 
            this.tvFrames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFrames.Location = new System.Drawing.Point(0, 0);
            this.tvFrames.Name = "tvFrames";
            this.tvFrames.Size = new System.Drawing.Size(144, 384);
            this.tvFrames.TabIndex = 0;
            this.tvFrames.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFrames_AfterSelect);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tlChildSections);
            this.groupBox3.Location = new System.Drawing.Point(3, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 166);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Child sections";
            // 
            // tlChildSections
            // 
            this.tlChildSections.ColumnCount = 2;
            this.tlChildSections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.18587F));
            this.tlChildSections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.81413F));
            this.tlChildSections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlChildSections.Location = new System.Drawing.Point(3, 16);
            this.tlChildSections.Name = "tlChildSections";
            this.tlChildSections.RowCount = 2;
            this.tlChildSections.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlChildSections.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlChildSections.Size = new System.Drawing.Size(269, 147);
            this.tlChildSections.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pbTotalFrac);
            this.groupBox2.Controls.Add(this.pbSiblingFrac);
            this.groupBox2.Controls.Add(this.tbDuration);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Controls.Add(this.lblTotalFrac);
            this.groupBox2.Controls.Add(this.lblSiblingFrac);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(3, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Section";
            // 
            // pbTotalFrac
            // 
            this.pbTotalFrac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTotalFrac.Location = new System.Drawing.Point(141, 100);
            this.pbTotalFrac.Name = "pbTotalFrac";
            this.pbTotalFrac.Size = new System.Drawing.Size(128, 23);
            this.pbTotalFrac.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbTotalFrac.TabIndex = 10;
            // 
            // pbSiblingFrac
            // 
            this.pbSiblingFrac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSiblingFrac.Location = new System.Drawing.Point(141, 71);
            this.pbSiblingFrac.Name = "pbSiblingFrac";
            this.pbSiblingFrac.Size = new System.Drawing.Size(128, 23);
            this.pbSiblingFrac.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbSiblingFrac.TabIndex = 9;
            // 
            // tbDuration
            // 
            this.tbDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDuration.Location = new System.Drawing.Point(141, 45);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.ReadOnly = true;
            this.tbDuration.Size = new System.Drawing.Size(128, 20);
            this.tbDuration.TabIndex = 8;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(141, 19);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(128, 20);
            this.tbName.TabIndex = 4;
            // 
            // lblTotalFrac
            // 
            this.lblTotalFrac.AutoSize = true;
            this.lblTotalFrac.Location = new System.Drawing.Point(6, 105);
            this.lblTotalFrac.Name = "lblTotalFrac";
            this.lblTotalFrac.Size = new System.Drawing.Size(110, 13);
            this.lblTotalFrac.TabIndex = 7;
            this.lblTotalFrac.Text = "Total fraction (0.00%):";
            // 
            // lblSiblingFrac
            // 
            this.lblSiblingFrac.AutoSize = true;
            this.lblSiblingFrac.Location = new System.Drawing.Point(6, 76);
            this.lblSiblingFrac.Name = "lblSiblingFrac";
            this.lblSiblingFrac.Size = new System.Drawing.Size(117, 13);
            this.lblSiblingFrac.TabIndex = 6;
            this.lblSiblingFrac.Text = "Sibling fraction (0.00%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Duration:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbTotalDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbIndex);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frame";
            // 
            // tbTotalDuration
            // 
            this.tbTotalDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalDuration.Location = new System.Drawing.Point(141, 45);
            this.tbTotalDuration.Name = "tbTotalDuration";
            this.tbTotalDuration.ReadOnly = true;
            this.tbTotalDuration.Size = new System.Drawing.Size(128, 20);
            this.tbTotalDuration.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total duration:";
            // 
            // tbIndex
            // 
            this.tbIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIndex.Location = new System.Drawing.Point(141, 19);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.ReadOnly = true;
            this.tbIndex.Size = new System.Drawing.Size(128, 20);
            this.tbIndex.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Index:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblToolStrip,
            this.pbToolStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 444);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(434, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblToolStrip
            // 
            this.lblToolStrip.Name = "lblToolStrip";
            this.lblToolStrip.Size = new System.Drawing.Size(26, 17);
            this.lblToolStrip.Text = "Idle";
            // 
            // pbToolStrip
            // 
            this.pbToolStrip.Name = "pbToolStrip";
            this.pbToolStrip.Size = new System.Drawing.Size(100, 16);
            this.pbToolStrip.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSelectedFrame);
            this.panel1.Controls.Add(this.numFrameCount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numSelectedFrame);
            this.panel1.Controls.Add(this.lblActiveFrame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 27);
            this.panel1.TabIndex = 5;
            // 
            // numSelectedFrame
            // 
            this.numSelectedFrame.Location = new System.Drawing.Point(48, 3);
            this.numSelectedFrame.Name = "numSelectedFrame";
            this.numSelectedFrame.Size = new System.Drawing.Size(87, 20);
            this.numSelectedFrame.TabIndex = 1;
            this.numSelectedFrame.ValueChanged += new System.EventHandler(this.numSelectedFrame_ValueChanged);
            // 
            // lblActiveFrame
            // 
            this.lblActiveFrame.AutoSize = true;
            this.lblActiveFrame.Location = new System.Drawing.Point(3, 5);
            this.lblActiveFrame.Name = "lblActiveFrame";
            this.lblActiveFrame.Size = new System.Drawing.Size(39, 13);
            this.lblActiveFrame.TabIndex = 0;
            this.lblActiveFrame.Text = "Frame:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "/";
            // 
            // numFrameCount
            // 
            this.numFrameCount.Location = new System.Drawing.Point(159, 3);
            this.numFrameCount.Name = "numFrameCount";
            this.numFrameCount.ReadOnly = true;
            this.numFrameCount.Size = new System.Drawing.Size(87, 20);
            this.numFrameCount.TabIndex = 3;
            // 
            // tbSelectedFrame
            // 
            this.tbSelectedFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSelectedFrame.AutoSize = false;
            this.tbSelectedFrame.Location = new System.Drawing.Point(252, 3);
            this.tbSelectedFrame.Name = "tbSelectedFrame";
            this.tbSelectedFrame.Size = new System.Drawing.Size(179, 20);
            this.tbSelectedFrame.TabIndex = 4;
            this.tbSelectedFrame.Scroll += new System.EventHandler(this.tbSelectedFrame_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profiler log viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSelectedFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrameCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSelectedFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvFrames;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTotalDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalFrac;
        private System.Windows.Forms.Label lblSiblingFrac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ProgressBar pbSiblingFrac;
        private System.Windows.Forms.ProgressBar pbTotalFrac;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblToolStrip;
        private System.Windows.Forms.ToolStripProgressBar pbToolStrip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tlChildSections;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numSelectedFrame;
        private System.Windows.Forms.Label lblActiveFrame;
        private System.Windows.Forms.NumericUpDown numFrameCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbSelectedFrame;
    }
}

