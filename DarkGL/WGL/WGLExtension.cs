using System;
using System.Reflection;

namespace DarkTech.DarkGL
{
    public static class WGLExtension
    {
        static WGLExtension()
        {
            // Grab the extensions string. Each extension is separated by a space.
            string[] extensions = wgl.GetExtensionsStringEXT().ToString().Split(' ');
            Type type = typeof(WGLExtension);

            foreach (string extension in extensions)
            {
                string extensionName = extension;

                // If an extension starts with 'WGL_', then strip those characters.
                if (extensionName.StartsWith("WGL_"))
                {
                    extensionName = extensionName.Substring(4);
                }

                // If a field was found for the extension, update the value.
                FieldInfo info = type.GetField("has" + extensionName);

                if (info != null)
                {
                    info.SetValue(null, true);
                }
            }
        }

        public static bool hasARB_buffer_region = false;
        public static bool hasARB_multisample = false;
        public static bool hasARB_extensions_string = false;
        public static bool hasARB_pixel_format = false;
        public static bool hasARB_make_current_read = false;
        public static bool hasARB_pbuffer = false;
        public static bool hasARB_render_texture = false;
        public static bool hasARB_pixel_format_float = false;
        public static bool hasARB_framebuffer_sRGB = false;
        public static bool hasARB_create_context = false;
        public static bool hasARB_create_context_profile = false;
        public static bool hasARB_create_context_robustness = false;
        public static bool hasEXT_display_color_table = false;
        public static bool hasEXT_extensions_string = false;
        public static bool hasEXT_make_current_read = false;
        public static bool hasEXT_pbuffer = false;
        public static bool hasEXT_pixel_format = false;
        public static bool hasEXT_swap_control = false;
        public static bool hasEXT_depth_float = false;
        public static bool hasNV_vertex_array_range = false;
        public static bool has3DFX_multisample = false;
        public static bool hasEXT_multisample = false;
        public static bool hasOML_sync_control = false;
        public static bool hasI3D_digital_video_control = false;
        public static bool hasI3D_gamma = false;
        public static bool hasI3D_genlock = false;
        public static bool hasI3D_image_buffer = false;
        public static bool hasI3D_swap_frame_lock = false;
        public static bool hasI3D_swap_frame_usage = false;
        public static bool hasATI_pixel_format_float = false;
        public static bool hasNV_float_buffer = false;
        public static bool has3DL_stereo_control = false;
        public static bool hasEXT_pixel_format_packed_float = false;
        public static bool hasEXT_framebuffer_sRGB = false;
        public static bool hasNV_present_video = false;
        public static bool hasNV_video_output = false;
        public static bool hasNV_swap_group = false;
        public static bool hasNV_gpu_affinity = false;
        public static bool hasAMD_gpu_association = false;
        public static bool hasNV_video_capture = false;
        public static bool hasNV_copy_image = false;
        public static bool hasNV_multisample_coverage = false;
        public static bool hasNV_DX_interop = false;
        public static bool hasNV_DX_interop2 = false;
        public static bool hasEXT_swap_control_tear = false;
    }
}
