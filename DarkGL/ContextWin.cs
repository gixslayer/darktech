using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DarkTech.DarkGL
{
	/// <summary>
	/// Preliminary Win32 context class. Subject to change.
	/// </summary>
	public class ContextWin : Context, IDisposable
	{
		//private IntPtr hWnd;
		private PixelFormatDescriptor pfd;
		private bool disposed;

		/// <summary>
		/// Returns the device context handle.
		/// </summary>
		public IntPtr DC { get; private set; }

		/// <summary>
		/// Returns the rendering context handle.
		/// </summary>
		public IntPtr RC { get; private set; }

		public IntPtr hWnd { get; private set; }

		private ContextWin(ContextSetting setting, IntPtr hWnd)
		{
			this.Setting = setting;
			this.hWnd = hWnd;
			this.disposed = false;
		}

		~ContextWin()
		{
			Dispose();
		}

		/// <summary>
		/// Deletes the rendering context and releases the device context.
		/// </summary>
		public void Dispose()
		{
			if (!disposed)
			{
				UnmakeCurrent();

				if (RC != IntPtr.Zero)
					wgl.DeleteContext(RC);
				if (DC != IntPtr.Zero)
					Windows.ReleaseDC(hWnd, DC);

				RC = IntPtr.Zero;
				DC = IntPtr.Zero;

				disposed = true;
			}
		}

		/// <summary>
		/// Make rendering context current
		/// </summary>
		public override void MakeCurrent()
		{
			MakeCurrent(DC, RC);
		}

		/// <summary>
		/// Releasing context (shortcut for MakeCurrent(0,0))
		/// </summary>
		public override void UnmakeCurrent()
		{
			MakeCurrent(IntPtr.Zero, IntPtr.Zero);
		}

		private void MakeCurrent(IntPtr hDc, IntPtr newContext)
		{
			if (!wgl.MakeCurrent(hDc, newContext))
			{
				throw GetException("MakeCurrent failed");
			}
		}

		/// <summary>
		/// Swap buffers
		/// </summary>
		public override void SwapBuffers()
		{
			Windows.SwapBuffers(DC);
		}

		/// <summary>
		/// Creates a simple context
		/// </summary>
		/// <param name="c">Control to host the rendering context</param>
		private void CreateBaseContext()
		{
			DC = Windows.GetDC(hWnd);

			if (DC == IntPtr.Zero)
			{
				throw GetException("GetDC failed");
			}

			pfd = new PixelFormatDescriptor();
			pfd.Flags = PFDFlags.DOUBLEBUFFER | PFDFlags.SUPPORT_OPENGL | PFDFlags.DRAW_TO_WINDOW;
			pfd.PixelType = PFDPixelType.RGBA;
			pfd.ColorBits = Setting.ColorBits;
			pfd.AlphaBits = Setting.AlphaBits;
			pfd.DepthBits = Setting.DepthBits;
			pfd.StencilBits = Setting.StencilBits;

			int format = wgl.ChoosePixelFormat(DC, pfd);

			if (format == 0)
			{
				throw GetException("ChoosePixelFormat failed");
			}

			if (!Windows.SetPixelFormat(DC, format, pfd))
			{
				throw GetException("SetPixelFormat failed");
			}

			wgl.DescribePixelFormat(DC, format, (uint)pfd.Size, pfd);

			Setting.ColorBits = pfd.ColorBits;
			Setting.AlphaBits = pfd.AlphaBits;
			Setting.DepthBits = pfd.DepthBits;
			Setting.StencilBits = pfd.StencilBits;

			RC = wgl.CreateContext(DC);

			if (RC == IntPtr.Zero)
			{
				throw GetException("CreateContext failed");
			}

			MakeCurrent();

			Loader.Load(typeof(gl));
			Loader.Load(typeof(wgl));
		}

		/// <summary>
		/// Create OpenGL pre 3.0 context
		/// </summary>
		/// <param name="c">Control to host the rendering context</param>
		private void CreateOldContext()
		{
			if (Setting.Multisample == 0)
			{
				// create non-multisample context
				CreateBaseContext();
				MakeCurrent();

				return;
			}

			Form tmpform = new Form();
			ContextWin tmprc = new ContextWin(Setting, tmpform.Handle);
			tmprc.CreateBaseContext();

			// test multisampling and pixel format possibilities
			if (!(WGLExtension.isARB_pixel_format || WGLExtension.isEXT_pixel_format))
			{
				// if the maximum multisample should be used on non-multisample device, create a simple context without multisample.
				// if the number of samples is specified strictly on non-multisample device throw an exception.
				if (Setting.Multisample != 0xFF)
					throw new GLException(string.Format("ARB_pixel_format nor EXT_pixel_format is not supported."));

				CreateBaseContext();
				MakeCurrent();

				return;
			}

			int[] pixelFormat = new int[100];
			uint[] numFormats = new uint[1];
			float[] fAttributes = new float[] { 0, 0 };

			tmprc.Dispose();
			tmpform.Close();

			//hWnd = c.Handle;
			DC = Windows.GetDC(hWnd);

			if (Setting.Multisample == 0xFF)
			{
				Setting.Multisample = (byte)GetInteger(GL.MAX_SAMPLES_EXT);
			}

			if (Setting.Multisample > 0) // Number of samples was specified or the HW supports MAX_SAMPLES_EXT for multisample = 0xFF
			{
				int[] attributes = GetAttributes(true);
				bool valid = wgl.ChoosePixelFormat(DC, attributes, fAttributes, 1, pixelFormat, numFormats);

				if (valid && (numFormats[0] > 0))
				{
					if (!Windows.SetPixelFormat(DC, pixelFormat[0], pfd))
					{
						throw GetException("SetPixelFormat failed");
					}
				}
			}
			else // Does not support MAX_SAMPLES_EXT
			{
				int[] attributes = GetAttributes(false);
				bool valid = wgl.ChoosePixelFormat(DC, attributes, fAttributes, 100, pixelFormat, numFormats);

				if (valid && (numFormats[0] > 0))
				{
					int maxSamples = 0;
					int maxSamplesFormat = 0;
					int[] piAttributes = { WGL.SAMPLES_ARB };
					int[] piValues = new int[1];

					for (uint i = 0; i < Math.Min(100, numFormats[0]); i++)
					{
						wgl.GetPixelFormatAttribiv(DC, pixelFormat[i], 0, 1, piAttributes, piValues);

						if (piValues[0] > maxSamples)
						{
							maxSamples = piValues[0];
							maxSamplesFormat = (int)i;
						}
					}

					Setting.Multisample = (byte)maxSamples;

					if (!Windows.SetPixelFormat(DC, pixelFormat[maxSamplesFormat], pfd))
					{
						throw GetException("SetPixelFormat failed");
					}
				}
				else
				{
					CreateBaseContext();
					MakeCurrent();

					return;
				}
			}

			RC = wgl.CreateContext(DC);
			MakeCurrent();
		}

		private int[] GetAttributes(bool multisample)
		{
			if (multisample)
				return new int[] {  WGL.SAMPLES_ARB, Setting.Multisample,						
									WGL.DRAW_TO_WINDOW_ARB,(int)GL.TRUE,
									WGL.SUPPORT_OPENGL_ARB,(int)GL.TRUE,
									WGL.ACCELERATION_ARB,WGL.FULL_ACCELERATION_ARB,
									WGL.COLOR_BITS_ARB, Setting.ColorBits,
									WGL.ALPHA_BITS_ARB, Setting.AlphaBits,
									WGL.DEPTH_BITS_ARB, Setting.DepthBits,
									WGL.STENCIL_BITS_ARB, Setting.StencilBits,
									WGL.DOUBLE_BUFFER_ARB,(int)GL.TRUE,
									WGL.SAMPLE_BUFFERS_ARB,(int)GL.TRUE,		
									0,0 };
			else
				return new int[] {  WGL.DRAW_TO_WINDOW_ARB,(int)GL.TRUE,
									WGL.SUPPORT_OPENGL_ARB,(int)GL.TRUE,
									WGL.ACCELERATION_ARB,WGL.FULL_ACCELERATION_ARB,
									WGL.COLOR_BITS_ARB, Setting.ColorBits,
									WGL.ALPHA_BITS_ARB, Setting.AlphaBits,
									WGL.DEPTH_BITS_ARB, Setting.DepthBits,
									WGL.STENCIL_BITS_ARB, Setting.StencilBits,
									WGL.DOUBLE_BUFFER_ARB,(int)GL.TRUE,
									WGL.SAMPLE_BUFFERS_ARB,(int)GL.TRUE,		
									0,0 };
		}

		/// <summary>
		/// Create OpenGL post 3.0 context
		/// </summary>
		private void CreateNewContext()
		{
			if (!WGLExtension.isARB_create_context)
				throw new GLException(string.Format("ARB_create_context extension is not supported"));

			List<int> attribs = new List<int>();
			attribs.Add(WGL.CONTEXT_MAJOR_VERSION_ARB);
			attribs.Add(Setting.MajorVersion);
			attribs.Add(WGL.CONTEXT_MINOR_VERSION_ARB);
			attribs.Add(Setting.MinorVersion);
			attribs.Add(WGL.CONTEXT_FLAGS_ARB);
			attribs.Add((int)Setting.Flags);

			// Solve NVIDIA driver bug with 3.0, 3.1 context and CONTEXT_PROFILE_MASK
			// "If the requested OpenGL version is less than 3.2, WGL_CONTEXT_PROFILE_MASK_ARB is ignored and the functionality of the context is determined solely by the requested version."
			if ((Setting.MajorVersion > 3 || Setting.MinorVersion > 1))
			{
				attribs.Add(WGL.CONTEXT_PROFILE_MASK_ARB);
				attribs.Add((int)Setting.Profile);
			}

			attribs.Add(0);

			IntPtr newRC = wgl.CreateContextAttribs(DC, IntPtr.Zero, attribs.ToArray());

			if (newRC == IntPtr.Zero)
			{
				throw GetException("CreateContextAttribs failed");
			}

			UnmakeCurrent();
			wgl.DeleteContext(RC);

			RC = newRC;
			MakeCurrent();
		}

		/// <summary>
		/// Create Context using user setting.
		/// </summary>
		/// <param name="c">Control to host the rendering context</param>
		/// <param name="setting">Context setting parameters</param>
		/// <returns>Rendering context</returns>
		new public static Context CreateContext(IntPtr hWnd, ContextSetting setting)
		{
			ContextWin rc = new ContextWin(setting, hWnd);
			rc.CreateOldContext();

			// set highest context major version
			if (setting.MajorVersion == 0xff)
			{
				setting.MajorVersion = (byte)GetInteger(GL.MAJOR_VERSION);
			}

			// set highest context minor version
			if (setting.MinorVersion == 0xff)
			{
				setting.MinorVersion = (byte)GetInteger(GL.MINOR_VERSION);
			}

			// create new context using ARB_create_context
			if (setting.MajorVersion >= 3)
			{
				rc.CreateNewContext();
			}
			else
			{
				setting.Profile = ContextProfile.None;
				setting.Flags = ContextFlags.None;
			}

			setting.MajorVersion = (byte)GetInteger(GL.MAJOR_VERSION);
			setting.MinorVersion = (byte)GetInteger(GL.MINOR_VERSION);

			return rc;
		}

		private static string GetLastErrorMessage()
		{
			return new System.ComponentModel.Win32Exception().Message;
		}

		private static GLException GetException(string message)
		{
			return new GLException(string.Format("{0}: {1}: {2}", message, Windows.GetLastError(), GetLastErrorMessage()));
		}

		private static int GetInteger(int pname)
		{
			int[] buffer = new int[1];

			gl.GetIntegerv(pname, buffer);

			return buffer[0];
		}
	}
}
