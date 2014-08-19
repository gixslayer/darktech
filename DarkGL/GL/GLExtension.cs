using System.Collections.Generic;
using System.Reflection;

namespace DarkTech.DarkGL
{
    public static class GLExtension
    {
        private static HashSet<string> detectedExtensions;

        static GLExtension()
        {
            detectedExtensions = new HashSet<string>();
            string[] extensions;
            string extensionsString = gl.GetStringNet(GL.EXTENSIONS);

            if (extensionsString != null)
            {
                extensions = extensionsString.Split(' ');
            }
            else
            {
                // OpenGL 3.1 core does not support GetString with GL_EXTENSIONS parameter.
                int numExtensions;

                gl.GetIntegerv(GL.NUM_EXTENSIONS, out numExtensions);

                extensions = new string[numExtensions];

                for (uint i = 0; i < numExtensions; i++)
                {
                    extensions[i] = gl.GetStringiNet(GL.EXTENSIONS, i);
                }
            }

            // Iterate through all detected extensions.
            foreach (string extension in extensions)
            {
                string extensionName = extension;

                // Add the extension to the detected collection.
                detectedExtensions.Add(extension);

                // If the extension starts with 'GL_' then strip the character sequence.
                if (extensionName.StartsWith("GL_"))
                {
                    extensionName = extensionName.Substring(3);
                }

                // Set the extension field to true.
                SetField("has" + extensionName, true);
            }

            // Grab OpenGL version information string.
            // GL_VERSION string format: major.minor or major.minor.release
            string[] version = gl.GetStringNet(GL.VERSION).Split('.');

            versionMajor = int.Parse(version[0]);
            versionMinor = int.Parse(version[1]);

            // Set the isVERSION_MAJOR_MINOR field to true.
            SetField(string.Format("isVERSION_{0}_{1}", versionMajor, versionMinor), true);  
        }

        public static bool isDetected(string extension)
        {
            return detectedExtensions.Contains(extension);
        }

        public static bool isVersionOrHigher(int major, int minor)
        {
            return ((major << 16 + minor) <= (versionMajor << 16 + versionMinor));
        }

        private static void SetField(string name, bool value)
        {
            FieldInfo fieldInfo = typeof(GLExtension).GetField(name);

            if (fieldInfo != null)
            {
                fieldInfo.SetValue(null, value);
            }
        }

        public static int versionMajor = 0;
        public static int versionMinor = 0;

        public static bool isVERSION_1_0 = false;
        public static bool isVERSION_1_1 = false;
        public static bool isVERSION_1_2 = false;
        public static bool isVERSION_1_3 = false;
        public static bool isVERSION_1_4 = false;
        public static bool isVERSION_1_5 = false;
        public static bool isVERSION_2_0 = false;
        public static bool isVERSION_2_1 = false;
        public static bool isVERSION_3_0 = false;
        public static bool isVERSION_3_1 = false;
        public static bool isVERSION_3_2 = false;
        public static bool isVERSION_3_3 = false;
        public static bool isVERSION_4_0 = false;
        public static bool isVERSION_4_1 = false;
        public static bool isVERSION_4_2 = false;
        public static bool isVERSION_4_3 = false;
        public static bool isVERSION_4_4 = false;
        public static bool isVERSION_4_5 = false;

