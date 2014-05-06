using System.Collections.Generic;
using System.Reflection;

namespace DarkTech.DarkGL
{
    public static class GLExtension
    {
        static HashSet<string> extensionsList;

        public static bool isSupported(string extension)
        {
            return extensionsList.Contains(extension);
        }

        static GLExtension()
        {
            FieldInfo info;
            string[] extensions;
            extensionsList = new HashSet<string>();

            string extensionlist = gl.GetStringNet(GL.EXTENSIONS);

            if (extensionlist != null)
            {
                extensions = extensionlist.Split(new char[] { ' ' });
            }
            else
            {
                // OpenGL 3.1 core does not support GetString with GL_EXTENSIONS parameter.
                int[] num = new int[1];
                gl.GetIntegerv(GL.NUM_EXTENSIONS, num);

                extensions = new string[num[0]];

                for (uint i = 0; i < num[0]; i++)
                {
                    extensions[i] = gl.GetStringiNet(GL.EXTENSIONS, i);
                }
            }

            foreach (string extension in extensions)
            {
                string extensionName = extension;

                extensionsList.Add(extension);

                if (extensionName.StartsWith("GL_")) 
                    extensionName = extensionName.Substring(3);

                info = typeof(GLExtension).GetField("is" + extensionName);

                if (info != null)
                {
                    info.SetValue(null, true);
                }
            }

            string[] version = gl.GetStringNet(GL.VERSION).Split(new char[] { '.' });

            info = typeof(GLExtension).GetField("isVERSION_" + version[0] + "_" + version[1]);

            if (info != null)
            {
                info.SetValue(null, true);
            }

            info = typeof(GLExtension).GetField("versionMajor");

            if (info != null)
            {
                int major;
                int.TryParse(version[0], out major);
                info.SetValue(null, major);
            }

            info = typeof(GLExtension).GetField("versionMinor");

            if (info != null)
            {
                int minor;
                int.TryParse(version[1], out minor);
                info.SetValue(null, minor);
            }
        }

        public static int versionMajor = 0;
        public static int versionMinor = 0;

