using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using DarkTech.NativeWin32.Gdi32;
using DarkTech.NativeWin32.Kernel32;
using DarkTech.NativeWin32.User32;

namespace DarkTech.DarkGL
{
	/// <summary>
	/// Preliminary Win32 context class. Subject to change.
	/// </summary>
	public sealed class ContextWin : Context
	{
		private PixelFormatDescriptor pfd;
		private bool disposed;

		public IntPtr hDC { get; private set; }
		public IntPtr hRC { get; private set; }
		public IntPtr hWnd { get; private set; }

		private ContextWin(ContextSettings setting, IntPtr hWnd)
		{
			this.Settings = setting;
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
		public override void Dispose()
		{
			if (!disposed)
			{
				UnmakeCurrent();

				if (hRC != IntPtr.Zero)
				{
					wgl.DeleteContext(hRC);
					hRC = IntPtr.Zero;
				}

				if (hDC != IntPtr.Zero)
				{
					User32.ReleaseDC(hWnd, hDC);
					hDC = IntPtr.Zero;
				}

				disposed = true;
			}
		}

		/// <summary>
		/// Make rendering context current
		/// </summary>
		public override void MakeCurrent()
		{
			MakeCurrent(hDC, hRC);
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
			Gdi32.SwapBuffers(hDC);
		}

		/// <summary>
		/// Creates a simple context.
		/// </summary>
		private void CreateBaseContext()
		{
			// Attempt to get a handle to the current device context.
			hDC = User32.GetDC(hWnd);

			// Verify a valid handle was returned.
			if (hDC == IntPtr.Zero)
			{
				throw GetException("GetDC failed");
			}

			// Set the pixel format descriptor fields.
			pfd = new PixelFormatDescriptor();
			pfd.nSize = 40;
			pfd.nVersion = 1;
			pfd.dwFlags = PFDFlags.DoubleBuffer | PFDFlags.SupportOpenGL | PFDFlags.DrawToWindow;
			pfd.iPixelType = PFDPixelType.RGBA;
			pfd.cColorBits = Settings.ColorBits;
			pfd.cAlphaBits = Settings.AlphaBits;
			pfd.cDepthBits = Settings.DepthBits;
			pfd.cStencilBits = Settings.StencilBits;

			// Find the best match for the requested pixel format.
			int format = wgl.ChoosePixelFormat(hDC, ref pfd);

			// Verify at least one valid pixel format was found.
			if (format == 0)
			{
				throw GetException("ChoosePixelFormat failed");
			}

			// Set the pixel format to the format returned by ChoosePixelFormat and validate the operation.
			if (!Gdi32.SetPixelFormat(hDC, format, ref pfd))
			{
				throw GetException("SetPixelFormat failed");
			}

			// Pixel format was successfully set, grab the actual pixel format description.
			wgl.DescribePixelFormat(hDC, format, pfd.nSize, ref pfd);

			Settings.ColorBits = pfd.cColorBits;
			Settings.AlphaBits = pfd.cAlphaBits;
			Settings.DepthBits = pfd.cDepthBits;
			Settings.StencilBits = pfd.cStencilBits;

			// Attempt to create a rendering context on the current device context.
			hRC = wgl.CreateContext(hDC);

			// Verify the new rendering context was created successfully.
			if (hRC == IntPtr.Zero)
			{
				throw GetException("CreateContext failed");
			}

			// Make the newly created rending context current.
			MakeCurrent();

			// Load the OpenGL & WinGL function/extension pointers.
			Loader.Load<gl>();
			Loader.Load<wgl>();
		}

		/// <summary>
		/// Creates a pre OpenGL 3.0 context.
		/// </summary>
		private void CreateOldContext()
		{
			if (Settings.Multisample == 0)
			{
				// create non-multisample context
				CreateBaseContext();
				MakeCurrent();

				return;
			}

			// Replace Windows.Form with custom window library implementation.
			Form tmpform = new Form();
			ContextWin tmprc = new ContextWin(Settings, tmpform.Handle);
			tmprc.CreateBaseContext();

			// test multisampling and pixel format possibilities
			if (!(WGLExtension.hasARB_pixel_format || WGLExtension.hasEXT_pixel_format))
			{
				// if the maximum multisample should be used on non-multisample device, create a simple context without multisample.
				// if the number of samples is specified strictly on non-multisample device throw an exception.
				if (Settings.Multisample != 0xFF)
					throw new GLException(string.Format("ARB_pixel_format nor EXT_pixel_format is not supported."));

				CreateBaseContext();
				MakeCurrent();

				return;
			}

			tmprc.Dispose();
			tmpform.Close();

			int[] pixelFormat = new int[100];
			uint[] numFormats = new uint[1];
			float[] fAttributes = new float[] { 0, 0 };

			hDC = User32.GetDC(hWnd);

			if (Settings.Multisample == 0xFF)
			{
				Settings.Multisample = (byte)GetInteger(GL.MAX_SAMPLES_EXT);
			}

			if (Settings.Multisample > 0) // Number of samples was specified or the HW supports MAX_SAMPLES_EXT for multisample = 0xFF
			{
				int[] attributes = GetAttributes(true);
				bool valid = wgl.ChoosePixelFormat(hDC, attributes, fAttributes, 1, pixelFormat, numFormats);

				if (valid && (numFormats[0] > 0))
				{
					if (!Gdi32.SetPixelFormat(hDC, pixelFormat[0], ref pfd))
					{
						throw GetException("SetPixelFormat failed");
					}
				}
			}
			else // Does not support MAX_SAMPLES_EXT
			{
				int[] attributes = GetAttributes(false);
				bool valid = wgl.ChoosePixelFormat(hDC, attributes, fAttributes, 100, pixelFormat, numFormats);

				if (valid && (numFormats[0] > 0))
				{
					int maxSamples = 0;
					int maxSamplesFormat = 0;
					int[] piAttributes = { WGL.SAMPLES_ARB };
					int[] piValues = new int[1];

					for (uint i = 0; i < Math.Min(100, numFormats[0]); i++)
					{
						wgl.GetPixelFormatAttribiv(hDC, pixelFormat[i], 0, 1, piAttributes, piValues);

						if (piValues[0] > maxSamples)
						{
							maxSamples = piValues[0];
							maxSamplesFormat = (int)i;
						}
					}

					Settings.Multisample = (byte)maxSamples;

					if (!Gdi32.SetPixelFormat(hDC, pixelFormat[maxSamplesFormat], ref pfd))
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

			hRC = wgl.CreateContext(hDC);
			MakeCurrent();
		}

		private int[] GetAttributes(bool multisample)
		{
			if (multisample)
				return new int[] {  WGL.SAMPLES_ARB, Settings.Multisample,						
									WGL.DRAW_TO_WINDOW_ARB,(int)GL.TRUE,
									WGL.SUPPORT_OPENGL_ARB,(int)GL.TRUE,
									WGL.ACCELERATION_ARB,WGL.FULL_ACCELERATION_ARB,
									WGL.COLOR_BITS_ARB, Settings.ColorBits,
									WGL.ALPHA_BITS_ARB, Settings.AlphaBits,
									WGL.DEPTH_BITS_ARB, Settings.DepthBits,
									WGL.STENCIL_BITS_ARB, Settings.StencilBits,
									WGL.DOUBLE_BUFFER_ARB,(int)GL.TRUE,
									WGL.SAMPLE_BUFFERS_ARB,(int)GL.TRUE,		
									0,0 };
			else
				return new int[] {  WGL.DRAW_TO_WINDOW_ARB,(int)GL.TRUE,
									WGL.SUPPORT_OPENGL_ARB,(int)GL.TRUE,
									WGL.ACCELERATION_ARB,WGL.FULL_ACCELERATION_ARB,
									WGL.COLOR_BITS_ARB, Settings.ColorBits,
									WGL.ALPHA_BITS_ARB, Settings.AlphaBits,
									WGL.DEPTH_BITS_ARB, Settings.DepthBits,
									WGL.STENCIL_BITS_ARB, Settings.StencilBits,
									WGL.DOUBLE_BUFFER_ARB,(int)GL.TRUE,
									WGL.SAMPLE_BUFFERS_ARB,(int)GL.TRUE,		
									0,0 };
		}

		/// <summary>
		/// Creates a post OpenGL 3.0 context.
		/// </summary>
		private void CreateNewContext()
		{
			// Verify the ARB_create_context extension is loaded.
			if (!WGLExtension.hasARB_create_context)
			{
				throw new GLException("ARB_create_context extension is not supported");
			}

			// Build the attributes.
			List<int> attribs = new List<int>();
			attribs.Add(WGL.CONTEXT_MAJOR_VERSION_ARB);
			attribs.Add(Settings.MajorVersion);
			attribs.Add(WGL.CONTEXT_MINOR_VERSION_ARB);
			attribs.Add(Settings.MinorVersion);
			attribs.Add(WGL.CONTEXT_FLAGS_ARB);
			attribs.Add((int)Settings.Flags);

			// Solve NVIDIA driver bug with 3.0, 3.1 context and CONTEXT_PROFILE_MASK
			// "If the requested OpenGL version is less than 3.2, WGL_CONTEXT_PROFILE_MASK_ARB is ignored and the functionality of the context is determined solely by the requested version."
			if ((Settings.MajorVersion > 3 || Settings.MinorVersion > 1))
			{
				attribs.Add(WGL.CONTEXT_PROFILE_MASK_ARB);
				attribs.Add((int)Settings.Profile);
			}

			attribs.Add(0);

			// Attempt to create a new rendering context on the current device context using the specified attributes.
			IntPtr newRC = wgl.CreateContextAttribs(hDC, IntPtr.Zero, attribs.ToArray());

			// Verify the new rendering context was successfully created.
			if (newRC == IntPtr.Zero)
			{
				throw GetException("CreateContextAttribs failed");
			}

			// New rendering context created successfully.
			// Release and delete the current rendering context.
			UnmakeCurrent();
			wgl.DeleteContext(hRC);

			// Update the handle to the current rendering context and make it current.
			hRC = newRC;
			MakeCurrent();
		}

		/// <summary>
		/// Create Context using user setting.
		/// </summary>
		/// <param name="c">Control to host the rendering context</param>
		/// <param name="setting">Context setting parameters</param>
		/// <returns>Rendering context</returns>
		public static new Context CreateContext(IntPtr hWnd, ContextSettings setting)
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

		private static GLException GetException(string message)
		{
			return new GLException(string.Format("{0}: {1} ({2})", message, Kernel32.GetLastErrorMsg(), Kernel32.GetLastError()));
		}

		private static int GetInteger(int pname)
		{
			int param;

			gl.GetIntegerv(pname, out param);

			return param;
		}
	}
}