        public static bool hasARB_multitexture = false;
        public static bool hasARB_transpose_matrix = false;
        public static bool hasARB_multisample = false;
        public static bool hasARB_texture_env_add = false;
        public static bool hasARB_texture_cube_map = false;
        public static bool hasARB_texture_compression = false;
        public static bool hasARB_texture_border_clamp = false;
        public static bool hasARB_point_parameters = false;
        public static bool hasARB_vertex_blend = false;
        public static bool hasARB_matrix_palette = false;
        public static bool hasARB_texture_env_combine = false;
        public static bool hasARB_texture_env_crossbar = false;
        public static bool hasARB_texture_env_dot3 = false;
        public static bool hasARB_texture_mirrored_repeat = false;
        public static bool hasARB_depth_texture = false;
        public static bool hasARB_shadow = false;
        public static bool hasARB_shadow_ambient = false;
        public static bool hasARB_window_pos = false;
        public static bool hasARB_vertex_program = false;
        public static bool hasARB_fragment_program = false;
        public static bool hasARB_vertex_buffer_object = false;
        public static bool hasARB_occlusion_query = false;
        public static bool hasARB_shader_objects = false;
        public static bool hasARB_vertex_shader = false;
        public static bool hasARB_fragment_shader = false;
        public static bool hasARB_shading_language_100 = false;
        public static bool hasARB_texture_non_power_of_two = false;
        public static bool hasARB_point_sprite = false;
        public static bool hasARB_fragment_program_shadow = false;
        public static bool hasARB_draw_buffers = false;
        public static bool hasARB_texture_rectangle = false;
        public static bool hasARB_color_buffer_float = false;
        public static bool hasARB_half_float_pixel = false;
        public static bool hasARB_texture_float = false;
        public static bool hasARB_pixel_buffer_object = false;
        public static bool hasARB_depth_buffer_float = false;
        public static bool hasARB_draw_instanced = false;
        public static bool hasARB_framebuffer_object = false;
        public static bool hasARB_framebuffer_sRGB = false;
        public static bool hasARB_geometry_shader4 = false;
        public static bool hasARB_half_float_vertex = false;
        public static bool hasARB_instanced_arrays = false;
        public static bool hasARB_map_buffer_range = false;
        public static bool hasARB_texture_buffer_object = false;
        public static bool hasARB_texture_compression_rgtc = false;
        public static bool hasARB_texture_rg = false;
        public static bool hasARB_vertex_array_object = false;
        public static bool hasARB_uniform_buffer_object = false;
        public static bool hasARB_compatibility = false;
        public static bool hasARB_copy_buffer = false;
        public static bool hasARB_shader_texture_lod = false;
        public static bool hasARB_depth_clamp = false;
        public static bool hasARB_draw_elements_base_vertex = false;
        public static bool hasARB_fragment_coord_conventions = false;
        public static bool hasARB_provoking_vertex = false;
        public static bool hasARB_seamless_cube_map = false;
        public static bool hasARB_sync = false;
        public static bool hasARB_texture_multisample = false;
        public static bool hasARB_vertex_array_bgra = false;
        public static bool hasARB_draw_buffers_blend = false;
        public static bool hasARB_sample_shading = false;
        public static bool hasARB_texture_cube_map_array = false;
        public static bool hasARB_texture_gather = false;
        public static bool hasARB_texture_query_lod = false;
        public static bool hasARB_shading_language_include = false;
        public static bool hasARB_texture_compression_bptc = false;
        public static bool hasARB_blend_func_extended = false;
        public static bool hasARB_explicit_attrib_location = false;
        public static bool hasARB_occlusion_query2 = false;
        public static bool hasARB_sampler_objects = false;
        public static bool hasARB_shader_bit_encoding = false;
        public static bool hasARB_texture_rgb10_a2ui = false;
        public static bool hasARB_texture_swizzle = false;
        public static bool hasARB_timer_query = false;
        public static bool hasARB_vertex_type_2_10_10_10_rev = false;
        public static bool hasARB_draw_indirect = false;
        public static bool hasARB_gpu_shader5 = false;
        public static bool hasARB_gpu_shader_fp64 = false;
        public static bool hasARB_shader_subroutine = false;
        public static bool hasARB_tessellation_shader = false;
        public static bool hasARB_texture_buffer_object_rgb32 = false;
        public static bool hasARB_transform_feedback2 = false;
        public static bool hasARB_transform_feedback3 = false;
        public static bool hasARB_ES2_compatibility = false;
        public static bool hasARB_get_program_binary = false;
        public static bool hasARB_separate_shader_objects = false;
        public static bool hasARB_vertex_attrib_64bit = false;
        public static bool hasARB_viewport_array = false;
        public static bool hasARB_cl_event = false;
        public static bool hasARB_debug_output = false;
        public static bool hasARB_robustness = false;
        public static bool hasARB_shader_stencil_export = false;
        public static bool hasARB_base_instance = false;
        public static bool hasARB_shading_language_420pack = false;
        public static bool hasARB_transform_feedback_instanced = false;
        public static bool hasARB_compressed_texture_pixel_storage = false;
        public static bool hasARB_conservative_depth = false;
        public static bool hasARB_internalformat_query = false;
        public static bool hasARB_map_buffer_alignment = false;
        public static bool hasARB_shader_atomic_counters = false;
        public static bool hasARB_shader_image_load_store = false;
        public static bool hasARB_shading_language_packing = false;
        public static bool hasARB_texture_storage = false;
        public static bool hasKHR_texture_compression_astc_ldr = false;
        public static bool hasKHR_debug = false;
        public static bool hasARB_arrays_of_arrays = false;
        public static bool hasARB_clear_buffer_object = false;
        public static bool hasARB_compute_shader = false;
        public static bool hasARB_copy_image = false;
        public static bool hasARB_texture_view = false;
        public static bool hasARB_vertex_attrib_binding = false;
        public static bool hasARB_robustness_isolation = false;
        public static bool hasARB_ES3_compatibility = false;
        public static bool hasARB_explicit_uniform_location = false;
        public static bool hasARB_fragment_layer_viewport = false;
        public static bool hasARB_framebuffer_no_attachments = false;
        public static bool hasARB_internalformat_query2 = false;
        public static bool hasARB_invalidate_subdata = false;
        public static bool hasARB_multi_draw_indirect = false;
        public static bool hasARB_program_interface_query = false;
        public static bool hasARB_robust_buffer_access_behavior = false;
        public static bool hasARB_shader_image_size = false;
        public static bool hasARB_shader_storage_buffer_object = false;
        public static bool hasARB_stencil_texturing = false;
        public static bool hasARB_texture_buffer_range = false;
        public static bool hasARB_texture_query_levels = false;
        public static bool hasARB_texture_storage_multisample = false;
        public static bool hasEXT_abgr = false;
        public static bool hasEXT_blend_color = false;
        public static bool hasEXT_polygon_offset = false;
        public static bool hasEXT_texture = false;
        public static bool hasEXT_texture3D = false;
        public static bool hasSGIS_texture_filter4 = false;
        public static bool hasEXT_subtexture = false;
        public static bool hasEXT_copy_texture = false;
        public static bool hasEXT_histogram = false;
        public static bool hasEXT_convolution = false;
        public static bool hasSGI_color_matrix = false;
        public static bool hasSGI_color_table = false;
        public static bool hasSGIX_pixel_texture = false;
        public static bool hasSGIS_pixel_texture = false;
        public static bool hasSGIS_texture4D = false;
        public static bool hasSGI_texture_color_table = false;
        public static bool hasEXT_cmyka = false;
        public static bool hasEXT_texture_object = false;
        public static bool hasSGIS_detail_texture = false;
        public static bool hasSGIS_sharpen_texture = false;
        public static bool hasEXT_packed_pixels = false;
        public static bool hasSGIS_texture_lod = false;
        public static bool hasSGIS_multisample = false;
        public static bool hasEXT_rescale_normal = false;
        public static bool hasEXT_vertex_array = false;
        public static bool hasEXT_misc_attribute = false;
        public static bool hasSGIS_generate_mipmap = false;
        public static bool hasSGIX_clipmap = false;
        public static bool hasSGIX_shadow = false;
        public static bool hasSGIS_texture_edge_clamp = false;
        public static bool hasSGIS_texture_border_clamp = false;
        public static bool hasEXT_blend_minmax = false;
        public static bool hasEXT_blend_subtract = false;
        public static bool hasEXT_blend_logic_op = false;
        public static bool hasSGIX_interlace = false;
        public static bool hasSGIX_pixel_tiles = false;
        public static bool hasSGIX_texture_select = false;
        public static bool hasSGIX_sprite = false;
        public static bool hasSGIX_texture_multi_buffer = false;
        public static bool hasEXT_point_parameters = false;
        public static bool hasSGIS_point_parameters = false;
        public static bool hasSGIX_instruments = false;
        public static bool hasSGIX_texture_scale_bias = false;
        public static bool hasSGIX_framezoom = false;
        public static bool hasSGIX_tag_sample_buffer = false;
        public static bool hasSGIX_polynomial_ffd = false;
        public static bool hasSGIX_reference_plane = false;
        public static bool hasSGIX_flush_raster = false;
        public static bool hasSGIX_depth_texture = false;
        public static bool hasSGIS_fog_function = false;
        public static bool hasSGIX_fog_offset = false;
        public static bool hasHP_image_transform = false;
        public static bool hasHP_convolution_border_modes = false;
        public static bool hasSGIX_texture_add_env = false;
        public static bool hasEXT_color_subtable = false;
        public static bool hasPGI_vertex_hints = false;
        public static bool hasPGI_misc_hints = false;
        public static bool hasEXT_paletted_texture = false;
        public static bool hasEXT_clip_volume_hint = false;
        public static bool hasSGIX_list_priority = false;
        public static bool hasSGIX_ir_instrument1 = false;
        public static bool hasSGIX_calligraphic_fragment = false;
        public static bool hasSGIX_texture_lod_bias = false;
        public static bool hasSGIX_shadow_ambient = false;
        public static bool hasEXT_index_texture = false;
        public static bool hasEXT_index_material = false;
        public static bool hasEXT_index_func = false;
        public static bool hasEXT_index_array_formats = false;
        public static bool hasEXT_compiled_vertex_array = false;
        public static bool hasEXT_cull_vertex = false;
        public static bool hasSGIX_ycrcb = false;
        public static bool hasSGIX_fragment_lighting = false;
        public static bool hasIBM_rasterpos_clip = false;
        public static bool hasHP_texture_lighting = false;
        public static bool hasEXT_draw_range_elements = false;
        public static bool hasWIN_phong_shading = false;
        public static bool hasWIN_specular_fog = false;
        public static bool hasEXT_light_texture = false;
        public static bool hasSGIX_blend_alpha_minmax = false;
        public static bool hasEXT_bgra = false;
        public static bool hasSGIX_async = false;
        public static bool hasSGIX_async_pixel = false;
        public static bool hasSGIX_async_histogram = false;
        public static bool hasINTEL_parallel_arrays = false;
        public static bool hasHP_occlusion_test = false;
        public static bool hasEXT_pixel_transform = false;
        public static bool hasEXT_pixel_transform_color_table = false;
        public static bool hasEXT_shared_texture_palette = false;
        public static bool hasEXT_separate_specular_color = false;
        public static bool hasEXT_secondary_color = false;
        public static bool hasEXT_texture_perturb_normal = false;
        public static bool hasEXT_multi_draw_arrays = false;
        public static bool hasEXT_fog_coord = false;
        public static bool hasREND_screen_coordinates = false;
        public static bool hasEXT_coordinate_frame = false;
        public static bool hasEXT_texture_env_combine = false;
        public static bool hasAPPLE_specular_vector = false;
        public static bool hasAPPLE_transform_hint = false;
        public static bool hasSGIX_fog_scale = false;
        public static bool hasSUNX_constant_data = false;
        public static bool hasSUN_global_alpha = false;
        public static bool hasSUN_triangle_list = false;
        public static bool hasSUN_vertex = false;
        public static bool hasEXT_blend_func_separate = false;
        public static bool hasINGR_blend_func_separate = false;
        public static bool hasINGR_color_clamp = false;
        public static bool hasINGR_interlace_read = false;
        public static bool hasEXT_stencil_wrap = false;
        public static bool hasEXT_422_pixels = false;
        public static bool hasNV_texgen_reflection = false;
        public static bool hasSUN_convolution_border_modes = false;
        public static bool hasEXT_texture_env_add = false;
        public static bool hasEXT_texture_lod_bias = false;
        public static bool hasEXT_texture_filter_anisotropic = false;
        public static bool hasEXT_vertex_weighting = false;
        public static bool hasNV_light_max_exponent = false;
        public static bool hasNV_vertex_array_range = false;
        public static bool hasNV_register_combiners = false;
        public static bool hasNV_fog_distance = false;
        public static bool hasNV_texgen_emboss = false;
        public static bool hasNV_blend_square = false;
        public static bool hasNV_texture_env_combine4 = false;
        public static bool hasMESA_resize_buffers = false;
        public static bool hasMESA_window_pos = false;
        public static bool hasIBM_cull_vertex = false;
        public static bool hasIBM_multimode_draw_arrays = false;
        public static bool hasIBM_vertex_array_lists = false;
        public static bool hasSGIX_subsample = false;
        public static bool hasSGIX_ycrcba = false;
        public static bool hasSGIX_ycrcb_subsample = false;
        public static bool hasSGIX_depth_pass_instrument = false;
        public static bool has3DFX_texture_compression_FXT1 = false;
        public static bool has3DFX_multisample = false;
        public static bool has3DFX_tbuffer = false;
        public static bool hasEXT_multisample = false;
        public static bool hasSGIX_vertex_preclip = false;
        public static bool hasSGIX_convolution_accuracy = false;
        public static bool hasSGIX_resample = false;
        public static bool hasSGIS_point_line_texgen = false;
        public static bool hasSGIS_texture_color_mask = false;
        public static bool hasSGIX_igloo_interface = false;
        public static bool hasEXT_texture_env_dot3 = false;
        public static bool hasATI_texture_mirror_once = false;
        public static bool hasNV_fence = false;
        public static bool hasNV_evaluators = false;
        public static bool hasNV_packed_depth_stencil = false;
        public static bool hasNV_register_combiners2 = false;
        public static bool hasNV_texture_compression_vtc = false;
        public static bool hasNV_texture_rectangle = false;
        public static bool hasNV_texture_shader = false;
        public static bool hasNV_texture_shader2 = false;
        public static bool hasNV_vertex_array_range2 = false;
        public static bool hasNV_vertex_program = false;
        public static bool hasSGIX_texture_coordinate_clamp = false;
        public static bool hasSGIX_scalebias_hint = false;
        public static bool hasOML_interlace = false;
        public static bool hasOML_subsample = false;
        public static bool hasOML_resample = false;
        public static bool hasNV_copy_depth_to_color = false;
        public static bool hasATI_envmap_bumpmap = false;
        public static bool hasATI_fragment_shader = false;
        public static bool hasATI_pn_triangles = false;
        public static bool hasATI_vertex_array_object = false;
        public static bool hasEXT_vertex_shader = false;
        public static bool hasATI_vertex_streams = false;
        public static bool hasATI_element_array = false;
        public static bool hasSUN_mesh_array = false;
        public static bool hasSUN_slice_accum = false;
        public static bool hasNV_multisample_filter_hint = false;
        public static bool hasNV_depth_clamp = false;
        public static bool hasNV_occlusion_query = false;
        public static bool hasNV_point_sprite = false;
        public static bool hasNV_texture_shader3 = false;
        public static bool hasNV_vertex_program1_1 = false;
        public static bool hasEXT_shadow_funcs = false;
        public static bool hasEXT_stencil_two_side = false;
        public static bool hasATI_text_fragment_shader = false;
        public static bool hasAPPLE_client_storage = false;
        public static bool hasAPPLE_element_array = false;
        public static bool hasAPPLE_fence = false;
        public static bool hasAPPLE_vertex_array_object = false;
        public static bool hasAPPLE_vertex_array_range = false;
        public static bool hasAPPLE_ycbcr_422 = false;
        public static bool hasS3_s3tc = false;
        public static bool hasATI_draw_buffers = false;
        public static bool hasATI_pixel_format_float = false;
        public static bool hasATI_texture_env_combine3 = false;
        public static bool hasATI_texture_float = false;
        public static bool hasNV_float_buffer = false;
        public static bool hasNV_fragment_program = false;
        public static bool hasNV_half_float = false;
        public static bool hasNV_pixel_data_range = false;
        public static bool hasNV_primitive_restart = false;
        public static bool hasNV_texture_expand_normal = false;
        public static bool hasNV_vertex_program2 = false;
        public static bool hasATI_map_object_buffer = false;
        public static bool hasATI_separate_stencil = false;
        public static bool hasATI_vertex_attrib_array_object = false;
        public static bool hasOES_read_format = false;
        public static bool hasEXT_depth_bounds_test = false;
        public static bool hasEXT_texture_mirror_clamp = false;
        public static bool hasEXT_blend_equation_separate = false;
        public static bool hasMESA_pack_invert = false;
        public static bool hasMESA_ycbcr_texture = false;
        public static bool hasEXT_pixel_buffer_object = false;
        public static bool hasNV_fragment_program_option = false;
        public static bool hasNV_fragment_program2 = false;
        public static bool hasNV_vertex_program2_option = false;
        public static bool hasNV_vertex_program3 = false;
        public static bool hasEXT_framebuffer_object = false;
        public static bool hasGREMEDY_string_marker = false;
        public static bool hasEXT_packed_depth_stencil = false;
        public static bool hasEXT_stencil_clear_tag = false;
        public static bool hasEXT_texture_sRGB = false;
        public static bool hasEXT_framebuffer_blit = false;
        public static bool hasEXT_framebuffer_multisample = false;
        public static bool hasMESAX_texture_stack = false;
        public static bool hasEXT_timer_query = false;
        public static bool hasEXT_gpu_program_parameters = false;
        public static bool hasAPPLE_flush_buffer_range = false;
        public static bool hasNV_gpu_program4 = false;
        public static bool hasNV_geometry_program4 = false;
        public static bool hasEXT_geometry_shader4 = false;
        public static bool hasNV_vertex_program4 = false;
        public static bool hasEXT_gpu_shader4 = false;
        public static bool hasEXT_draw_instanced = false;
        public static bool hasEXT_packed_float = false;
        public static bool hasEXT_texture_array = false;
        public static bool hasEXT_texture_buffer_object = false;
        public static bool hasEXT_texture_compression_latc = false;
        public static bool hasEXT_texture_compression_rgtc = false;
        public static bool hasEXT_texture_shared_exponent = false;
        public static bool hasNV_depth_buffer_float = false;
        public static bool hasNV_fragment_program4 = false;
        public static bool hasNV_framebuffer_multisample_coverage = false;
        public static bool hasEXT_framebuffer_sRGB = false;
        public static bool hasNV_geometry_shader4 = false;
        public static bool hasNV_parameter_buffer_object = false;
        public static bool hasEXT_draw_buffers2 = false;
        public static bool hasNV_transform_feedback = false;
        public static bool hasEXT_bindable_uniform = false;
        public static bool hasEXT_texture_integer = false;
        public static bool hasGREMEDY_frame_terminator = false;
        public static bool hasNV_conditional_render = false;
        public static bool hasNV_present_video = false;
        public static bool hasEXT_transform_feedback = false;
        public static bool hasEXT_direct_state_access = false;
        public static bool hasEXT_vertex_array_bgra = false;
        public static bool hasEXT_texture_swizzle = false;
        public static bool hasNV_explicit_multisample = false;
        public static bool hasNV_transform_feedback2 = false;
        public static bool hasATI_meminfo = false;
        public static bool hasAMD_performance_monitor = false;
        public static bool hasAMD_texture_texture4 = false;
        public static bool hasAMD_vertex_shader_tesselator = false;
        public static bool hasEXT_provoking_vertex = false;
        public static bool hasEXT_texture_snorm = false;
        public static bool hasAMD_draw_buffers_blend = false;
        public static bool hasAPPLE_texture_range = false;
        public static bool hasAPPLE_float_pixels = false;
        public static bool hasAPPLE_vertex_program_evaluators = false;
        public static bool hasAPPLE_aux_depth_stencil = false;
        public static bool hasAPPLE_object_purgeable = false;
        public static bool hasAPPLE_row_bytes = false;
        public static bool hasAPPLE_rgb_422 = false;
        public static bool hasNV_video_capture = false;
        public static bool hasNV_copy_image = false;
        public static bool hasEXT_separate_shader_objects = false;
        public static bool hasNV_parameter_buffer_object2 = false;
        public static bool hasNV_shader_buffer_load = false;
        public static bool hasNV_vertex_buffer_unified_memory = false;
        public static bool hasNV_texture_barrier = false;
        public static bool hasAMD_shader_stencil_export = false;
        public static bool hasAMD_seamless_cubemap_per_texture = false;
        public static bool hasAMD_conservative_depth = false;
        public static bool hasEXT_shader_image_load_store = false;
        public static bool hasEXT_vertex_attrib_64bit = false;
        public static bool hasNV_gpu_program5 = false;
        public static bool hasNV_gpu_shader5 = false;
        public static bool hasNV_shader_buffer_store = false;
        public static bool hasNV_tessellation_program5 = false;
        public static bool hasNV_vertex_attrib_integer_64bit = false;
        public static bool hasNV_multisample_coverage = false;
        public static bool hasAMD_name_gen_delete = false;
        public static bool hasAMD_debug_output = false;
        public static bool hasNV_vdpau_interop = false;
        public static bool hasAMD_transform_feedback3_lines_triangles = false;
        public static bool hasAMD_depth_clamp_separate = false;
        public static bool hasEXT_texture_sRGB_decode = false;
        public static bool hasNV_texture_multisample = false;
        public static bool hasAMD_blend_minmax_factor = false;
        public static bool hasAMD_sample_positions = false;
        public static bool hasEXT_x11_sync_object = false;
        public static bool hasAMD_multi_draw_indirect = false;
        public static bool hasEXT_framebuffer_multisample_blit_scaled = false;
        public static bool hasNV_path_rendering = false;
        public static bool hasAMD_pinned_memory = false;
        public static bool hasAMD_stencil_operation_extended = false;
        public static bool hasAMD_vertex_shader_viewport_index = false;
        public static bool hasAMD_vertex_shader_layer = false;
        public static bool hasNV_bindless_texture = false;
        public static bool hasNV_shader_atomic_float = false;
        public static bool hasAMD_query_buffer_object = false;
    }
}