        public static bool isVersionOrHigher(int major, int minor)
        {
            return ((major << 16 + minor) <= (versionMajor << 16 + versionMinor));
        }

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
        public static bool isARB_multitexture = false;
        public static bool isARB_transpose_matrix = false;
        public static bool isARB_multisample = false;
        public static bool isARB_texture_env_add = false;
        public static bool isARB_texture_cube_map = false;
        public static bool isARB_texture_compression = false;
        public static bool isARB_texture_border_clamp = false;
        public static bool isARB_point_parameters = false;
        public static bool isARB_vertex_blend = false;
        public static bool isARB_matrix_palette = false;
        public static bool isARB_texture_env_combine = false;
        public static bool isARB_texture_env_crossbar = false;
        public static bool isARB_texture_env_dot3 = false;
        public static bool isARB_texture_mirrored_repeat = false;
        public static bool isARB_depth_texture = false;
        public static bool isARB_shadow = false;
        public static bool isARB_shadow_ambient = false;
        public static bool isARB_window_pos = false;
        public static bool isARB_vertex_program = false;
        public static bool isARB_fragment_program = false;
        public static bool isARB_vertex_buffer_object = false;
        public static bool isARB_occlusion_query = false;
        public static bool isARB_shader_objects = false;
        public static bool isARB_vertex_shader = false;
        public static bool isARB_fragment_shader = false;
        public static bool isARB_shading_language_100 = false;
        public static bool isARB_texture_non_power_of_two = false;
        public static bool isARB_point_sprite = false;
        public static bool isARB_fragment_program_shadow = false;
        public static bool isARB_draw_buffers = false;
        public static bool isARB_texture_rectangle = false;
        public static bool isARB_color_buffer_float = false;
        public static bool isARB_half_float_pixel = false;
        public static bool isARB_texture_float = false;
        public static bool isARB_pixel_buffer_object = false;
        public static bool isARB_depth_buffer_float = false;
        public static bool isARB_draw_instanced = false;
        public static bool isARB_framebuffer_object = false;
        public static bool isARB_framebuffer_sRGB = false;
        public static bool isARB_geometry_shader4 = false;
        public static bool isARB_half_float_vertex = false;
        public static bool isARB_instanced_arrays = false;
        public static bool isARB_map_buffer_range = false;
        public static bool isARB_texture_buffer_object = false;
        public static bool isARB_texture_compression_rgtc = false;
        public static bool isARB_texture_rg = false;
        public static bool isARB_vertex_array_object = false;
        public static bool isARB_uniform_buffer_object = false;
        public static bool isARB_compatibility = false;
        public static bool isARB_copy_buffer = false;
        public static bool isARB_shader_texture_lod = false;
        public static bool isARB_depth_clamp = false;
        public static bool isARB_draw_elements_base_vertex = false;
        public static bool isARB_fragment_coord_conventions = false;
        public static bool isARB_provoking_vertex = false;
        public static bool isARB_seamless_cube_map = false;
        public static bool isARB_sync = false;
        public static bool isARB_texture_multisample = false;
        public static bool isARB_vertex_array_bgra = false;
        public static bool isARB_draw_buffers_blend = false;
        public static bool isARB_sample_shading = false;
        public static bool isARB_texture_cube_map_array = false;
        public static bool isARB_texture_gather = false;
        public static bool isARB_texture_query_lod = false;
        public static bool isARB_shading_language_include = false;
        public static bool isARB_texture_compression_bptc = false;
        public static bool isARB_blend_func_extended = false;
        public static bool isARB_explicit_attrib_location = false;
        public static bool isARB_occlusion_query2 = false;
        public static bool isARB_sampler_objects = false;
        public static bool isARB_shader_bit_encoding = false;
        public static bool isARB_texture_rgb10_a2ui = false;
        public static bool isARB_texture_swizzle = false;
        public static bool isARB_timer_query = false;
        public static bool isARB_vertex_type_2_10_10_10_rev = false;
        public static bool isARB_draw_indirect = false;
        public static bool isARB_gpu_shader5 = false;
        public static bool isARB_gpu_shader_fp64 = false;
        public static bool isARB_shader_subroutine = false;
        public static bool isARB_tessellation_shader = false;
        public static bool isARB_texture_buffer_object_rgb32 = false;
        public static bool isARB_transform_feedback2 = false;
        public static bool isARB_transform_feedback3 = false;
        public static bool isARB_ES2_compatibility = false;
        public static bool isARB_get_program_binary = false;
        public static bool isARB_separate_shader_objects = false;
        public static bool isARB_vertex_attrib_64bit = false;
        public static bool isARB_viewport_array = false;
        public static bool isARB_cl_event = false;
        public static bool isARB_debug_output = false;
        public static bool isARB_robustness = false;
        public static bool isARB_shader_stencil_export = false;
        public static bool isARB_base_instance = false;
        public static bool isARB_shading_language_420pack = false;
        public static bool isARB_transform_feedback_instanced = false;
        public static bool isARB_compressed_texture_pixel_storage = false;
        public static bool isARB_conservative_depth = false;
        public static bool isARB_internalformat_query = false;
        public static bool isARB_map_buffer_alignment = false;
        public static bool isARB_shader_atomic_counters = false;
        public static bool isARB_shader_image_load_store = false;
        public static bool isARB_shading_language_packing = false;
        public static bool isARB_texture_storage = false;
        public static bool isKHR_texture_compression_astc_ldr = false;
        public static bool isKHR_debug = false;
        public static bool isARB_arrays_of_arrays = false;
        public static bool isARB_clear_buffer_object = false;
        public static bool isARB_compute_shader = false;
        public static bool isARB_copy_image = false;
        public static bool isARB_texture_view = false;
        public static bool isARB_vertex_attrib_binding = false;
        public static bool isARB_robustness_isolation = false;
        public static bool isARB_ES3_compatibility = false;
        public static bool isARB_explicit_uniform_location = false;
        public static bool isARB_fragment_layer_viewport = false;
        public static bool isARB_framebuffer_no_attachments = false;
        public static bool isARB_internalformat_query2 = false;
        public static bool isARB_invalidate_subdata = false;
        public static bool isARB_multi_draw_indirect = false;
        public static bool isARB_program_interface_query = false;
        public static bool isARB_robust_buffer_access_behavior = false;
        public static bool isARB_shader_image_size = false;
        public static bool isARB_shader_storage_buffer_object = false;
        public static bool isARB_stencil_texturing = false;
        public static bool isARB_texture_buffer_range = false;
        public static bool isARB_texture_query_levels = false;
        public static bool isARB_texture_storage_multisample = false;
        public static bool isEXT_abgr = false;
        public static bool isEXT_blend_color = false;
        public static bool isEXT_polygon_offset = false;
        public static bool isEXT_texture = false;
        public static bool isEXT_texture3D = false;
        public static bool isSGIS_texture_filter4 = false;
        public static bool isEXT_subtexture = false;
        public static bool isEXT_copy_texture = false;
        public static bool isEXT_histogram = false;
        public static bool isEXT_convolution = false;
        public static bool isSGI_color_matrix = false;
        public static bool isSGI_color_table = false;
        public static bool isSGIX_pixel_texture = false;
        public static bool isSGIS_pixel_texture = false;
        public static bool isSGIS_texture4D = false;
        public static bool isSGI_texture_color_table = false;
        public static bool isEXT_cmyka = false;
        public static bool isEXT_texture_object = false;
        public static bool isSGIS_detail_texture = false;
        public static bool isSGIS_sharpen_texture = false;
        public static bool isEXT_packed_pixels = false;
        public static bool isSGIS_texture_lod = false;
        public static bool isSGIS_multisample = false;
        public static bool isEXT_rescale_normal = false;
        public static bool isEXT_vertex_array = false;
        public static bool isEXT_misc_attribute = false;
        public static bool isSGIS_generate_mipmap = false;
        public static bool isSGIX_clipmap = false;
        public static bool isSGIX_shadow = false;
        public static bool isSGIS_texture_edge_clamp = false;
        public static bool isSGIS_texture_border_clamp = false;
        public static bool isEXT_blend_minmax = false;
        public static bool isEXT_blend_subtract = false;
        public static bool isEXT_blend_logic_op = false;
        public static bool isSGIX_interlace = false;
        public static bool isSGIX_pixel_tiles = false;
        public static bool isSGIX_texture_select = false;
        public static bool isSGIX_sprite = false;
        public static bool isSGIX_texture_multi_buffer = false;
        public static bool isEXT_point_parameters = false;
        public static bool isSGIS_point_parameters = false;
        public static bool isSGIX_instruments = false;
        public static bool isSGIX_texture_scale_bias = false;
        public static bool isSGIX_framezoom = false;
        public static bool isSGIX_tag_sample_buffer = false;
        public static bool isSGIX_polynomial_ffd = false;
        public static bool isSGIX_reference_plane = false;
        public static bool isSGIX_flush_raster = false;
        public static bool isSGIX_depth_texture = false;
        public static bool isSGIS_fog_function = false;
        public static bool isSGIX_fog_offset = false;
        public static bool isHP_image_transform = false;
        public static bool isHP_convolution_border_modes = false;
        public static bool isSGIX_texture_add_env = false;
        public static bool isEXT_color_subtable = false;
        public static bool isPGI_vertex_hints = false;
        public static bool isPGI_misc_hints = false;
        public static bool isEXT_paletted_texture = false;
        public static bool isEXT_clip_volume_hint = false;
        public static bool isSGIX_list_priority = false;
        public static bool isSGIX_ir_instrument1 = false;
        public static bool isSGIX_calligraphic_fragment = false;
        public static bool isSGIX_texture_lod_bias = false;
        public static bool isSGIX_shadow_ambient = false;
        public static bool isEXT_index_texture = false;
        public static bool isEXT_index_material = false;
        public static bool isEXT_index_func = false;
        public static bool isEXT_index_array_formats = false;
        public static bool isEXT_compiled_vertex_array = false;
        public static bool isEXT_cull_vertex = false;
        public static bool isSGIX_ycrcb = false;
        public static bool isSGIX_fragment_lighting = false;
        public static bool isIBM_rasterpos_clip = false;
        public static bool isHP_texture_lighting = false;
        public static bool isEXT_draw_range_elements = false;
        public static bool isWIN_phong_shading = false;
        public static bool isWIN_specular_fog = false;
        public static bool isEXT_light_texture = false;
        public static bool isSGIX_blend_alpha_minmax = false;
        public static bool isEXT_bgra = false;
        public static bool isSGIX_async = false;
        public static bool isSGIX_async_pixel = false;
        public static bool isSGIX_async_histogram = false;
        public static bool isINTEL_parallel_arrays = false;
        public static bool isHP_occlusion_test = false;
        public static bool isEXT_pixel_transform = false;
        public static bool isEXT_pixel_transform_color_table = false;
        public static bool isEXT_shared_texture_palette = false;
        public static bool isEXT_separate_specular_color = false;
        public static bool isEXT_secondary_color = false;
        public static bool isEXT_texture_perturb_normal = false;
        public static bool isEXT_multi_draw_arrays = false;
        public static bool isEXT_fog_coord = false;
        public static bool isREND_screen_coordinates = false;
        public static bool isEXT_coordinate_frame = false;
        public static bool isEXT_texture_env_combine = false;
        public static bool isAPPLE_specular_vector = false;
        public static bool isAPPLE_transform_hint = false;
        public static bool isSGIX_fog_scale = false;
        public static bool isSUNX_constant_data = false;
        public static bool isSUN_global_alpha = false;
        public static bool isSUN_triangle_list = false;
        public static bool isSUN_vertex = false;
        public static bool isEXT_blend_func_separate = false;
        public static bool isINGR_blend_func_separate = false;
        public static bool isINGR_color_clamp = false;
        public static bool isINGR_interlace_read = false;
        public static bool isEXT_stencil_wrap = false;
        public static bool isEXT_422_pixels = false;
        public static bool isNV_texgen_reflection = false;
        public static bool isSUN_convolution_border_modes = false;
        public static bool isEXT_texture_env_add = false;
        public static bool isEXT_texture_lod_bias = false;
        public static bool isEXT_texture_filter_anisotropic = false;
        public static bool isEXT_vertex_weighting = false;
        public static bool isNV_light_max_exponent = false;
        public static bool isNV_vertex_array_range = false;
        public static bool isNV_register_combiners = false;
        public static bool isNV_fog_distance = false;
        public static bool isNV_texgen_emboss = false;
        public static bool isNV_blend_square = false;
        public static bool isNV_texture_env_combine4 = false;
        public static bool isMESA_resize_buffers = false;
        public static bool isMESA_window_pos = false;
        public static bool isIBM_cull_vertex = false;
        public static bool isIBM_multimode_draw_arrays = false;
        public static bool isIBM_vertex_array_lists = false;
        public static bool isSGIX_subsample = false;
        public static bool isSGIX_ycrcba = false;
        public static bool isSGIX_ycrcb_subsample = false;
        public static bool isSGIX_depth_pass_instrument = false;
        public static bool is3DFX_texture_compression_FXT1 = false;
        public static bool is3DFX_multisample = false;
        public static bool is3DFX_tbuffer = false;
        public static bool isEXT_multisample = false;
        public static bool isSGIX_vertex_preclip = false;
        public static bool isSGIX_convolution_accuracy = false;
        public static bool isSGIX_resample = false;
        public static bool isSGIS_point_line_texgen = false;
        public static bool isSGIS_texture_color_mask = false;
        public static bool isSGIX_igloo_interface = false;
        public static bool isEXT_texture_env_dot3 = false;
        public static bool isATI_texture_mirror_once = false;
        public static bool isNV_fence = false;
        public static bool isNV_evaluators = false;
        public static bool isNV_packed_depth_stencil = false;
        public static bool isNV_register_combiners2 = false;
        public static bool isNV_texture_compression_vtc = false;
        public static bool isNV_texture_rectangle = false;
        public static bool isNV_texture_shader = false;
        public static bool isNV_texture_shader2 = false;
        public static bool isNV_vertex_array_range2 = false;
        public static bool isNV_vertex_program = false;
        public static bool isSGIX_texture_coordinate_clamp = false;
        public static bool isSGIX_scalebias_hint = false;
        public static bool isOML_interlace = false;
        public static bool isOML_subsample = false;
        public static bool isOML_resample = false;
        public static bool isNV_copy_depth_to_color = false;
        public static bool isATI_envmap_bumpmap = false;
        public static bool isATI_fragment_shader = false;
        public static bool isATI_pn_triangles = false;
        public static bool isATI_vertex_array_object = false;
        public static bool isEXT_vertex_shader = false;
        public static bool isATI_vertex_streams = false;
        public static bool isATI_element_array = false;
        public static bool isSUN_mesh_array = false;
        public static bool isSUN_slice_accum = false;
        public static bool isNV_multisample_filter_hint = false;
        public static bool isNV_depth_clamp = false;
        public static bool isNV_occlusion_query = false;
        public static bool isNV_point_sprite = false;
        public static bool isNV_texture_shader3 = false;
        public static bool isNV_vertex_program1_1 = false;
        public static bool isEXT_shadow_funcs = false;
        public static bool isEXT_stencil_two_side = false;
        public static bool isATI_text_fragment_shader = false;
        public static bool isAPPLE_client_storage = false;
        public static bool isAPPLE_element_array = false;
        public static bool isAPPLE_fence = false;
        public static bool isAPPLE_vertex_array_object = false;
        public static bool isAPPLE_vertex_array_range = false;
        public static bool isAPPLE_ycbcr_422 = false;
        public static bool isS3_s3tc = false;
        public static bool isATI_draw_buffers = false;
        public static bool isATI_pixel_format_float = false;
        public static bool isATI_texture_env_combine3 = false;
        public static bool isATI_texture_float = false;
        public static bool isNV_float_buffer = false;
        public static bool isNV_fragment_program = false;
        public static bool isNV_half_float = false;
        public static bool isNV_pixel_data_range = false;
        public static bool isNV_primitive_restart = false;
        public static bool isNV_texture_expand_normal = false;
        public static bool isNV_vertex_program2 = false;
        public static bool isATI_map_object_buffer = false;
        public static bool isATI_separate_stencil = false;
        public static bool isATI_vertex_attrib_array_object = false;
        public static bool isOES_read_format = false;
        public static bool isEXT_depth_bounds_test = false;
        public static bool isEXT_texture_mirror_clamp = false;
        public static bool isEXT_blend_equation_separate = false;
        public static bool isMESA_pack_invert = false;
        public static bool isMESA_ycbcr_texture = false;
        public static bool isEXT_pixel_buffer_object = false;
        public static bool isNV_fragment_program_option = false;
        public static bool isNV_fragment_program2 = false;
        public static bool isNV_vertex_program2_option = false;
        public static bool isNV_vertex_program3 = false;
        public static bool isEXT_framebuffer_object = false;
        public static bool isGREMEDY_string_marker = false;
        public static bool isEXT_packed_depth_stencil = false;
        public static bool isEXT_stencil_clear_tag = false;
        public static bool isEXT_texture_sRGB = false;
        public static bool isEXT_framebuffer_blit = false;
        public static bool isEXT_framebuffer_multisample = false;
        public static bool isMESAX_texture_stack = false;
        public static bool isEXT_timer_query = false;
        public static bool isEXT_gpu_program_parameters = false;
        public static bool isAPPLE_flush_buffer_range = false;
        public static bool isNV_gpu_program4 = false;
        public static bool isNV_geometry_program4 = false;
        public static bool isEXT_geometry_shader4 = false;
        public static bool isNV_vertex_program4 = false;
        public static bool isEXT_gpu_shader4 = false;
        public static bool isEXT_draw_instanced = false;
        public static bool isEXT_packed_float = false;
        public static bool isEXT_texture_array = false;
        public static bool isEXT_texture_buffer_object = false;
        public static bool isEXT_texture_compression_latc = false;
        public static bool isEXT_texture_compression_rgtc = false;
        public static bool isEXT_texture_shared_exponent = false;
        public static bool isNV_depth_buffer_float = false;
        public static bool isNV_fragment_program4 = false;
        public static bool isNV_framebuffer_multisample_coverage = false;
        public static bool isEXT_framebuffer_sRGB = false;
        public static bool isNV_geometry_shader4 = false;
        public static bool isNV_parameter_buffer_object = false;
        public static bool isEXT_draw_buffers2 = false;
        public static bool isNV_transform_feedback = false;
        public static bool isEXT_bindable_uniform = false;
        public static bool isEXT_texture_integer = false;
        public static bool isGREMEDY_frame_terminator = false;
        public static bool isNV_conditional_render = false;
        public static bool isNV_present_video = false;
        public static bool isEXT_transform_feedback = false;
        public static bool isEXT_direct_state_access = false;
        public static bool isEXT_vertex_array_bgra = false;
        public static bool isEXT_texture_swizzle = false;
        public static bool isNV_explicit_multisample = false;
        public static bool isNV_transform_feedback2 = false;
        public static bool isATI_meminfo = false;
        public static bool isAMD_performance_monitor = false;
        public static bool isAMD_texture_texture4 = false;
        public static bool isAMD_vertex_shader_tesselator = false;
        public static bool isEXT_provoking_vertex = false;
        public static bool isEXT_texture_snorm = false;
        public static bool isAMD_draw_buffers_blend = false;
        public static bool isAPPLE_texture_range = false;
        public static bool isAPPLE_float_pixels = false;
        public static bool isAPPLE_vertex_program_evaluators = false;
        public static bool isAPPLE_aux_depth_stencil = false;
        public static bool isAPPLE_object_purgeable = false;
        public static bool isAPPLE_row_bytes = false;
        public static bool isAPPLE_rgb_422 = false;
        public static bool isNV_video_capture = false;
        public static bool isNV_copy_image = false;
        public static bool isEXT_separate_shader_objects = false;
        public static bool isNV_parameter_buffer_object2 = false;
        public static bool isNV_shader_buffer_load = false;
        public static bool isNV_vertex_buffer_unified_memory = false;
        public static bool isNV_texture_barrier = false;
        public static bool isAMD_shader_stencil_export = false;
        public static bool isAMD_seamless_cubemap_per_texture = false;
        public static bool isAMD_conservative_depth = false;
        public static bool isEXT_shader_image_load_store = false;
        public static bool isEXT_vertex_attrib_64bit = false;
        public static bool isNV_gpu_program5 = false;
        public static bool isNV_gpu_shader5 = false;
        public static bool isNV_shader_buffer_store = false;
        public static bool isNV_tessellation_program5 = false;
        public static bool isNV_vertex_attrib_integer_64bit = false;
        public static bool isNV_multisample_coverage = false;
        public static bool isAMD_name_gen_delete = false;
        public static bool isAMD_debug_output = false;
        public static bool isNV_vdpau_interop = false;
        public static bool isAMD_transform_feedback3_lines_triangles = false;
        public static bool isAMD_depth_clamp_separate = false;
        public static bool isEXT_texture_sRGB_decode = false;
        public static bool isNV_texture_multisample = false;
        public static bool isAMD_blend_minmax_factor = false;
        public static bool isAMD_sample_positions = false;
        public static bool isEXT_x11_sync_object = false;
        public static bool isAMD_multi_draw_indirect = false;
        public static bool isEXT_framebuffer_multisample_blit_scaled = false;
        public static bool isNV_path_rendering = false;
        public static bool isAMD_pinned_memory = false;
        public static bool isAMD_stencil_operation_extended = false;
        public static bool isAMD_vertex_shader_viewport_index = false;
        public static bool isAMD_vertex_shader_layer = false;
        public static bool isNV_bindless_texture = false;
        public static bool isNV_shader_atomic_float = false;
        public static bool isAMD_query_buffer_object = false;
    }
}
