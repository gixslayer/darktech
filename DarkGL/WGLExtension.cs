using System.Reflection;

namespace DarkTech.DarkGL
{
    public static class WGLExtension
    {
        static WGLExtension()
        {
            string[] extensions = wgl.GetExtensionsStringEXT().ToString().Split(new char[] { ' ' });

            foreach (string extension in extensions)
            {
                string extensionName = extension;

                if (extensionName.StartsWith("WGL_"))
                {
                    extensionName = extensionName.Substring(4);
                }

                FieldInfo info = typeof(WGLExtension).GetField("is" + extensionName);

                if (info != null)
                {
                    info.SetValue(null, true);
                }
            }
        }

        public static bool isARB_buffer_region = false;
        public static bool isARB_multisample = false;
        public static bool isARB_extensions_string = false;
        public static bool isARB_pixel_format = false;
        public static bool isARB_make_current_read = false;
        public static bool isARB_pbuffer = false;
        public static bool isARB_render_texture = false;
        public static bool isARB_pixel_format_float = false;
        public static bool isARB_framebuffer_sRGB = false;
        public static bool isARB_create_context = false;
        public static bool isARB_create_context_profile = false;
        public static bool isARB_create_context_robustness = false;
        public static bool isEXT_display_color_table = false;
        public static bool isEXT_extensions_string = false;
        public static bool isEXT_make_current_read = false;
        public static bool isEXT_pbuffer = false;
        public static bool isEXT_pixel_format = false;
        public static bool isEXT_swap_control = false;
        public static bool isEXT_depth_float = false;
        public static bool isNV_vertex_array_range = false;
        public static bool is3DFX_multisample = false;
        public static bool isEXT_multisample = false;
        public static bool isOML_sync_control = false;
        public static bool isI3D_digital_video_control = false;
        public static bool isI3D_gamma = false;
        public static bool isI3D_genlock = false;
        public static bool isI3D_image_buffer = false;
        public static bool isI3D_swap_frame_lock = false;
        public static bool isI3D_swap_frame_usage = false;
        public static bool isATI_pixel_format_float = false;
        public static bool isNV_float_buffer = false;
        public static bool is3DL_stereo_control = false;
        public static bool isEXT_pixel_format_packed_float = false;
        public static bool isEXT_framebuffer_sRGB = false;
        public static bool isNV_present_video = false;
        public static bool isNV_video_output = false;
        public static bool isNV_swap_group = false;
        public static bool isNV_gpu_affinity = false;
        public static bool isAMD_gpu_association = false;
        public static bool isNV_video_capture = false;
        public static bool isNV_copy_image = false;
        public static bool isNV_multisample_coverage = false;
        public static bool isNV_DX_interop = false;
        public static bool isNV_DX_interop2 = false;
        public static bool isEXT_swap_control_tear = false;
    }
}
