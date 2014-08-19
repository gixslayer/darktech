namespace DarkTech.DarkGL
{
    public class GL
    {
        ///<summary>VERSION_1_1 (AttribMask)</summary>
        public const int DEPTH_BUFFER_BIT = 0x00000100;
        ///<summary>VERSION_1_1 (AttribMask)</summary>
        public const int STENCIL_BUFFER_BIT = 0x00000400;
        ///<summary>VERSION_1_1 (AttribMask)</summary>
        public const int COLOR_BUFFER_BIT = 0x00004000;
        ///<summary>VERSION_1_1 (Boolean)</summary>
        public const int FALSE = 0;
        ///<summary>VERSION_1_1 (Boolean)</summary>
        public const int TRUE = 1;
        ///<summary>VERSION_1_1 (BeginMode)</summary>
        public const int POINTS = 0x0000;
        ///<summary>VERSION_1_1 (BeginMode)</summary>
        public const int LINES = 0x0001;
        ///<summary>VERSION_1_1 (BeginMode)</summary>
        public const int LINE_LOOP = 0x0002;
        ///<summary>VERSION_1_1 (BeginMode)</summary>
        public const int LINE_STRIP = 0x0003;
        ///<summary>VERSION_1_1 (BeginMode)</summary>
        public const int TRIANGLES = 0x0004;
        ///<summary>VERSION_1_1 (BeginMode)</summary>
        public const int TRIANGLE_STRIP = 0x0005;
        ///<summary>VERSION_1_1 (BeginMode)</summary>
        public const int TRIANGLE_FAN = 0x0006;
        ///<summary>VERSION_1_1 (AlphaFunction)</summary>
        public const int NEVER = 0x0200;
        ///<summary>VERSION_1_1 (AlphaFunction)</summary>
        public const int LESS = 0x0201;
        ///<summary>VERSION_1_1 (AlphaFunction)</summary>
        public const int EQUAL = 0x0202;
        ///<summary>VERSION_1_1 (AlphaFunction)</summary>
        public const int LEQUAL = 0x0203;
        ///<summary>VERSION_1_1 (AlphaFunction)</summary>
        public const int GREATER = 0x0204;
        ///<summary>VERSION_1_1 (AlphaFunction)</summary>
        public const int NOTEQUAL = 0x0205;
        ///<summary>VERSION_1_1 (AlphaFunction)</summary>
        public const int GEQUAL = 0x0206;
        ///<summary>VERSION_1_1 (AlphaFunction)</summary>
        public const int ALWAYS = 0x0207;
        ///<summary>VERSION_1_1 (BlendingFactorDest)</summary>
        public const int ZERO = 0;
        ///<summary>VERSION_1_1 (BlendingFactorDest)</summary>
        public const int ONE = 1;
        ///<summary>VERSION_1_1 (BlendingFactorDest)</summary>
        public const int SRC_COLOR = 0x0300;
        ///<summary>VERSION_1_1 (BlendingFactorDest)</summary>
        public const int ONE_MINUS_SRC_COLOR = 0x0301;
        ///<summary>VERSION_1_1 (BlendingFactorDest)</summary>
        public const int SRC_ALPHA = 0x0302;
        ///<summary>VERSION_1_1 (BlendingFactorDest)</summary>
        public const int ONE_MINUS_SRC_ALPHA = 0x0303;
        ///<summary>VERSION_1_1 (BlendingFactorDest)</summary>
        public const int DST_ALPHA = 0x0304;
        ///<summary>VERSION_1_1 (BlendingFactorDest)</summary>
        public const int ONE_MINUS_DST_ALPHA = 0x0305;
        ///<summary>VERSION_1_1 (BlendingFactorSrc)</summary>
        public const int DST_COLOR = 0x0306;
        ///<summary>VERSION_1_1 (BlendingFactorSrc)</summary>
        public const int ONE_MINUS_DST_COLOR = 0x0307;
        ///<summary>VERSION_1_1 (BlendingFactorSrc)</summary>
        public const int SRC_ALPHA_SATURATE = 0x0308;
        ///<summary>VERSION_1_1 (DrawBufferMode)</summary>
        public const int NONE = 0;
        ///<summary>VERSION_1_1 (DrawBufferMode)</summary>
        public const int FRONT_LEFT = 0x0400;
        ///<summary>VERSION_1_1 (DrawBufferMode)</summary>
        public const int FRONT_RIGHT = 0x0401;
        ///<summary>VERSION_1_1 (DrawBufferMode)</summary>
        public const int BACK_LEFT = 0x0402;
        ///<summary>VERSION_1_1 (DrawBufferMode)</summary>
        public const int BACK_RIGHT = 0x0403;
        ///<summary>VERSION_1_1 (DrawBufferMode)</summary>
        public const int FRONT = 0x0404;
        ///<summary>VERSION_1_1 (DrawBufferMode)</summary>
        public const int BACK = 0x0405;
        ///<summary>VERSION_1_1 (DrawBufferMode)</summary>
        public const int LEFT = 0x0406;
        ///<summary>VERSION_1_1 (DrawBufferMode)</summary>
        public const int RIGHT = 0x0407;
        ///<summary>VERSION_1_1 (DrawBufferMode)</summary>
        public const int FRONT_AND_BACK = 0x0408;
        ///<summary>VERSION_1_1 (ErrorCode)</summary>
        public const int NO_ERROR = 0;
        ///<summary>VERSION_1_1 (ErrorCode)</summary>
        public const int INVALID_ENUM = 0x0500;
        ///<summary>VERSION_1_1 (ErrorCode)</summary>
        public const int INVALID_VALUE = 0x0501;
        ///<summary>VERSION_1_1 (ErrorCode)</summary>
        public const int INVALID_OPERATION = 0x0502;
        ///<summary>VERSION_1_1 (ErrorCode)</summary>
        public const int OUT_OF_MEMORY = 0x0505;
        ///<summary>VERSION_1_1 (FrontFaceDirection)</summary>
        public const int CW = 0x0900;
        ///<summary>VERSION_1_1 (FrontFaceDirection)</summary>
        public const int CCW = 0x0901;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int POINT_SIZE = 0x0B11;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int POINT_SIZE_RANGE = 0x0B12;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int POINT_SIZE_GRANULARITY = 0x0B13;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int LINE_SMOOTH = 0x0B20;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int LINE_WIDTH = 0x0B21;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int LINE_WIDTH_RANGE = 0x0B22;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int LINE_WIDTH_GRANULARITY = 0x0B23;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int POLYGON_SMOOTH = 0x0B41;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int CULL_FACE = 0x0B44;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int CULL_FACE_MODE = 0x0B45;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int FRONT_FACE = 0x0B46;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int DEPTH_RANGE = 0x0B70;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int DEPTH_TEST = 0x0B71;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int DEPTH_WRITEMASK = 0x0B72;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int DEPTH_CLEAR_VALUE = 0x0B73;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int DEPTH_FUNC = 0x0B74;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int STENCIL_TEST = 0x0B90;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int STENCIL_CLEAR_VALUE = 0x0B91;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int STENCIL_FUNC = 0x0B92;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int STENCIL_VALUE_MASK = 0x0B93;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int STENCIL_FAIL = 0x0B94;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int STENCIL_PASS_DEPTH_FAIL = 0x0B95;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int STENCIL_PASS_DEPTH_PASS = 0x0B96;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int STENCIL_REF = 0x0B97;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int STENCIL_WRITEMASK = 0x0B98;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int VIEWPORT = 0x0BA2;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int DITHER = 0x0BD0;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int BLEND_DST = 0x0BE0;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int BLEND_SRC = 0x0BE1;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int BLEND = 0x0BE2;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int LOGIC_OP_MODE = 0x0BF0;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int COLOR_LOGIC_OP = 0x0BF2;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int DRAW_BUFFER = 0x0C01;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int READ_BUFFER = 0x0C02;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int SCISSOR_BOX = 0x0C10;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int SCISSOR_TEST = 0x0C11;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int COLOR_CLEAR_VALUE = 0x0C22;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int COLOR_WRITEMASK = 0x0C23;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int DOUBLEBUFFER = 0x0C32;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int STEREO = 0x0C33;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int LINE_SMOOTH_HINT = 0x0C52;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int POLYGON_SMOOTH_HINT = 0x0C53;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int UNPACK_SWAP_BYTES = 0x0CF0;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int UNPACK_LSB_FIRST = 0x0CF1;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int UNPACK_ROW_LENGTH = 0x0CF2;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int UNPACK_SKIP_ROWS = 0x0CF3;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int UNPACK_SKIP_PIXELS = 0x0CF4;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int UNPACK_ALIGNMENT = 0x0CF5;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int PACK_SWAP_BYTES = 0x0D00;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int PACK_LSB_FIRST = 0x0D01;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int PACK_ROW_LENGTH = 0x0D02;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int PACK_SKIP_ROWS = 0x0D03;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int PACK_SKIP_PIXELS = 0x0D04;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int PACK_ALIGNMENT = 0x0D05;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int MAX_TEXTURE_SIZE = 0x0D33;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int MAX_VIEWPORT_DIMS = 0x0D3A;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int SUBPIXEL_BITS = 0x0D50;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int TEXTURE_1D = 0x0DE0;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int TEXTURE_2D = 0x0DE1;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int POLYGON_OFFSET_UNITS = 0x2A00;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int POLYGON_OFFSET_POINT = 0x2A01;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int POLYGON_OFFSET_LINE = 0x2A02;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int POLYGON_OFFSET_FILL = 0x8037;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int POLYGON_OFFSET_FACTOR = 0x8038;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int TEXTURE_BINDING_1D = 0x8068;
        ///<summary>VERSION_1_1 (GetPName)</summary>
        public const int TEXTURE_BINDING_2D = 0x8069;
        ///<summary>VERSION_1_1 (GetTextureParameter)</summary>
        public const int TEXTURE_WIDTH = 0x1000;
        ///<summary>VERSION_1_1 (GetTextureParameter)</summary>
        public const int TEXTURE_HEIGHT = 0x1001;
        ///<summary>VERSION_1_1 (GetTextureParameter)</summary>
        public const int TEXTURE_INTERNAL_FORMAT = 0x1003;
        ///<summary>VERSION_1_1 (GetTextureParameter)</summary>
        public const int TEXTURE_BORDER_COLOR = 0x1004;
        ///<summary>VERSION_1_1 (GetTextureParameter)</summary>
        public const int TEXTURE_RED_SIZE = 0x805C;
        ///<summary>VERSION_1_1 (GetTextureParameter)</summary>
        public const int TEXTURE_GREEN_SIZE = 0x805D;
        ///<summary>VERSION_1_1 (GetTextureParameter)</summary>
        public const int TEXTURE_BLUE_SIZE = 0x805E;
        ///<summary>VERSION_1_1 (GetTextureParameter)</summary>
        public const int TEXTURE_ALPHA_SIZE = 0x805F;
        ///<summary>VERSION_1_1 (HintMode)</summary>
        public const int DONT_CARE = 0x1100;
        ///<summary>VERSION_1_1 (HintMode)</summary>
        public const int FASTEST = 0x1101;
        ///<summary>VERSION_1_1 (HintMode)</summary>
        public const int NICEST = 0x1102;
        ///<summary>VERSION_1_1 (DataType)</summary>
        public const int BYTE = 0x1400;
        ///<summary>VERSION_1_1 (DataType)</summary>
        public const int UNSIGNED_BYTE = 0x1401;
        ///<summary>VERSION_1_1 (DataType)</summary>
        public const int SHORT = 0x1402;
        ///<summary>VERSION_1_1 (DataType)</summary>
        public const int UNSIGNED_SHORT = 0x1403;
        ///<summary>VERSION_1_1 (DataType)</summary>
        public const int INT = 0x1404;
        ///<summary>VERSION_1_1 (DataType)</summary>
        public const int UNSIGNED_INT = 0x1405;
        ///<summary>VERSION_1_1 (DataType)</summary>
        public const int FLOAT = 0x1406;
        ///<summary>VERSION_1_1 (DataType)</summary>
        public const int DOUBLE = 0x140A;
        ///<summary>VERSION_1_1 (ErrorCode)</summary>
        public const int STACK_OVERFLOW = 0x0503;
        ///<summary>VERSION_1_1 (ErrorCode)</summary>
        public const int STACK_UNDERFLOW = 0x0504;
        ///<summary>VERSION_1_1 (LogicOp)</summary>
        public const int CLEAR = 0x1500;
        ///<summary>VERSION_1_1 (LogicOp)</summary>
        public const int AND = 0x1501;
        ///<summary>VERSION_1_1 (LogicOp)</summary>
        public const int AND_REVERSE = 0x1502;
        ///<summary>VERSION_1_1 (LogicOp)</summary>
        public const int COPY = 0x1503;
        ///<summary>VERSION_1_1 (LogicOp)</summary>
        public const int AND_INVERTED = 0x1504;
        ///<summary>VERSION_1_1 (LogicOp)</summary>
        public const int NOOP = 0x1505;
        ///<summary>VERSION_1_1 (LogicOp)</summary>
        public const int XOR = 0x1506;
        ///<summary>VERSION_1_1 (LogicOp)</summary>
        public const int OR = 0x1507;
        ///<summary>VERSION_1_1 (LogicOp)</summary>
        public const int NOR = 0x1508;
        ///<summary>VERSION_1_1 (LogicOp)</summary>
        public const int EQUIV = 0x1509;
        ///<summary>VERSION_1_1 (LogicOp)</summary>
        public const int INVERT = 0x150A;
        ///<summary>VERSION_1_1 (LogicOp)</summary>
        public const int OR_REVERSE = 0x150B;
        ///<summary>VERSION_1_1 (LogicOp)</summary>
        public const int COPY_INVERTED = 0x150C;
        ///<summary>VERSION_1_1 (LogicOp)</summary>
        public const int OR_INVERTED = 0x150D;
        ///<summary>VERSION_1_1 (LogicOp)</summary>
        public const int NAND = 0x150E;
        ///<summary>VERSION_1_1 (LogicOp)</summary>
        public const int SET = 0x150F;
        ///<summary>VERSION_1_1 (MatrixMode (for gl3.h, FBO attachment type))</summary>
        public const int TEXTURE = 0x1702;
        ///<summary>VERSION_1_1 (PixelCopyType)</summary>
        public const int COLOR = 0x1800;
        ///<summary>VERSION_1_1 (PixelCopyType)</summary>
        public const int DEPTH = 0x1801;
        ///<summary>VERSION_1_1 (PixelCopyType)</summary>
        public const int STENCIL = 0x1802;
        ///<summary>VERSION_1_1 (PixelFormat)</summary>
        public const int STENCIL_INDEX = 0x1901;
        ///<summary>VERSION_1_1 (PixelFormat)</summary>
        public const int DEPTH_COMPONENT = 0x1902;
        ///<summary>VERSION_1_1 (PixelFormat)</summary>
        public const int RED = 0x1903;
        ///<summary>VERSION_1_1 (PixelFormat)</summary>
        public const int GREEN = 0x1904;
        ///<summary>VERSION_1_1 (PixelFormat)</summary>
        public const int BLUE = 0x1905;
        ///<summary>VERSION_1_1 (PixelFormat)</summary>
        public const int ALPHA = 0x1906;
        ///<summary>VERSION_1_1 (PixelFormat)</summary>
        public const int RGB = 0x1907;
        ///<summary>VERSION_1_1 (PixelFormat)</summary>
        public const int RGBA = 0x1908;
        ///<summary>VERSION_1_1 (PolygonMode)</summary>
        public const int POINT = 0x1B00;
        ///<summary>VERSION_1_1 (PolygonMode)</summary>
        public const int LINE = 0x1B01;
        ///<summary>VERSION_1_1 (PolygonMode)</summary>
        public const int FILL = 0x1B02;
        ///<summary>VERSION_1_1 (StencilOp)</summary>
        public const int KEEP = 0x1E00;
        ///<summary>VERSION_1_1 (StencilOp)</summary>
        public const int REPLACE = 0x1E01;
        ///<summary>VERSION_1_1 (StencilOp)</summary>
        public const int INCR = 0x1E02;
        ///<summary>VERSION_1_1 (StencilOp)</summary>
        public const int DECR = 0x1E03;
        ///<summary>VERSION_1_1 (StringName)</summary>
        public const int VENDOR = 0x1F00;
        ///<summary>VERSION_1_1 (StringName)</summary>
        public const int RENDERER = 0x1F01;
        ///<summary>VERSION_1_1 (StringName)</summary>
        public const int VERSION = 0x1F02;
        ///<summary>VERSION_1_1 (StringName)</summary>
        public const int EXTENSIONS = 0x1F03;
        ///<summary>VERSION_1_1 (TextureMagFilter)</summary>
        public const int NEAREST = 0x2600;
        ///<summary>VERSION_1_1 (TextureMagFilter)</summary>
        public const int LINEAR = 0x2601;
        ///<summary>VERSION_1_1 (TextureMinFilter)</summary>
        public const int NEAREST_MIPMAP_NEAREST = 0x2700;
        ///<summary>VERSION_1_1 (TextureMinFilter)</summary>
        public const int LINEAR_MIPMAP_NEAREST = 0x2701;
        ///<summary>VERSION_1_1 (TextureMinFilter)</summary>
        public const int NEAREST_MIPMAP_LINEAR = 0x2702;
        ///<summary>VERSION_1_1 (TextureMinFilter)</summary>
        public const int LINEAR_MIPMAP_LINEAR = 0x2703;
        ///<summary>VERSION_1_1 (TextureParameterName)</summary>
        public const int TEXTURE_MAG_FILTER = 0x2800;
        ///<summary>VERSION_1_1 (TextureParameterName)</summary>
        public const int TEXTURE_MIN_FILTER = 0x2801;
        ///<summary>VERSION_1_1 (TextureParameterName)</summary>
        public const int TEXTURE_WRAP_S = 0x2802;
        ///<summary>VERSION_1_1 (TextureParameterName)</summary>
        public const int TEXTURE_WRAP_T = 0x2803;
        ///<summary>VERSION_1_1 (TextureTarget)</summary>
        public const int PROXY_TEXTURE_1D = 0x8063;
        ///<summary>VERSION_1_1 (TextureTarget)</summary>
        public const int PROXY_TEXTURE_2D = 0x8064;
        ///<summary>VERSION_1_1 (TextureWrapMode)</summary>
        public const int REPEAT = 0x2901;
        ///<summary>VERSION_1_1 (PixelInternalFormat)</summary>
        public const int R3_G3_B2 = 0x2A10;
        ///<summary>VERSION_1_1 (PixelInternalFormat)</summary>
        public const int RGB4 = 0x804F;
        ///<summary>VERSION_1_1 (PixelInternalFormat)</summary>
        public const int RGB5 = 0x8050;
        ///<summary>VERSION_1_1 (PixelInternalFormat)</summary>
        public const int RGB8 = 0x8051;
        ///<summary>VERSION_1_1 (PixelInternalFormat)</summary>
        public const int RGB10 = 0x8052;
        ///<summary>VERSION_1_1 (PixelInternalFormat)</summary>
        public const int RGB12 = 0x8053;
        ///<summary>VERSION_1_1 (PixelInternalFormat)</summary>
        public const int RGB16 = 0x8054;
        ///<summary>VERSION_1_1 (PixelInternalFormat)</summary>
        public const int RGBA2 = 0x8055;
        ///<summary>VERSION_1_1 (PixelInternalFormat)</summary>
        public const int RGBA4 = 0x8056;
        ///<summary>VERSION_1_1 (PixelInternalFormat)</summary>
        public const int RGB5_A1 = 0x8057;
        ///<summary>VERSION_1_1 (PixelInternalFormat)</summary>
        public const int RGBA8 = 0x8058;
        ///<summary>VERSION_1_1 (PixelInternalFormat)</summary>
        public const int RGB10_A2 = 0x8059;
        ///<summary>VERSION_1_1 (PixelInternalFormat)</summary>
        public const int RGBA12 = 0x805A;
        ///<summary>VERSION_1_1 (PixelInternalFormat)</summary>
        public const int RGBA16 = 0x805B;
        ///<summary>VERSION_1_1_DEPRECATED (AttribMask)</summary>
        public const int CURRENT_BIT = 0x00000001;
        ///<summary>VERSION_1_1_DEPRECATED (AttribMask)</summary>
        public const int POINT_BIT = 0x00000002;
        ///<summary>VERSION_1_1_DEPRECATED (AttribMask)</summary>
        public const int LINE_BIT = 0x00000004;
        ///<summary>VERSION_1_1_DEPRECATED (AttribMask)</summary>
        public const int POLYGON_BIT = 0x00000008;
        ///<summary>VERSION_1_1_DEPRECATED (AttribMask)</summary>
        public const int POLYGON_STIPPLE_BIT = 0x00000010;
        ///<summary>VERSION_1_1_DEPRECATED (AttribMask)</summary>
        public const int PIXEL_MODE_BIT = 0x00000020;
        ///<summary>VERSION_1_1_DEPRECATED (AttribMask)</summary>
        public const int LIGHTING_BIT = 0x00000040;
        ///<summary>VERSION_1_1_DEPRECATED (AttribMask)</summary>
        public const int FOG_BIT = 0x00000080;
        ///<summary>VERSION_1_1_DEPRECATED (AttribMask)</summary>
        public const int ACCUM_BUFFER_BIT = 0x00000200;
        ///<summary>VERSION_1_1_DEPRECATED (AttribMask)</summary>
        public const int VIEWPORT_BIT = 0x00000800;
        ///<summary>VERSION_1_1_DEPRECATED (AttribMask)</summary>
        public const int TRANSFORM_BIT = 0x00001000;
        ///<summary>VERSION_1_1_DEPRECATED (AttribMask)</summary>
        public const int ENABLE_BIT = 0x00002000;
        ///<summary>VERSION_1_1_DEPRECATED (AttribMask)</summary>
        public const int HINT_BIT = 0x00008000;
        ///<summary>VERSION_1_1_DEPRECATED (AttribMask)</summary>
        public const int EVAL_BIT = 0x00010000;
        ///<summary>VERSION_1_1_DEPRECATED (AttribMask)</summary>
        public const int LIST_BIT = 0x00020000;
        ///<summary>VERSION_1_1_DEPRECATED (AttribMask)</summary>
        public const int TEXTURE_BIT = 0x00040000;
        ///<summary>VERSION_1_1_DEPRECATED (AttribMask)</summary>
        public const int SCISSOR_BIT = 0x00080000;
        ///<summary>VERSION_1_1_DEPRECATED (AttribMask)</summary>
        public const int ALL_ATTRIB_BITS = unchecked((int)0xFFFFFFFF);
        ///<summary>VERSION_1_1_DEPRECATED (ClientAttribMask)</summary>
        public const int CLIENT_PIXEL_STORE_BIT = 0x00000001;
        ///<summary>VERSION_1_1_DEPRECATED (ClientAttribMask)</summary>
        public const int CLIENT_VERTEX_ARRAY_BIT = 0x00000002;
        ///<summary>VERSION_1_1_DEPRECATED (ClientAttribMask)</summary>
        public const int CLIENT_ALL_ATTRIB_BITS = unchecked((int)0xFFFFFFFF);
        ///<summary>VERSION_1_1_DEPRECATED (BeginMode)</summary>
        public const int QUADS = 0x0007;
        ///<summary>VERSION_1_1_DEPRECATED (BeginMode)</summary>
        public const int QUAD_STRIP = 0x0008;
        ///<summary>VERSION_1_1_DEPRECATED (BeginMode)</summary>
        public const int POLYGON = 0x0009;
        ///<summary>VERSION_1_1_DEPRECATED (AccumOp)</summary>
        public const int ACCUM = 0x0100;
        ///<summary>VERSION_1_1_DEPRECATED (AccumOp)</summary>
        public const int LOAD = 0x0101;
        ///<summary>VERSION_1_1_DEPRECATED (AccumOp)</summary>
        public const int RETURN = 0x0102;
        ///<summary>VERSION_1_1_DEPRECATED (AccumOp)</summary>
        public const int MULT = 0x0103;
        ///<summary>VERSION_1_1_DEPRECATED (AccumOp)</summary>
        public const int ADD = 0x0104;
        ///<summary>VERSION_1_1_DEPRECATED (DrawBufferMode)</summary>
        public const int AUX0 = 0x0409;
        ///<summary>VERSION_1_1_DEPRECATED (DrawBufferMode)</summary>
        public const int AUX1 = 0x040A;
        ///<summary>VERSION_1_1_DEPRECATED (DrawBufferMode)</summary>
        public const int AUX2 = 0x040B;
        ///<summary>VERSION_1_1_DEPRECATED (DrawBufferMode)</summary>
        public const int AUX3 = 0x040C;
        ///<summary>VERSION_1_1_DEPRECATED (FeedbackType)</summary>
        public const int _2D = 0x0600;
        ///<summary>VERSION_1_1_DEPRECATED (FeedbackType)</summary>
        public const int _3D = 0x0601;
        ///<summary>VERSION_1_1_DEPRECATED (FeedbackType)</summary>
        public const int _3D_COLOR = 0x0602;
        ///<summary>VERSION_1_1_DEPRECATED (FeedbackType)</summary>
        public const int _3D_COLOR_TEXTURE = 0x0603;
        ///<summary>VERSION_1_1_DEPRECATED (FeedbackType)</summary>
        public const int _4D_COLOR_TEXTURE = 0x0604;
        ///<summary>VERSION_1_1_DEPRECATED (FeedBackToken)</summary>
        public const int PASS_THROUGH_TOKEN = 0x0700;
        ///<summary>VERSION_1_1_DEPRECATED (FeedBackToken)</summary>
        public const int POINT_TOKEN = 0x0701;
        ///<summary>VERSION_1_1_DEPRECATED (FeedBackToken)</summary>
        public const int LINE_TOKEN = 0x0702;
        ///<summary>VERSION_1_1_DEPRECATED (FeedBackToken)</summary>
        public const int POLYGON_TOKEN = 0x0703;
        ///<summary>VERSION_1_1_DEPRECATED (FeedBackToken)</summary>
        public const int BITMAP_TOKEN = 0x0704;
        ///<summary>VERSION_1_1_DEPRECATED (FeedBackToken)</summary>
        public const int DRAW_PIXEL_TOKEN = 0x0705;
        ///<summary>VERSION_1_1_DEPRECATED (FeedBackToken)</summary>
        public const int COPY_PIXEL_TOKEN = 0x0706;
        ///<summary>VERSION_1_1_DEPRECATED (FeedBackToken)</summary>
        public const int LINE_RESET_TOKEN = 0x0707;
        ///<summary>VERSION_1_1_DEPRECATED (FogMode)</summary>
        public const int EXP = 0x0800;
        ///<summary>VERSION_1_1_DEPRECATED (FogMode)</summary>
        public const int EXP2 = 0x0801;
        ///<summary>VERSION_1_1_DEPRECATED (GetMapQuery)</summary>
        public const int COEFF = 0x0A00;
        ///<summary>VERSION_1_1_DEPRECATED (GetMapQuery)</summary>
        public const int ORDER = 0x0A01;
        ///<summary>VERSION_1_1_DEPRECATED (GetMapQuery)</summary>
        public const int DOMAIN = 0x0A02;
        ///<summary>VERSION_1_1_DEPRECATED (GetPixelMap)</summary>
        public const int PIXEL_MAP_I_TO_I = 0x0C70;
        ///<summary>VERSION_1_1_DEPRECATED (GetPixelMap)</summary>
        public const int PIXEL_MAP_S_TO_S = 0x0C71;
        ///<summary>VERSION_1_1_DEPRECATED (GetPixelMap)</summary>
        public const int PIXEL_MAP_I_TO_R = 0x0C72;
        ///<summary>VERSION_1_1_DEPRECATED (GetPixelMap)</summary>
        public const int PIXEL_MAP_I_TO_G = 0x0C73;
        ///<summary>VERSION_1_1_DEPRECATED (GetPixelMap)</summary>
        public const int PIXEL_MAP_I_TO_B = 0x0C74;
        ///<summary>VERSION_1_1_DEPRECATED (GetPixelMap)</summary>
        public const int PIXEL_MAP_I_TO_A = 0x0C75;
        ///<summary>VERSION_1_1_DEPRECATED (GetPixelMap)</summary>
        public const int PIXEL_MAP_R_TO_R = 0x0C76;
        ///<summary>VERSION_1_1_DEPRECATED (GetPixelMap)</summary>
        public const int PIXEL_MAP_G_TO_G = 0x0C77;
        ///<summary>VERSION_1_1_DEPRECATED (GetPixelMap)</summary>
        public const int PIXEL_MAP_B_TO_B = 0x0C78;
        ///<summary>VERSION_1_1_DEPRECATED (GetPixelMap)</summary>
        public const int PIXEL_MAP_A_TO_A = 0x0C79;
        ///<summary>VERSION_1_1_DEPRECATED (GetPointervPName)</summary>
        public const int VERTEX_ARRAY_POINTER = 0x808E;
        ///<summary>VERSION_1_1_DEPRECATED (GetPointervPName)</summary>
        public const int NORMAL_ARRAY_POINTER = 0x808F;
        ///<summary>VERSION_1_1_DEPRECATED (GetPointervPName)</summary>
        public const int COLOR_ARRAY_POINTER = 0x8090;
        ///<summary>VERSION_1_1_DEPRECATED (GetPointervPName)</summary>
        public const int INDEX_ARRAY_POINTER = 0x8091;
        ///<summary>VERSION_1_1_DEPRECATED (GetPointervPName)</summary>
        public const int TEXTURE_COORD_ARRAY_POINTER = 0x8092;
        ///<summary>VERSION_1_1_DEPRECATED (GetPointervPName)</summary>
        public const int EDGE_FLAG_ARRAY_POINTER = 0x8093;
        ///<summary>VERSION_1_1_DEPRECATED (GetPointervPName)</summary>
        public const int FEEDBACK_BUFFER_POINTER = 0x0DF0;
        ///<summary>VERSION_1_1_DEPRECATED (GetPointervPName)</summary>
        public const int SELECTION_BUFFER_POINTER = 0x0DF3;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int CURRENT_COLOR = 0x0B00;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int CURRENT_INDEX = 0x0B01;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int CURRENT_NORMAL = 0x0B02;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int CURRENT_TEXTURE_COORDS = 0x0B03;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int CURRENT_RASTER_COLOR = 0x0B04;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int CURRENT_RASTER_INDEX = 0x0B05;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int CURRENT_RASTER_TEXTURE_COORDS = 0x0B06;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int CURRENT_RASTER_POSITION = 0x0B07;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int CURRENT_RASTER_POSITION_VALID = 0x0B08;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int CURRENT_RASTER_DISTANCE = 0x0B09;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int POINT_SMOOTH = 0x0B10;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int LINE_STIPPLE = 0x0B24;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int LINE_STIPPLE_PATTERN = 0x0B25;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int LINE_STIPPLE_REPEAT = 0x0B26;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int LIST_MODE = 0x0B30;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAX_LIST_NESTING = 0x0B31;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int LIST_BASE = 0x0B32;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int LIST_INDEX = 0x0B33;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int POLYGON_MODE = 0x0B40;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int POLYGON_STIPPLE = 0x0B42;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int EDGE_FLAG = 0x0B43;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int LIGHTING = 0x0B50;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int LIGHT_MODEL_LOCAL_VIEWER = 0x0B51;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int LIGHT_MODEL_TWO_SIDE = 0x0B52;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int LIGHT_MODEL_AMBIENT = 0x0B53;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int SHADE_MODEL = 0x0B54;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int COLOR_MATERIAL_FACE = 0x0B55;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int COLOR_MATERIAL_PARAMETER = 0x0B56;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int COLOR_MATERIAL = 0x0B57;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int FOG = 0x0B60;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int FOG_INDEX = 0x0B61;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int FOG_DENSITY = 0x0B62;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int FOG_START = 0x0B63;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int FOG_END = 0x0B64;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int FOG_MODE = 0x0B65;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int FOG_COLOR = 0x0B66;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int ACCUM_CLEAR_VALUE = 0x0B80;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MATRIX_MODE = 0x0BA0;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int NORMALIZE = 0x0BA1;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MODELVIEW_STACK_DEPTH = 0x0BA3;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int PROJECTION_STACK_DEPTH = 0x0BA4;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int TEXTURE_STACK_DEPTH = 0x0BA5;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MODELVIEW_MATRIX = 0x0BA6;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int PROJECTION_MATRIX = 0x0BA7;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int TEXTURE_MATRIX = 0x0BA8;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int ATTRIB_STACK_DEPTH = 0x0BB0;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int ALPHA_TEST = 0x0BC0;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int ALPHA_TEST_FUNC = 0x0BC1;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int ALPHA_TEST_REF = 0x0BC2;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int INDEX_LOGIC_OP = 0x0BF1;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int LOGIC_OP = 0x0BF1;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int AUX_BUFFERS = 0x0C00;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int INDEX_CLEAR_VALUE = 0x0C20;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int INDEX_WRITEMASK = 0x0C21;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int INDEX_MODE = 0x0C30;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int RGBA_MODE = 0x0C31;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int RENDER_MODE = 0x0C40;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int PERSPECTIVE_CORRECTION_HINT = 0x0C50;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int POINT_SMOOTH_HINT = 0x0C51;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int FOG_HINT = 0x0C54;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int TEXTURE_GEN_S = 0x0C60;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int TEXTURE_GEN_T = 0x0C61;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int TEXTURE_GEN_R = 0x0C62;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int TEXTURE_GEN_Q = 0x0C63;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int PIXEL_MAP_I_TO_I_SIZE = 0x0CB0;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int PIXEL_MAP_S_TO_S_SIZE = 0x0CB1;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int PIXEL_MAP_I_TO_R_SIZE = 0x0CB2;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int PIXEL_MAP_I_TO_G_SIZE = 0x0CB3;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int PIXEL_MAP_I_TO_B_SIZE = 0x0CB4;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int PIXEL_MAP_I_TO_A_SIZE = 0x0CB5;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int PIXEL_MAP_R_TO_R_SIZE = 0x0CB6;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int PIXEL_MAP_G_TO_G_SIZE = 0x0CB7;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int PIXEL_MAP_B_TO_B_SIZE = 0x0CB8;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int PIXEL_MAP_A_TO_A_SIZE = 0x0CB9;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP_COLOR = 0x0D10;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP_STENCIL = 0x0D11;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int INDEX_SHIFT = 0x0D12;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int INDEX_OFFSET = 0x0D13;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int RED_SCALE = 0x0D14;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int RED_BIAS = 0x0D15;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int ZOOM_X = 0x0D16;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int ZOOM_Y = 0x0D17;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int GREEN_SCALE = 0x0D18;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int GREEN_BIAS = 0x0D19;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int BLUE_SCALE = 0x0D1A;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int BLUE_BIAS = 0x0D1B;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int ALPHA_SCALE = 0x0D1C;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int ALPHA_BIAS = 0x0D1D;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int DEPTH_SCALE = 0x0D1E;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int DEPTH_BIAS = 0x0D1F;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAX_EVAL_ORDER = 0x0D30;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAX_LIGHTS = 0x0D31;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAX_CLIP_PLANES = 0x0D32;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAX_PIXEL_MAP_TABLE = 0x0D34;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAX_ATTRIB_STACK_DEPTH = 0x0D35;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAX_MODELVIEW_STACK_DEPTH = 0x0D36;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAX_NAME_STACK_DEPTH = 0x0D37;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAX_PROJECTION_STACK_DEPTH = 0x0D38;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAX_TEXTURE_STACK_DEPTH = 0x0D39;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int INDEX_BITS = 0x0D51;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int RED_BITS = 0x0D52;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int GREEN_BITS = 0x0D53;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int BLUE_BITS = 0x0D54;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int ALPHA_BITS = 0x0D55;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int DEPTH_BITS = 0x0D56;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int STENCIL_BITS = 0x0D57;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int ACCUM_RED_BITS = 0x0D58;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int ACCUM_GREEN_BITS = 0x0D59;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int ACCUM_BLUE_BITS = 0x0D5A;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int ACCUM_ALPHA_BITS = 0x0D5B;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int NAME_STACK_DEPTH = 0x0D70;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int AUTO_NORMAL = 0x0D80;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP1_COLOR_4 = 0x0D90;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP1_INDEX = 0x0D91;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP1_NORMAL = 0x0D92;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP1_TEXTURE_COORD_1 = 0x0D93;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP1_TEXTURE_COORD_2 = 0x0D94;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP1_TEXTURE_COORD_3 = 0x0D95;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP1_TEXTURE_COORD_4 = 0x0D96;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP1_VERTEX_3 = 0x0D97;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP1_VERTEX_4 = 0x0D98;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP2_COLOR_4 = 0x0DB0;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP2_INDEX = 0x0DB1;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP2_NORMAL = 0x0DB2;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP2_TEXTURE_COORD_1 = 0x0DB3;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP2_TEXTURE_COORD_2 = 0x0DB4;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP2_TEXTURE_COORD_3 = 0x0DB5;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP2_TEXTURE_COORD_4 = 0x0DB6;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP2_VERTEX_3 = 0x0DB7;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP2_VERTEX_4 = 0x0DB8;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP1_GRID_DOMAIN = 0x0DD0;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP1_GRID_SEGMENTS = 0x0DD1;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP2_GRID_DOMAIN = 0x0DD2;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int MAP2_GRID_SEGMENTS = 0x0DD3;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int FEEDBACK_BUFFER_SIZE = 0x0DF1;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int FEEDBACK_BUFFER_TYPE = 0x0DF2;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int SELECTION_BUFFER_SIZE = 0x0DF4;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int VERTEX_ARRAY = 0x8074;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int NORMAL_ARRAY = 0x8075;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int COLOR_ARRAY = 0x8076;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int INDEX_ARRAY = 0x8077;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int TEXTURE_COORD_ARRAY = 0x8078;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int EDGE_FLAG_ARRAY = 0x8079;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int VERTEX_ARRAY_SIZE = 0x807A;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int VERTEX_ARRAY_TYPE = 0x807B;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int VERTEX_ARRAY_STRIDE = 0x807C;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int NORMAL_ARRAY_TYPE = 0x807E;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int NORMAL_ARRAY_STRIDE = 0x807F;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int COLOR_ARRAY_SIZE = 0x8081;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int COLOR_ARRAY_TYPE = 0x8082;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int COLOR_ARRAY_STRIDE = 0x8083;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int INDEX_ARRAY_TYPE = 0x8085;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int INDEX_ARRAY_STRIDE = 0x8086;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int TEXTURE_COORD_ARRAY_SIZE = 0x8088;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int TEXTURE_COORD_ARRAY_TYPE = 0x8089;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int TEXTURE_COORD_ARRAY_STRIDE = 0x808A;
        ///<summary>VERSION_1_1_DEPRECATED (GetPName)</summary>
        public const int EDGE_FLAG_ARRAY_STRIDE = 0x808C;
        ///<summary>VERSION_1_1_DEPRECATED (GetTextureParameter)</summary>
        public const int TEXTURE_COMPONENTS = 0x1003;
        ///<summary>VERSION_1_1_DEPRECATED (GetTextureParameter)</summary>
        public const int TEXTURE_BORDER = 0x1005;
        ///<summary>VERSION_1_1_DEPRECATED (GetTextureParameter)</summary>
        public const int TEXTURE_LUMINANCE_SIZE = 0x8060;
        ///<summary>VERSION_1_1_DEPRECATED (GetTextureParameter)</summary>
        public const int TEXTURE_INTENSITY_SIZE = 0x8061;
        ///<summary>VERSION_1_1_DEPRECATED (GetTextureParameter)</summary>
        public const int TEXTURE_PRIORITY = 0x8066;
        ///<summary>VERSION_1_1_DEPRECATED (GetTextureParameter)</summary>
        public const int TEXTURE_RESIDENT = 0x8067;
        ///<summary>VERSION_1_1_DEPRECATED (LightParameter)</summary>
        public const int AMBIENT = 0x1200;
        ///<summary>VERSION_1_1_DEPRECATED (LightParameter)</summary>
        public const int DIFFUSE = 0x1201;
        ///<summary>VERSION_1_1_DEPRECATED (LightParameter)</summary>
        public const int SPECULAR = 0x1202;
        ///<summary>VERSION_1_1_DEPRECATED (LightParameter)</summary>
        public const int POSITION = 0x1203;
        ///<summary>VERSION_1_1_DEPRECATED (LightParameter)</summary>
        public const int SPOT_DIRECTION = 0x1204;
        ///<summary>VERSION_1_1_DEPRECATED (LightParameter)</summary>
        public const int SPOT_EXPONENT = 0x1205;
        ///<summary>VERSION_1_1_DEPRECATED (LightParameter)</summary>
        public const int SPOT_CUTOFF = 0x1206;
        ///<summary>VERSION_1_1_DEPRECATED (LightParameter)</summary>
        public const int CONSTANT_ATTENUATION = 0x1207;
        ///<summary>VERSION_1_1_DEPRECATED (LightParameter)</summary>
        public const int LINEAR_ATTENUATION = 0x1208;
        ///<summary>VERSION_1_1_DEPRECATED (LightParameter)</summary>
        public const int QUADRATIC_ATTENUATION = 0x1209;
        ///<summary>VERSION_1_1_DEPRECATED (ListMode)</summary>
        public const int COMPILE = 0x1300;
        ///<summary>VERSION_1_1_DEPRECATED (ListMode)</summary>
        public const int COMPILE_AND_EXECUTE = 0x1301;
        ///<summary>VERSION_1_1_DEPRECATED (DataType)</summary>
        public const int _2_BYTES = 0x1407;
        ///<summary>VERSION_1_1_DEPRECATED (DataType)</summary>
        public const int _3_BYTES = 0x1408;
        ///<summary>VERSION_1_1_DEPRECATED (DataType)</summary>
        public const int _4_BYTES = 0x1409;
        ///<summary>VERSION_1_1_DEPRECATED (MaterialParameter)</summary>
        public const int EMISSION = 0x1600;
        ///<summary>VERSION_1_1_DEPRECATED (MaterialParameter)</summary>
        public const int SHININESS = 0x1601;
        ///<summary>VERSION_1_1_DEPRECATED (MaterialParameter)</summary>
        public const int AMBIENT_AND_DIFFUSE = 0x1602;
        ///<summary>VERSION_1_1_DEPRECATED (MaterialParameter)</summary>
        public const int COLOR_INDEXES = 0x1603;
        ///<summary>VERSION_1_1_DEPRECATED (MatrixMode)</summary>
        public const int MODELVIEW = 0x1700;
        ///<summary>VERSION_1_1_DEPRECATED (MatrixMode)</summary>
        public const int PROJECTION = 0x1701;
        ///<summary>VERSION_1_1_DEPRECATED (PixelFormat)</summary>
        public const int COLOR_INDEX = 0x1900;
        ///<summary>VERSION_1_1_DEPRECATED (PixelFormat)</summary>
        public const int LUMINANCE = 0x1909;
        ///<summary>VERSION_1_1_DEPRECATED (PixelFormat)</summary>
        public const int LUMINANCE_ALPHA = 0x190A;
        ///<summary>VERSION_1_1_DEPRECATED (PixelType)</summary>
        public const int BITMAP = 0x1A00;
        ///<summary>VERSION_1_1_DEPRECATED (RenderingMode)</summary>
        public const int RENDER = 0x1C00;
        ///<summary>VERSION_1_1_DEPRECATED (RenderingMode)</summary>
        public const int FEEDBACK = 0x1C01;
        ///<summary>VERSION_1_1_DEPRECATED (RenderingMode)</summary>
        public const int SELECT = 0x1C02;
        ///<summary>VERSION_1_1_DEPRECATED (ShadingModel)</summary>
        public const int FLAT = 0x1D00;
        ///<summary>VERSION_1_1_DEPRECATED (ShadingModel)</summary>
        public const int SMOOTH = 0x1D01;
        ///<summary>VERSION_1_1_DEPRECATED (TextureCoordName)</summary>
        public const int S = 0x2000;
        ///<summary>VERSION_1_1_DEPRECATED (TextureCoordName)</summary>
        public const int T = 0x2001;
        ///<summary>VERSION_1_1_DEPRECATED (TextureCoordName)</summary>
        public const int R = 0x2002;
        ///<summary>VERSION_1_1_DEPRECATED (TextureCoordName)</summary>
        public const int Q = 0x2003;
        ///<summary>VERSION_1_1_DEPRECATED (TextureEnvMode)</summary>
        public const int MODULATE = 0x2100;
        ///<summary>VERSION_1_1_DEPRECATED (TextureEnvMode)</summary>
        public const int DECAL = 0x2101;
        ///<summary>VERSION_1_1_DEPRECATED (TextureEnvParameter)</summary>
        public const int TEXTURE_ENV_MODE = 0x2200;
        ///<summary>VERSION_1_1_DEPRECATED (TextureEnvParameter)</summary>
        public const int TEXTURE_ENV_COLOR = 0x2201;
        ///<summary>VERSION_1_1_DEPRECATED (TextureEnvTarget)</summary>
        public const int TEXTURE_ENV = 0x2300;
        ///<summary>VERSION_1_1_DEPRECATED (TextureGenMode)</summary>
        public const int EYE_LINEAR = 0x2400;
        ///<summary>VERSION_1_1_DEPRECATED (TextureGenMode)</summary>
        public const int OBJECT_LINEAR = 0x2401;
        ///<summary>VERSION_1_1_DEPRECATED (TextureGenMode)</summary>
        public const int SPHERE_MAP = 0x2402;
        ///<summary>VERSION_1_1_DEPRECATED (TextureGenParameter)</summary>
        public const int TEXTURE_GEN_MODE = 0x2500;
        ///<summary>VERSION_1_1_DEPRECATED (TextureGenParameter)</summary>
        public const int OBJECT_PLANE = 0x2501;
        ///<summary>VERSION_1_1_DEPRECATED (TextureGenParameter)</summary>
        public const int EYE_PLANE = 0x2502;
        ///<summary>VERSION_1_1_DEPRECATED (TextureWrapMode)</summary>
        public const int CLAMP = 0x2900;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int ALPHA4 = 0x803B;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int ALPHA8 = 0x803C;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int ALPHA12 = 0x803D;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int ALPHA16 = 0x803E;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int LUMINANCE4 = 0x803F;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int LUMINANCE8 = 0x8040;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int LUMINANCE12 = 0x8041;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int LUMINANCE16 = 0x8042;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int LUMINANCE4_ALPHA4 = 0x8043;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int LUMINANCE6_ALPHA2 = 0x8044;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int LUMINANCE8_ALPHA8 = 0x8045;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int LUMINANCE12_ALPHA4 = 0x8046;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int LUMINANCE12_ALPHA12 = 0x8047;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int LUMINANCE16_ALPHA16 = 0x8048;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int INTENSITY = 0x8049;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int INTENSITY4 = 0x804A;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int INTENSITY8 = 0x804B;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int INTENSITY12 = 0x804C;
        ///<summary>VERSION_1_1_DEPRECATED (PixelInternalFormat)</summary>
        public const int INTENSITY16 = 0x804D;
        ///<summary>VERSION_1_1_DEPRECATED (InterleavedArrayFormat)</summary>
        public const int V2F = 0x2A20;
        ///<summary>VERSION_1_1_DEPRECATED (InterleavedArrayFormat)</summary>
        public const int V3F = 0x2A21;
        ///<summary>VERSION_1_1_DEPRECATED (InterleavedArrayFormat)</summary>
        public const int C4UB_V2F = 0x2A22;
        ///<summary>VERSION_1_1_DEPRECATED (InterleavedArrayFormat)</summary>
        public const int C4UB_V3F = 0x2A23;
        ///<summary>VERSION_1_1_DEPRECATED (InterleavedArrayFormat)</summary>
        public const int C3F_V3F = 0x2A24;
        ///<summary>VERSION_1_1_DEPRECATED (InterleavedArrayFormat)</summary>
        public const int N3F_V3F = 0x2A25;
        ///<summary>VERSION_1_1_DEPRECATED (InterleavedArrayFormat)</summary>
        public const int C4F_N3F_V3F = 0x2A26;
        ///<summary>VERSION_1_1_DEPRECATED (InterleavedArrayFormat)</summary>
        public const int T2F_V3F = 0x2A27;
        ///<summary>VERSION_1_1_DEPRECATED (InterleavedArrayFormat)</summary>
        public const int T4F_V4F = 0x2A28;
        ///<summary>VERSION_1_1_DEPRECATED (InterleavedArrayFormat)</summary>
        public const int T2F_C4UB_V3F = 0x2A29;
        ///<summary>VERSION_1_1_DEPRECATED (InterleavedArrayFormat)</summary>
        public const int T2F_C3F_V3F = 0x2A2A;
        ///<summary>VERSION_1_1_DEPRECATED (InterleavedArrayFormat)</summary>
        public const int T2F_N3F_V3F = 0x2A2B;
        ///<summary>VERSION_1_1_DEPRECATED (InterleavedArrayFormat)</summary>
        public const int T2F_C4F_N3F_V3F = 0x2A2C;
        ///<summary>VERSION_1_1_DEPRECATED (InterleavedArrayFormat)</summary>
        public const int T4F_C4F_N3F_V4F = 0x2A2D;
        ///<summary>VERSION_1_1_DEPRECATED (ClipPlaneName)</summary>
        public const int CLIP_PLANE0 = 0x3000;
        ///<summary>VERSION_1_1_DEPRECATED (ClipPlaneName)</summary>
        public const int CLIP_PLANE1 = 0x3001;
        ///<summary>VERSION_1_1_DEPRECATED (ClipPlaneName)</summary>
        public const int CLIP_PLANE2 = 0x3002;
        ///<summary>VERSION_1_1_DEPRECATED (ClipPlaneName)</summary>
        public const int CLIP_PLANE3 = 0x3003;
        ///<summary>VERSION_1_1_DEPRECATED (ClipPlaneName)</summary>
        public const int CLIP_PLANE4 = 0x3004;
        ///<summary>VERSION_1_1_DEPRECATED (ClipPlaneName)</summary>
        public const int CLIP_PLANE5 = 0x3005;
        ///<summary>VERSION_1_1_DEPRECATED (LightName)</summary>
        public const int LIGHT0 = 0x4000;
        ///<summary>VERSION_1_1_DEPRECATED (LightName)</summary>
        public const int LIGHT1 = 0x4001;
        ///<summary>VERSION_1_1_DEPRECATED (LightName)</summary>
        public const int LIGHT2 = 0x4002;
        ///<summary>VERSION_1_1_DEPRECATED (LightName)</summary>
        public const int LIGHT3 = 0x4003;
        ///<summary>VERSION_1_1_DEPRECATED (LightName)</summary>
        public const int LIGHT4 = 0x4004;
        ///<summary>VERSION_1_1_DEPRECATED (LightName)</summary>
        public const int LIGHT5 = 0x4005;
        ///<summary>VERSION_1_1_DEPRECATED (LightName)</summary>
        public const int LIGHT6 = 0x4006;
        ///<summary>VERSION_1_1_DEPRECATED (LightName)</summary>
        public const int LIGHT7 = 0x4007;
        ///<summary>VERSION_1_2</summary>
        public const int UNSIGNED_BYTE_3_3_2 = 0x8032;
        ///<summary>VERSION_1_2</summary>
        public const int UNSIGNED_SHORT_4_4_4_4 = 0x8033;
        ///<summary>VERSION_1_2</summary>
        public const int UNSIGNED_SHORT_5_5_5_1 = 0x8034;
        ///<summary>VERSION_1_2</summary>
        public const int UNSIGNED_INT_8_8_8_8 = 0x8035;
        ///<summary>VERSION_1_2</summary>
        public const int UNSIGNED_INT_10_10_10_2 = 0x8036;
        ///<summary>VERSION_1_2</summary>
        public const int TEXTURE_BINDING_3D = 0x806A;
        ///<summary>VERSION_1_2</summary>
        public const int PACK_SKIP_IMAGES = 0x806B;
        ///<summary>VERSION_1_2</summary>
        public const int PACK_IMAGE_HEIGHT = 0x806C;
        ///<summary>VERSION_1_2</summary>
        public const int UNPACK_SKIP_IMAGES = 0x806D;
        ///<summary>VERSION_1_2</summary>
        public const int UNPACK_IMAGE_HEIGHT = 0x806E;
        ///<summary>VERSION_1_2</summary>
        public const int TEXTURE_3D = 0x806F;
        ///<summary>VERSION_1_2</summary>
        public const int PROXY_TEXTURE_3D = 0x8070;
        ///<summary>VERSION_1_2</summary>
        public const int TEXTURE_DEPTH = 0x8071;
        ///<summary>VERSION_1_2</summary>
        public const int TEXTURE_WRAP_R = 0x8072;
        ///<summary>VERSION_1_2</summary>
        public const int MAX_3D_TEXTURE_SIZE = 0x8073;
        ///<summary>VERSION_1_2</summary>
        public const int UNSIGNED_BYTE_2_3_3_REV = 0x8362;
        ///<summary>VERSION_1_2</summary>
        public const int UNSIGNED_SHORT_5_6_5 = 0x8363;
        ///<summary>VERSION_1_2</summary>
        public const int UNSIGNED_SHORT_5_6_5_REV = 0x8364;
        ///<summary>VERSION_1_2</summary>
        public const int UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;
        ///<summary>VERSION_1_2</summary>
        public const int UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;
        ///<summary>VERSION_1_2</summary>
        public const int UNSIGNED_INT_8_8_8_8_REV = 0x8367;
        ///<summary>VERSION_1_2</summary>
        public const int UNSIGNED_INT_2_10_10_10_REV = 0x8368;
        ///<summary>VERSION_1_2</summary>
        public const int BGR = 0x80E0;
        ///<summary>VERSION_1_2</summary>
        public const int BGRA = 0x80E1;
        ///<summary>VERSION_1_2</summary>
        public const int MAX_ELEMENTS_VERTICES = 0x80E8;
        ///<summary>VERSION_1_2</summary>
        public const int MAX_ELEMENTS_INDICES = 0x80E9;
        ///<summary>VERSION_1_2</summary>
        public const int CLAMP_TO_EDGE = 0x812F;
        ///<summary>VERSION_1_2</summary>
        public const int TEXTURE_MIN_LOD = 0x813A;
        ///<summary>VERSION_1_2</summary>
        public const int TEXTURE_MAX_LOD = 0x813B;
        ///<summary>VERSION_1_2</summary>
        public const int TEXTURE_BASE_LEVEL = 0x813C;
        ///<summary>VERSION_1_2</summary>
        public const int TEXTURE_MAX_LEVEL = 0x813D;
        ///<summary>VERSION_1_2</summary>
        public const int SMOOTH_POINT_SIZE_RANGE = 0x0B12;
        ///<summary>VERSION_1_2</summary>
        public const int SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13;
        ///<summary>VERSION_1_2</summary>
        public const int SMOOTH_LINE_WIDTH_RANGE = 0x0B22;
        ///<summary>VERSION_1_2</summary>
        public const int SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23;
        ///<summary>VERSION_1_2</summary>
        public const int ALIASED_LINE_WIDTH_RANGE = 0x846E;
        ///<summary>VERSION_1_2_DEPRECATED</summary>
        public const int RESCALE_NORMAL = 0x803A;
        ///<summary>VERSION_1_2_DEPRECATED</summary>
        public const int LIGHT_MODEL_COLOR_CONTROL = 0x81F8;
        ///<summary>VERSION_1_2_DEPRECATED</summary>
        public const int SINGLE_COLOR = 0x81F9;
        ///<summary>VERSION_1_2_DEPRECATED</summary>
        public const int SEPARATE_SPECULAR_COLOR = 0x81FA;
        ///<summary>VERSION_1_2_DEPRECATED</summary>
        public const int ALIASED_POINT_SIZE_RANGE = 0x846D;
        ///<summary>ARB_imaging</summary>
        public const int CONSTANT_COLOR = 0x8001;
        ///<summary>ARB_imaging</summary>
        public const int ONE_MINUS_CONSTANT_COLOR = 0x8002;
        ///<summary>ARB_imaging</summary>
        public const int CONSTANT_ALPHA = 0x8003;
        ///<summary>ARB_imaging</summary>
        public const int ONE_MINUS_CONSTANT_ALPHA = 0x8004;
        ///<summary>ARB_imaging</summary>
        public const int BLEND_COLOR = 0x8005;
        ///<summary>ARB_imaging</summary>
        public const int FUNC_ADD = 0x8006;
        ///<summary>ARB_imaging</summary>
        public const int MIN = 0x8007;
        ///<summary>ARB_imaging</summary>
        public const int MAX = 0x8008;
        ///<summary>ARB_imaging</summary>
        public const int BLEND_EQUATION = 0x8009;
        ///<summary>ARB_imaging</summary>
        public const int FUNC_SUBTRACT = 0x800A;
        ///<summary>ARB_imaging</summary>
        public const int FUNC_REVERSE_SUBTRACT = 0x800B;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int CONVOLUTION_1D = 0x8010;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int CONVOLUTION_2D = 0x8011;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int SEPARABLE_2D = 0x8012;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int CONVOLUTION_BORDER_MODE = 0x8013;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int CONVOLUTION_FILTER_SCALE = 0x8014;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int CONVOLUTION_FILTER_BIAS = 0x8015;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int REDUCE = 0x8016;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int CONVOLUTION_FORMAT = 0x8017;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int CONVOLUTION_WIDTH = 0x8018;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int CONVOLUTION_HEIGHT = 0x8019;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int MAX_CONVOLUTION_WIDTH = 0x801A;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int MAX_CONVOLUTION_HEIGHT = 0x801B;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int POST_CONVOLUTION_RED_SCALE = 0x801C;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int POST_CONVOLUTION_GREEN_SCALE = 0x801D;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int POST_CONVOLUTION_BLUE_SCALE = 0x801E;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int POST_CONVOLUTION_ALPHA_SCALE = 0x801F;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int POST_CONVOLUTION_RED_BIAS = 0x8020;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int POST_CONVOLUTION_GREEN_BIAS = 0x8021;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int POST_CONVOLUTION_BLUE_BIAS = 0x8022;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int POST_CONVOLUTION_ALPHA_BIAS = 0x8023;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int HISTOGRAM = 0x8024;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int PROXY_HISTOGRAM = 0x8025;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int HISTOGRAM_WIDTH = 0x8026;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int HISTOGRAM_FORMAT = 0x8027;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int HISTOGRAM_RED_SIZE = 0x8028;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int HISTOGRAM_GREEN_SIZE = 0x8029;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int HISTOGRAM_BLUE_SIZE = 0x802A;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int HISTOGRAM_ALPHA_SIZE = 0x802B;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int HISTOGRAM_LUMINANCE_SIZE = 0x802C;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int HISTOGRAM_SINK = 0x802D;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int MINMAX = 0x802E;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int MINMAX_FORMAT = 0x802F;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int MINMAX_SINK = 0x8030;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int TABLE_TOO_LARGE = 0x8031;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int COLOR_MATRIX = 0x80B1;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int COLOR_MATRIX_STACK_DEPTH = 0x80B2;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int POST_COLOR_MATRIX_RED_SCALE = 0x80B4;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int POST_COLOR_MATRIX_RED_BIAS = 0x80B8;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int COLOR_TABLE = 0x80D0;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int POST_CONVOLUTION_COLOR_TABLE = 0x80D1;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int PROXY_COLOR_TABLE = 0x80D3;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int COLOR_TABLE_SCALE = 0x80D6;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int COLOR_TABLE_BIAS = 0x80D7;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int COLOR_TABLE_FORMAT = 0x80D8;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int COLOR_TABLE_WIDTH = 0x80D9;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int COLOR_TABLE_RED_SIZE = 0x80DA;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int COLOR_TABLE_GREEN_SIZE = 0x80DB;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int COLOR_TABLE_BLUE_SIZE = 0x80DC;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int COLOR_TABLE_ALPHA_SIZE = 0x80DD;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int COLOR_TABLE_LUMINANCE_SIZE = 0x80DE;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int COLOR_TABLE_INTENSITY_SIZE = 0x80DF;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int CONSTANT_BORDER = 0x8151;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int REPLICATE_BORDER = 0x8153;
        ///<summary>ARB_imaging_DEPRECATED</summary>
        public const int CONVOLUTION_BORDER_COLOR = 0x8154;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE0 = 0x84C0;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE1 = 0x84C1;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE2 = 0x84C2;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE3 = 0x84C3;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE4 = 0x84C4;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE5 = 0x84C5;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE6 = 0x84C6;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE7 = 0x84C7;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE8 = 0x84C8;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE9 = 0x84C9;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE10 = 0x84CA;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE11 = 0x84CB;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE12 = 0x84CC;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE13 = 0x84CD;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE14 = 0x84CE;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE15 = 0x84CF;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE16 = 0x84D0;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE17 = 0x84D1;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE18 = 0x84D2;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE19 = 0x84D3;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE20 = 0x84D4;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE21 = 0x84D5;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE22 = 0x84D6;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE23 = 0x84D7;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE24 = 0x84D8;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE25 = 0x84D9;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE26 = 0x84DA;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE27 = 0x84DB;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE28 = 0x84DC;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE29 = 0x84DD;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE30 = 0x84DE;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE31 = 0x84DF;
        ///<summary>VERSION_1_3</summary>
        public const int ACTIVE_TEXTURE = 0x84E0;
        ///<summary>VERSION_1_3</summary>
        public const int MULTISAMPLE = 0x809D;
        ///<summary>VERSION_1_3</summary>
        public const int SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
        ///<summary>VERSION_1_3</summary>
        public const int SAMPLE_ALPHA_TO_ONE = 0x809F;
        ///<summary>VERSION_1_3</summary>
        public const int SAMPLE_COVERAGE = 0x80A0;
        ///<summary>VERSION_1_3</summary>
        public const int SAMPLE_BUFFERS = 0x80A8;
        ///<summary>VERSION_1_3</summary>
        public const int SAMPLES = 0x80A9;
        ///<summary>VERSION_1_3</summary>
        public const int SAMPLE_COVERAGE_VALUE = 0x80AA;
        ///<summary>VERSION_1_3</summary>
        public const int SAMPLE_COVERAGE_INVERT = 0x80AB;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE_CUBE_MAP = 0x8513;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE_BINDING_CUBE_MAP = 0x8514;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
        ///<summary>VERSION_1_3</summary>
        public const int PROXY_TEXTURE_CUBE_MAP = 0x851B;
        ///<summary>VERSION_1_3</summary>
        public const int MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
        ///<summary>VERSION_1_3</summary>
        public const int COMPRESSED_RGB = 0x84ED;
        ///<summary>VERSION_1_3</summary>
        public const int COMPRESSED_RGBA = 0x84EE;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE_COMPRESSION_HINT = 0x84EF;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;
        ///<summary>VERSION_1_3</summary>
        public const int TEXTURE_COMPRESSED = 0x86A1;
        ///<summary>VERSION_1_3</summary>
        public const int NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
        ///<summary>VERSION_1_3</summary>
        public const int COMPRESSED_TEXTURE_FORMATS = 0x86A3;
        ///<summary>VERSION_1_3</summary>
        public const int CLAMP_TO_BORDER = 0x812D;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int CLIENT_ACTIVE_TEXTURE = 0x84E1;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int MAX_TEXTURE_UNITS = 0x84E2;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int TRANSPOSE_MODELVIEW_MATRIX = 0x84E3;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int TRANSPOSE_PROJECTION_MATRIX = 0x84E4;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int TRANSPOSE_TEXTURE_MATRIX = 0x84E5;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int TRANSPOSE_COLOR_MATRIX = 0x84E6;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int MULTISAMPLE_BIT = 0x20000000;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int NORMAL_MAP = 0x8511;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int REFLECTION_MAP = 0x8512;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int COMPRESSED_ALPHA = 0x84E9;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int COMPRESSED_LUMINANCE = 0x84EA;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int COMPRESSED_LUMINANCE_ALPHA = 0x84EB;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int COMPRESSED_INTENSITY = 0x84EC;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int COMBINE = 0x8570;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int COMBINE_RGB = 0x8571;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int COMBINE_ALPHA = 0x8572;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int SOURCE0_RGB = 0x8580;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int SOURCE1_RGB = 0x8581;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int SOURCE2_RGB = 0x8582;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int SOURCE0_ALPHA = 0x8588;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int SOURCE1_ALPHA = 0x8589;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int SOURCE2_ALPHA = 0x858A;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int OPERAND0_RGB = 0x8590;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int OPERAND1_RGB = 0x8591;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int OPERAND2_RGB = 0x8592;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int OPERAND0_ALPHA = 0x8598;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int OPERAND1_ALPHA = 0x8599;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int OPERAND2_ALPHA = 0x859A;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int RGB_SCALE = 0x8573;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int ADD_SIGNED = 0x8574;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int INTERPOLATE = 0x8575;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int SUBTRACT = 0x84E7;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int CONSTANT = 0x8576;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int PRIMARY_COLOR = 0x8577;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int PREVIOUS = 0x8578;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int DOT3_RGB = 0x86AE;
        ///<summary>VERSION_1_3_DEPRECATED</summary>
        public const int DOT3_RGBA = 0x86AF;
        ///<summary>VERSION_1_4</summary>
        public const int BLEND_DST_RGB = 0x80C8;
        ///<summary>VERSION_1_4</summary>
        public const int BLEND_SRC_RGB = 0x80C9;
        ///<summary>VERSION_1_4</summary>
        public const int BLEND_DST_ALPHA = 0x80CA;
        ///<summary>VERSION_1_4</summary>
        public const int BLEND_SRC_ALPHA = 0x80CB;
        ///<summary>VERSION_1_4</summary>
        public const int POINT_FADE_THRESHOLD_SIZE = 0x8128;
        ///<summary>VERSION_1_4</summary>
        public const int DEPTH_COMPONENT16 = 0x81A5;
        ///<summary>VERSION_1_4</summary>
        public const int DEPTH_COMPONENT24 = 0x81A6;
        ///<summary>VERSION_1_4</summary>
        public const int DEPTH_COMPONENT32 = 0x81A7;
        ///<summary>VERSION_1_4</summary>
        public const int MIRRORED_REPEAT = 0x8370;
        ///<summary>VERSION_1_4</summary>
        public const int MAX_TEXTURE_LOD_BIAS = 0x84FD;
        ///<summary>VERSION_1_4</summary>
        public const int TEXTURE_LOD_BIAS = 0x8501;
        ///<summary>VERSION_1_4</summary>
        public const int INCR_WRAP = 0x8507;
        ///<summary>VERSION_1_4</summary>
        public const int DECR_WRAP = 0x8508;
        ///<summary>VERSION_1_4</summary>
        public const int TEXTURE_DEPTH_SIZE = 0x884A;
        ///<summary>VERSION_1_4</summary>
        public const int TEXTURE_COMPARE_MODE = 0x884C;
        ///<summary>VERSION_1_4</summary>
        public const int TEXTURE_COMPARE_FUNC = 0x884D;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int POINT_SIZE_MIN = 0x8126;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int POINT_SIZE_MAX = 0x8127;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int POINT_DISTANCE_ATTENUATION = 0x8129;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int GENERATE_MIPMAP = 0x8191;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int GENERATE_MIPMAP_HINT = 0x8192;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int FOG_COORDINATE_SOURCE = 0x8450;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int FOG_COORDINATE = 0x8451;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int FRAGMENT_DEPTH = 0x8452;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int CURRENT_FOG_COORDINATE = 0x8453;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int FOG_COORDINATE_ARRAY_TYPE = 0x8454;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int FOG_COORDINATE_ARRAY_STRIDE = 0x8455;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int FOG_COORDINATE_ARRAY_POINTER = 0x8456;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int FOG_COORDINATE_ARRAY = 0x8457;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int COLOR_SUM = 0x8458;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int CURRENT_SECONDARY_COLOR = 0x8459;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int SECONDARY_COLOR_ARRAY_SIZE = 0x845A;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int SECONDARY_COLOR_ARRAY_TYPE = 0x845B;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int SECONDARY_COLOR_ARRAY_STRIDE = 0x845C;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int SECONDARY_COLOR_ARRAY_POINTER = 0x845D;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int SECONDARY_COLOR_ARRAY = 0x845E;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int TEXTURE_FILTER_CONTROL = 0x8500;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int DEPTH_TEXTURE_MODE = 0x884B;
        ///<summary>VERSION_1_4_DEPRECATED</summary>
        public const int COMPARE_R_TO_TEXTURE = 0x884E;
        ///<summary>VERSION_1_5</summary>
        public const int BUFFER_SIZE = 0x8764;
        ///<summary>VERSION_1_5</summary>
        public const int BUFFER_USAGE = 0x8765;
        ///<summary>VERSION_1_5</summary>
        public const int QUERY_COUNTER_BITS = 0x8864;
        ///<summary>VERSION_1_5</summary>
        public const int CURRENT_QUERY = 0x8865;
        ///<summary>VERSION_1_5</summary>
        public const int QUERY_RESULT = 0x8866;
        ///<summary>VERSION_1_5</summary>
        public const int QUERY_RESULT_AVAILABLE = 0x8867;
        ///<summary>VERSION_1_5</summary>
        public const int ARRAY_BUFFER = 0x8892;
        ///<summary>VERSION_1_5</summary>
        public const int ELEMENT_ARRAY_BUFFER = 0x8893;
        ///<summary>VERSION_1_5</summary>
        public const int ARRAY_BUFFER_BINDING = 0x8894;
        ///<summary>VERSION_1_5</summary>
        public const int ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
        ///<summary>VERSION_1_5</summary>
        public const int VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
        ///<summary>VERSION_1_5</summary>
        public const int READ_ONLY = 0x88B8;
        ///<summary>VERSION_1_5</summary>
        public const int WRITE_ONLY = 0x88B9;
        ///<summary>VERSION_1_5</summary>
        public const int READ_WRITE = 0x88BA;
        ///<summary>VERSION_1_5</summary>
        public const int BUFFER_ACCESS = 0x88BB;
        ///<summary>VERSION_1_5</summary>
        public const int BUFFER_MAPPED = 0x88BC;
        ///<summary>VERSION_1_5</summary>
        public const int BUFFER_MAP_POINTER = 0x88BD;
        ///<summary>VERSION_1_5</summary>
        public const int STREAM_DRAW = 0x88E0;
        ///<summary>VERSION_1_5</summary>
        public const int STREAM_READ = 0x88E1;
        ///<summary>VERSION_1_5</summary>
        public const int STREAM_COPY = 0x88E2;
        ///<summary>VERSION_1_5</summary>
        public const int STATIC_DRAW = 0x88E4;
        ///<summary>VERSION_1_5</summary>
        public const int STATIC_READ = 0x88E5;
        ///<summary>VERSION_1_5</summary>
        public const int STATIC_COPY = 0x88E6;
        ///<summary>VERSION_1_5</summary>
        public const int DYNAMIC_DRAW = 0x88E8;
        ///<summary>VERSION_1_5</summary>
        public const int DYNAMIC_READ = 0x88E9;
        ///<summary>VERSION_1_5</summary>
        public const int DYNAMIC_COPY = 0x88EA;
        ///<summary>VERSION_1_5</summary>
        public const int SAMPLES_PASSED = 0x8914;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int VERTEX_ARRAY_BUFFER_BINDING = 0x8896;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int NORMAL_ARRAY_BUFFER_BINDING = 0x8897;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int COLOR_ARRAY_BUFFER_BINDING = 0x8898;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int INDEX_ARRAY_BUFFER_BINDING = 0x8899;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int EDGE_FLAG_ARRAY_BUFFER_BINDING = 0x889B;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int SECONDARY_COLOR_ARRAY_BUFFER_BINDING = 0x889C;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int FOG_COORDINATE_ARRAY_BUFFER_BINDING = 0x889D;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int WEIGHT_ARRAY_BUFFER_BINDING = 0x889E;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int FOG_COORD_SRC = 0x8450;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int FOG_COORD = 0x8451;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int CURRENT_FOG_COORD = 0x8453;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int FOG_COORD_ARRAY_TYPE = 0x8454;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int FOG_COORD_ARRAY_STRIDE = 0x8455;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int FOG_COORD_ARRAY_POINTER = 0x8456;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int FOG_COORD_ARRAY = 0x8457;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int FOG_COORD_ARRAY_BUFFER_BINDING = 0x889D;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int SRC0_RGB = 0x8580;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int SRC1_RGB = 0x8581;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int SRC2_RGB = 0x8582;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int SRC0_ALPHA = 0x8588;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int SRC1_ALPHA = 0x8589;
        ///<summary>VERSION_1_5_DEPRECATED</summary>
        public const int SRC2_ALPHA = 0x858A;
        ///<summary>VERSION_2_0</summary>
        public const int BLEND_EQUATION_RGB = 0x8009;
        ///<summary>VERSION_2_0</summary>
        public const int VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
        ///<summary>VERSION_2_0</summary>
        public const int VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
        ///<summary>VERSION_2_0</summary>
        public const int VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
        ///<summary>VERSION_2_0</summary>
        public const int VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
        ///<summary>VERSION_2_0</summary>
        public const int CURRENT_VERTEX_ATTRIB = 0x8626;
        ///<summary>VERSION_2_0</summary>
        public const int VERTEX_PROGRAM_POINT_SIZE = 0x8642;
        ///<summary>VERSION_2_0</summary>
        public const int VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
        ///<summary>VERSION_2_0</summary>
        public const int STENCIL_BACK_FUNC = 0x8800;
        ///<summary>VERSION_2_0</summary>
        public const int STENCIL_BACK_FAIL = 0x8801;
        ///<summary>VERSION_2_0</summary>
        public const int STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
        ///<summary>VERSION_2_0</summary>
        public const int STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
        ///<summary>VERSION_2_0</summary>
        public const int MAX_DRAW_BUFFERS = 0x8824;
        ///<summary>VERSION_2_0</summary>
        public const int DRAW_BUFFER0 = 0x8825;
        ///<summary>VERSION_2_0</summary>
        public const int DRAW_BUFFER1 = 0x8826;
        ///<summary>VERSION_2_0</summary>
        public const int DRAW_BUFFER2 = 0x8827;
        ///<summary>VERSION_2_0</summary>
        public const int DRAW_BUFFER3 = 0x8828;
        ///<summary>VERSION_2_0</summary>
        public const int DRAW_BUFFER4 = 0x8829;
        ///<summary>VERSION_2_0</summary>
        public const int DRAW_BUFFER5 = 0x882A;
        ///<summary>VERSION_2_0</summary>
        public const int DRAW_BUFFER6 = 0x882B;
        ///<summary>VERSION_2_0</summary>
        public const int DRAW_BUFFER7 = 0x882C;
        ///<summary>VERSION_2_0</summary>
        public const int DRAW_BUFFER8 = 0x882D;
        ///<summary>VERSION_2_0</summary>
        public const int DRAW_BUFFER9 = 0x882E;
        ///<summary>VERSION_2_0</summary>
        public const int DRAW_BUFFER10 = 0x882F;
        ///<summary>VERSION_2_0</summary>
        public const int DRAW_BUFFER11 = 0x8830;
        ///<summary>VERSION_2_0</summary>
        public const int DRAW_BUFFER12 = 0x8831;
        ///<summary>VERSION_2_0</summary>
        public const int DRAW_BUFFER13 = 0x8832;
        ///<summary>VERSION_2_0</summary>
        public const int DRAW_BUFFER14 = 0x8833;
        ///<summary>VERSION_2_0</summary>
        public const int DRAW_BUFFER15 = 0x8834;
        ///<summary>VERSION_2_0</summary>
        public const int BLEND_EQUATION_ALPHA = 0x883D;
        ///<summary>VERSION_2_0</summary>
        public const int MAX_VERTEX_ATTRIBS = 0x8869;
        ///<summary>VERSION_2_0</summary>
        public const int VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
        ///<summary>VERSION_2_0</summary>
        public const int MAX_TEXTURE_IMAGE_UNITS = 0x8872;
        ///<summary>VERSION_2_0</summary>
        public const int FRAGMENT_SHADER = 0x8B30;
        ///<summary>VERSION_2_0</summary>
        public const int VERTEX_SHADER = 0x8B31;
        ///<summary>VERSION_2_0</summary>
        public const int MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;
        ///<summary>VERSION_2_0</summary>
        public const int MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;
        ///<summary>VERSION_2_0</summary>
        public const int MAX_VARYING_FLOATS = 0x8B4B;
        ///<summary>VERSION_2_0</summary>
        public const int MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
        ///<summary>VERSION_2_0</summary>
        public const int MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
        ///<summary>VERSION_2_0</summary>
        public const int SHADER_TYPE = 0x8B4F;
        ///<summary>VERSION_2_0</summary>
        public const int FLOAT_VEC2 = 0x8B50;
        ///<summary>VERSION_2_0</summary>
        public const int FLOAT_VEC3 = 0x8B51;
        ///<summary>VERSION_2_0</summary>
        public const int FLOAT_VEC4 = 0x8B52;
        ///<summary>VERSION_2_0</summary>
        public const int INT_VEC2 = 0x8B53;
        ///<summary>VERSION_2_0</summary>
        public const int INT_VEC3 = 0x8B54;
        ///<summary>VERSION_2_0</summary>
        public const int INT_VEC4 = 0x8B55;
        ///<summary>VERSION_2_0</summary>
        public const int BOOL = 0x8B56;
        ///<summary>VERSION_2_0</summary>
        public const int BOOL_VEC2 = 0x8B57;
        ///<summary>VERSION_2_0</summary>
        public const int BOOL_VEC3 = 0x8B58;
        ///<summary>VERSION_2_0</summary>
        public const int BOOL_VEC4 = 0x8B59;
        ///<summary>VERSION_2_0</summary>
        public const int FLOAT_MAT2 = 0x8B5A;
        ///<summary>VERSION_2_0</summary>
        public const int FLOAT_MAT3 = 0x8B5B;
        ///<summary>VERSION_2_0</summary>
        public const int FLOAT_MAT4 = 0x8B5C;
        ///<summary>VERSION_2_0</summary>
        public const int SAMPLER_1D = 0x8B5D;
        ///<summary>VERSION_2_0</summary>
        public const int SAMPLER_2D = 0x8B5E;
        ///<summary>VERSION_2_0</summary>
        public const int SAMPLER_3D = 0x8B5F;
        ///<summary>VERSION_2_0</summary>
        public const int SAMPLER_CUBE = 0x8B60;
        ///<summary>VERSION_2_0</summary>
        public const int SAMPLER_1D_SHADOW = 0x8B61;
        ///<summary>VERSION_2_0</summary>
        public const int SAMPLER_2D_SHADOW = 0x8B62;
        ///<summary>VERSION_2_0</summary>
        public const int DELETE_STATUS = 0x8B80;
        ///<summary>VERSION_2_0</summary>
        public const int COMPILE_STATUS = 0x8B81;
        ///<summary>VERSION_2_0</summary>
        public const int LINK_STATUS = 0x8B82;
        ///<summary>VERSION_2_0</summary>
        public const int VALIDATE_STATUS = 0x8B83;
        ///<summary>VERSION_2_0</summary>
        public const int INFO_LOG_LENGTH = 0x8B84;
        ///<summary>VERSION_2_0</summary>
        public const int ATTACHED_SHADERS = 0x8B85;
        ///<summary>VERSION_2_0</summary>
        public const int ACTIVE_UNIFORMS = 0x8B86;
        ///<summary>VERSION_2_0</summary>
        public const int ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
        ///<summary>VERSION_2_0</summary>
        public const int SHADER_SOURCE_LENGTH = 0x8B88;
        ///<summary>VERSION_2_0</summary>
        public const int ACTIVE_ATTRIBUTES = 0x8B89;
        ///<summary>VERSION_2_0</summary>
        public const int ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
        ///<summary>VERSION_2_0</summary>
        public const int FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;
        ///<summary>VERSION_2_0</summary>
        public const int SHADING_LANGUAGE_VERSION = 0x8B8C;
        ///<summary>VERSION_2_0</summary>
        public const int CURRENT_PROGRAM = 0x8B8D;
        ///<summary>VERSION_2_0</summary>
        public const int POINT_SPRITE_COORD_ORIGIN = 0x8CA0;
        ///<summary>VERSION_2_0</summary>
        public const int LOWER_LEFT = 0x8CA1;
        ///<summary>VERSION_2_0</summary>
        public const int UPPER_LEFT = 0x8CA2;
        ///<summary>VERSION_2_0</summary>
        public const int STENCIL_BACK_REF = 0x8CA3;
        ///<summary>VERSION_2_0</summary>
        public const int STENCIL_BACK_VALUE_MASK = 0x8CA4;
        ///<summary>VERSION_2_0</summary>
        public const int STENCIL_BACK_WRITEMASK = 0x8CA5;
        ///<summary>VERSION_2_0_DEPRECATED</summary>
        public const int VERTEX_PROGRAM_TWO_SIDE = 0x8643;
        ///<summary>VERSION_2_0_DEPRECATED</summary>
        public const int POINT_SPRITE = 0x8861;
        ///<summary>VERSION_2_0_DEPRECATED</summary>
        public const int COORD_REPLACE = 0x8862;
        ///<summary>VERSION_2_0_DEPRECATED</summary>
        public const int MAX_TEXTURE_COORDS = 0x8871;
        ///<summary>VERSION_2_1</summary>
        public const int PIXEL_PACK_BUFFER = 0x88EB;
        ///<summary>VERSION_2_1</summary>
        public const int PIXEL_UNPACK_BUFFER = 0x88EC;
        ///<summary>VERSION_2_1</summary>
        public const int PIXEL_PACK_BUFFER_BINDING = 0x88ED;
        ///<summary>VERSION_2_1</summary>
        public const int PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
        ///<summary>VERSION_2_1</summary>
        public const int FLOAT_MAT2x3 = 0x8B65;
        ///<summary>VERSION_2_1</summary>
        public const int FLOAT_MAT2x4 = 0x8B66;
        ///<summary>VERSION_2_1</summary>
        public const int FLOAT_MAT3x2 = 0x8B67;
        ///<summary>VERSION_2_1</summary>
        public const int FLOAT_MAT3x4 = 0x8B68;
        ///<summary>VERSION_2_1</summary>
        public const int FLOAT_MAT4x2 = 0x8B69;
        ///<summary>VERSION_2_1</summary>
        public const int FLOAT_MAT4x3 = 0x8B6A;
        ///<summary>VERSION_2_1</summary>
        public const int SRGB = 0x8C40;
        ///<summary>VERSION_2_1</summary>
        public const int SRGB8 = 0x8C41;
        ///<summary>VERSION_2_1</summary>
        public const int SRGB_ALPHA = 0x8C42;
        ///<summary>VERSION_2_1</summary>
        public const int SRGB8_ALPHA8 = 0x8C43;
        ///<summary>VERSION_2_1</summary>
        public const int COMPRESSED_SRGB = 0x8C48;
        ///<summary>VERSION_2_1</summary>
        public const int COMPRESSED_SRGB_ALPHA = 0x8C49;
        ///<summary>VERSION_2_1_DEPRECATED</summary>
        public const int CURRENT_RASTER_SECONDARY_COLOR = 0x845F;
        ///<summary>VERSION_2_1_DEPRECATED</summary>
        public const int SLUMINANCE_ALPHA = 0x8C44;
        ///<summary>VERSION_2_1_DEPRECATED</summary>
        public const int SLUMINANCE8_ALPHA8 = 0x8C45;
        ///<summary>VERSION_2_1_DEPRECATED</summary>
        public const int SLUMINANCE = 0x8C46;
        ///<summary>VERSION_2_1_DEPRECATED</summary>
        public const int SLUMINANCE8 = 0x8C47;
        ///<summary>VERSION_2_1_DEPRECATED</summary>
        public const int COMPRESSED_SLUMINANCE = 0x8C4A;
        ///<summary>VERSION_2_1_DEPRECATED</summary>
        public const int COMPRESSED_SLUMINANCE_ALPHA = 0x8C4B;
        ///<summary>VERSION_3_0</summary>
        public const int COMPARE_REF_TO_TEXTURE = 0x884E;
        ///<summary>VERSION_3_0</summary>
        public const int CLIP_DISTANCE0 = 0x3000;
        ///<summary>VERSION_3_0</summary>
        public const int CLIP_DISTANCE1 = 0x3001;
        ///<summary>VERSION_3_0</summary>
        public const int CLIP_DISTANCE2 = 0x3002;
        ///<summary>VERSION_3_0</summary>
        public const int CLIP_DISTANCE3 = 0x3003;
        ///<summary>VERSION_3_0</summary>
        public const int CLIP_DISTANCE4 = 0x3004;
        ///<summary>VERSION_3_0</summary>
        public const int CLIP_DISTANCE5 = 0x3005;
        ///<summary>VERSION_3_0</summary>
        public const int CLIP_DISTANCE6 = 0x3006;
        ///<summary>VERSION_3_0</summary>
        public const int CLIP_DISTANCE7 = 0x3007;
        ///<summary>VERSION_3_0</summary>
        public const int MAX_CLIP_DISTANCES = 0x0D32;
        ///<summary>VERSION_3_0</summary>
        public const int MAJOR_VERSION = 0x821B;
        ///<summary>VERSION_3_0</summary>
        public const int MINOR_VERSION = 0x821C;
        ///<summary>VERSION_3_0</summary>
        public const int NUM_EXTENSIONS = 0x821D;
        ///<summary>VERSION_3_0</summary>
        public const int CONTEXT_FLAGS = 0x821E;
        ///<summary>VERSION_3_0</summary>
        public const int COMPRESSED_RED = 0x8225;
        ///<summary>VERSION_3_0</summary>
        public const int COMPRESSED_RG = 0x8226;
        ///<summary>VERSION_3_0</summary>
        public const int CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x0001;
        ///<summary>VERSION_3_0</summary>
        public const int RGBA32F = 0x8814;
        ///<summary>VERSION_3_0</summary>
        public const int RGB32F = 0x8815;
        ///<summary>VERSION_3_0</summary>
        public const int RGBA16F = 0x881A;
        ///<summary>VERSION_3_0</summary>
        public const int RGB16F = 0x881B;
        ///<summary>VERSION_3_0</summary>
        public const int VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;
        ///<summary>VERSION_3_0</summary>
        public const int MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;
        ///<summary>VERSION_3_0</summary>
        public const int MIN_PROGRAM_TEXEL_OFFSET = 0x8904;
        ///<summary>VERSION_3_0</summary>
        public const int MAX_PROGRAM_TEXEL_OFFSET = 0x8905;
        ///<summary>VERSION_3_0</summary>
        public const int CLAMP_READ_COLOR = 0x891C;
        ///<summary>VERSION_3_0</summary>
        public const int FIXED_ONLY = 0x891D;
        ///<summary>VERSION_3_0</summary>
        public const int MAX_VARYING_COMPONENTS = 0x8B4B;
        ///<summary>VERSION_3_0</summary>
        public const int TEXTURE_1D_ARRAY = 0x8C18;
        ///<summary>VERSION_3_0</summary>
        public const int PROXY_TEXTURE_1D_ARRAY = 0x8C19;
        ///<summary>VERSION_3_0</summary>
        public const int TEXTURE_2D_ARRAY = 0x8C1A;
        ///<summary>VERSION_3_0</summary>
        public const int PROXY_TEXTURE_2D_ARRAY = 0x8C1B;
        ///<summary>VERSION_3_0</summary>
        public const int TEXTURE_BINDING_1D_ARRAY = 0x8C1C;
        ///<summary>VERSION_3_0</summary>
        public const int TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
        ///<summary>VERSION_3_0</summary>
        public const int R11F_G11F_B10F = 0x8C3A;
        ///<summary>VERSION_3_0</summary>
        public const int UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
        ///<summary>VERSION_3_0</summary>
        public const int RGB9_E5 = 0x8C3D;
        ///<summary>VERSION_3_0</summary>
        public const int UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
        ///<summary>VERSION_3_0</summary>
        public const int TEXTURE_SHARED_SIZE = 0x8C3F;
        ///<summary>VERSION_3_0</summary>
        public const int TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;
        ///<summary>VERSION_3_0</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
        ///<summary>VERSION_3_0</summary>
        public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
        ///<summary>VERSION_3_0</summary>
        public const int TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;
        ///<summary>VERSION_3_0</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
        ///<summary>VERSION_3_0</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
        ///<summary>VERSION_3_0</summary>
        public const int PRIMITIVES_GENERATED = 0x8C87;
        ///<summary>VERSION_3_0</summary>
        public const int TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
        ///<summary>VERSION_3_0</summary>
        public const int RASTERIZER_DISCARD = 0x8C89;
        ///<summary>VERSION_3_0</summary>
        public const int MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
        ///<summary>VERSION_3_0</summary>
        public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
        ///<summary>VERSION_3_0</summary>
        public const int INTERLEAVED_ATTRIBS = 0x8C8C;
        ///<summary>VERSION_3_0</summary>
        public const int SEPARATE_ATTRIBS = 0x8C8D;
        ///<summary>VERSION_3_0</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
        ///<summary>VERSION_3_0</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;
        ///<summary>VERSION_3_0</summary>
        public const int RGBA32UI = 0x8D70;
        ///<summary>VERSION_3_0</summary>
        public const int RGB32UI = 0x8D71;
        ///<summary>VERSION_3_0</summary>
        public const int RGBA16UI = 0x8D76;
        ///<summary>VERSION_3_0</summary>
        public const int RGB16UI = 0x8D77;
        ///<summary>VERSION_3_0</summary>
        public const int RGBA8UI = 0x8D7C;
        ///<summary>VERSION_3_0</summary>
        public const int RGB8UI = 0x8D7D;
        ///<summary>VERSION_3_0</summary>
        public const int RGBA32I = 0x8D82;
        ///<summary>VERSION_3_0</summary>
        public const int RGB32I = 0x8D83;
        ///<summary>VERSION_3_0</summary>
        public const int RGBA16I = 0x8D88;
        ///<summary>VERSION_3_0</summary>
        public const int RGB16I = 0x8D89;
        ///<summary>VERSION_3_0</summary>
        public const int RGBA8I = 0x8D8E;
        ///<summary>VERSION_3_0</summary>
        public const int RGB8I = 0x8D8F;
        ///<summary>VERSION_3_0</summary>
        public const int RED_INTEGER = 0x8D94;
        ///<summary>VERSION_3_0</summary>
        public const int GREEN_INTEGER = 0x8D95;
        ///<summary>VERSION_3_0</summary>
        public const int BLUE_INTEGER = 0x8D96;
        ///<summary>VERSION_3_0</summary>
        public const int RGB_INTEGER = 0x8D98;
        ///<summary>VERSION_3_0</summary>
        public const int RGBA_INTEGER = 0x8D99;
        ///<summary>VERSION_3_0</summary>
        public const int BGR_INTEGER = 0x8D9A;
        ///<summary>VERSION_3_0</summary>
        public const int BGRA_INTEGER = 0x8D9B;
        ///<summary>VERSION_3_0</summary>
        public const int SAMPLER_1D_ARRAY = 0x8DC0;
        ///<summary>VERSION_3_0</summary>
        public const int SAMPLER_2D_ARRAY = 0x8DC1;
        ///<summary>VERSION_3_0</summary>
        public const int SAMPLER_1D_ARRAY_SHADOW = 0x8DC3;
        ///<summary>VERSION_3_0</summary>
        public const int SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;
        ///<summary>VERSION_3_0</summary>
        public const int SAMPLER_CUBE_SHADOW = 0x8DC5;
        ///<summary>VERSION_3_0</summary>
        public const int UNSIGNED_INT_VEC2 = 0x8DC6;
        ///<summary>VERSION_3_0</summary>
        public const int UNSIGNED_INT_VEC3 = 0x8DC7;
        ///<summary>VERSION_3_0</summary>
        public const int UNSIGNED_INT_VEC4 = 0x8DC8;
        ///<summary>VERSION_3_0</summary>
        public const int INT_SAMPLER_1D = 0x8DC9;
        ///<summary>VERSION_3_0</summary>
        public const int INT_SAMPLER_2D = 0x8DCA;
        ///<summary>VERSION_3_0</summary>
        public const int INT_SAMPLER_3D = 0x8DCB;
        ///<summary>VERSION_3_0</summary>
        public const int INT_SAMPLER_CUBE = 0x8DCC;
        ///<summary>VERSION_3_0</summary>
        public const int INT_SAMPLER_1D_ARRAY = 0x8DCE;
        ///<summary>VERSION_3_0</summary>
        public const int INT_SAMPLER_2D_ARRAY = 0x8DCF;
        ///<summary>VERSION_3_0</summary>
        public const int UNSIGNED_INT_SAMPLER_1D = 0x8DD1;
        ///<summary>VERSION_3_0</summary>
        public const int UNSIGNED_INT_SAMPLER_2D = 0x8DD2;
        ///<summary>VERSION_3_0</summary>
        public const int UNSIGNED_INT_SAMPLER_3D = 0x8DD3;
        ///<summary>VERSION_3_0</summary>
        public const int UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;
        ///<summary>VERSION_3_0</summary>
        public const int UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6;
        ///<summary>VERSION_3_0</summary>
        public const int UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;
        ///<summary>VERSION_3_0</summary>
        public const int QUERY_WAIT = 0x8E13;
        ///<summary>VERSION_3_0</summary>
        public const int QUERY_NO_WAIT = 0x8E14;
        ///<summary>VERSION_3_0</summary>
        public const int QUERY_BY_REGION_WAIT = 0x8E15;
        ///<summary>VERSION_3_0</summary>
        public const int QUERY_BY_REGION_NO_WAIT = 0x8E16;
        ///<summary>VERSION_3_0</summary>
        public const int BUFFER_ACCESS_FLAGS = 0x911F;
        ///<summary>VERSION_3_0</summary>
        public const int BUFFER_MAP_LENGTH = 0x9120;
        ///<summary>VERSION_3_0</summary>
        public const int BUFFER_MAP_OFFSET = 0x9121;
        ///<summary>VERSION_3_0_DEPRECATED</summary>
        public const int CLAMP_VERTEX_COLOR = 0x891A;
        ///<summary>VERSION_3_0_DEPRECATED</summary>
        public const int CLAMP_FRAGMENT_COLOR = 0x891B;
        ///<summary>VERSION_3_0_DEPRECATED</summary>
        public const int ALPHA_INTEGER = 0x8D97;
        ///<summary>VERSION_3_1</summary>
        public const int SAMPLER_2D_RECT = 0x8B63;
        ///<summary>VERSION_3_1</summary>
        public const int SAMPLER_2D_RECT_SHADOW = 0x8B64;
        ///<summary>VERSION_3_1</summary>
        public const int SAMPLER_BUFFER = 0x8DC2;
        ///<summary>VERSION_3_1</summary>
        public const int INT_SAMPLER_2D_RECT = 0x8DCD;
        ///<summary>VERSION_3_1</summary>
        public const int INT_SAMPLER_BUFFER = 0x8DD0;
        ///<summary>VERSION_3_1</summary>
        public const int UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5;
        ///<summary>VERSION_3_1</summary>
        public const int UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;
        ///<summary>VERSION_3_1</summary>
        public const int TEXTURE_BUFFER = 0x8C2A;
        ///<summary>VERSION_3_1</summary>
        public const int MAX_TEXTURE_BUFFER_SIZE = 0x8C2B;
        ///<summary>VERSION_3_1</summary>
        public const int TEXTURE_BINDING_BUFFER = 0x8C2C;
        ///<summary>VERSION_3_1</summary>
        public const int TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;
        ///<summary>VERSION_3_1</summary>
        public const int TEXTURE_BUFFER_FORMAT = 0x8C2E;
        ///<summary>VERSION_3_1</summary>
        public const int TEXTURE_RECTANGLE = 0x84F5;
        ///<summary>VERSION_3_1</summary>
        public const int TEXTURE_BINDING_RECTANGLE = 0x84F6;
        ///<summary>VERSION_3_1</summary>
        public const int PROXY_TEXTURE_RECTANGLE = 0x84F7;
        ///<summary>VERSION_3_1</summary>
        public const int MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8;
        ///<summary>VERSION_3_1</summary>
        public const int RED_SNORM = 0x8F90;
        ///<summary>VERSION_3_1</summary>
        public const int RG_SNORM = 0x8F91;
        ///<summary>VERSION_3_1</summary>
        public const int RGB_SNORM = 0x8F92;
        ///<summary>VERSION_3_1</summary>
        public const int RGBA_SNORM = 0x8F93;
        ///<summary>VERSION_3_1</summary>
        public const int R8_SNORM = 0x8F94;
        ///<summary>VERSION_3_1</summary>
        public const int RG8_SNORM = 0x8F95;
        ///<summary>VERSION_3_1</summary>
        public const int RGB8_SNORM = 0x8F96;
        ///<summary>VERSION_3_1</summary>
        public const int RGBA8_SNORM = 0x8F97;
        ///<summary>VERSION_3_1</summary>
        public const int R16_SNORM = 0x8F98;
        ///<summary>VERSION_3_1</summary>
        public const int RG16_SNORM = 0x8F99;
        ///<summary>VERSION_3_1</summary>
        public const int RGB16_SNORM = 0x8F9A;
        ///<summary>VERSION_3_1</summary>
        public const int RGBA16_SNORM = 0x8F9B;
        ///<summary>VERSION_3_1</summary>
        public const int SIGNED_NORMALIZED = 0x8F9C;
        ///<summary>VERSION_3_1</summary>
        public const int PRIMITIVE_RESTART = 0x8F9D;
        ///<summary>VERSION_3_1</summary>
        public const int PRIMITIVE_RESTART_INDEX = 0x8F9E;
        ///<summary>VERSION_3_2</summary>
        public const int CONTEXT_CORE_PROFILE_BIT = 0x00000001;
        ///<summary>VERSION_3_2</summary>
        public const int CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002;
        ///<summary>VERSION_3_2</summary>
        public const int LINES_ADJACENCY = 0x000A;
        ///<summary>VERSION_3_2</summary>
        public const int LINE_STRIP_ADJACENCY = 0x000B;
        ///<summary>VERSION_3_2</summary>
        public const int TRIANGLES_ADJACENCY = 0x000C;
        ///<summary>VERSION_3_2</summary>
        public const int TRIANGLE_STRIP_ADJACENCY = 0x000D;
        ///<summary>VERSION_3_2</summary>
        public const int PROGRAM_POINT_SIZE = 0x8642;
        ///<summary>VERSION_3_2</summary>
        public const int MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;
        ///<summary>VERSION_3_2</summary>
        public const int FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;
        ///<summary>VERSION_3_2</summary>
        public const int FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;
        ///<summary>VERSION_3_2</summary>
        public const int GEOMETRY_SHADER = 0x8DD9;
        ///<summary>VERSION_3_2</summary>
        public const int GEOMETRY_VERTICES_OUT = 0x8916;
        ///<summary>VERSION_3_2</summary>
        public const int GEOMETRY_INPUT_TYPE = 0x8917;
        ///<summary>VERSION_3_2</summary>
        public const int GEOMETRY_OUTPUT_TYPE = 0x8918;
        ///<summary>VERSION_3_2</summary>
        public const int MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;
        ///<summary>VERSION_3_2</summary>
        public const int MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;
        ///<summary>VERSION_3_2</summary>
        public const int MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;
        ///<summary>VERSION_3_2</summary>
        public const int MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;
        ///<summary>VERSION_3_2</summary>
        public const int MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;
        ///<summary>VERSION_3_2</summary>
        public const int MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;
        ///<summary>VERSION_3_2</summary>
        public const int MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;
        ///<summary>VERSION_3_2</summary>
        public const int CONTEXT_PROFILE_MASK = 0x9126;
        ///<summary>VERSION_3_3</summary>
        public const int VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;
        ///<summary>VERSION_4_0</summary>
        public const int SAMPLE_SHADING = 0x8C36;
        ///<summary>VERSION_4_0</summary>
        public const int MIN_SAMPLE_SHADING_VALUE = 0x8C37;
        ///<summary>VERSION_4_0</summary>
        public const int MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;
        ///<summary>VERSION_4_0</summary>
        public const int MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;
        ///<summary>VERSION_4_0</summary>
        public const int TEXTURE_CUBE_MAP_ARRAY = 0x9009;
        ///<summary>VERSION_4_0</summary>
        public const int TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
        ///<summary>VERSION_4_0</summary>
        public const int PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B;
        ///<summary>VERSION_4_0</summary>
        public const int SAMPLER_CUBE_MAP_ARRAY = 0x900C;
        ///<summary>VERSION_4_0</summary>
        public const int SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;
        ///<summary>VERSION_4_0</summary>
        public const int INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;
        ///<summary>VERSION_4_0</summary>
        public const int UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;
        ///<summary>VERSION_4_3</summary>
        public const int NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9;
        ///<summary>VERSION_4_3</summary>
        public const int VERTEX_ATTRIB_ARRAY_LONG = 0x874E;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE0_ARB = 0x84C0;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE1_ARB = 0x84C1;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE2_ARB = 0x84C2;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE3_ARB = 0x84C3;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE4_ARB = 0x84C4;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE5_ARB = 0x84C5;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE6_ARB = 0x84C6;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE7_ARB = 0x84C7;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE8_ARB = 0x84C8;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE9_ARB = 0x84C9;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE10_ARB = 0x84CA;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE11_ARB = 0x84CB;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE12_ARB = 0x84CC;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE13_ARB = 0x84CD;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE14_ARB = 0x84CE;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE15_ARB = 0x84CF;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE16_ARB = 0x84D0;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE17_ARB = 0x84D1;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE18_ARB = 0x84D2;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE19_ARB = 0x84D3;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE20_ARB = 0x84D4;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE21_ARB = 0x84D5;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE22_ARB = 0x84D6;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE23_ARB = 0x84D7;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE24_ARB = 0x84D8;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE25_ARB = 0x84D9;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE26_ARB = 0x84DA;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE27_ARB = 0x84DB;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE28_ARB = 0x84DC;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE29_ARB = 0x84DD;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE30_ARB = 0x84DE;
        ///<summary>ARB_multitexture</summary>
        public const int TEXTURE31_ARB = 0x84DF;
        ///<summary>ARB_multitexture</summary>
        public const int ACTIVE_TEXTURE_ARB = 0x84E0;
        ///<summary>ARB_multitexture</summary>
        public const int CLIENT_ACTIVE_TEXTURE_ARB = 0x84E1;
        ///<summary>ARB_multitexture</summary>
        public const int MAX_TEXTURE_UNITS_ARB = 0x84E2;
        ///<summary>ARB_transpose_matrix</summary>
        public const int TRANSPOSE_MODELVIEW_MATRIX_ARB = 0x84E3;
        ///<summary>ARB_transpose_matrix</summary>
        public const int TRANSPOSE_PROJECTION_MATRIX_ARB = 0x84E4;
        ///<summary>ARB_transpose_matrix</summary>
        public const int TRANSPOSE_TEXTURE_MATRIX_ARB = 0x84E5;
        ///<summary>ARB_transpose_matrix</summary>
        public const int TRANSPOSE_COLOR_MATRIX_ARB = 0x84E6;
        ///<summary>ARB_multisample</summary>
        public const int MULTISAMPLE_ARB = 0x809D;
        ///<summary>ARB_multisample</summary>
        public const int SAMPLE_ALPHA_TO_COVERAGE_ARB = 0x809E;
        ///<summary>ARB_multisample</summary>
        public const int SAMPLE_ALPHA_TO_ONE_ARB = 0x809F;
        ///<summary>ARB_multisample</summary>
        public const int SAMPLE_COVERAGE_ARB = 0x80A0;
        ///<summary>ARB_multisample</summary>
        public const int SAMPLE_BUFFERS_ARB = 0x80A8;
        ///<summary>ARB_multisample</summary>
        public const int SAMPLES_ARB = 0x80A9;
        ///<summary>ARB_multisample</summary>
        public const int SAMPLE_COVERAGE_VALUE_ARB = 0x80AA;
        ///<summary>ARB_multisample</summary>
        public const int SAMPLE_COVERAGE_INVERT_ARB = 0x80AB;
        ///<summary>ARB_multisample</summary>
        public const int MULTISAMPLE_BIT_ARB = 0x20000000;
        ///<summary>ARB_texture_cube_map</summary>
        public const int NORMAL_MAP_ARB = 0x8511;
        ///<summary>ARB_texture_cube_map</summary>
        public const int REFLECTION_MAP_ARB = 0x8512;
        ///<summary>ARB_texture_cube_map</summary>
        public const int TEXTURE_CUBE_MAP_ARB = 0x8513;
        ///<summary>ARB_texture_cube_map</summary>
        public const int TEXTURE_BINDING_CUBE_MAP_ARB = 0x8514;
        ///<summary>ARB_texture_cube_map</summary>
        public const int TEXTURE_CUBE_MAP_POSITIVE_X_ARB = 0x8515;
        ///<summary>ARB_texture_cube_map</summary>
        public const int TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = 0x8516;
        ///<summary>ARB_texture_cube_map</summary>
        public const int TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = 0x8517;
        ///<summary>ARB_texture_cube_map</summary>
        public const int TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = 0x8518;
        ///<summary>ARB_texture_cube_map</summary>
        public const int TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = 0x8519;
        ///<summary>ARB_texture_cube_map</summary>
        public const int TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = 0x851A;
        ///<summary>ARB_texture_cube_map</summary>
        public const int PROXY_TEXTURE_CUBE_MAP_ARB = 0x851B;
        ///<summary>ARB_texture_cube_map</summary>
        public const int MAX_CUBE_MAP_TEXTURE_SIZE_ARB = 0x851C;
        ///<summary>ARB_texture_compression</summary>
        public const int COMPRESSED_ALPHA_ARB = 0x84E9;
        ///<summary>ARB_texture_compression</summary>
        public const int COMPRESSED_LUMINANCE_ARB = 0x84EA;
        ///<summary>ARB_texture_compression</summary>
        public const int COMPRESSED_LUMINANCE_ALPHA_ARB = 0x84EB;
        ///<summary>ARB_texture_compression</summary>
        public const int COMPRESSED_INTENSITY_ARB = 0x84EC;
        ///<summary>ARB_texture_compression</summary>
        public const int COMPRESSED_RGB_ARB = 0x84ED;
        ///<summary>ARB_texture_compression</summary>
        public const int COMPRESSED_RGBA_ARB = 0x84EE;
        ///<summary>ARB_texture_compression</summary>
        public const int TEXTURE_COMPRESSION_HINT_ARB = 0x84EF;
        ///<summary>ARB_texture_compression</summary>
        public const int TEXTURE_COMPRESSED_IMAGE_SIZE_ARB = 0x86A0;
        ///<summary>ARB_texture_compression</summary>
        public const int TEXTURE_COMPRESSED_ARB = 0x86A1;
        ///<summary>ARB_texture_compression</summary>
        public const int NUM_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A2;
        ///<summary>ARB_texture_compression</summary>
        public const int COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A3;
        ///<summary>ARB_texture_border_clamp</summary>
        public const int CLAMP_TO_BORDER_ARB = 0x812D;
        ///<summary>ARB_point_parameters</summary>
        public const int POINT_SIZE_MIN_ARB = 0x8126;
        ///<summary>ARB_point_parameters</summary>
        public const int POINT_SIZE_MAX_ARB = 0x8127;
        ///<summary>ARB_point_parameters</summary>
        public const int POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128;
        ///<summary>ARB_point_parameters</summary>
        public const int POINT_DISTANCE_ATTENUATION_ARB = 0x8129;
        ///<summary>ARB_vertex_blend</summary>
        public const int MAX_VERTEX_UNITS_ARB = 0x86A4;
        ///<summary>ARB_vertex_blend</summary>
        public const int ACTIVE_VERTEX_UNITS_ARB = 0x86A5;
        ///<summary>ARB_vertex_blend</summary>
        public const int WEIGHT_SUM_UNITY_ARB = 0x86A6;
        ///<summary>ARB_vertex_blend</summary>
        public const int VERTEX_BLEND_ARB = 0x86A7;
        ///<summary>ARB_vertex_blend</summary>
        public const int CURRENT_WEIGHT_ARB = 0x86A8;
        ///<summary>ARB_vertex_blend</summary>
        public const int WEIGHT_ARRAY_TYPE_ARB = 0x86A9;
        ///<summary>ARB_vertex_blend</summary>
        public const int WEIGHT_ARRAY_STRIDE_ARB = 0x86AA;
        ///<summary>ARB_vertex_blend</summary>
        public const int WEIGHT_ARRAY_SIZE_ARB = 0x86AB;
        ///<summary>ARB_vertex_blend</summary>
        public const int WEIGHT_ARRAY_POINTER_ARB = 0x86AC;
        ///<summary>ARB_vertex_blend</summary>
        public const int WEIGHT_ARRAY_ARB = 0x86AD;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW0_ARB = 0x1700;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW1_ARB = 0x850A;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW2_ARB = 0x8722;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW3_ARB = 0x8723;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW4_ARB = 0x8724;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW5_ARB = 0x8725;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW6_ARB = 0x8726;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW7_ARB = 0x8727;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW8_ARB = 0x8728;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW9_ARB = 0x8729;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW10_ARB = 0x872A;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW11_ARB = 0x872B;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW12_ARB = 0x872C;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW13_ARB = 0x872D;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW14_ARB = 0x872E;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW15_ARB = 0x872F;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW16_ARB = 0x8730;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW17_ARB = 0x8731;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW18_ARB = 0x8732;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW19_ARB = 0x8733;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW20_ARB = 0x8734;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW21_ARB = 0x8735;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW22_ARB = 0x8736;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW23_ARB = 0x8737;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW24_ARB = 0x8738;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW25_ARB = 0x8739;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW26_ARB = 0x873A;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW27_ARB = 0x873B;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW28_ARB = 0x873C;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW29_ARB = 0x873D;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW30_ARB = 0x873E;
        ///<summary>ARB_vertex_blend</summary>
        public const int MODELVIEW31_ARB = 0x873F;
        ///<summary>ARB_matrix_palette</summary>
        public const int MATRIX_PALETTE_ARB = 0x8840;
        ///<summary>ARB_matrix_palette</summary>
        public const int MAX_MATRIX_PALETTE_STACK_DEPTH_ARB = 0x8841;
        ///<summary>ARB_matrix_palette</summary>
        public const int MAX_PALETTE_MATRICES_ARB = 0x8842;
        ///<summary>ARB_matrix_palette</summary>
        public const int CURRENT_PALETTE_MATRIX_ARB = 0x8843;
        ///<summary>ARB_matrix_palette</summary>
        public const int MATRIX_INDEX_ARRAY_ARB = 0x8844;
        ///<summary>ARB_matrix_palette</summary>
        public const int CURRENT_MATRIX_INDEX_ARB = 0x8845;
        ///<summary>ARB_matrix_palette</summary>
        public const int MATRIX_INDEX_ARRAY_SIZE_ARB = 0x8846;
        ///<summary>ARB_matrix_palette</summary>
        public const int MATRIX_INDEX_ARRAY_TYPE_ARB = 0x8847;
        ///<summary>ARB_matrix_palette</summary>
        public const int MATRIX_INDEX_ARRAY_STRIDE_ARB = 0x8848;
        ///<summary>ARB_matrix_palette</summary>
        public const int MATRIX_INDEX_ARRAY_POINTER_ARB = 0x8849;
        ///<summary>ARB_texture_env_combine</summary>
        public const int COMBINE_ARB = 0x8570;
        ///<summary>ARB_texture_env_combine</summary>
        public const int COMBINE_RGB_ARB = 0x8571;
        ///<summary>ARB_texture_env_combine</summary>
        public const int COMBINE_ALPHA_ARB = 0x8572;
        ///<summary>ARB_texture_env_combine</summary>
        public const int SOURCE0_RGB_ARB = 0x8580;
        ///<summary>ARB_texture_env_combine</summary>
        public const int SOURCE1_RGB_ARB = 0x8581;
        ///<summary>ARB_texture_env_combine</summary>
        public const int SOURCE2_RGB_ARB = 0x8582;
        ///<summary>ARB_texture_env_combine</summary>
        public const int SOURCE0_ALPHA_ARB = 0x8588;
        ///<summary>ARB_texture_env_combine</summary>
        public const int SOURCE1_ALPHA_ARB = 0x8589;
        ///<summary>ARB_texture_env_combine</summary>
        public const int SOURCE2_ALPHA_ARB = 0x858A;
        ///<summary>ARB_texture_env_combine</summary>
        public const int OPERAND0_RGB_ARB = 0x8590;
        ///<summary>ARB_texture_env_combine</summary>
        public const int OPERAND1_RGB_ARB = 0x8591;
        ///<summary>ARB_texture_env_combine</summary>
        public const int OPERAND2_RGB_ARB = 0x8592;
        ///<summary>ARB_texture_env_combine</summary>
        public const int OPERAND0_ALPHA_ARB = 0x8598;
        ///<summary>ARB_texture_env_combine</summary>
        public const int OPERAND1_ALPHA_ARB = 0x8599;
        ///<summary>ARB_texture_env_combine</summary>
        public const int OPERAND2_ALPHA_ARB = 0x859A;
        ///<summary>ARB_texture_env_combine</summary>
        public const int RGB_SCALE_ARB = 0x8573;
        ///<summary>ARB_texture_env_combine</summary>
        public const int ADD_SIGNED_ARB = 0x8574;
        ///<summary>ARB_texture_env_combine</summary>
        public const int INTERPOLATE_ARB = 0x8575;
        ///<summary>ARB_texture_env_combine</summary>
        public const int SUBTRACT_ARB = 0x84E7;
        ///<summary>ARB_texture_env_combine</summary>
        public const int CONSTANT_ARB = 0x8576;
        ///<summary>ARB_texture_env_combine</summary>
        public const int PRIMARY_COLOR_ARB = 0x8577;
        ///<summary>ARB_texture_env_combine</summary>
        public const int PREVIOUS_ARB = 0x8578;
        ///<summary>ARB_texture_env_dot3</summary>
        public const int DOT3_RGB_ARB = 0x86AE;
        ///<summary>ARB_texture_env_dot3</summary>
        public const int DOT3_RGBA_ARB = 0x86AF;
        ///<summary>ARB_texture_mirrored_repeat</summary>
        public const int MIRRORED_REPEAT_ARB = 0x8370;
        ///<summary>ARB_depth_texture</summary>
        public const int DEPTH_COMPONENT16_ARB = 0x81A5;
        ///<summary>ARB_depth_texture</summary>
        public const int DEPTH_COMPONENT24_ARB = 0x81A6;
        ///<summary>ARB_depth_texture</summary>
        public const int DEPTH_COMPONENT32_ARB = 0x81A7;
        ///<summary>ARB_depth_texture</summary>
        public const int TEXTURE_DEPTH_SIZE_ARB = 0x884A;
        ///<summary>ARB_depth_texture</summary>
        public const int DEPTH_TEXTURE_MODE_ARB = 0x884B;
        ///<summary>ARB_shadow_ambient</summary>
        public const int TEXTURE_COMPARE_FAIL_VALUE_ARB = 0x80BF;
        ///<summary>ARB_vertex_program</summary>
        public const int COLOR_SUM_ARB = 0x8458;
        ///<summary>ARB_vertex_program</summary>
        public const int VERTEX_PROGRAM_ARB = 0x8620;
        ///<summary>ARB_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY_ENABLED_ARB = 0x8622;
        ///<summary>ARB_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY_SIZE_ARB = 0x8623;
        ///<summary>ARB_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY_STRIDE_ARB = 0x8624;
        ///<summary>ARB_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY_TYPE_ARB = 0x8625;
        ///<summary>ARB_vertex_program</summary>
        public const int CURRENT_VERTEX_ATTRIB_ARB = 0x8626;
        ///<summary>ARB_vertex_program</summary>
        public const int PROGRAM_LENGTH_ARB = 0x8627;
        ///<summary>ARB_vertex_program</summary>
        public const int PROGRAM_STRING_ARB = 0x8628;
        ///<summary>ARB_vertex_program</summary>
        public const int MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB = 0x862E;
        ///<summary>ARB_vertex_program</summary>
        public const int MAX_PROGRAM_MATRICES_ARB = 0x862F;
        ///<summary>ARB_vertex_program</summary>
        public const int CURRENT_MATRIX_STACK_DEPTH_ARB = 0x8640;
        ///<summary>ARB_vertex_program</summary>
        public const int CURRENT_MATRIX_ARB = 0x8641;
        ///<summary>ARB_vertex_program</summary>
        public const int VERTEX_PROGRAM_POINT_SIZE_ARB = 0x8642;
        ///<summary>ARB_vertex_program</summary>
        public const int VERTEX_PROGRAM_TWO_SIDE_ARB = 0x8643;
        ///<summary>ARB_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY_POINTER_ARB = 0x8645;
        ///<summary>ARB_vertex_program</summary>
        public const int PROGRAM_ERROR_POSITION_ARB = 0x864B;
        ///<summary>ARB_vertex_program</summary>
        public const int PROGRAM_BINDING_ARB = 0x8677;
        ///<summary>ARB_vertex_program</summary>
        public const int MAX_VERTEX_ATTRIBS_ARB = 0x8869;
        ///<summary>ARB_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB = 0x886A;
        ///<summary>ARB_vertex_program</summary>
        public const int PROGRAM_ERROR_STRING_ARB = 0x8874;
        ///<summary>ARB_vertex_program</summary>
        public const int PROGRAM_FORMAT_ASCII_ARB = 0x8875;
        ///<summary>ARB_vertex_program</summary>
        public const int PROGRAM_FORMAT_ARB = 0x8876;
        ///<summary>ARB_vertex_program</summary>
        public const int PROGRAM_INSTRUCTIONS_ARB = 0x88A0;
        ///<summary>ARB_vertex_program</summary>
        public const int MAX_PROGRAM_INSTRUCTIONS_ARB = 0x88A1;
        ///<summary>ARB_vertex_program</summary>
        public const int PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A2;
        ///<summary>ARB_vertex_program</summary>
        public const int MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A3;
        ///<summary>ARB_vertex_program</summary>
        public const int PROGRAM_TEMPORARIES_ARB = 0x88A4;
        ///<summary>ARB_vertex_program</summary>
        public const int MAX_PROGRAM_TEMPORARIES_ARB = 0x88A5;
        ///<summary>ARB_vertex_program</summary>
        public const int PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A6;
        ///<summary>ARB_vertex_program</summary>
        public const int MAX_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A7;
        ///<summary>ARB_vertex_program</summary>
        public const int PROGRAM_PARAMETERS_ARB = 0x88A8;
        ///<summary>ARB_vertex_program</summary>
        public const int MAX_PROGRAM_PARAMETERS_ARB = 0x88A9;
        ///<summary>ARB_vertex_program</summary>
        public const int PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AA;
        ///<summary>ARB_vertex_program</summary>
        public const int MAX_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AB;
        ///<summary>ARB_vertex_program</summary>
        public const int PROGRAM_ATTRIBS_ARB = 0x88AC;
        ///<summary>ARB_vertex_program</summary>
        public const int MAX_PROGRAM_ATTRIBS_ARB = 0x88AD;
        ///<summary>ARB_vertex_program</summary>
        public const int PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AE;
        ///<summary>ARB_vertex_program</summary>
        public const int MAX_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AF;
        ///<summary>ARB_vertex_program</summary>
        public const int PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B0;
        ///<summary>ARB_vertex_program</summary>
        public const int MAX_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B1;
        ///<summary>ARB_vertex_program</summary>
        public const int PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B2;
        ///<summary>ARB_vertex_program</summary>
        public const int MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B3;
        ///<summary>ARB_vertex_program</summary>
        public const int MAX_PROGRAM_LOCAL_PARAMETERS_ARB = 0x88B4;
        ///<summary>ARB_vertex_program</summary>
        public const int MAX_PROGRAM_ENV_PARAMETERS_ARB = 0x88B5;
        ///<summary>ARB_vertex_program</summary>
        public const int PROGRAM_UNDER_NATIVE_LIMITS_ARB = 0x88B6;
        ///<summary>ARB_vertex_program</summary>
        public const int TRANSPOSE_CURRENT_MATRIX_ARB = 0x88B7;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX0_ARB = 0x88C0;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX1_ARB = 0x88C1;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX2_ARB = 0x88C2;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX3_ARB = 0x88C3;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX4_ARB = 0x88C4;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX5_ARB = 0x88C5;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX6_ARB = 0x88C6;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX7_ARB = 0x88C7;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX8_ARB = 0x88C8;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX9_ARB = 0x88C9;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX10_ARB = 0x88CA;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX11_ARB = 0x88CB;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX12_ARB = 0x88CC;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX13_ARB = 0x88CD;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX14_ARB = 0x88CE;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX15_ARB = 0x88CF;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX16_ARB = 0x88D0;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX17_ARB = 0x88D1;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX18_ARB = 0x88D2;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX19_ARB = 0x88D3;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX20_ARB = 0x88D4;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX21_ARB = 0x88D5;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX22_ARB = 0x88D6;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX23_ARB = 0x88D7;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX24_ARB = 0x88D8;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX25_ARB = 0x88D9;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX26_ARB = 0x88DA;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX27_ARB = 0x88DB;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX28_ARB = 0x88DC;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX29_ARB = 0x88DD;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX30_ARB = 0x88DE;
        ///<summary>ARB_vertex_program</summary>
        public const int MATRIX31_ARB = 0x88DF;
        ///<summary>ARB_fragment_program</summary>
        public const int FRAGMENT_PROGRAM_ARB = 0x8804;
        ///<summary>ARB_fragment_program</summary>
        public const int PROGRAM_ALU_INSTRUCTIONS_ARB = 0x8805;
        ///<summary>ARB_fragment_program</summary>
        public const int PROGRAM_TEX_INSTRUCTIONS_ARB = 0x8806;
        ///<summary>ARB_fragment_program</summary>
        public const int PROGRAM_TEX_INDIRECTIONS_ARB = 0x8807;
        ///<summary>ARB_fragment_program</summary>
        public const int PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x8808;
        ///<summary>ARB_fragment_program</summary>
        public const int PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x8809;
        ///<summary>ARB_fragment_program</summary>
        public const int PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x880A;
        ///<summary>ARB_fragment_program</summary>
        public const int MAX_PROGRAM_ALU_INSTRUCTIONS_ARB = 0x880B;
        ///<summary>ARB_fragment_program</summary>
        public const int MAX_PROGRAM_TEX_INSTRUCTIONS_ARB = 0x880C;
        ///<summary>ARB_fragment_program</summary>
        public const int MAX_PROGRAM_TEX_INDIRECTIONS_ARB = 0x880D;
        ///<summary>ARB_fragment_program</summary>
        public const int MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x880E;
        ///<summary>ARB_fragment_program</summary>
        public const int MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x880F;
        ///<summary>ARB_fragment_program</summary>
        public const int MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x8810;
        ///<summary>ARB_fragment_program</summary>
        public const int MAX_TEXTURE_COORDS_ARB = 0x8871;
        ///<summary>ARB_fragment_program</summary>
        public const int MAX_TEXTURE_IMAGE_UNITS_ARB = 0x8872;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int BUFFER_SIZE_ARB = 0x8764;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int BUFFER_USAGE_ARB = 0x8765;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int ARRAY_BUFFER_ARB = 0x8892;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int ELEMENT_ARRAY_BUFFER_ARB = 0x8893;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int ARRAY_BUFFER_BINDING_ARB = 0x8894;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int ELEMENT_ARRAY_BUFFER_BINDING_ARB = 0x8895;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int VERTEX_ARRAY_BUFFER_BINDING_ARB = 0x8896;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int NORMAL_ARRAY_BUFFER_BINDING_ARB = 0x8897;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int COLOR_ARRAY_BUFFER_BINDING_ARB = 0x8898;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int INDEX_ARRAY_BUFFER_BINDING_ARB = 0x8899;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB = 0x889A;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB = 0x889B;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x889C;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB = 0x889D;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int WEIGHT_ARRAY_BUFFER_BINDING_ARB = 0x889E;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB = 0x889F;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int READ_ONLY_ARB = 0x88B8;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int WRITE_ONLY_ARB = 0x88B9;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int READ_WRITE_ARB = 0x88BA;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int BUFFER_ACCESS_ARB = 0x88BB;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int BUFFER_MAPPED_ARB = 0x88BC;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int BUFFER_MAP_POINTER_ARB = 0x88BD;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int STREAM_DRAW_ARB = 0x88E0;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int STREAM_READ_ARB = 0x88E1;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int STREAM_COPY_ARB = 0x88E2;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int STATIC_DRAW_ARB = 0x88E4;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int STATIC_READ_ARB = 0x88E5;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int STATIC_COPY_ARB = 0x88E6;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int DYNAMIC_DRAW_ARB = 0x88E8;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int DYNAMIC_READ_ARB = 0x88E9;
        ///<summary>ARB_vertex_buffer_object</summary>
        public const int DYNAMIC_COPY_ARB = 0x88EA;
        ///<summary>ARB_occlusion_query</summary>
        public const int QUERY_COUNTER_BITS_ARB = 0x8864;
        ///<summary>ARB_occlusion_query</summary>
        public const int CURRENT_QUERY_ARB = 0x8865;
        ///<summary>ARB_occlusion_query</summary>
        public const int QUERY_RESULT_ARB = 0x8866;
        ///<summary>ARB_occlusion_query</summary>
        public const int QUERY_RESULT_AVAILABLE_ARB = 0x8867;
        ///<summary>ARB_occlusion_query</summary>
        public const int SAMPLES_PASSED_ARB = 0x8914;
        ///<summary>ARB_shader_objects</summary>
        public const int PROGRAM_OBJECT_ARB = 0x8B40;
        ///<summary>ARB_shader_objects</summary>
        public const int SHADER_OBJECT_ARB = 0x8B48;
        ///<summary>ARB_shader_objects</summary>
        public const int OBJECT_TYPE_ARB = 0x8B4E;
        ///<summary>ARB_shader_objects</summary>
        public const int OBJECT_SUBTYPE_ARB = 0x8B4F;
        ///<summary>ARB_shader_objects</summary>
        public const int FLOAT_VEC2_ARB = 0x8B50;
        ///<summary>ARB_shader_objects</summary>
        public const int FLOAT_VEC3_ARB = 0x8B51;
        ///<summary>ARB_shader_objects</summary>
        public const int FLOAT_VEC4_ARB = 0x8B52;
        ///<summary>ARB_shader_objects</summary>
        public const int INT_VEC2_ARB = 0x8B53;
        ///<summary>ARB_shader_objects</summary>
        public const int INT_VEC3_ARB = 0x8B54;
        ///<summary>ARB_shader_objects</summary>
        public const int INT_VEC4_ARB = 0x8B55;
        ///<summary>ARB_shader_objects</summary>
        public const int BOOL_ARB = 0x8B56;
        ///<summary>ARB_shader_objects</summary>
        public const int BOOL_VEC2_ARB = 0x8B57;
        ///<summary>ARB_shader_objects</summary>
        public const int BOOL_VEC3_ARB = 0x8B58;
        ///<summary>ARB_shader_objects</summary>
        public const int BOOL_VEC4_ARB = 0x8B59;
        ///<summary>ARB_shader_objects</summary>
        public const int FLOAT_MAT2_ARB = 0x8B5A;
        ///<summary>ARB_shader_objects</summary>
        public const int FLOAT_MAT3_ARB = 0x8B5B;
        ///<summary>ARB_shader_objects</summary>
        public const int FLOAT_MAT4_ARB = 0x8B5C;
        ///<summary>ARB_shader_objects</summary>
        public const int SAMPLER_1D_ARB = 0x8B5D;
        ///<summary>ARB_shader_objects</summary>
        public const int SAMPLER_2D_ARB = 0x8B5E;
        ///<summary>ARB_shader_objects</summary>
        public const int SAMPLER_3D_ARB = 0x8B5F;
        ///<summary>ARB_shader_objects</summary>
        public const int SAMPLER_CUBE_ARB = 0x8B60;
        ///<summary>ARB_shader_objects</summary>
        public const int SAMPLER_1D_SHADOW_ARB = 0x8B61;
        ///<summary>ARB_shader_objects</summary>
        public const int SAMPLER_2D_SHADOW_ARB = 0x8B62;
        ///<summary>ARB_shader_objects</summary>
        public const int SAMPLER_2D_RECT_ARB = 0x8B63;
        ///<summary>ARB_shader_objects</summary>
        public const int SAMPLER_2D_RECT_SHADOW_ARB = 0x8B64;
        ///<summary>ARB_shader_objects</summary>
        public const int OBJECT_DELETE_STATUS_ARB = 0x8B80;
        ///<summary>ARB_shader_objects</summary>
        public const int OBJECT_COMPILE_STATUS_ARB = 0x8B81;
        ///<summary>ARB_shader_objects</summary>
        public const int OBJECT_LINK_STATUS_ARB = 0x8B82;
        ///<summary>ARB_shader_objects</summary>
        public const int OBJECT_VALIDATE_STATUS_ARB = 0x8B83;
        ///<summary>ARB_shader_objects</summary>
        public const int OBJECT_INFO_LOG_LENGTH_ARB = 0x8B84;
        ///<summary>ARB_shader_objects</summary>
        public const int OBJECT_ATTACHED_OBJECTS_ARB = 0x8B85;
        ///<summary>ARB_shader_objects</summary>
        public const int OBJECT_ACTIVE_UNIFORMS_ARB = 0x8B86;
        ///<summary>ARB_shader_objects</summary>
        public const int OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB = 0x8B87;
        ///<summary>ARB_shader_objects</summary>
        public const int OBJECT_SHADER_SOURCE_LENGTH_ARB = 0x8B88;
        ///<summary>ARB_vertex_shader</summary>
        public const int VERTEX_SHADER_ARB = 0x8B31;
        ///<summary>ARB_vertex_shader</summary>
        public const int MAX_VERTEX_UNIFORM_COMPONENTS_ARB = 0x8B4A;
        ///<summary>ARB_vertex_shader</summary>
        public const int MAX_VARYING_FLOATS_ARB = 0x8B4B;
        ///<summary>ARB_vertex_shader</summary>
        public const int MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB = 0x8B4C;
        ///<summary>ARB_vertex_shader</summary>
        public const int MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB = 0x8B4D;
        ///<summary>ARB_vertex_shader</summary>
        public const int OBJECT_ACTIVE_ATTRIBUTES_ARB = 0x8B89;
        ///<summary>ARB_vertex_shader</summary>
        public const int OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB = 0x8B8A;
        ///<summary>ARB_fragment_shader</summary>
        public const int FRAGMENT_SHADER_ARB = 0x8B30;
        ///<summary>ARB_fragment_shader</summary>
        public const int MAX_FRAGMENT_UNIFORM_COMPONENTS_ARB = 0x8B49;
        ///<summary>ARB_fragment_shader</summary>
        public const int FRAGMENT_SHADER_DERIVATIVE_HINT_ARB = 0x8B8B;
        ///<summary>ARB_shading_language_100</summary>
        public const int SHADING_LANGUAGE_VERSION_ARB = 0x8B8C;
        ///<summary>ARB_point_sprite</summary>
        public const int POINT_SPRITE_ARB = 0x8861;
        ///<summary>ARB_point_sprite</summary>
        public const int COORD_REPLACE_ARB = 0x8862;
        ///<summary>ARB_draw_buffers</summary>
        public const int MAX_DRAW_BUFFERS_ARB = 0x8824;
        ///<summary>ARB_draw_buffers</summary>
        public const int DRAW_BUFFER0_ARB = 0x8825;
        ///<summary>ARB_draw_buffers</summary>
        public const int DRAW_BUFFER1_ARB = 0x8826;
        ///<summary>ARB_draw_buffers</summary>
        public const int DRAW_BUFFER2_ARB = 0x8827;
        ///<summary>ARB_draw_buffers</summary>
        public const int DRAW_BUFFER3_ARB = 0x8828;
        ///<summary>ARB_draw_buffers</summary>
        public const int DRAW_BUFFER4_ARB = 0x8829;
        ///<summary>ARB_draw_buffers</summary>
        public const int DRAW_BUFFER5_ARB = 0x882A;
        ///<summary>ARB_draw_buffers</summary>
        public const int DRAW_BUFFER6_ARB = 0x882B;
        ///<summary>ARB_draw_buffers</summary>
        public const int DRAW_BUFFER7_ARB = 0x882C;
        ///<summary>ARB_draw_buffers</summary>
        public const int DRAW_BUFFER8_ARB = 0x882D;
        ///<summary>ARB_draw_buffers</summary>
        public const int DRAW_BUFFER9_ARB = 0x882E;
        ///<summary>ARB_draw_buffers</summary>
        public const int DRAW_BUFFER10_ARB = 0x882F;
        ///<summary>ARB_draw_buffers</summary>
        public const int DRAW_BUFFER11_ARB = 0x8830;
        ///<summary>ARB_draw_buffers</summary>
        public const int DRAW_BUFFER12_ARB = 0x8831;
        ///<summary>ARB_draw_buffers</summary>
        public const int DRAW_BUFFER13_ARB = 0x8832;
        ///<summary>ARB_draw_buffers</summary>
        public const int DRAW_BUFFER14_ARB = 0x8833;
        ///<summary>ARB_draw_buffers</summary>
        public const int DRAW_BUFFER15_ARB = 0x8834;
        ///<summary>ARB_texture_rectangle</summary>
        public const int TEXTURE_RECTANGLE_ARB = 0x84F5;
        ///<summary>ARB_texture_rectangle</summary>
        public const int TEXTURE_BINDING_RECTANGLE_ARB = 0x84F6;
        ///<summary>ARB_texture_rectangle</summary>
        public const int PROXY_TEXTURE_RECTANGLE_ARB = 0x84F7;
        ///<summary>ARB_texture_rectangle</summary>
        public const int MAX_RECTANGLE_TEXTURE_SIZE_ARB = 0x84F8;
        ///<summary>ARB_color_buffer_float</summary>
        public const int RGBA_FLOAT_MODE_ARB = 0x8820;
        ///<summary>ARB_color_buffer_float</summary>
        public const int CLAMP_VERTEX_COLOR_ARB = 0x891A;
        ///<summary>ARB_color_buffer_float</summary>
        public const int CLAMP_FRAGMENT_COLOR_ARB = 0x891B;
        ///<summary>ARB_color_buffer_float</summary>
        public const int CLAMP_READ_COLOR_ARB = 0x891C;
        ///<summary>ARB_color_buffer_float</summary>
        public const int FIXED_ONLY_ARB = 0x891D;
        ///<summary>ARB_half_float_pixel</summary>
        public const int HALF_FLOAT_ARB = 0x140B;
        ///<summary>ARB_texture_float</summary>
        public const int TEXTURE_RED_TYPE_ARB = 0x8C10;
        ///<summary>ARB_texture_float</summary>
        public const int TEXTURE_GREEN_TYPE_ARB = 0x8C11;
        ///<summary>ARB_texture_float</summary>
        public const int TEXTURE_BLUE_TYPE_ARB = 0x8C12;
        ///<summary>ARB_texture_float</summary>
        public const int TEXTURE_ALPHA_TYPE_ARB = 0x8C13;
        ///<summary>ARB_texture_float</summary>
        public const int TEXTURE_LUMINANCE_TYPE_ARB = 0x8C14;
        ///<summary>ARB_texture_float</summary>
        public const int TEXTURE_INTENSITY_TYPE_ARB = 0x8C15;
        ///<summary>ARB_texture_float</summary>
        public const int TEXTURE_DEPTH_TYPE_ARB = 0x8C16;
        ///<summary>ARB_texture_float</summary>
        public const int UNSIGNED_NORMALIZED_ARB = 0x8C17;
        ///<summary>ARB_texture_float</summary>
        public const int RGBA32F_ARB = 0x8814;
        ///<summary>ARB_texture_float</summary>
        public const int RGB32F_ARB = 0x8815;
        ///<summary>ARB_texture_float</summary>
        public const int ALPHA32F_ARB = 0x8816;
        ///<summary>ARB_texture_float</summary>
        public const int INTENSITY32F_ARB = 0x8817;
        ///<summary>ARB_texture_float</summary>
        public const int LUMINANCE32F_ARB = 0x8818;
        ///<summary>ARB_texture_float</summary>
        public const int LUMINANCE_ALPHA32F_ARB = 0x8819;
        ///<summary>ARB_texture_float</summary>
        public const int RGBA16F_ARB = 0x881A;
        ///<summary>ARB_texture_float</summary>
        public const int RGB16F_ARB = 0x881B;
        ///<summary>ARB_texture_float</summary>
        public const int ALPHA16F_ARB = 0x881C;
        ///<summary>ARB_texture_float</summary>
        public const int INTENSITY16F_ARB = 0x881D;
        ///<summary>ARB_texture_float</summary>
        public const int LUMINANCE16F_ARB = 0x881E;
        ///<summary>ARB_texture_float</summary>
        public const int LUMINANCE_ALPHA16F_ARB = 0x881F;
        ///<summary>ARB_pixel_buffer_object</summary>
        public const int PIXEL_PACK_BUFFER_ARB = 0x88EB;
        ///<summary>ARB_pixel_buffer_object</summary>
        public const int PIXEL_UNPACK_BUFFER_ARB = 0x88EC;
        ///<summary>ARB_pixel_buffer_object</summary>
        public const int PIXEL_PACK_BUFFER_BINDING_ARB = 0x88ED;
        ///<summary>ARB_pixel_buffer_object</summary>
        public const int PIXEL_UNPACK_BUFFER_BINDING_ARB = 0x88EF;
        ///<summary>ARB_depth_buffer_float</summary>
        public const int DEPTH_COMPONENT32F = 0x8CAC;
        ///<summary>ARB_depth_buffer_float</summary>
        public const int DEPTH32F_STENCIL8 = 0x8CAD;
        ///<summary>ARB_depth_buffer_float</summary>
        public const int FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
        ///<summary>ARB_framebuffer_object</summary>
        public const int INVALID_FRAMEBUFFER_OPERATION = 0x0506;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_DEFAULT = 0x8218;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_UNDEFINED = 0x8219;
        ///<summary>ARB_framebuffer_object</summary>
        public const int DEPTH_STENCIL_ATTACHMENT = 0x821A;
        ///<summary>ARB_framebuffer_object</summary>
        public const int MAX_RENDERBUFFER_SIZE = 0x84E8;
        ///<summary>ARB_framebuffer_object</summary>
        public const int DEPTH_STENCIL = 0x84F9;
        ///<summary>ARB_framebuffer_object</summary>
        public const int UNSIGNED_INT_24_8 = 0x84FA;
        ///<summary>ARB_framebuffer_object</summary>
        public const int DEPTH24_STENCIL8 = 0x88F0;
        ///<summary>ARB_framebuffer_object</summary>
        public const int TEXTURE_STENCIL_SIZE = 0x88F1;
        ///<summary>ARB_framebuffer_object</summary>
        public const int TEXTURE_RED_TYPE = 0x8C10;
        ///<summary>ARB_framebuffer_object</summary>
        public const int TEXTURE_GREEN_TYPE = 0x8C11;
        ///<summary>ARB_framebuffer_object</summary>
        public const int TEXTURE_BLUE_TYPE = 0x8C12;
        ///<summary>ARB_framebuffer_object</summary>
        public const int TEXTURE_ALPHA_TYPE = 0x8C13;
        ///<summary>ARB_framebuffer_object</summary>
        public const int TEXTURE_DEPTH_TYPE = 0x8C16;
        ///<summary>ARB_framebuffer_object</summary>
        public const int UNSIGNED_NORMALIZED = 0x8C17;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_BINDING = 0x8CA6;
        ///<summary>ARB_framebuffer_object</summary>
        public const int DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
        ///<summary>ARB_framebuffer_object</summary>
        public const int RENDERBUFFER_BINDING = 0x8CA7;
        ///<summary>ARB_framebuffer_object</summary>
        public const int READ_FRAMEBUFFER = 0x8CA8;
        ///<summary>ARB_framebuffer_object</summary>
        public const int DRAW_FRAMEBUFFER = 0x8CA9;
        ///<summary>ARB_framebuffer_object</summary>
        public const int READ_FRAMEBUFFER_BINDING = 0x8CAA;
        ///<summary>ARB_framebuffer_object</summary>
        public const int RENDERBUFFER_SAMPLES = 0x8CAB;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_COMPLETE = 0x8CD5;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
        ///<summary>ARB_framebuffer_object</summary>
        public const int MAX_COLOR_ATTACHMENTS = 0x8CDF;
        ///<summary>ARB_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT0 = 0x8CE0;
        ///<summary>ARB_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT1 = 0x8CE1;
        ///<summary>ARB_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT2 = 0x8CE2;
        ///<summary>ARB_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT3 = 0x8CE3;
        ///<summary>ARB_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT4 = 0x8CE4;
        ///<summary>ARB_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT5 = 0x8CE5;
        ///<summary>ARB_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT6 = 0x8CE6;
        ///<summary>ARB_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT7 = 0x8CE7;
        ///<summary>ARB_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT8 = 0x8CE8;
        ///<summary>ARB_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT9 = 0x8CE9;
        ///<summary>ARB_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT10 = 0x8CEA;
        ///<summary>ARB_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT11 = 0x8CEB;
        ///<summary>ARB_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT12 = 0x8CEC;
        ///<summary>ARB_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT13 = 0x8CED;
        ///<summary>ARB_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT14 = 0x8CEE;
        ///<summary>ARB_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT15 = 0x8CEF;
        ///<summary>ARB_framebuffer_object</summary>
        public const int DEPTH_ATTACHMENT = 0x8D00;
        ///<summary>ARB_framebuffer_object</summary>
        public const int STENCIL_ATTACHMENT = 0x8D20;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER = 0x8D40;
        ///<summary>ARB_framebuffer_object</summary>
        public const int RENDERBUFFER = 0x8D41;
        ///<summary>ARB_framebuffer_object</summary>
        public const int RENDERBUFFER_WIDTH = 0x8D42;
        ///<summary>ARB_framebuffer_object</summary>
        public const int RENDERBUFFER_HEIGHT = 0x8D43;
        ///<summary>ARB_framebuffer_object</summary>
        public const int RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
        ///<summary>ARB_framebuffer_object</summary>
        public const int STENCIL_INDEX1 = 0x8D46;
        ///<summary>ARB_framebuffer_object</summary>
        public const int STENCIL_INDEX4 = 0x8D47;
        ///<summary>ARB_framebuffer_object</summary>
        public const int STENCIL_INDEX8 = 0x8D48;
        ///<summary>ARB_framebuffer_object</summary>
        public const int STENCIL_INDEX16 = 0x8D49;
        ///<summary>ARB_framebuffer_object</summary>
        public const int RENDERBUFFER_RED_SIZE = 0x8D50;
        ///<summary>ARB_framebuffer_object</summary>
        public const int RENDERBUFFER_GREEN_SIZE = 0x8D51;
        ///<summary>ARB_framebuffer_object</summary>
        public const int RENDERBUFFER_BLUE_SIZE = 0x8D52;
        ///<summary>ARB_framebuffer_object</summary>
        public const int RENDERBUFFER_ALPHA_SIZE = 0x8D53;
        ///<summary>ARB_framebuffer_object</summary>
        public const int RENDERBUFFER_DEPTH_SIZE = 0x8D54;
        ///<summary>ARB_framebuffer_object</summary>
        public const int RENDERBUFFER_STENCIL_SIZE = 0x8D55;
        ///<summary>ARB_framebuffer_object</summary>
        public const int FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
        ///<summary>ARB_framebuffer_object</summary>
        public const int MAX_SAMPLES = 0x8D57;
        ///<summary>ARB_framebuffer_object_DEPRECATED</summary>
        public const int INDEX = 0x8222;
        ///<summary>ARB_framebuffer_object_DEPRECATED</summary>
        public const int TEXTURE_LUMINANCE_TYPE = 0x8C14;
        ///<summary>ARB_framebuffer_object_DEPRECATED</summary>
        public const int TEXTURE_INTENSITY_TYPE = 0x8C15;
        ///<summary>ARB_framebuffer_sRGB</summary>
        public const int FRAMEBUFFER_SRGB = 0x8DB9;
        ///<summary>ARB_geometry_shader4</summary>
        public const int LINES_ADJACENCY_ARB = 0x000A;
        ///<summary>ARB_geometry_shader4</summary>
        public const int LINE_STRIP_ADJACENCY_ARB = 0x000B;
        ///<summary>ARB_geometry_shader4</summary>
        public const int TRIANGLES_ADJACENCY_ARB = 0x000C;
        ///<summary>ARB_geometry_shader4</summary>
        public const int TRIANGLE_STRIP_ADJACENCY_ARB = 0x000D;
        ///<summary>ARB_geometry_shader4</summary>
        public const int PROGRAM_POINT_SIZE_ARB = 0x8642;
        ///<summary>ARB_geometry_shader4</summary>
        public const int MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB = 0x8C29;
        ///<summary>ARB_geometry_shader4</summary>
        public const int FRAMEBUFFER_ATTACHMENT_LAYERED_ARB = 0x8DA7;
        ///<summary>ARB_geometry_shader4</summary>
        public const int FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB = 0x8DA8;
        ///<summary>ARB_geometry_shader4</summary>
        public const int FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB = 0x8DA9;
        ///<summary>ARB_geometry_shader4</summary>
        public const int GEOMETRY_SHADER_ARB = 0x8DD9;
        ///<summary>ARB_geometry_shader4</summary>
        public const int GEOMETRY_VERTICES_OUT_ARB = 0x8DDA;
        ///<summary>ARB_geometry_shader4</summary>
        public const int GEOMETRY_INPUT_TYPE_ARB = 0x8DDB;
        ///<summary>ARB_geometry_shader4</summary>
        public const int GEOMETRY_OUTPUT_TYPE_ARB = 0x8DDC;
        ///<summary>ARB_geometry_shader4</summary>
        public const int MAX_GEOMETRY_VARYING_COMPONENTS_ARB = 0x8DDD;
        ///<summary>ARB_geometry_shader4</summary>
        public const int MAX_VERTEX_VARYING_COMPONENTS_ARB = 0x8DDE;
        ///<summary>ARB_geometry_shader4</summary>
        public const int MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB = 0x8DDF;
        ///<summary>ARB_geometry_shader4</summary>
        public const int MAX_GEOMETRY_OUTPUT_VERTICES_ARB = 0x8DE0;
        ///<summary>ARB_geometry_shader4</summary>
        public const int MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB = 0x8DE1;
        ///<summary>ARB_half_float_vertex</summary>
        public const int HALF_FLOAT = 0x140B;
        ///<summary>ARB_instanced_arrays</summary>
        public const int VERTEX_ATTRIB_ARRAY_DIVISOR_ARB = 0x88FE;
        ///<summary>ARB_map_buffer_range</summary>
        public const int MAP_READ_BIT = 0x0001;
        ///<summary>ARB_map_buffer_range</summary>
        public const int MAP_WRITE_BIT = 0x0002;
        ///<summary>ARB_map_buffer_range</summary>
        public const int MAP_INVALIDATE_RANGE_BIT = 0x0004;
        ///<summary>ARB_map_buffer_range</summary>
        public const int MAP_INVALIDATE_BUFFER_BIT = 0x0008;
        ///<summary>ARB_map_buffer_range</summary>
        public const int MAP_FLUSH_EXPLICIT_BIT = 0x0010;
        ///<summary>ARB_map_buffer_range</summary>
        public const int MAP_UNSYNCHRONIZED_BIT = 0x0020;
        ///<summary>ARB_texture_buffer_object</summary>
        public const int TEXTURE_BUFFER_ARB = 0x8C2A;
        ///<summary>ARB_texture_buffer_object</summary>
        public const int MAX_TEXTURE_BUFFER_SIZE_ARB = 0x8C2B;
        ///<summary>ARB_texture_buffer_object</summary>
        public const int TEXTURE_BINDING_BUFFER_ARB = 0x8C2C;
        ///<summary>ARB_texture_buffer_object</summary>
        public const int TEXTURE_BUFFER_DATA_STORE_BINDING_ARB = 0x8C2D;
        ///<summary>ARB_texture_buffer_object</summary>
        public const int TEXTURE_BUFFER_FORMAT_ARB = 0x8C2E;
        ///<summary>ARB_texture_compression_rgtc</summary>
        public const int COMPRESSED_RED_RGTC1 = 0x8DBB;
        ///<summary>ARB_texture_compression_rgtc</summary>
        public const int COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;
        ///<summary>ARB_texture_compression_rgtc</summary>
        public const int COMPRESSED_RG_RGTC2 = 0x8DBD;
        ///<summary>ARB_texture_compression_rgtc</summary>
        public const int COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;
        ///<summary>ARB_texture_rg</summary>
        public const int RG = 0x8227;
        ///<summary>ARB_texture_rg</summary>
        public const int RG_INTEGER = 0x8228;
        ///<summary>ARB_texture_rg</summary>
        public const int R8 = 0x8229;
        ///<summary>ARB_texture_rg</summary>
        public const int R16 = 0x822A;
        ///<summary>ARB_texture_rg</summary>
        public const int RG8 = 0x822B;
        ///<summary>ARB_texture_rg</summary>
        public const int RG16 = 0x822C;
        ///<summary>ARB_texture_rg</summary>
        public const int R16F = 0x822D;
        ///<summary>ARB_texture_rg</summary>
        public const int R32F = 0x822E;
        ///<summary>ARB_texture_rg</summary>
        public const int RG16F = 0x822F;
        ///<summary>ARB_texture_rg</summary>
        public const int RG32F = 0x8230;
        ///<summary>ARB_texture_rg</summary>
        public const int R8I = 0x8231;
        ///<summary>ARB_texture_rg</summary>
        public const int R8UI = 0x8232;
        ///<summary>ARB_texture_rg</summary>
        public const int R16I = 0x8233;
        ///<summary>ARB_texture_rg</summary>
        public const int R16UI = 0x8234;
        ///<summary>ARB_texture_rg</summary>
        public const int R32I = 0x8235;
        ///<summary>ARB_texture_rg</summary>
        public const int R32UI = 0x8236;
        ///<summary>ARB_texture_rg</summary>
        public const int RG8I = 0x8237;
        ///<summary>ARB_texture_rg</summary>
        public const int RG8UI = 0x8238;
        ///<summary>ARB_texture_rg</summary>
        public const int RG16I = 0x8239;
        ///<summary>ARB_texture_rg</summary>
        public const int RG16UI = 0x823A;
        ///<summary>ARB_texture_rg</summary>
        public const int RG32I = 0x823B;
        ///<summary>ARB_texture_rg</summary>
        public const int RG32UI = 0x823C;
        ///<summary>ARB_vertex_array_object</summary>
        public const int VERTEX_ARRAY_BINDING = 0x85B5;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_BUFFER = 0x8A11;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_BUFFER_BINDING = 0x8A28;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_BUFFER_START = 0x8A29;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_BUFFER_SIZE = 0x8A2A;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int ACTIVE_UNIFORM_BLOCKS = 0x8A36;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_TYPE = 0x8A37;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_SIZE = 0x8A38;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_NAME_LENGTH = 0x8A39;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_BLOCK_INDEX = 0x8A3A;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_OFFSET = 0x8A3B;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_ARRAY_STRIDE = 0x8A3C;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_MATRIX_STRIDE = 0x8A3D;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_IS_ROW_MAJOR = 0x8A3E;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_BLOCK_BINDING = 0x8A3F;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const int UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
        ///<summary>ARB_uniform_buffer_object</summary>
        public const uint INVALID_INDEX = 0xFFFFFFFFu;
        ///<summary>ARB_copy_buffer</summary>
        public const int COPY_READ_BUFFER_BINDING = 0x8F36;
        ///<summary>ARB_copy_buffer</summary>
        public const int COPY_READ_BUFFER = 0x8F36;
        ///<summary>ARB_copy_buffer</summary>
        public const int COPY_WRITE_BUFFER_BINDING = 0x8F37;
        ///<summary>ARB_copy_buffer</summary>
        public const int COPY_WRITE_BUFFER = 0x8F37;
        ///<summary>ARB_depth_clamp</summary>
        public const int DEPTH_CLAMP = 0x864F;
        ///<summary>ARB_provoking_vertex</summary>
        public const int QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;
        ///<summary>ARB_provoking_vertex</summary>
        public const int FIRST_VERTEX_CONVENTION = 0x8E4D;
        ///<summary>ARB_provoking_vertex</summary>
        public const int LAST_VERTEX_CONVENTION = 0x8E4E;
        ///<summary>ARB_provoking_vertex</summary>
        public const int PROVOKING_VERTEX = 0x8E4F;
        ///<summary>ARB_seamless_cube_map</summary>
        public const int TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;
        ///<summary>ARB_sync</summary>
        public const int MAX_SERVER_WAIT_TIMEOUT = 0x9111;
        ///<summary>ARB_sync</summary>
        public const int OBJECT_TYPE = 0x9112;
        ///<summary>ARB_sync</summary>
        public const int SYNC_CONDITION = 0x9113;
        ///<summary>ARB_sync</summary>
        public const int SYNC_STATUS = 0x9114;
        ///<summary>ARB_sync</summary>
        public const int SYNC_FLAGS = 0x9115;
        ///<summary>ARB_sync</summary>
        public const int SYNC_FENCE = 0x9116;
        ///<summary>ARB_sync</summary>
        public const int SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
        ///<summary>ARB_sync</summary>
        public const int UNSIGNALED = 0x9118;
        ///<summary>ARB_sync</summary>
        public const int SIGNALED = 0x9119;
        ///<summary>ARB_sync</summary>
        public const int ALREADY_SIGNALED = 0x911A;
        ///<summary>ARB_sync</summary>
        public const int TIMEOUT_EXPIRED = 0x911B;
        ///<summary>ARB_sync</summary>
        public const int CONDITION_SATISFIED = 0x911C;
        ///<summary>ARB_sync</summary>
        public const int WAIT_FAILED = 0x911D;
        ///<summary>ARB_sync</summary>
        public const int SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
        ///<summary>ARB_sync</summary>
        public const ulong TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFFul;
        ///<summary>ARB_texture_multisample</summary>
        public const int SAMPLE_POSITION = 0x8E50;
        ///<summary>ARB_texture_multisample</summary>
        public const int SAMPLE_MASK = 0x8E51;
        ///<summary>ARB_texture_multisample</summary>
        public const int SAMPLE_MASK_VALUE = 0x8E52;
        ///<summary>ARB_texture_multisample</summary>
        public const int MAX_SAMPLE_MASK_WORDS = 0x8E59;
        ///<summary>ARB_texture_multisample</summary>
        public const int TEXTURE_2D_MULTISAMPLE = 0x9100;
        ///<summary>ARB_texture_multisample</summary>
        public const int PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;
        ///<summary>ARB_texture_multisample</summary>
        public const int TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
        ///<summary>ARB_texture_multisample</summary>
        public const int PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;
        ///<summary>ARB_texture_multisample</summary>
        public const int TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
        ///<summary>ARB_texture_multisample</summary>
        public const int TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
        ///<summary>ARB_texture_multisample</summary>
        public const int TEXTURE_SAMPLES = 0x9106;
        ///<summary>ARB_texture_multisample</summary>
        public const int TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
        ///<summary>ARB_texture_multisample</summary>
        public const int SAMPLER_2D_MULTISAMPLE = 0x9108;
        ///<summary>ARB_texture_multisample</summary>
        public const int INT_SAMPLER_2D_MULTISAMPLE = 0x9109;
        ///<summary>ARB_texture_multisample</summary>
        public const int UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;
        ///<summary>ARB_texture_multisample</summary>
        public const int SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;
        ///<summary>ARB_texture_multisample</summary>
        public const int INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
        ///<summary>ARB_texture_multisample</summary>
        public const int UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;
        ///<summary>ARB_texture_multisample</summary>
        public const int MAX_COLOR_TEXTURE_SAMPLES = 0x910E;
        ///<summary>ARB_texture_multisample</summary>
        public const int MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;
        ///<summary>ARB_texture_multisample</summary>
        public const int MAX_INTEGER_SAMPLES = 0x9110;
        ///<summary>ARB_sample_shading</summary>
        public const int SAMPLE_SHADING_ARB = 0x8C36;
        ///<summary>ARB_sample_shading</summary>
        public const int MIN_SAMPLE_SHADING_VALUE_ARB = 0x8C37;
        ///<summary>ARB_texture_cube_map_array</summary>
        public const int TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009;
        ///<summary>ARB_texture_cube_map_array</summary>
        public const int TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB = 0x900A;
        ///<summary>ARB_texture_cube_map_array</summary>
        public const int PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B;
        ///<summary>ARB_texture_cube_map_array</summary>
        public const int SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900C;
        ///<summary>ARB_texture_cube_map_array</summary>
        public const int SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB = 0x900D;
        ///<summary>ARB_texture_cube_map_array</summary>
        public const int INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900E;
        ///<summary>ARB_texture_cube_map_array</summary>
        public const int UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900F;
        ///<summary>ARB_texture_gather</summary>
        public const int MIN_PROGRAM_TEXTURE_GATHER_OFFSET_ARB = 0x8E5E;
        ///<summary>ARB_texture_gather</summary>
        public const int MAX_PROGRAM_TEXTURE_GATHER_OFFSET_ARB = 0x8E5F;
        ///<summary>ARB_shading_language_include</summary>
        public const int SHADER_INCLUDE_ARB = 0x8DAE;
        ///<summary>ARB_shading_language_include</summary>
        public const int NAMED_STRING_LENGTH_ARB = 0x8DE9;
        ///<summary>ARB_shading_language_include</summary>
        public const int NAMED_STRING_TYPE_ARB = 0x8DEA;
        ///<summary>ARB_texture_compression_bptc</summary>
        public const int COMPRESSED_RGBA_BPTC_UNORM_ARB = 0x8E8C;
        ///<summary>ARB_texture_compression_bptc</summary>
        public const int COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB = 0x8E8D;
        ///<summary>ARB_texture_compression_bptc</summary>
        public const int COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB = 0x8E8E;
        ///<summary>ARB_texture_compression_bptc</summary>
        public const int COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB = 0x8E8F;
        ///<summary>ARB_blend_func_extended</summary>
        public const int SRC1_COLOR = 0x88F9;
        ///<summary>ARB_blend_func_extended</summary>
        public const int ONE_MINUS_SRC1_COLOR = 0x88FA;
        ///<summary>ARB_blend_func_extended</summary>
        public const int ONE_MINUS_SRC1_ALPHA = 0x88FB;
        ///<summary>ARB_blend_func_extended</summary>
        public const int MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;
        ///<summary>ARB_occlusion_query2</summary>
        public const int ANY_SAMPLES_PASSED = 0x8C2F;
        ///<summary>ARB_sampler_objects</summary>
        public const int SAMPLER_BINDING = 0x8919;
        ///<summary>ARB_texture_rgb10_a2ui</summary>
        public const int RGB10_A2UI = 0x906F;
        ///<summary>ARB_texture_swizzle</summary>
        public const int TEXTURE_SWIZZLE_R = 0x8E42;
        ///<summary>ARB_texture_swizzle</summary>
        public const int TEXTURE_SWIZZLE_G = 0x8E43;
        ///<summary>ARB_texture_swizzle</summary>
        public const int TEXTURE_SWIZZLE_B = 0x8E44;
        ///<summary>ARB_texture_swizzle</summary>
        public const int TEXTURE_SWIZZLE_A = 0x8E45;
        ///<summary>ARB_texture_swizzle</summary>
        public const int TEXTURE_SWIZZLE_RGBA = 0x8E46;
        ///<summary>ARB_timer_query</summary>
        public const int TIME_ELAPSED = 0x88BF;
        ///<summary>ARB_timer_query</summary>
        public const int TIMESTAMP = 0x8E28;
        ///<summary>ARB_vertex_type_2_10_10_10_rev</summary>
        public const int INT_2_10_10_10_REV = 0x8D9F;
        ///<summary>ARB_draw_indirect</summary>
        public const int DRAW_INDIRECT_BUFFER = 0x8F3F;
        ///<summary>ARB_draw_indirect</summary>
        public const int DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
        ///<summary>ARB_gpu_shader5</summary>
        public const int GEOMETRY_SHADER_INVOCATIONS = 0x887F;
        ///<summary>ARB_gpu_shader5</summary>
        public const int MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;
        ///<summary>ARB_gpu_shader5</summary>
        public const int MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;
        ///<summary>ARB_gpu_shader5</summary>
        public const int MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;
        ///<summary>ARB_gpu_shader5</summary>
        public const int FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;
        ///<summary>ARB_gpu_shader_fp64</summary>
        public const int DOUBLE_VEC2 = 0x8FFC;
        ///<summary>ARB_gpu_shader_fp64</summary>
        public const int DOUBLE_VEC3 = 0x8FFD;
        ///<summary>ARB_gpu_shader_fp64</summary>
        public const int DOUBLE_VEC4 = 0x8FFE;
        ///<summary>ARB_gpu_shader_fp64</summary>
        public const int DOUBLE_MAT2 = 0x8F46;
        ///<summary>ARB_gpu_shader_fp64</summary>
        public const int DOUBLE_MAT3 = 0x8F47;
        ///<summary>ARB_gpu_shader_fp64</summary>
        public const int DOUBLE_MAT4 = 0x8F48;
        ///<summary>ARB_gpu_shader_fp64</summary>
        public const int DOUBLE_MAT2x3 = 0x8F49;
        ///<summary>ARB_gpu_shader_fp64</summary>
        public const int DOUBLE_MAT2x4 = 0x8F4A;
        ///<summary>ARB_gpu_shader_fp64</summary>
        public const int DOUBLE_MAT3x2 = 0x8F4B;
        ///<summary>ARB_gpu_shader_fp64</summary>
        public const int DOUBLE_MAT3x4 = 0x8F4C;
        ///<summary>ARB_gpu_shader_fp64</summary>
        public const int DOUBLE_MAT4x2 = 0x8F4D;
        ///<summary>ARB_gpu_shader_fp64</summary>
        public const int DOUBLE_MAT4x3 = 0x8F4E;
        ///<summary>ARB_shader_subroutine</summary>
        public const int ACTIVE_SUBROUTINES = 0x8DE5;
        ///<summary>ARB_shader_subroutine</summary>
        public const int ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6;
        ///<summary>ARB_shader_subroutine</summary>
        public const int ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47;
        ///<summary>ARB_shader_subroutine</summary>
        public const int ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48;
        ///<summary>ARB_shader_subroutine</summary>
        public const int ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;
        ///<summary>ARB_shader_subroutine</summary>
        public const int MAX_SUBROUTINES = 0x8DE7;
        ///<summary>ARB_shader_subroutine</summary>
        public const int MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;
        ///<summary>ARB_shader_subroutine</summary>
        public const int NUM_COMPATIBLE_SUBROUTINES = 0x8E4A;
        ///<summary>ARB_shader_subroutine</summary>
        public const int COMPATIBLE_SUBROUTINES = 0x8E4B;
        ///<summary>ARB_tessellation_shader</summary>
        public const int PATCHES = 0x000E;
        ///<summary>ARB_tessellation_shader</summary>
        public const int PATCH_VERTICES = 0x8E72;
        ///<summary>ARB_tessellation_shader</summary>
        public const int PATCH_DEFAULT_INNER_LEVEL = 0x8E73;
        ///<summary>ARB_tessellation_shader</summary>
        public const int PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;
        ///<summary>ARB_tessellation_shader</summary>
        public const int TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;
        ///<summary>ARB_tessellation_shader</summary>
        public const int TESS_GEN_MODE = 0x8E76;
        ///<summary>ARB_tessellation_shader</summary>
        public const int TESS_GEN_SPACING = 0x8E77;
        ///<summary>ARB_tessellation_shader</summary>
        public const int TESS_GEN_VERTEX_ORDER = 0x8E78;
        ///<summary>ARB_tessellation_shader</summary>
        public const int TESS_GEN_POINT_MODE = 0x8E79;
        ///<summary>ARB_tessellation_shader</summary>
        public const int ISOLINES = 0x8E7A;
        ///<summary>ARB_tessellation_shader</summary>
        public const int FRACTIONAL_ODD = 0x8E7B;
        ///<summary>ARB_tessellation_shader</summary>
        public const int FRACTIONAL_EVEN = 0x8E7C;
        ///<summary>ARB_tessellation_shader</summary>
        public const int MAX_PATCH_VERTICES = 0x8E7D;
        ///<summary>ARB_tessellation_shader</summary>
        public const int MAX_TESS_GEN_LEVEL = 0x8E7E;
        ///<summary>ARB_tessellation_shader</summary>
        public const int MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;
        ///<summary>ARB_tessellation_shader</summary>
        public const int MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;
        ///<summary>ARB_tessellation_shader</summary>
        public const int MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;
        ///<summary>ARB_tessellation_shader</summary>
        public const int MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;
        ///<summary>ARB_tessellation_shader</summary>
        public const int MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;
        ///<summary>ARB_tessellation_shader</summary>
        public const int MAX_TESS_PATCH_COMPONENTS = 0x8E84;
        ///<summary>ARB_tessellation_shader</summary>
        public const int MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;
        ///<summary>ARB_tessellation_shader</summary>
        public const int MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;
        ///<summary>ARB_tessellation_shader</summary>
        public const int MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;
        ///<summary>ARB_tessellation_shader</summary>
        public const int MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;
        ///<summary>ARB_tessellation_shader</summary>
        public const int MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;
        ///<summary>ARB_tessellation_shader</summary>
        public const int MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;
        ///<summary>ARB_tessellation_shader</summary>
        public const int MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;
        ///<summary>ARB_tessellation_shader</summary>
        public const int MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;
        ///<summary>ARB_tessellation_shader</summary>
        public const int UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0;
        ///<summary>ARB_tessellation_shader</summary>
        public const int UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;
        ///<summary>ARB_tessellation_shader</summary>
        public const int TESS_EVALUATION_SHADER = 0x8E87;
        ///<summary>ARB_tessellation_shader</summary>
        public const int TESS_CONTROL_SHADER = 0x8E88;
        ///<summary>ARB_transform_feedback2</summary>
        public const int TRANSFORM_FEEDBACK = 0x8E22;
        ///<summary>ARB_transform_feedback2</summary>
        public const int TRANSFORM_FEEDBACK_PAUSED = 0x8E23;
        ///<summary>ARB_transform_feedback2</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
        ///<summary>ARB_transform_feedback2</summary>
        public const int TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;
        ///<summary>ARB_transform_feedback2</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;
        ///<summary>ARB_transform_feedback2</summary>
        public const int TRANSFORM_FEEDBACK_BINDING = 0x8E25;
        ///<summary>ARB_transform_feedback3</summary>
        public const int MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;
        ///<summary>ARB_transform_feedback3</summary>
        public const int MAX_VERTEX_STREAMS = 0x8E71;
        ///<summary>ARB_ES2_compatibility</summary>
        public const int FIXED = 0x140C;
        ///<summary>ARB_ES2_compatibility</summary>
        public const int IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
        ///<summary>ARB_ES2_compatibility</summary>
        public const int IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
        ///<summary>ARB_ES2_compatibility</summary>
        public const int LOW_FLOAT = 0x8DF0;
        ///<summary>ARB_ES2_compatibility</summary>
        public const int MEDIUM_FLOAT = 0x8DF1;
        ///<summary>ARB_ES2_compatibility</summary>
        public const int HIGH_FLOAT = 0x8DF2;
        ///<summary>ARB_ES2_compatibility</summary>
        public const int LOW_INT = 0x8DF3;
        ///<summary>ARB_ES2_compatibility</summary>
        public const int MEDIUM_INT = 0x8DF4;
        ///<summary>ARB_ES2_compatibility</summary>
        public const int HIGH_INT = 0x8DF5;
        ///<summary>ARB_ES2_compatibility</summary>
        public const int SHADER_COMPILER = 0x8DFA;
        ///<summary>ARB_ES2_compatibility</summary>
        public const int NUM_SHADER_BINARY_FORMATS = 0x8DF9;
        ///<summary>ARB_ES2_compatibility</summary>
        public const int MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
        ///<summary>ARB_ES2_compatibility</summary>
        public const int MAX_VARYING_VECTORS = 0x8DFC;
        ///<summary>ARB_ES2_compatibility</summary>
        public const int MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
        ///<summary>ARB_ES2_compatibility</summary>
        public const int RGB565 = 0x8D62;
        ///<summary>ARB_get_program_binary</summary>
        public const int PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
        ///<summary>ARB_get_program_binary</summary>
        public const int PROGRAM_BINARY_LENGTH = 0x8741;
        ///<summary>ARB_get_program_binary</summary>
        public const int NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
        ///<summary>ARB_get_program_binary</summary>
        public const int PROGRAM_BINARY_FORMATS = 0x87FF;
        ///<summary>ARB_separate_shader_objects</summary>
        public const int VERTEX_SHADER_BIT = 0x00000001;
        ///<summary>ARB_separate_shader_objects</summary>
        public const int FRAGMENT_SHADER_BIT = 0x00000002;
        ///<summary>ARB_separate_shader_objects</summary>
        public const int GEOMETRY_SHADER_BIT = 0x00000004;
        ///<summary>ARB_separate_shader_objects</summary>
        public const int TESS_CONTROL_SHADER_BIT = 0x00000008;
        ///<summary>ARB_separate_shader_objects</summary>
        public const int TESS_EVALUATION_SHADER_BIT = 0x00000010;
        ///<summary>ARB_separate_shader_objects</summary>
        public const int ALL_SHADER_BITS = unchecked((int)0xFFFFFFFF);
        ///<summary>ARB_separate_shader_objects</summary>
        public const int PROGRAM_SEPARABLE = 0x8258;
        ///<summary>ARB_separate_shader_objects</summary>
        public const int ACTIVE_PROGRAM = 0x8259;
        ///<summary>ARB_separate_shader_objects</summary>
        public const int PROGRAM_PIPELINE_BINDING = 0x825A;
        ///<summary>ARB_viewport_array</summary>
        public const int MAX_VIEWPORTS = 0x825B;
        ///<summary>ARB_viewport_array</summary>
        public const int VIEWPORT_SUBPIXEL_BITS = 0x825C;
        ///<summary>ARB_viewport_array</summary>
        public const int VIEWPORT_BOUNDS_RANGE = 0x825D;
        ///<summary>ARB_viewport_array</summary>
        public const int LAYER_PROVOKING_VERTEX = 0x825E;
        ///<summary>ARB_viewport_array</summary>
        public const int VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;
        ///<summary>ARB_viewport_array</summary>
        public const int UNDEFINED_VERTEX = 0x8260;
        ///<summary>ARB_cl_event</summary>
        public const int SYNC_CL_EVENT_ARB = 0x8240;
        ///<summary>ARB_cl_event</summary>
        public const int SYNC_CL_EVENT_COMPLETE_ARB = 0x8241;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_OUTPUT_SYNCHRONOUS_ARB = 0x8242;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_ARB = 0x8243;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_CALLBACK_FUNCTION_ARB = 0x8244;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_CALLBACK_USER_PARAM_ARB = 0x8245;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_SOURCE_API_ARB = 0x8246;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_SOURCE_WINDOW_SYSTEM_ARB = 0x8247;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_SOURCE_SHADER_COMPILER_ARB = 0x8248;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_SOURCE_THIRD_PARTY_ARB = 0x8249;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_SOURCE_APPLICATION_ARB = 0x824A;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_SOURCE_OTHER_ARB = 0x824B;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_TYPE_ERROR_ARB = 0x824C;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB = 0x824D;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB = 0x824E;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_TYPE_PORTABILITY_ARB = 0x824F;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_TYPE_PERFORMANCE_ARB = 0x8250;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_TYPE_OTHER_ARB = 0x8251;
        ///<summary>ARB_debug_output</summary>
        public const int MAX_DEBUG_MESSAGE_LENGTH_ARB = 0x9143;
        ///<summary>ARB_debug_output</summary>
        public const int MAX_DEBUG_LOGGED_MESSAGES_ARB = 0x9144;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_LOGGED_MESSAGES_ARB = 0x9145;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_SEVERITY_HIGH_ARB = 0x9146;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_SEVERITY_MEDIUM_ARB = 0x9147;
        ///<summary>ARB_debug_output</summary>
        public const int DEBUG_SEVERITY_LOW_ARB = 0x9148;
        ///<summary>ARB_robustness</summary>
        public const int CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x00000004;
        ///<summary>ARB_robustness</summary>
        public const int LOSE_CONTEXT_ON_RESET_ARB = 0x8252;
        ///<summary>ARB_robustness</summary>
        public const int GUILTY_CONTEXT_RESET_ARB = 0x8253;
        ///<summary>ARB_robustness</summary>
        public const int INNOCENT_CONTEXT_RESET_ARB = 0x8254;
        ///<summary>ARB_robustness</summary>
        public const int UNKNOWN_CONTEXT_RESET_ARB = 0x8255;
        ///<summary>ARB_robustness</summary>
        public const int RESET_NOTIFICATION_STRATEGY_ARB = 0x8256;
        ///<summary>ARB_robustness</summary>
        public const int NO_RESET_NOTIFICATION_ARB = 0x8261;
        ///<summary>ARB_compressed_texture_pixel_storage</summary>
        public const int UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127;
        ///<summary>ARB_compressed_texture_pixel_storage</summary>
        public const int UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;
        ///<summary>ARB_compressed_texture_pixel_storage</summary>
        public const int UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129;
        ///<summary>ARB_compressed_texture_pixel_storage</summary>
        public const int UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A;
        ///<summary>ARB_compressed_texture_pixel_storage</summary>
        public const int PACK_COMPRESSED_BLOCK_WIDTH = 0x912B;
        ///<summary>ARB_compressed_texture_pixel_storage</summary>
        public const int PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C;
        ///<summary>ARB_compressed_texture_pixel_storage</summary>
        public const int PACK_COMPRESSED_BLOCK_DEPTH = 0x912D;
        ///<summary>ARB_compressed_texture_pixel_storage</summary>
        public const int PACK_COMPRESSED_BLOCK_SIZE = 0x912E;
        ///<summary>ARB_internalformat_query</summary>
        public const int NUM_SAMPLE_COUNTS = 0x9380;
        ///<summary>ARB_map_buffer_alignment</summary>
        public const int MIN_MAP_BUFFER_ALIGNMENT = 0x90BC;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int ATOMIC_COUNTER_BUFFER = 0x92C0;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int ATOMIC_COUNTER_BUFFER_START = 0x92C2;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;
        ///<summary>ARB_shader_atomic_counters</summary>
        public const int UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int ELEMENT_ARRAY_BARRIER_BIT = 0x00000002;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int UNIFORM_BARRIER_BIT = 0x00000004;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int TEXTURE_FETCH_BARRIER_BIT = 0x00000008;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int COMMAND_BARRIER_BIT = 0x00000040;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int PIXEL_BUFFER_BARRIER_BIT = 0x00000080;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int TEXTURE_UPDATE_BARRIER_BIT = 0x00000100;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int BUFFER_UPDATE_BARRIER_BIT = 0x00000200;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int FRAMEBUFFER_BARRIER_BIT = 0x00000400;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int ATOMIC_COUNTER_BARRIER_BIT = 0x00001000;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int ALL_BARRIER_BITS = unchecked((int)0xFFFFFFFF);
        ///<summary>ARB_shader_image_load_store</summary>
        public const int MAX_IMAGE_UNITS = 0x8F38;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_BINDING_NAME = 0x8F3A;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_BINDING_LEVEL = 0x8F3B;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_BINDING_LAYERED = 0x8F3C;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_BINDING_LAYER = 0x8F3D;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_BINDING_ACCESS = 0x8F3E;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_1D = 0x904C;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_2D = 0x904D;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_3D = 0x904E;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_2D_RECT = 0x904F;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_CUBE = 0x9050;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_BUFFER = 0x9051;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_1D_ARRAY = 0x9052;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_2D_ARRAY = 0x9053;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_CUBE_MAP_ARRAY = 0x9054;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_2D_MULTISAMPLE = 0x9055;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int INT_IMAGE_1D = 0x9057;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int INT_IMAGE_2D = 0x9058;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int INT_IMAGE_3D = 0x9059;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int INT_IMAGE_2D_RECT = 0x905A;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int INT_IMAGE_CUBE = 0x905B;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int INT_IMAGE_BUFFER = 0x905C;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int INT_IMAGE_1D_ARRAY = 0x905D;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int INT_IMAGE_2D_ARRAY = 0x905E;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int INT_IMAGE_2D_MULTISAMPLE = 0x9060;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_1D = 0x9062;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_2D = 0x9063;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_3D = 0x9064;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_2D_RECT = 0x9065;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_CUBE = 0x9066;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_BUFFER = 0x9067;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int MAX_IMAGE_SAMPLES = 0x906D;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_BINDING_FORMAT = 0x906E;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;
        ///<summary>ARB_shader_image_load_store</summary>
        public const int MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;
        ///<summary>ARB_texture_storage</summary>
        public const int TEXTURE_IMMUTABLE_FORMAT = 0x912F;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_RGBA_ASTC_4x4_KHR = 0x93B0;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_RGBA_ASTC_5x4_KHR = 0x93B1;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_RGBA_ASTC_5x5_KHR = 0x93B2;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_RGBA_ASTC_6x5_KHR = 0x93B3;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_RGBA_ASTC_6x6_KHR = 0x93B4;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_RGBA_ASTC_8x5_KHR = 0x93B5;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_RGBA_ASTC_8x6_KHR = 0x93B6;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_RGBA_ASTC_8x8_KHR = 0x93B7;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_RGBA_ASTC_10x5_KHR = 0x93B8;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_RGBA_ASTC_10x6_KHR = 0x93B9;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_RGBA_ASTC_10x8_KHR = 0x93BA;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_RGBA_ASTC_10x10_KHR = 0x93BB;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_RGBA_ASTC_12x10_KHR = 0x93BC;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_RGBA_ASTC_12x12_KHR = 0x93BD;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR = 0x93D0;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR = 0x93D1;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR = 0x93D2;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR = 0x93D3;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR = 0x93D4;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR = 0x93D5;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR = 0x93D6;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR = 0x93D7;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR = 0x93D8;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR = 0x93D9;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR = 0x93DA;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR = 0x93DB;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR = 0x93DC;
        ///<summary>KHR_texture_compression_astc_ldr</summary>
        public const int COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR = 0x93DD;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_CALLBACK_FUNCTION = 0x8244;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_CALLBACK_USER_PARAM = 0x8245;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_SOURCE_API = 0x8246;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_SOURCE_SHADER_COMPILER = 0x8248;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_SOURCE_THIRD_PARTY = 0x8249;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_SOURCE_APPLICATION = 0x824A;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_SOURCE_OTHER = 0x824B;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_TYPE_ERROR = 0x824C;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_TYPE_PORTABILITY = 0x824F;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_TYPE_PERFORMANCE = 0x8250;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_TYPE_OTHER = 0x8251;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_TYPE_MARKER = 0x8268;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_TYPE_PUSH_GROUP = 0x8269;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_TYPE_POP_GROUP = 0x826A;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_SEVERITY_NOTIFICATION = 0x826B;
        ///<summary>KHR_debug</summary>
        public const int MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;
        ///<summary>KHR_debug</summary>
        public const int DEBUG_GROUP_STACK_DEPTH = 0x826D;
        ///<summary>KHR_debug</summary>
        public const int BUFFER = 0x82E0;
        ///<summary>KHR_debug</summary>
        public const int SHADER = 0x82E1;
        ///<summary>KHR_debug</summary>
        public const int PROGRAM = 0x82E2;
        ///<summary>KHR_debug</summary>
        public const int QUERY = 0x82E3;
        ///<summary>KHR_debug</summary>
        public const int PROGRAM_PIPELINE = 0x82E4;
        ///<summary>KHR_debug</summary>
        public const int SAMPLER = 0x82E6;
        ///<summary>KHR_debug</summary>
        public const int DISPLAY_LIST = 0x82E7;
        ///<summary>KHR_debug (DISPLAY_LIST used in compatibility profile only)</summary>
        public const int MAX_LABEL_LENGTH = 0x82E8;
        ///<summary>KHR_debug (DISPLAY_LIST used in compatibility profile only)</summary>
        public const int MAX_DEBUG_MESSAGE_LENGTH = 0x9143;
        ///<summary>KHR_debug (DISPLAY_LIST used in compatibility profile only)</summary>
        public const int MAX_DEBUG_LOGGED_MESSAGES = 0x9144;
        ///<summary>KHR_debug (DISPLAY_LIST used in compatibility profile only)</summary>
        public const int DEBUG_LOGGED_MESSAGES = 0x9145;
        ///<summary>KHR_debug (DISPLAY_LIST used in compatibility profile only)</summary>
        public const int DEBUG_SEVERITY_HIGH = 0x9146;
        ///<summary>KHR_debug (DISPLAY_LIST used in compatibility profile only)</summary>
        public const int DEBUG_SEVERITY_MEDIUM = 0x9147;
        ///<summary>KHR_debug (DISPLAY_LIST used in compatibility profile only)</summary>
        public const int DEBUG_SEVERITY_LOW = 0x9148;
        ///<summary>KHR_debug (DISPLAY_LIST used in compatibility profile only)</summary>
        public const int DEBUG_OUTPUT = 0x92E0;
        ///<summary>KHR_debug (DISPLAY_LIST used in compatibility profile only)</summary>
        public const int CONTEXT_FLAG_DEBUG_BIT = 0x00000002;
        ///<summary>ARB_compute_shader</summary>
        public const int COMPUTE_SHADER = 0x91B9;
        ///<summary>ARB_compute_shader</summary>
        public const int MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;
        ///<summary>ARB_compute_shader</summary>
        public const int MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;
        ///<summary>ARB_compute_shader</summary>
        public const int MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;
        ///<summary>ARB_compute_shader</summary>
        public const int MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
        ///<summary>ARB_compute_shader</summary>
        public const int MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;
        ///<summary>ARB_compute_shader</summary>
        public const int MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;
        ///<summary>ARB_compute_shader</summary>
        public const int MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;
        ///<summary>ARB_compute_shader</summary>
        public const int MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;
        ///<summary>ARB_compute_shader</summary>
        public const int MAX_COMPUTE_LOCAL_INVOCATIONS = 0x90EB;
        ///<summary>ARB_compute_shader</summary>
        public const int MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;
        ///<summary>ARB_compute_shader</summary>
        public const int MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;
        ///<summary>ARB_compute_shader</summary>
        public const int COMPUTE_LOCAL_WORK_SIZE = 0x8267;
        ///<summary>ARB_compute_shader</summary>
        public const int UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;
        ///<summary>ARB_compute_shader</summary>
        public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;
        ///<summary>ARB_compute_shader</summary>
        public const int DISPATCH_INDIRECT_BUFFER = 0x90EE;
        ///<summary>ARB_compute_shader</summary>
        public const int DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;
        ///<summary>ARB_compute_shader</summary>
        public const int COMPUTE_SHADER_BIT = 0x00000020;
        ///<summary>ARB_texture_view</summary>
        public const int TEXTURE_VIEW_MIN_LEVEL = 0x82DB;
        ///<summary>ARB_texture_view</summary>
        public const int TEXTURE_VIEW_NUM_LEVELS = 0x82DC;
        ///<summary>ARB_texture_view</summary>
        public const int TEXTURE_VIEW_MIN_LAYER = 0x82DD;
        ///<summary>ARB_texture_view</summary>
        public const int TEXTURE_VIEW_NUM_LAYERS = 0x82DE;
        ///<summary>ARB_texture_view</summary>
        public const int TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
        ///<summary>ARB_vertex_attrib_binding</summary>
        public const int VERTEX_ATTRIB_BINDING = 0x82D4;
        ///<summary>ARB_vertex_attrib_binding</summary>
        public const int VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;
        ///<summary>ARB_vertex_attrib_binding</summary>
        public const int VERTEX_BINDING_DIVISOR = 0x82D6;
        ///<summary>ARB_vertex_attrib_binding</summary>
        public const int VERTEX_BINDING_OFFSET = 0x82D7;
        ///<summary>ARB_vertex_attrib_binding</summary>
        public const int VERTEX_BINDING_STRIDE = 0x82D8;
        ///<summary>ARB_vertex_attrib_binding</summary>
        public const int MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
        ///<summary>ARB_vertex_attrib_binding</summary>
        public const int MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;
        ///<summary>ARB_ES3_compatibility</summary>
        public const int COMPRESSED_RGB8_ETC2 = 0x9274;
        ///<summary>ARB_ES3_compatibility</summary>
        public const int COMPRESSED_SRGB8_ETC2 = 0x9275;
        ///<summary>ARB_ES3_compatibility</summary>
        public const int COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;
        ///<summary>ARB_ES3_compatibility</summary>
        public const int COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;
        ///<summary>ARB_ES3_compatibility</summary>
        public const int COMPRESSED_RGBA8_ETC2_EAC = 0x9278;
        ///<summary>ARB_ES3_compatibility</summary>
        public const int COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;
        ///<summary>ARB_ES3_compatibility</summary>
        public const int COMPRESSED_R11_EAC = 0x9270;
        ///<summary>ARB_ES3_compatibility</summary>
        public const int COMPRESSED_SIGNED_R11_EAC = 0x9271;
        ///<summary>ARB_ES3_compatibility</summary>
        public const int COMPRESSED_RG11_EAC = 0x9272;
        ///<summary>ARB_ES3_compatibility</summary>
        public const int COMPRESSED_SIGNED_RG11_EAC = 0x9273;
        ///<summary>ARB_ES3_compatibility</summary>
        public const int PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;
        ///<summary>ARB_ES3_compatibility</summary>
        public const int ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;
        ///<summary>ARB_ES3_compatibility</summary>
        public const int MAX_ELEMENT_INDEX = 0x8D6B;
        ///<summary>ARB_explicit_uniform_location</summary>
        public const int MAX_UNIFORM_LOCATIONS = 0x826E;
        ///<summary>ARB_framebuffer_no_attachments</summary>
        public const int FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;
        ///<summary>ARB_framebuffer_no_attachments</summary>
        public const int FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;
        ///<summary>ARB_framebuffer_no_attachments</summary>
        public const int FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;
        ///<summary>ARB_framebuffer_no_attachments</summary>
        public const int FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;
        ///<summary>ARB_framebuffer_no_attachments</summary>
        public const int FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;
        ///<summary>ARB_framebuffer_no_attachments</summary>
        public const int MAX_FRAMEBUFFER_WIDTH = 0x9315;
        ///<summary>ARB_framebuffer_no_attachments</summary>
        public const int MAX_FRAMEBUFFER_HEIGHT = 0x9316;
        ///<summary>ARB_framebuffer_no_attachments</summary>
        public const int MAX_FRAMEBUFFER_LAYERS = 0x9317;
        ///<summary>ARB_framebuffer_no_attachments</summary>
        public const int MAX_FRAMEBUFFER_SAMPLES = 0x9318;
        ///<summary>ARB_internalformat_query2</summary>
        public const int INTERNALFORMAT_SUPPORTED = 0x826F;
        ///<summary>ARB_internalformat_query2</summary>
        public const int INTERNALFORMAT_PREFERRED = 0x8270;
        ///<summary>ARB_internalformat_query2</summary>
        public const int INTERNALFORMAT_RED_SIZE = 0x8271;
        ///<summary>ARB_internalformat_query2</summary>
        public const int INTERNALFORMAT_GREEN_SIZE = 0x8272;
        ///<summary>ARB_internalformat_query2</summary>
        public const int INTERNALFORMAT_BLUE_SIZE = 0x8273;
        ///<summary>ARB_internalformat_query2</summary>
        public const int INTERNALFORMAT_ALPHA_SIZE = 0x8274;
        ///<summary>ARB_internalformat_query2</summary>
        public const int INTERNALFORMAT_DEPTH_SIZE = 0x8275;
        ///<summary>ARB_internalformat_query2</summary>
        public const int INTERNALFORMAT_STENCIL_SIZE = 0x8276;
        ///<summary>ARB_internalformat_query2</summary>
        public const int INTERNALFORMAT_SHARED_SIZE = 0x8277;
        ///<summary>ARB_internalformat_query2</summary>
        public const int INTERNALFORMAT_RED_TYPE = 0x8278;
        ///<summary>ARB_internalformat_query2</summary>
        public const int INTERNALFORMAT_GREEN_TYPE = 0x8279;
        ///<summary>ARB_internalformat_query2</summary>
        public const int INTERNALFORMAT_BLUE_TYPE = 0x827A;
        ///<summary>ARB_internalformat_query2</summary>
        public const int INTERNALFORMAT_ALPHA_TYPE = 0x827B;
        ///<summary>ARB_internalformat_query2</summary>
        public const int INTERNALFORMAT_DEPTH_TYPE = 0x827C;
        ///<summary>ARB_internalformat_query2</summary>
        public const int INTERNALFORMAT_STENCIL_TYPE = 0x827D;
        ///<summary>ARB_internalformat_query2</summary>
        public const int MAX_WIDTH = 0x827E;
        ///<summary>ARB_internalformat_query2</summary>
        public const int MAX_HEIGHT = 0x827F;
        ///<summary>ARB_internalformat_query2</summary>
        public const int MAX_DEPTH = 0x8280;
        ///<summary>ARB_internalformat_query2</summary>
        public const int MAX_LAYERS = 0x8281;
        ///<summary>ARB_internalformat_query2</summary>
        public const int MAX_COMBINED_DIMENSIONS = 0x8282;
        ///<summary>ARB_internalformat_query2</summary>
        public const int COLOR_COMPONENTS = 0x8283;
        ///<summary>ARB_internalformat_query2</summary>
        public const int DEPTH_COMPONENTS = 0x8284;
        ///<summary>ARB_internalformat_query2</summary>
        public const int STENCIL_COMPONENTS = 0x8285;
        ///<summary>ARB_internalformat_query2</summary>
        public const int COLOR_RENDERABLE = 0x8286;
        ///<summary>ARB_internalformat_query2</summary>
        public const int DEPTH_RENDERABLE = 0x8287;
        ///<summary>ARB_internalformat_query2</summary>
        public const int STENCIL_RENDERABLE = 0x8288;
        ///<summary>ARB_internalformat_query2</summary>
        public const int FRAMEBUFFER_RENDERABLE = 0x8289;
        ///<summary>ARB_internalformat_query2</summary>
        public const int FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;
        ///<summary>ARB_internalformat_query2</summary>
        public const int FRAMEBUFFER_BLEND = 0x828B;
        ///<summary>ARB_internalformat_query2</summary>
        public const int READ_PIXELS = 0x828C;
        ///<summary>ARB_internalformat_query2</summary>
        public const int READ_PIXELS_FORMAT = 0x828D;
        ///<summary>ARB_internalformat_query2</summary>
        public const int READ_PIXELS_TYPE = 0x828E;
        ///<summary>ARB_internalformat_query2</summary>
        public const int TEXTURE_IMAGE_FORMAT = 0x828F;
        ///<summary>ARB_internalformat_query2</summary>
        public const int TEXTURE_IMAGE_TYPE = 0x8290;
        ///<summary>ARB_internalformat_query2</summary>
        public const int GET_TEXTURE_IMAGE_FORMAT = 0x8291;
        ///<summary>ARB_internalformat_query2</summary>
        public const int GET_TEXTURE_IMAGE_TYPE = 0x8292;
        ///<summary>ARB_internalformat_query2</summary>
        public const int MIPMAP = 0x8293;
        ///<summary>ARB_internalformat_query2</summary>
        public const int MANUAL_GENERATE_MIPMAP = 0x8294;
        ///<summary>ARB_internalformat_query2</summary>
        public const int AUTO_GENERATE_MIPMAP = 0x8295;
        ///<summary>ARB_internalformat_query2</summary>
        public const int COLOR_ENCODING = 0x8296;
        ///<summary>ARB_internalformat_query2</summary>
        public const int SRGB_READ = 0x8297;
        ///<summary>ARB_internalformat_query2</summary>
        public const int SRGB_WRITE = 0x8298;
        ///<summary>ARB_internalformat_query2</summary>
        public const int SRGB_DECODE_ARB = 0x8299;
        ///<summary>ARB_internalformat_query2</summary>
        public const int FILTER = 0x829A;
        ///<summary>ARB_internalformat_query2</summary>
        public const int VERTEX_TEXTURE = 0x829B;
        ///<summary>ARB_internalformat_query2</summary>
        public const int TESS_CONTROL_TEXTURE = 0x829C;
        ///<summary>ARB_internalformat_query2</summary>
        public const int TESS_EVALUATION_TEXTURE = 0x829D;
        ///<summary>ARB_internalformat_query2</summary>
        public const int GEOMETRY_TEXTURE = 0x829E;
        ///<summary>ARB_internalformat_query2</summary>
        public const int FRAGMENT_TEXTURE = 0x829F;
        ///<summary>ARB_internalformat_query2</summary>
        public const int COMPUTE_TEXTURE = 0x82A0;
        ///<summary>ARB_internalformat_query2</summary>
        public const int TEXTURE_SHADOW = 0x82A1;
        ///<summary>ARB_internalformat_query2</summary>
        public const int TEXTURE_GATHER = 0x82A2;
        ///<summary>ARB_internalformat_query2</summary>
        public const int TEXTURE_GATHER_SHADOW = 0x82A3;
        ///<summary>ARB_internalformat_query2</summary>
        public const int SHADER_IMAGE_LOAD = 0x82A4;
        ///<summary>ARB_internalformat_query2</summary>
        public const int SHADER_IMAGE_STORE = 0x82A5;
        ///<summary>ARB_internalformat_query2</summary>
        public const int SHADER_IMAGE_ATOMIC = 0x82A6;
        ///<summary>ARB_internalformat_query2</summary>
        public const int IMAGE_TEXEL_SIZE = 0x82A7;
        ///<summary>ARB_internalformat_query2</summary>
        public const int IMAGE_COMPATIBILITY_CLASS = 0x82A8;
        ///<summary>ARB_internalformat_query2</summary>
        public const int IMAGE_PIXEL_FORMAT = 0x82A9;
        ///<summary>ARB_internalformat_query2</summary>
        public const int IMAGE_PIXEL_TYPE = 0x82AA;
        ///<summary>ARB_internalformat_query2</summary>
        public const int SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;
        ///<summary>ARB_internalformat_query2</summary>
        public const int SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;
        ///<summary>ARB_internalformat_query2</summary>
        public const int SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;
        ///<summary>ARB_internalformat_query2</summary>
        public const int SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;
        ///<summary>ARB_internalformat_query2</summary>
        public const int TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;
        ///<summary>ARB_internalformat_query2</summary>
        public const int TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;
        ///<summary>ARB_internalformat_query2</summary>
        public const int TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3;
        ///<summary>ARB_internalformat_query2</summary>
        public const int CLEAR_BUFFER = 0x82B4;
        ///<summary>ARB_internalformat_query2</summary>
        public const int TEXTURE_VIEW = 0x82B5;
        ///<summary>ARB_internalformat_query2</summary>
        public const int VIEW_COMPATIBILITY_CLASS = 0x82B6;
        ///<summary>ARB_internalformat_query2</summary>
        public const int FULL_SUPPORT = 0x82B7;
        ///<summary>ARB_internalformat_query2</summary>
        public const int CAVEAT_SUPPORT = 0x82B8;
        ///<summary>ARB_internalformat_query2</summary>
        public const int IMAGE_CLASS_4_X_32 = 0x82B9;
        ///<summary>ARB_internalformat_query2</summary>
        public const int IMAGE_CLASS_2_X_32 = 0x82BA;
        ///<summary>ARB_internalformat_query2</summary>
        public const int IMAGE_CLASS_1_X_32 = 0x82BB;
        ///<summary>ARB_internalformat_query2</summary>
        public const int IMAGE_CLASS_4_X_16 = 0x82BC;
        ///<summary>ARB_internalformat_query2</summary>
        public const int IMAGE_CLASS_2_X_16 = 0x82BD;
        ///<summary>ARB_internalformat_query2</summary>
        public const int IMAGE_CLASS_1_X_16 = 0x82BE;
        ///<summary>ARB_internalformat_query2</summary>
        public const int IMAGE_CLASS_4_X_8 = 0x82BF;
        ///<summary>ARB_internalformat_query2</summary>
        public const int IMAGE_CLASS_2_X_8 = 0x82C0;
        ///<summary>ARB_internalformat_query2</summary>
        public const int IMAGE_CLASS_1_X_8 = 0x82C1;
        ///<summary>ARB_internalformat_query2</summary>
        public const int IMAGE_CLASS_11_11_10 = 0x82C2;
        ///<summary>ARB_internalformat_query2</summary>
        public const int IMAGE_CLASS_10_10_10_2 = 0x82C3;
        ///<summary>ARB_internalformat_query2</summary>
        public const int VIEW_CLASS_128_BITS = 0x82C4;
        ///<summary>ARB_internalformat_query2</summary>
        public const int VIEW_CLASS_96_BITS = 0x82C5;
        ///<summary>ARB_internalformat_query2</summary>
        public const int VIEW_CLASS_64_BITS = 0x82C6;
        ///<summary>ARB_internalformat_query2</summary>
        public const int VIEW_CLASS_48_BITS = 0x82C7;
        ///<summary>ARB_internalformat_query2</summary>
        public const int VIEW_CLASS_32_BITS = 0x82C8;
        ///<summary>ARB_internalformat_query2</summary>
        public const int VIEW_CLASS_24_BITS = 0x82C9;
        ///<summary>ARB_internalformat_query2</summary>
        public const int VIEW_CLASS_16_BITS = 0x82CA;
        ///<summary>ARB_internalformat_query2</summary>
        public const int VIEW_CLASS_8_BITS = 0x82CB;
        ///<summary>ARB_internalformat_query2</summary>
        public const int VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;
        ///<summary>ARB_internalformat_query2</summary>
        public const int VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;
        ///<summary>ARB_internalformat_query2</summary>
        public const int VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;
        ///<summary>ARB_internalformat_query2</summary>
        public const int VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;
        ///<summary>ARB_internalformat_query2</summary>
        public const int VIEW_CLASS_RGTC1_RED = 0x82D0;
        ///<summary>ARB_internalformat_query2</summary>
        public const int VIEW_CLASS_RGTC2_RG = 0x82D1;
        ///<summary>ARB_internalformat_query2</summary>
        public const int VIEW_CLASS_BPTC_UNORM = 0x82D2;
        ///<summary>ARB_internalformat_query2</summary>
        public const int VIEW_CLASS_BPTC_FLOAT = 0x82D3;
        ///<summary>ARB_program_interface_query</summary>
        public const int UNIFORM = 0x92E1;
        ///<summary>ARB_program_interface_query</summary>
        public const int UNIFORM_BLOCK = 0x92E2;
        ///<summary>ARB_program_interface_query</summary>
        public const int PROGRAM_INPUT = 0x92E3;
        ///<summary>ARB_program_interface_query</summary>
        public const int PROGRAM_OUTPUT = 0x92E4;
        ///<summary>ARB_program_interface_query</summary>
        public const int BUFFER_VARIABLE = 0x92E5;
        ///<summary>ARB_program_interface_query</summary>
        public const int SHADER_STORAGE_BLOCK = 0x92E6;
        ///<summary>ARB_program_interface_query</summary>
        public const int VERTEX_SUBROUTINE = 0x92E8;
        ///<summary>ARB_program_interface_query</summary>
        public const int TESS_CONTROL_SUBROUTINE = 0x92E9;
        ///<summary>ARB_program_interface_query</summary>
        public const int TESS_EVALUATION_SUBROUTINE = 0x92EA;
        ///<summary>ARB_program_interface_query</summary>
        public const int GEOMETRY_SUBROUTINE = 0x92EB;
        ///<summary>ARB_program_interface_query</summary>
        public const int FRAGMENT_SUBROUTINE = 0x92EC;
        ///<summary>ARB_program_interface_query</summary>
        public const int COMPUTE_SUBROUTINE = 0x92ED;
        ///<summary>ARB_program_interface_query</summary>
        public const int VERTEX_SUBROUTINE_UNIFORM = 0x92EE;
        ///<summary>ARB_program_interface_query</summary>
        public const int TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;
        ///<summary>ARB_program_interface_query</summary>
        public const int TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0;
        ///<summary>ARB_program_interface_query</summary>
        public const int GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1;
        ///<summary>ARB_program_interface_query</summary>
        public const int FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2;
        ///<summary>ARB_program_interface_query</summary>
        public const int COMPUTE_SUBROUTINE_UNIFORM = 0x92F3;
        ///<summary>ARB_program_interface_query</summary>
        public const int TRANSFORM_FEEDBACK_VARYING = 0x92F4;
        ///<summary>ARB_program_interface_query</summary>
        public const int ACTIVE_RESOURCES = 0x92F5;
        ///<summary>ARB_program_interface_query</summary>
        public const int MAX_NAME_LENGTH = 0x92F6;
        ///<summary>ARB_program_interface_query</summary>
        public const int MAX_NUM_ACTIVE_VARIABLES = 0x92F7;
        ///<summary>ARB_program_interface_query</summary>
        public const int MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;
        ///<summary>ARB_program_interface_query</summary>
        public const int NAME_LENGTH = 0x92F9;
        ///<summary>ARB_program_interface_query</summary>
        public const int TYPE = 0x92FA;
        ///<summary>ARB_program_interface_query</summary>
        public const int ARRAY_SIZE = 0x92FB;
        ///<summary>ARB_program_interface_query</summary>
        public const int OFFSET = 0x92FC;
        ///<summary>ARB_program_interface_query</summary>
        public const int BLOCK_INDEX = 0x92FD;
        ///<summary>ARB_program_interface_query</summary>
        public const int ARRAY_STRIDE = 0x92FE;
        ///<summary>ARB_program_interface_query</summary>
        public const int MATRIX_STRIDE = 0x92FF;
        ///<summary>ARB_program_interface_query</summary>
        public const int IS_ROW_MAJOR = 0x9300;
        ///<summary>ARB_program_interface_query</summary>
        public const int ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;
        ///<summary>ARB_program_interface_query</summary>
        public const int BUFFER_BINDING = 0x9302;
        ///<summary>ARB_program_interface_query</summary>
        public const int BUFFER_DATA_SIZE = 0x9303;
        ///<summary>ARB_program_interface_query</summary>
        public const int NUM_ACTIVE_VARIABLES = 0x9304;
        ///<summary>ARB_program_interface_query</summary>
        public const int ACTIVE_VARIABLES = 0x9305;
        ///<summary>ARB_program_interface_query</summary>
        public const int REFERENCED_BY_VERTEX_SHADER = 0x9306;
        ///<summary>ARB_program_interface_query</summary>
        public const int REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;
        ///<summary>ARB_program_interface_query</summary>
        public const int REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;
        ///<summary>ARB_program_interface_query</summary>
        public const int REFERENCED_BY_GEOMETRY_SHADER = 0x9309;
        ///<summary>ARB_program_interface_query</summary>
        public const int REFERENCED_BY_FRAGMENT_SHADER = 0x930A;
        ///<summary>ARB_program_interface_query</summary>
        public const int REFERENCED_BY_COMPUTE_SHADER = 0x930B;
        ///<summary>ARB_program_interface_query</summary>
        public const int TOP_LEVEL_ARRAY_SIZE = 0x930C;
        ///<summary>ARB_program_interface_query</summary>
        public const int TOP_LEVEL_ARRAY_STRIDE = 0x930D;
        ///<summary>ARB_program_interface_query</summary>
        public const int LOCATION = 0x930E;
        ///<summary>ARB_program_interface_query</summary>
        public const int LOCATION_INDEX = 0x930F;
        ///<summary>ARB_program_interface_query</summary>
        public const int IS_PER_PATCH = 0x92E7;
        ///<summary>ARB_shader_storage_buffer_object</summary>
        public const int SHADER_STORAGE_BUFFER = 0x90D2;
        ///<summary>ARB_shader_storage_buffer_object</summary>
        public const int SHADER_STORAGE_BUFFER_BINDING = 0x90D3;
        ///<summary>ARB_shader_storage_buffer_object</summary>
        public const int SHADER_STORAGE_BUFFER_START = 0x90D4;
        ///<summary>ARB_shader_storage_buffer_object</summary>
        public const int SHADER_STORAGE_BUFFER_SIZE = 0x90D5;
        ///<summary>ARB_shader_storage_buffer_object</summary>
        public const int MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;
        ///<summary>ARB_shader_storage_buffer_object</summary>
        public const int MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;
        ///<summary>ARB_shader_storage_buffer_object</summary>
        public const int MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;
        ///<summary>ARB_shader_storage_buffer_object</summary>
        public const int MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;
        ///<summary>ARB_shader_storage_buffer_object</summary>
        public const int MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;
        ///<summary>ARB_shader_storage_buffer_object</summary>
        public const int MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;
        ///<summary>ARB_shader_storage_buffer_object</summary>
        public const int MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;
        ///<summary>ARB_shader_storage_buffer_object</summary>
        public const int MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;
        ///<summary>ARB_shader_storage_buffer_object</summary>
        public const int MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;
        ///<summary>ARB_shader_storage_buffer_object</summary>
        public const int SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;
        ///<summary>ARB_shader_storage_buffer_object</summary>
        public const int SHADER_STORAGE_BARRIER_BIT = 0x2000;
        ///<summary>ARB_shader_storage_buffer_object</summary>
        public const int MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;
        ///<summary>ARB_stencil_texturing</summary>
        public const int DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;
        ///<summary>ARB_texture_buffer_range</summary>
        public const int TEXTURE_BUFFER_OFFSET = 0x919D;
        ///<summary>ARB_texture_buffer_range</summary>
        public const int TEXTURE_BUFFER_SIZE = 0x919E;
        ///<summary>ARB_texture_buffer_range</summary>
        public const int TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;
        ///<summary>EXT_abgr</summary>
        public const int ABGR_EXT = 0x8000;
        ///<summary>EXT_blend_color</summary>
        public const int CONSTANT_COLOR_EXT = 0x8001;
        ///<summary>EXT_blend_color</summary>
        public const int ONE_MINUS_CONSTANT_COLOR_EXT = 0x8002;
        ///<summary>EXT_blend_color</summary>
        public const int CONSTANT_ALPHA_EXT = 0x8003;
        ///<summary>EXT_blend_color</summary>
        public const int ONE_MINUS_CONSTANT_ALPHA_EXT = 0x8004;
        ///<summary>EXT_blend_color</summary>
        public const int BLEND_COLOR_EXT = 0x8005;
        ///<summary>EXT_polygon_offset</summary>
        public const int POLYGON_OFFSET_EXT = 0x8037;
        ///<summary>EXT_polygon_offset</summary>
        public const int POLYGON_OFFSET_FACTOR_EXT = 0x8038;
        ///<summary>EXT_polygon_offset</summary>
        public const int POLYGON_OFFSET_BIAS_EXT = 0x8039;
        ///<summary>EXT_texture</summary>
        public const int ALPHA4_EXT = 0x803B;
        ///<summary>EXT_texture</summary>
        public const int ALPHA8_EXT = 0x803C;
        ///<summary>EXT_texture</summary>
        public const int ALPHA12_EXT = 0x803D;
        ///<summary>EXT_texture</summary>
        public const int ALPHA16_EXT = 0x803E;
        ///<summary>EXT_texture</summary>
        public const int LUMINANCE4_EXT = 0x803F;
        ///<summary>EXT_texture</summary>
        public const int LUMINANCE8_EXT = 0x8040;
        ///<summary>EXT_texture</summary>
        public const int LUMINANCE12_EXT = 0x8041;
        ///<summary>EXT_texture</summary>
        public const int LUMINANCE16_EXT = 0x8042;
        ///<summary>EXT_texture</summary>
        public const int LUMINANCE4_ALPHA4_EXT = 0x8043;
        ///<summary>EXT_texture</summary>
        public const int LUMINANCE6_ALPHA2_EXT = 0x8044;
        ///<summary>EXT_texture</summary>
        public const int LUMINANCE8_ALPHA8_EXT = 0x8045;
        ///<summary>EXT_texture</summary>
        public const int LUMINANCE12_ALPHA4_EXT = 0x8046;
        ///<summary>EXT_texture</summary>
        public const int LUMINANCE12_ALPHA12_EXT = 0x8047;
        ///<summary>EXT_texture</summary>
        public const int LUMINANCE16_ALPHA16_EXT = 0x8048;
        ///<summary>EXT_texture</summary>
        public const int INTENSITY_EXT = 0x8049;
        ///<summary>EXT_texture</summary>
        public const int INTENSITY4_EXT = 0x804A;
        ///<summary>EXT_texture</summary>
        public const int INTENSITY8_EXT = 0x804B;
        ///<summary>EXT_texture</summary>
        public const int INTENSITY12_EXT = 0x804C;
        ///<summary>EXT_texture</summary>
        public const int INTENSITY16_EXT = 0x804D;
        ///<summary>EXT_texture</summary>
        public const int RGB2_EXT = 0x804E;
        ///<summary>EXT_texture</summary>
        public const int RGB4_EXT = 0x804F;
        ///<summary>EXT_texture</summary>
        public const int RGB5_EXT = 0x8050;
        ///<summary>EXT_texture</summary>
        public const int RGB8_EXT = 0x8051;
        ///<summary>EXT_texture</summary>
        public const int RGB10_EXT = 0x8052;
        ///<summary>EXT_texture</summary>
        public const int RGB12_EXT = 0x8053;
        ///<summary>EXT_texture</summary>
        public const int RGB16_EXT = 0x8054;
        ///<summary>EXT_texture</summary>
        public const int RGBA2_EXT = 0x8055;
        ///<summary>EXT_texture</summary>
        public const int RGBA4_EXT = 0x8056;
        ///<summary>EXT_texture</summary>
        public const int RGB5_A1_EXT = 0x8057;
        ///<summary>EXT_texture</summary>
        public const int RGBA8_EXT = 0x8058;
        ///<summary>EXT_texture</summary>
        public const int RGB10_A2_EXT = 0x8059;
        ///<summary>EXT_texture</summary>
        public const int RGBA12_EXT = 0x805A;
        ///<summary>EXT_texture</summary>
        public const int RGBA16_EXT = 0x805B;
        ///<summary>EXT_texture</summary>
        public const int TEXTURE_RED_SIZE_EXT = 0x805C;
        ///<summary>EXT_texture</summary>
        public const int TEXTURE_GREEN_SIZE_EXT = 0x805D;
        ///<summary>EXT_texture</summary>
        public const int TEXTURE_BLUE_SIZE_EXT = 0x805E;
        ///<summary>EXT_texture</summary>
        public const int TEXTURE_ALPHA_SIZE_EXT = 0x805F;
        ///<summary>EXT_texture</summary>
        public const int TEXTURE_LUMINANCE_SIZE_EXT = 0x8060;
        ///<summary>EXT_texture</summary>
        public const int TEXTURE_INTENSITY_SIZE_EXT = 0x8061;
        ///<summary>EXT_texture</summary>
        public const int REPLACE_EXT = 0x8062;
        ///<summary>EXT_texture</summary>
        public const int PROXY_TEXTURE_1D_EXT = 0x8063;
        ///<summary>EXT_texture</summary>
        public const int PROXY_TEXTURE_2D_EXT = 0x8064;
        ///<summary>EXT_texture</summary>
        public const int TEXTURE_TOO_LARGE_EXT = 0x8065;
        ///<summary>EXT_texture3D</summary>
        public const int PACK_SKIP_IMAGES_EXT = 0x806B;
        ///<summary>EXT_texture3D</summary>
        public const int PACK_IMAGE_HEIGHT_EXT = 0x806C;
        ///<summary>EXT_texture3D</summary>
        public const int UNPACK_SKIP_IMAGES_EXT = 0x806D;
        ///<summary>EXT_texture3D</summary>
        public const int UNPACK_IMAGE_HEIGHT_EXT = 0x806E;
        ///<summary>EXT_texture3D</summary>
        public const int TEXTURE_3D_EXT = 0x806F;
        ///<summary>EXT_texture3D</summary>
        public const int PROXY_TEXTURE_3D_EXT = 0x8070;
        ///<summary>EXT_texture3D</summary>
        public const int TEXTURE_DEPTH_EXT = 0x8071;
        ///<summary>EXT_texture3D</summary>
        public const int TEXTURE_WRAP_R_EXT = 0x8072;
        ///<summary>EXT_texture3D</summary>
        public const int MAX_3D_TEXTURE_SIZE_EXT = 0x8073;
        ///<summary>SGIS_texture_filter4</summary>
        public const int FILTER4_SGIS = 0x8146;
        ///<summary>SGIS_texture_filter4</summary>
        public const int TEXTURE_FILTER4_SIZE_SGIS = 0x8147;
        ///<summary>EXT_histogram</summary>
        public const int HISTOGRAM_EXT = 0x8024;
        ///<summary>EXT_histogram</summary>
        public const int PROXY_HISTOGRAM_EXT = 0x8025;
        ///<summary>EXT_histogram</summary>
        public const int HISTOGRAM_WIDTH_EXT = 0x8026;
        ///<summary>EXT_histogram</summary>
        public const int HISTOGRAM_FORMAT_EXT = 0x8027;
        ///<summary>EXT_histogram</summary>
        public const int HISTOGRAM_RED_SIZE_EXT = 0x8028;
        ///<summary>EXT_histogram</summary>
        public const int HISTOGRAM_GREEN_SIZE_EXT = 0x8029;
        ///<summary>EXT_histogram</summary>
        public const int HISTOGRAM_BLUE_SIZE_EXT = 0x802A;
        ///<summary>EXT_histogram</summary>
        public const int HISTOGRAM_ALPHA_SIZE_EXT = 0x802B;
        ///<summary>EXT_histogram</summary>
        public const int HISTOGRAM_LUMINANCE_SIZE_EXT = 0x802C;
        ///<summary>EXT_histogram</summary>
        public const int HISTOGRAM_SINK_EXT = 0x802D;
        ///<summary>EXT_histogram</summary>
        public const int MINMAX_EXT = 0x802E;
        ///<summary>EXT_histogram</summary>
        public const int MINMAX_FORMAT_EXT = 0x802F;
        ///<summary>EXT_histogram</summary>
        public const int MINMAX_SINK_EXT = 0x8030;
        ///<summary>EXT_histogram</summary>
        public const int TABLE_TOO_LARGE_EXT = 0x8031;
        ///<summary>EXT_convolution</summary>
        public const int CONVOLUTION_1D_EXT = 0x8010;
        ///<summary>EXT_convolution</summary>
        public const int CONVOLUTION_2D_EXT = 0x8011;
        ///<summary>EXT_convolution</summary>
        public const int SEPARABLE_2D_EXT = 0x8012;
        ///<summary>EXT_convolution</summary>
        public const int CONVOLUTION_BORDER_MODE_EXT = 0x8013;
        ///<summary>EXT_convolution</summary>
        public const int CONVOLUTION_FILTER_SCALE_EXT = 0x8014;
        ///<summary>EXT_convolution</summary>
        public const int CONVOLUTION_FILTER_BIAS_EXT = 0x8015;
        ///<summary>EXT_convolution</summary>
        public const int REDUCE_EXT = 0x8016;
        ///<summary>EXT_convolution</summary>
        public const int CONVOLUTION_FORMAT_EXT = 0x8017;
        ///<summary>EXT_convolution</summary>
        public const int CONVOLUTION_WIDTH_EXT = 0x8018;
        ///<summary>EXT_convolution</summary>
        public const int CONVOLUTION_HEIGHT_EXT = 0x8019;
        ///<summary>EXT_convolution</summary>
        public const int MAX_CONVOLUTION_WIDTH_EXT = 0x801A;
        ///<summary>EXT_convolution</summary>
        public const int MAX_CONVOLUTION_HEIGHT_EXT = 0x801B;
        ///<summary>EXT_convolution</summary>
        public const int POST_CONVOLUTION_RED_SCALE_EXT = 0x801C;
        ///<summary>EXT_convolution</summary>
        public const int POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D;
        ///<summary>EXT_convolution</summary>
        public const int POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E;
        ///<summary>EXT_convolution</summary>
        public const int POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F;
        ///<summary>EXT_convolution</summary>
        public const int POST_CONVOLUTION_RED_BIAS_EXT = 0x8020;
        ///<summary>EXT_convolution</summary>
        public const int POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021;
        ///<summary>EXT_convolution</summary>
        public const int POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022;
        ///<summary>EXT_convolution</summary>
        public const int POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023;
        ///<summary>SGI_color_matrix</summary>
        public const int COLOR_MATRIX_SGI = 0x80B1;
        ///<summary>SGI_color_matrix</summary>
        public const int COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B2;
        ///<summary>SGI_color_matrix</summary>
        public const int MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3;
        ///<summary>SGI_color_matrix</summary>
        public const int POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4;
        ///<summary>SGI_color_matrix</summary>
        public const int POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5;
        ///<summary>SGI_color_matrix</summary>
        public const int POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6;
        ///<summary>SGI_color_matrix</summary>
        public const int POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7;
        ///<summary>SGI_color_matrix</summary>
        public const int POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8;
        ///<summary>SGI_color_matrix</summary>
        public const int POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9;
        ///<summary>SGI_color_matrix</summary>
        public const int POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA;
        ///<summary>SGI_color_matrix</summary>
        public const int POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB;
        ///<summary>SGI_color_table</summary>
        public const int COLOR_TABLE_SGI = 0x80D0;
        ///<summary>SGI_color_table</summary>
        public const int POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1;
        ///<summary>SGI_color_table</summary>
        public const int POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2;
        ///<summary>SGI_color_table</summary>
        public const int PROXY_COLOR_TABLE_SGI = 0x80D3;
        ///<summary>SGI_color_table</summary>
        public const int PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D4;
        ///<summary>SGI_color_table</summary>
        public const int PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D5;
        ///<summary>SGI_color_table</summary>
        public const int COLOR_TABLE_SCALE_SGI = 0x80D6;
        ///<summary>SGI_color_table</summary>
        public const int COLOR_TABLE_BIAS_SGI = 0x80D7;
        ///<summary>SGI_color_table</summary>
        public const int COLOR_TABLE_FORMAT_SGI = 0x80D8;
        ///<summary>SGI_color_table</summary>
        public const int COLOR_TABLE_WIDTH_SGI = 0x80D9;
        ///<summary>SGI_color_table</summary>
        public const int COLOR_TABLE_RED_SIZE_SGI = 0x80DA;
        ///<summary>SGI_color_table</summary>
        public const int COLOR_TABLE_GREEN_SIZE_SGI = 0x80DB;
        ///<summary>SGI_color_table</summary>
        public const int COLOR_TABLE_BLUE_SIZE_SGI = 0x80DC;
        ///<summary>SGI_color_table</summary>
        public const int COLOR_TABLE_ALPHA_SIZE_SGI = 0x80DD;
        ///<summary>SGI_color_table</summary>
        public const int COLOR_TABLE_LUMINANCE_SIZE_SGI = 0x80DE;
        ///<summary>SGI_color_table</summary>
        public const int COLOR_TABLE_INTENSITY_SIZE_SGI = 0x80DF;
        ///<summary>SGIS_pixel_texture</summary>
        public const int PIXEL_TEXTURE_SGIS = 0x8353;
        ///<summary>SGIS_pixel_texture</summary>
        public const int PIXEL_FRAGMENT_RGB_SOURCE_SGIS = 0x8354;
        ///<summary>SGIS_pixel_texture</summary>
        public const int PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = 0x8355;
        ///<summary>SGIS_pixel_texture</summary>
        public const int PIXEL_GROUP_COLOR_SGIS = 0x8356;
        ///<summary>SGIX_pixel_texture</summary>
        public const int PIXEL_TEX_GEN_SGIX = 0x8139;
        ///<summary>SGIX_pixel_texture</summary>
        public const int PIXEL_TEX_GEN_MODE_SGIX = 0x832B;
        ///<summary>SGIS_texture4D</summary>
        public const int PACK_SKIP_VOLUMES_SGIS = 0x8130;
        ///<summary>SGIS_texture4D</summary>
        public const int PACK_IMAGE_DEPTH_SGIS = 0x8131;
        ///<summary>SGIS_texture4D</summary>
        public const int UNPACK_SKIP_VOLUMES_SGIS = 0x8132;
        ///<summary>SGIS_texture4D</summary>
        public const int UNPACK_IMAGE_DEPTH_SGIS = 0x8133;
        ///<summary>SGIS_texture4D</summary>
        public const int TEXTURE_4D_SGIS = 0x8134;
        ///<summary>SGIS_texture4D</summary>
        public const int PROXY_TEXTURE_4D_SGIS = 0x8135;
        ///<summary>SGIS_texture4D</summary>
        public const int TEXTURE_4DSIZE_SGIS = 0x8136;
        ///<summary>SGIS_texture4D</summary>
        public const int TEXTURE_WRAP_Q_SGIS = 0x8137;
        ///<summary>SGIS_texture4D</summary>
        public const int MAX_4D_TEXTURE_SIZE_SGIS = 0x8138;
        ///<summary>SGIS_texture4D</summary>
        public const int TEXTURE_4D_BINDING_SGIS = 0x814F;
        ///<summary>SGI_texture_color_table</summary>
        public const int TEXTURE_COLOR_TABLE_SGI = 0x80BC;
        ///<summary>SGI_texture_color_table</summary>
        public const int PROXY_TEXTURE_COLOR_TABLE_SGI = 0x80BD;
        ///<summary>EXT_cmyka</summary>
        public const int CMYK_EXT = 0x800C;
        ///<summary>EXT_cmyka</summary>
        public const int CMYKA_EXT = 0x800D;
        ///<summary>EXT_cmyka</summary>
        public const int PACK_CMYK_HINT_EXT = 0x800E;
        ///<summary>EXT_cmyka</summary>
        public const int UNPACK_CMYK_HINT_EXT = 0x800F;
        ///<summary>EXT_texture_object</summary>
        public const int TEXTURE_PRIORITY_EXT = 0x8066;
        ///<summary>EXT_texture_object</summary>
        public const int TEXTURE_RESIDENT_EXT = 0x8067;
        ///<summary>EXT_texture_object</summary>
        public const int TEXTURE_1D_BINDING_EXT = 0x8068;
        ///<summary>EXT_texture_object</summary>
        public const int TEXTURE_2D_BINDING_EXT = 0x8069;
        ///<summary>EXT_texture_object</summary>
        public const int TEXTURE_3D_BINDING_EXT = 0x806A;
        ///<summary>SGIS_detail_texture</summary>
        public const int DETAIL_TEXTURE_2D_SGIS = 0x8095;
        ///<summary>SGIS_detail_texture</summary>
        public const int DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096;
        ///<summary>SGIS_detail_texture</summary>
        public const int LINEAR_DETAIL_SGIS = 0x8097;
        ///<summary>SGIS_detail_texture</summary>
        public const int LINEAR_DETAIL_ALPHA_SGIS = 0x8098;
        ///<summary>SGIS_detail_texture</summary>
        public const int LINEAR_DETAIL_COLOR_SGIS = 0x8099;
        ///<summary>SGIS_detail_texture</summary>
        public const int DETAIL_TEXTURE_LEVEL_SGIS = 0x809A;
        ///<summary>SGIS_detail_texture</summary>
        public const int DETAIL_TEXTURE_MODE_SGIS = 0x809B;
        ///<summary>SGIS_detail_texture</summary>
        public const int DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C;
        ///<summary>SGIS_sharpen_texture</summary>
        public const int LINEAR_SHARPEN_SGIS = 0x80AD;
        ///<summary>SGIS_sharpen_texture</summary>
        public const int LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE;
        ///<summary>SGIS_sharpen_texture</summary>
        public const int LINEAR_SHARPEN_COLOR_SGIS = 0x80AF;
        ///<summary>SGIS_sharpen_texture</summary>
        public const int SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0;
        ///<summary>EXT_packed_pixels</summary>
        public const int UNSIGNED_BYTE_3_3_2_EXT = 0x8032;
        ///<summary>EXT_packed_pixels</summary>
        public const int UNSIGNED_SHORT_4_4_4_4_EXT = 0x8033;
        ///<summary>EXT_packed_pixels</summary>
        public const int UNSIGNED_SHORT_5_5_5_1_EXT = 0x8034;
        ///<summary>EXT_packed_pixels</summary>
        public const int UNSIGNED_INT_8_8_8_8_EXT = 0x8035;
        ///<summary>EXT_packed_pixels</summary>
        public const int UNSIGNED_INT_10_10_10_2_EXT = 0x8036;
        ///<summary>SGIS_texture_lod</summary>
        public const int TEXTURE_MIN_LOD_SGIS = 0x813A;
        ///<summary>SGIS_texture_lod</summary>
        public const int TEXTURE_MAX_LOD_SGIS = 0x813B;
        ///<summary>SGIS_texture_lod</summary>
        public const int TEXTURE_BASE_LEVEL_SGIS = 0x813C;
        ///<summary>SGIS_texture_lod</summary>
        public const int TEXTURE_MAX_LEVEL_SGIS = 0x813D;
        ///<summary>SGIS_multisample</summary>
        public const int MULTISAMPLE_SGIS = 0x809D;
        ///<summary>SGIS_multisample</summary>
        public const int SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E;
        ///<summary>SGIS_multisample</summary>
        public const int SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F;
        ///<summary>SGIS_multisample</summary>
        public const int SAMPLE_MASK_SGIS = 0x80A0;
        ///<summary>SGIS_multisample</summary>
        public const int _1PASS_SGIS = 0x80A1;
        ///<summary>SGIS_multisample</summary>
        public const int _2PASS_0_SGIS = 0x80A2;
        ///<summary>SGIS_multisample</summary>
        public const int _2PASS_1_SGIS = 0x80A3;
        ///<summary>SGIS_multisample</summary>
        public const int _4PASS_0_SGIS = 0x80A4;
        ///<summary>SGIS_multisample</summary>
        public const int _4PASS_1_SGIS = 0x80A5;
        ///<summary>SGIS_multisample</summary>
        public const int _4PASS_2_SGIS = 0x80A6;
        ///<summary>SGIS_multisample</summary>
        public const int _4PASS_3_SGIS = 0x80A7;
        ///<summary>SGIS_multisample</summary>
        public const int SAMPLE_BUFFERS_SGIS = 0x80A8;
        ///<summary>SGIS_multisample</summary>
        public const int SAMPLES_SGIS = 0x80A9;
        ///<summary>SGIS_multisample</summary>
        public const int SAMPLE_MASK_VALUE_SGIS = 0x80AA;
        ///<summary>SGIS_multisample</summary>
        public const int SAMPLE_MASK_INVERT_SGIS = 0x80AB;
        ///<summary>SGIS_multisample</summary>
        public const int SAMPLE_PATTERN_SGIS = 0x80AC;
        ///<summary>EXT_rescale_normal</summary>
        public const int RESCALE_NORMAL_EXT = 0x803A;
        ///<summary>EXT_vertex_array</summary>
        public const int VERTEX_ARRAY_EXT = 0x8074;
        ///<summary>EXT_vertex_array</summary>
        public const int NORMAL_ARRAY_EXT = 0x8075;
        ///<summary>EXT_vertex_array</summary>
        public const int COLOR_ARRAY_EXT = 0x8076;
        ///<summary>EXT_vertex_array</summary>
        public const int INDEX_ARRAY_EXT = 0x8077;
        ///<summary>EXT_vertex_array</summary>
        public const int TEXTURE_COORD_ARRAY_EXT = 0x8078;
        ///<summary>EXT_vertex_array</summary>
        public const int EDGE_FLAG_ARRAY_EXT = 0x8079;
        ///<summary>EXT_vertex_array</summary>
        public const int VERTEX_ARRAY_SIZE_EXT = 0x807A;
        ///<summary>EXT_vertex_array</summary>
        public const int VERTEX_ARRAY_TYPE_EXT = 0x807B;
        ///<summary>EXT_vertex_array</summary>
        public const int VERTEX_ARRAY_STRIDE_EXT = 0x807C;
        ///<summary>EXT_vertex_array</summary>
        public const int VERTEX_ARRAY_COUNT_EXT = 0x807D;
        ///<summary>EXT_vertex_array</summary>
        public const int NORMAL_ARRAY_TYPE_EXT = 0x807E;
        ///<summary>EXT_vertex_array</summary>
        public const int NORMAL_ARRAY_STRIDE_EXT = 0x807F;
        ///<summary>EXT_vertex_array</summary>
        public const int NORMAL_ARRAY_COUNT_EXT = 0x8080;
        ///<summary>EXT_vertex_array</summary>
        public const int COLOR_ARRAY_SIZE_EXT = 0x8081;
        ///<summary>EXT_vertex_array</summary>
        public const int COLOR_ARRAY_TYPE_EXT = 0x8082;
        ///<summary>EXT_vertex_array</summary>
        public const int COLOR_ARRAY_STRIDE_EXT = 0x8083;
        ///<summary>EXT_vertex_array</summary>
        public const int COLOR_ARRAY_COUNT_EXT = 0x8084;
        ///<summary>EXT_vertex_array</summary>
        public const int INDEX_ARRAY_TYPE_EXT = 0x8085;
        ///<summary>EXT_vertex_array</summary>
        public const int INDEX_ARRAY_STRIDE_EXT = 0x8086;
        ///<summary>EXT_vertex_array</summary>
        public const int INDEX_ARRAY_COUNT_EXT = 0x8087;
        ///<summary>EXT_vertex_array</summary>
        public const int TEXTURE_COORD_ARRAY_SIZE_EXT = 0x8088;
        ///<summary>EXT_vertex_array</summary>
        public const int TEXTURE_COORD_ARRAY_TYPE_EXT = 0x8089;
        ///<summary>EXT_vertex_array</summary>
        public const int TEXTURE_COORD_ARRAY_STRIDE_EXT = 0x808A;
        ///<summary>EXT_vertex_array</summary>
        public const int TEXTURE_COORD_ARRAY_COUNT_EXT = 0x808B;
        ///<summary>EXT_vertex_array</summary>
        public const int EDGE_FLAG_ARRAY_STRIDE_EXT = 0x808C;
        ///<summary>EXT_vertex_array</summary>
        public const int EDGE_FLAG_ARRAY_COUNT_EXT = 0x808D;
        ///<summary>EXT_vertex_array</summary>
        public const int VERTEX_ARRAY_POINTER_EXT = 0x808E;
        ///<summary>EXT_vertex_array</summary>
        public const int NORMAL_ARRAY_POINTER_EXT = 0x808F;
        ///<summary>EXT_vertex_array</summary>
        public const int COLOR_ARRAY_POINTER_EXT = 0x8090;
        ///<summary>EXT_vertex_array</summary>
        public const int INDEX_ARRAY_POINTER_EXT = 0x8091;
        ///<summary>EXT_vertex_array</summary>
        public const int TEXTURE_COORD_ARRAY_POINTER_EXT = 0x8092;
        ///<summary>EXT_vertex_array</summary>
        public const int EDGE_FLAG_ARRAY_POINTER_EXT = 0x8093;
        ///<summary>SGIS_generate_mipmap</summary>
        public const int GENERATE_MIPMAP_SGIS = 0x8191;
        ///<summary>SGIS_generate_mipmap</summary>
        public const int GENERATE_MIPMAP_HINT_SGIS = 0x8192;
        ///<summary>SGIX_clipmap</summary>
        public const int LINEAR_CLIPMAP_LINEAR_SGIX = 0x8170;
        ///<summary>SGIX_clipmap</summary>
        public const int TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171;
        ///<summary>SGIX_clipmap</summary>
        public const int TEXTURE_CLIPMAP_FRAME_SGIX = 0x8172;
        ///<summary>SGIX_clipmap</summary>
        public const int TEXTURE_CLIPMAP_OFFSET_SGIX = 0x8173;
        ///<summary>SGIX_clipmap</summary>
        public const int TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174;
        ///<summary>SGIX_clipmap</summary>
        public const int TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175;
        ///<summary>SGIX_clipmap</summary>
        public const int TEXTURE_CLIPMAP_DEPTH_SGIX = 0x8176;
        ///<summary>SGIX_clipmap</summary>
        public const int MAX_CLIPMAP_DEPTH_SGIX = 0x8177;
        ///<summary>SGIX_clipmap</summary>
        public const int MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8178;
        ///<summary>SGIX_clipmap</summary>
        public const int NEAREST_CLIPMAP_NEAREST_SGIX = 0x844D;
        ///<summary>SGIX_clipmap</summary>
        public const int NEAREST_CLIPMAP_LINEAR_SGIX = 0x844E;
        ///<summary>SGIX_clipmap</summary>
        public const int LINEAR_CLIPMAP_NEAREST_SGIX = 0x844F;
        ///<summary>SGIX_shadow</summary>
        public const int TEXTURE_COMPARE_SGIX = 0x819A;
        ///<summary>SGIX_shadow</summary>
        public const int TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B;
        ///<summary>SGIX_shadow</summary>
        public const int TEXTURE_LEQUAL_R_SGIX = 0x819C;
        ///<summary>SGIX_shadow</summary>
        public const int TEXTURE_GEQUAL_R_SGIX = 0x819D;
        ///<summary>SGIS_texture_edge_clamp</summary>
        public const int CLAMP_TO_EDGE_SGIS = 0x812F;
        ///<summary>SGIS_texture_border_clamp</summary>
        public const int CLAMP_TO_BORDER_SGIS = 0x812D;
        ///<summary>EXT_blend_minmax</summary>
        public const int FUNC_ADD_EXT = 0x8006;
        ///<summary>EXT_blend_minmax</summary>
        public const int MIN_EXT = 0x8007;
        ///<summary>EXT_blend_minmax</summary>
        public const int MAX_EXT = 0x8008;
        ///<summary>EXT_blend_minmax</summary>
        public const int BLEND_EQUATION_EXT = 0x8009;
        ///<summary>EXT_blend_subtract</summary>
        public const int FUNC_SUBTRACT_EXT = 0x800A;
        ///<summary>EXT_blend_subtract</summary>
        public const int FUNC_REVERSE_SUBTRACT_EXT = 0x800B;
        ///<summary>SGIX_interlace</summary>
        public const int INTERLACE_SGIX = 0x8094;
        ///<summary>SGIX_pixel_tiles</summary>
        public const int PIXEL_TILE_BEST_ALIGNMENT_SGIX = 0x813E;
        ///<summary>SGIX_pixel_tiles</summary>
        public const int PIXEL_TILE_CACHE_INCREMENT_SGIX = 0x813F;
        ///<summary>SGIX_pixel_tiles</summary>
        public const int PIXEL_TILE_WIDTH_SGIX = 0x8140;
        ///<summary>SGIX_pixel_tiles</summary>
        public const int PIXEL_TILE_HEIGHT_SGIX = 0x8141;
        ///<summary>SGIX_pixel_tiles</summary>
        public const int PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142;
        ///<summary>SGIX_pixel_tiles</summary>
        public const int PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143;
        ///<summary>SGIX_pixel_tiles</summary>
        public const int PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144;
        ///<summary>SGIX_pixel_tiles</summary>
        public const int PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145;
        ///<summary>SGIS_texture_select</summary>
        public const int DUAL_ALPHA4_SGIS = 0x8110;
        ///<summary>SGIS_texture_select</summary>
        public const int DUAL_ALPHA8_SGIS = 0x8111;
        ///<summary>SGIS_texture_select</summary>
        public const int DUAL_ALPHA12_SGIS = 0x8112;
        ///<summary>SGIS_texture_select</summary>
        public const int DUAL_ALPHA16_SGIS = 0x8113;
        ///<summary>SGIS_texture_select</summary>
        public const int DUAL_LUMINANCE4_SGIS = 0x8114;
        ///<summary>SGIS_texture_select</summary>
        public const int DUAL_LUMINANCE8_SGIS = 0x8115;
        ///<summary>SGIS_texture_select</summary>
        public const int DUAL_LUMINANCE12_SGIS = 0x8116;
        ///<summary>SGIS_texture_select</summary>
        public const int DUAL_LUMINANCE16_SGIS = 0x8117;
        ///<summary>SGIS_texture_select</summary>
        public const int DUAL_INTENSITY4_SGIS = 0x8118;
        ///<summary>SGIS_texture_select</summary>
        public const int DUAL_INTENSITY8_SGIS = 0x8119;
        ///<summary>SGIS_texture_select</summary>
        public const int DUAL_INTENSITY12_SGIS = 0x811A;
        ///<summary>SGIS_texture_select</summary>
        public const int DUAL_INTENSITY16_SGIS = 0x811B;
        ///<summary>SGIS_texture_select</summary>
        public const int DUAL_LUMINANCE_ALPHA4_SGIS = 0x811C;
        ///<summary>SGIS_texture_select</summary>
        public const int DUAL_LUMINANCE_ALPHA8_SGIS = 0x811D;
        ///<summary>SGIS_texture_select</summary>
        public const int QUAD_ALPHA4_SGIS = 0x811E;
        ///<summary>SGIS_texture_select</summary>
        public const int QUAD_ALPHA8_SGIS = 0x811F;
        ///<summary>SGIS_texture_select</summary>
        public const int QUAD_LUMINANCE4_SGIS = 0x8120;
        ///<summary>SGIS_texture_select</summary>
        public const int QUAD_LUMINANCE8_SGIS = 0x8121;
        ///<summary>SGIS_texture_select</summary>
        public const int QUAD_INTENSITY4_SGIS = 0x8122;
        ///<summary>SGIS_texture_select</summary>
        public const int QUAD_INTENSITY8_SGIS = 0x8123;
        ///<summary>SGIS_texture_select</summary>
        public const int DUAL_TEXTURE_SELECT_SGIS = 0x8124;
        ///<summary>SGIS_texture_select</summary>
        public const int QUAD_TEXTURE_SELECT_SGIS = 0x8125;
        ///<summary>SGIX_sprite</summary>
        public const int SPRITE_SGIX = 0x8148;
        ///<summary>SGIX_sprite</summary>
        public const int SPRITE_MODE_SGIX = 0x8149;
        ///<summary>SGIX_sprite</summary>
        public const int SPRITE_AXIS_SGIX = 0x814A;
        ///<summary>SGIX_sprite</summary>
        public const int SPRITE_TRANSLATION_SGIX = 0x814B;
        ///<summary>SGIX_sprite</summary>
        public const int SPRITE_AXIAL_SGIX = 0x814C;
        ///<summary>SGIX_sprite</summary>
        public const int SPRITE_OBJECT_ALIGNED_SGIX = 0x814D;
        ///<summary>SGIX_sprite</summary>
        public const int SPRITE_EYE_ALIGNED_SGIX = 0x814E;
        ///<summary>SGIX_texture_multi_buffer</summary>
        public const int TEXTURE_MULTI_BUFFER_HINT_SGIX = 0x812E;
        ///<summary>EXT_point_parameters</summary>
        public const int POINT_SIZE_MIN_EXT = 0x8126;
        ///<summary>EXT_point_parameters</summary>
        public const int POINT_SIZE_MAX_EXT = 0x8127;
        ///<summary>EXT_point_parameters</summary>
        public const int POINT_FADE_THRESHOLD_SIZE_EXT = 0x8128;
        ///<summary>EXT_point_parameters</summary>
        public const int DISTANCE_ATTENUATION_EXT = 0x8129;
        ///<summary>SGIS_point_parameters</summary>
        public const int POINT_SIZE_MIN_SGIS = 0x8126;
        ///<summary>SGIS_point_parameters</summary>
        public const int POINT_SIZE_MAX_SGIS = 0x8127;
        ///<summary>SGIS_point_parameters</summary>
        public const int POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128;
        ///<summary>SGIS_point_parameters</summary>
        public const int DISTANCE_ATTENUATION_SGIS = 0x8129;
        ///<summary>SGIX_instruments</summary>
        public const int INSTRUMENT_BUFFER_POINTER_SGIX = 0x8180;
        ///<summary>SGIX_instruments</summary>
        public const int INSTRUMENT_MEASUREMENTS_SGIX = 0x8181;
        ///<summary>SGIX_texture_scale_bias</summary>
        public const int POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179;
        ///<summary>SGIX_texture_scale_bias</summary>
        public const int POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A;
        ///<summary>SGIX_texture_scale_bias</summary>
        public const int POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = 0x817B;
        ///<summary>SGIX_texture_scale_bias</summary>
        public const int POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = 0x817C;
        ///<summary>SGIX_framezoom</summary>
        public const int FRAMEZOOM_SGIX = 0x818B;
        ///<summary>SGIX_framezoom</summary>
        public const int FRAMEZOOM_FACTOR_SGIX = 0x818C;
        ///<summary>SGIX_framezoom</summary>
        public const int MAX_FRAMEZOOM_FACTOR_SGIX = 0x818D;
        ///<summary>FfdMaskSGIX</summary>
        public const int TEXTURE_DEFORMATION_BIT_SGIX = 0x00000001;
        ///<summary>FfdMaskSGIX</summary>
        public const int GEOMETRY_DEFORMATION_BIT_SGIX = 0x00000002;
        ///<summary>SGIX_polynomial_ffd</summary>
        public const int GEOMETRY_DEFORMATION_SGIX = 0x8194;
        ///<summary>SGIX_polynomial_ffd</summary>
        public const int TEXTURE_DEFORMATION_SGIX = 0x8195;
        ///<summary>SGIX_polynomial_ffd</summary>
        public const int DEFORMATIONS_MASK_SGIX = 0x8196;
        ///<summary>SGIX_polynomial_ffd</summary>
        public const int MAX_DEFORMATION_ORDER_SGIX = 0x8197;
        ///<summary>SGIX_reference_plane</summary>
        public const int REFERENCE_PLANE_SGIX = 0x817D;
        ///<summary>SGIX_reference_plane</summary>
        public const int REFERENCE_PLANE_EQUATION_SGIX = 0x817E;
        ///<summary>SGIX_depth_texture</summary>
        public const int DEPTH_COMPONENT16_SGIX = 0x81A5;
        ///<summary>SGIX_depth_texture</summary>
        public const int DEPTH_COMPONENT24_SGIX = 0x81A6;
        ///<summary>SGIX_depth_texture</summary>
        public const int DEPTH_COMPONENT32_SGIX = 0x81A7;
        ///<summary>SGIS_fog_function</summary>
        public const int FOG_FUNC_SGIS = 0x812A;
        ///<summary>SGIS_fog_function</summary>
        public const int FOG_FUNC_POINTS_SGIS = 0x812B;
        ///<summary>SGIS_fog_function</summary>
        public const int MAX_FOG_FUNC_POINTS_SGIS = 0x812C;
        ///<summary>SGIX_fog_offset</summary>
        public const int FOG_OFFSET_SGIX = 0x8198;
        ///<summary>SGIX_fog_offset</summary>
        public const int FOG_OFFSET_VALUE_SGIX = 0x8199;
        ///<summary>HP_image_transform</summary>
        public const int IMAGE_SCALE_X_HP = 0x8155;
        ///<summary>HP_image_transform</summary>
        public const int IMAGE_SCALE_Y_HP = 0x8156;
        ///<summary>HP_image_transform</summary>
        public const int IMAGE_TRANSLATE_X_HP = 0x8157;
        ///<summary>HP_image_transform</summary>
        public const int IMAGE_TRANSLATE_Y_HP = 0x8158;
        ///<summary>HP_image_transform</summary>
        public const int IMAGE_ROTATE_ANGLE_HP = 0x8159;
        ///<summary>HP_image_transform</summary>
        public const int IMAGE_ROTATE_ORIGIN_X_HP = 0x815A;
        ///<summary>HP_image_transform</summary>
        public const int IMAGE_ROTATE_ORIGIN_Y_HP = 0x815B;
        ///<summary>HP_image_transform</summary>
        public const int IMAGE_MAG_FILTER_HP = 0x815C;
        ///<summary>HP_image_transform</summary>
        public const int IMAGE_MIN_FILTER_HP = 0x815D;
        ///<summary>HP_image_transform</summary>
        public const int IMAGE_CUBIC_WEIGHT_HP = 0x815E;
        ///<summary>HP_image_transform</summary>
        public const int CUBIC_HP = 0x815F;
        ///<summary>HP_image_transform</summary>
        public const int AVERAGE_HP = 0x8160;
        ///<summary>HP_image_transform</summary>
        public const int IMAGE_TRANSFORM_2D_HP = 0x8161;
        ///<summary>HP_image_transform</summary>
        public const int POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8162;
        ///<summary>HP_image_transform</summary>
        public const int PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8163;
        ///<summary>HP_convolution_border_modes</summary>
        public const int IGNORE_BORDER_HP = 0x8150;
        ///<summary>HP_convolution_border_modes</summary>
        public const int CONSTANT_BORDER_HP = 0x8151;
        ///<summary>HP_convolution_border_modes</summary>
        public const int REPLICATE_BORDER_HP = 0x8153;
        ///<summary>HP_convolution_border_modes</summary>
        public const int CONVOLUTION_BORDER_COLOR_HP = 0x8154;
        ///<summary>SGIX_texture_add_env</summary>
        public const int TEXTURE_ENV_BIAS_SGIX = 0x80BE;
        ///<summary>PGI_vertex_hints</summary>
        public const int VERTEX_DATA_HINT_PGI = 0x1A22A;
        ///<summary>PGI_vertex_hints</summary>
        public const int VERTEX_CONSISTENT_HINT_PGI = 0x1A22B;
        ///<summary>PGI_vertex_hints</summary>
        public const int MATERIAL_SIDE_HINT_PGI = 0x1A22C;
        ///<summary>PGI_vertex_hints</summary>
        public const int MAX_VERTEX_HINT_PGI = 0x1A22D;
        ///<summary>PGI_vertex_hints</summary>
        public const int COLOR3_BIT_PGI = 0x00010000;
        ///<summary>PGI_vertex_hints</summary>
        public const int COLOR4_BIT_PGI = 0x00020000;
        ///<summary>PGI_vertex_hints</summary>
        public const int EDGEFLAG_BIT_PGI = 0x00040000;
        ///<summary>PGI_vertex_hints</summary>
        public const int INDEX_BIT_PGI = 0x00080000;
        ///<summary>PGI_vertex_hints</summary>
        public const int MAT_AMBIENT_BIT_PGI = 0x00100000;
        ///<summary>PGI_vertex_hints</summary>
        public const int MAT_AMBIENT_AND_DIFFUSE_BIT_PGI = 0x00200000;
        ///<summary>PGI_vertex_hints</summary>
        public const int MAT_DIFFUSE_BIT_PGI = 0x00400000;
        ///<summary>PGI_vertex_hints</summary>
        public const int MAT_EMISSION_BIT_PGI = 0x00800000;
        ///<summary>PGI_vertex_hints</summary>
        public const int MAT_COLOR_INDEXES_BIT_PGI = 0x01000000;
        ///<summary>PGI_vertex_hints</summary>
        public const int MAT_SHININESS_BIT_PGI = 0x02000000;
        ///<summary>PGI_vertex_hints</summary>
        public const int MAT_SPECULAR_BIT_PGI = 0x04000000;
        ///<summary>PGI_vertex_hints</summary>
        public const int NORMAL_BIT_PGI = 0x08000000;
        ///<summary>PGI_vertex_hints</summary>
        public const int TEXCOORD1_BIT_PGI = 0x10000000;
        ///<summary>PGI_vertex_hints</summary>
        public const int TEXCOORD2_BIT_PGI = 0x20000000;
        ///<summary>PGI_vertex_hints</summary>
        public const int TEXCOORD3_BIT_PGI = 0x40000000;
        ///<summary>PGI_vertex_hints</summary>
        public const int TEXCOORD4_BIT_PGI = unchecked((int)0x80000000);
        ///<summary>PGI_vertex_hints</summary>
        public const int VERTEX23_BIT_PGI = 0x00000004;
        ///<summary>PGI_vertex_hints</summary>
        public const int VERTEX4_BIT_PGI = 0x00000008;
        ///<summary>PGI_misc_hints</summary>
        public const int PREFER_DOUBLEBUFFER_HINT_PGI = 0x1A1F8;
        ///<summary>PGI_misc_hints</summary>
        public const int CONSERVE_MEMORY_HINT_PGI = 0x1A1FD;
        ///<summary>PGI_misc_hints</summary>
        public const int RECLAIM_MEMORY_HINT_PGI = 0x1A1FE;
        ///<summary>PGI_misc_hints</summary>
        public const int NATIVE_GRAPHICS_HANDLE_PGI = 0x1A202;
        ///<summary>PGI_misc_hints</summary>
        public const int NATIVE_GRAPHICS_BEGIN_HINT_PGI = 0x1A203;
        ///<summary>PGI_misc_hints</summary>
        public const int NATIVE_GRAPHICS_END_HINT_PGI = 0x1A204;
        ///<summary>PGI_misc_hints</summary>
        public const int ALWAYS_FAST_HINT_PGI = 0x1A20C;
        ///<summary>PGI_misc_hints</summary>
        public const int ALWAYS_SOFT_HINT_PGI = 0x1A20D;
        ///<summary>PGI_misc_hints</summary>
        public const int ALLOW_DRAW_OBJ_HINT_PGI = 0x1A20E;
        ///<summary>PGI_misc_hints</summary>
        public const int ALLOW_DRAW_WIN_HINT_PGI = 0x1A20F;
        ///<summary>PGI_misc_hints</summary>
        public const int ALLOW_DRAW_FRG_HINT_PGI = 0x1A210;
        ///<summary>PGI_misc_hints</summary>
        public const int ALLOW_DRAW_MEM_HINT_PGI = 0x1A211;
        ///<summary>PGI_misc_hints</summary>
        public const int STRICT_DEPTHFUNC_HINT_PGI = 0x1A216;
        ///<summary>PGI_misc_hints</summary>
        public const int STRICT_LIGHTING_HINT_PGI = 0x1A217;
        ///<summary>PGI_misc_hints</summary>
        public const int STRICT_SCISSOR_HINT_PGI = 0x1A218;
        ///<summary>PGI_misc_hints</summary>
        public const int FULL_STIPPLE_HINT_PGI = 0x1A219;
        ///<summary>PGI_misc_hints</summary>
        public const int CLIP_NEAR_HINT_PGI = 0x1A220;
        ///<summary>PGI_misc_hints</summary>
        public const int CLIP_FAR_HINT_PGI = 0x1A221;
        ///<summary>PGI_misc_hints</summary>
        public const int WIDE_LINE_HINT_PGI = 0x1A222;
        ///<summary>PGI_misc_hints</summary>
        public const int BACK_NORMALS_HINT_PGI = 0x1A223;
        ///<summary>EXT_paletted_texture</summary>
        public const int COLOR_INDEX1_EXT = 0x80E2;
        ///<summary>EXT_paletted_texture</summary>
        public const int COLOR_INDEX2_EXT = 0x80E3;
        ///<summary>EXT_paletted_texture</summary>
        public const int COLOR_INDEX4_EXT = 0x80E4;
        ///<summary>EXT_paletted_texture</summary>
        public const int COLOR_INDEX8_EXT = 0x80E5;
        ///<summary>EXT_paletted_texture</summary>
        public const int COLOR_INDEX12_EXT = 0x80E6;
        ///<summary>EXT_paletted_texture</summary>
        public const int COLOR_INDEX16_EXT = 0x80E7;
        ///<summary>EXT_paletted_texture</summary>
        public const int TEXTURE_INDEX_SIZE_EXT = 0x80ED;
        ///<summary>EXT_clip_volume_hint</summary>
        public const int CLIP_VOLUME_CLIPPING_HINT_EXT = 0x80F0;
        ///<summary>SGIX_list_priority</summary>
        public const int LIST_PRIORITY_SGIX = 0x8182;
        ///<summary>SGIX_ir_instrument1</summary>
        public const int IR_INSTRUMENT1_SGIX = 0x817F;
        ///<summary>SGIX_calligraphic_fragment</summary>
        public const int CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183;
        ///<summary>SGIX_texture_lod_bias</summary>
        public const int TEXTURE_LOD_BIAS_S_SGIX = 0x818E;
        ///<summary>SGIX_texture_lod_bias</summary>
        public const int TEXTURE_LOD_BIAS_T_SGIX = 0x818F;
        ///<summary>SGIX_texture_lod_bias</summary>
        public const int TEXTURE_LOD_BIAS_R_SGIX = 0x8190;
        ///<summary>SGIX_shadow_ambient</summary>
        public const int SHADOW_AMBIENT_SGIX = 0x80BF;
        ///<summary>EXT_index_material</summary>
        public const int INDEX_MATERIAL_EXT = 0x81B8;
        ///<summary>EXT_index_material</summary>
        public const int INDEX_MATERIAL_PARAMETER_EXT = 0x81B9;
        ///<summary>EXT_index_material</summary>
        public const int INDEX_MATERIAL_FACE_EXT = 0x81BA;
        ///<summary>EXT_index_func</summary>
        public const int INDEX_TEST_EXT = 0x81B5;
        ///<summary>EXT_index_func</summary>
        public const int INDEX_TEST_FUNC_EXT = 0x81B6;
        ///<summary>EXT_index_func</summary>
        public const int INDEX_TEST_REF_EXT = 0x81B7;
        ///<summary>EXT_index_array_formats</summary>
        public const int IUI_V2F_EXT = 0x81AD;
        ///<summary>EXT_index_array_formats</summary>
        public const int IUI_V3F_EXT = 0x81AE;
        ///<summary>EXT_index_array_formats</summary>
        public const int IUI_N3F_V2F_EXT = 0x81AF;
        ///<summary>EXT_index_array_formats</summary>
        public const int IUI_N3F_V3F_EXT = 0x81B0;
        ///<summary>EXT_index_array_formats</summary>
        public const int T2F_IUI_V2F_EXT = 0x81B1;
        ///<summary>EXT_index_array_formats</summary>
        public const int T2F_IUI_V3F_EXT = 0x81B2;
        ///<summary>EXT_index_array_formats</summary>
        public const int T2F_IUI_N3F_V2F_EXT = 0x81B3;
        ///<summary>EXT_index_array_formats</summary>
        public const int T2F_IUI_N3F_V3F_EXT = 0x81B4;
        ///<summary>EXT_compiled_vertex_array</summary>
        public const int ARRAY_ELEMENT_LOCK_FIRST_EXT = 0x81A8;
        ///<summary>EXT_compiled_vertex_array</summary>
        public const int ARRAY_ELEMENT_LOCK_COUNT_EXT = 0x81A9;
        ///<summary>EXT_cull_vertex</summary>
        public const int CULL_VERTEX_EXT = 0x81AA;
        ///<summary>EXT_cull_vertex</summary>
        public const int CULL_VERTEX_EYE_POSITION_EXT = 0x81AB;
        ///<summary>EXT_cull_vertex</summary>
        public const int CULL_VERTEX_OBJECT_POSITION_EXT = 0x81AC;
        ///<summary>SGIX_ycrcb</summary>
        public const int YCRCB_422_SGIX = 0x81BB;
        ///<summary>SGIX_ycrcb</summary>
        public const int YCRCB_444_SGIX = 0x81BC;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int FRAGMENT_LIGHTING_SGIX = 0x8400;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int FRAGMENT_COLOR_MATERIAL_FACE_SGIX = 0x8402;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX = 0x8403;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int MAX_FRAGMENT_LIGHTS_SGIX = 0x8404;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int MAX_ACTIVE_LIGHTS_SGIX = 0x8405;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int CURRENT_RASTER_NORMAL_SGIX = 0x8406;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int LIGHT_ENV_MODE_SGIX = 0x8407;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int FRAGMENT_LIGHT0_SGIX = 0x840C;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int FRAGMENT_LIGHT1_SGIX = 0x840D;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int FRAGMENT_LIGHT2_SGIX = 0x840E;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int FRAGMENT_LIGHT3_SGIX = 0x840F;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int FRAGMENT_LIGHT4_SGIX = 0x8410;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int FRAGMENT_LIGHT5_SGIX = 0x8411;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int FRAGMENT_LIGHT6_SGIX = 0x8412;
        ///<summary>SGIX_fragment_lighting</summary>
        public const int FRAGMENT_LIGHT7_SGIX = 0x8413;
        ///<summary>IBM_rasterpos_clip</summary>
        public const int RASTER_POSITION_UNCLIPPED_IBM = 0x19262;
        ///<summary>HP_texture_lighting</summary>
        public const int TEXTURE_LIGHTING_MODE_HP = 0x8167;
        ///<summary>HP_texture_lighting</summary>
        public const int TEXTURE_POST_SPECULAR_HP = 0x8168;
        ///<summary>HP_texture_lighting</summary>
        public const int TEXTURE_PRE_SPECULAR_HP = 0x8169;
        ///<summary>EXT_draw_range_elements</summary>
        public const int MAX_ELEMENTS_VERTICES_EXT = 0x80E8;
        ///<summary>EXT_draw_range_elements</summary>
        public const int MAX_ELEMENTS_INDICES_EXT = 0x80E9;
        ///<summary>WIN_phong_shading</summary>
        public const int PHONG_WIN = 0x80EA;
        ///<summary>WIN_phong_shading</summary>
        public const int PHONG_HINT_WIN = 0x80EB;
        ///<summary>WIN_specular_fog</summary>
        public const int FOG_SPECULAR_TEXTURE_WIN = 0x80EC;
        ///<summary>EXT_light_texture</summary>
        public const int FRAGMENT_MATERIAL_EXT = 0x8349;
        ///<summary>EXT_light_texture</summary>
        public const int FRAGMENT_NORMAL_EXT = 0x834A;
        ///<summary>EXT_light_texture</summary>
        public const int FRAGMENT_COLOR_EXT = 0x834C;
        ///<summary>EXT_light_texture</summary>
        public const int ATTENUATION_EXT = 0x834D;
        ///<summary>EXT_light_texture</summary>
        public const int SHADOW_ATTENUATION_EXT = 0x834E;
        ///<summary>EXT_light_texture</summary>
        public const int TEXTURE_APPLICATION_MODE_EXT = 0x834F;
        ///<summary>EXT_light_texture</summary>
        public const int TEXTURE_LIGHT_EXT = 0x8350;
        ///<summary>EXT_light_texture</summary>
        public const int TEXTURE_MATERIAL_FACE_EXT = 0x8351;
        ///<summary>EXT_light_texture</summary>
        public const int TEXTURE_MATERIAL_PARAMETER_EXT = 0x8352;
        ///<summary>SGIX_blend_alpha_minmax</summary>
        public const int ALPHA_MIN_SGIX = 0x8320;
        ///<summary>SGIX_blend_alpha_minmax</summary>
        public const int ALPHA_MAX_SGIX = 0x8321;
        ///<summary>SGIX_impact_pixel_texture</summary>
        public const int PIXEL_TEX_GEN_Q_CEILING_SGIX = 0x8184;
        ///<summary>SGIX_impact_pixel_texture</summary>
        public const int PIXEL_TEX_GEN_Q_ROUND_SGIX = 0x8185;
        ///<summary>SGIX_impact_pixel_texture</summary>
        public const int PIXEL_TEX_GEN_Q_FLOOR_SGIX = 0x8186;
        ///<summary>SGIX_impact_pixel_texture</summary>
        public const int PIXEL_TEX_GEN_ALPHA_REPLACE_SGIX = 0x8187;
        ///<summary>SGIX_impact_pixel_texture</summary>
        public const int PIXEL_TEX_GEN_ALPHA_NO_REPLACE_SGIX = 0x8188;
        ///<summary>SGIX_impact_pixel_texture</summary>
        public const int PIXEL_TEX_GEN_ALPHA_LS_SGIX = 0x8189;
        ///<summary>SGIX_impact_pixel_texture</summary>
        public const int PIXEL_TEX_GEN_ALPHA_MS_SGIX = 0x818A;
        ///<summary>EXT_bgra</summary>
        public const int BGR_EXT = 0x80E0;
        ///<summary>EXT_bgra</summary>
        public const int BGRA_EXT = 0x80E1;
        ///<summary>SGIX_async</summary>
        public const int ASYNC_MARKER_SGIX = 0x8329;
        ///<summary>SGIX_async_pixel</summary>
        public const int ASYNC_TEX_IMAGE_SGIX = 0x835C;
        ///<summary>SGIX_async_pixel</summary>
        public const int ASYNC_DRAW_PIXELS_SGIX = 0x835D;
        ///<summary>SGIX_async_pixel</summary>
        public const int ASYNC_READ_PIXELS_SGIX = 0x835E;
        ///<summary>SGIX_async_pixel</summary>
        public const int MAX_ASYNC_TEX_IMAGE_SGIX = 0x835F;
        ///<summary>SGIX_async_pixel</summary>
        public const int MAX_ASYNC_DRAW_PIXELS_SGIX = 0x8360;
        ///<summary>SGIX_async_pixel</summary>
        public const int MAX_ASYNC_READ_PIXELS_SGIX = 0x8361;
        ///<summary>SGIX_async_histogram</summary>
        public const int ASYNC_HISTOGRAM_SGIX = 0x832C;
        ///<summary>SGIX_async_histogram</summary>
        public const int MAX_ASYNC_HISTOGRAM_SGIX = 0x832D;
        ///<summary>INTEL_parallel_arrays</summary>
        public const int PARALLEL_ARRAYS_INTEL = 0x83F4;
        ///<summary>INTEL_parallel_arrays</summary>
        public const int VERTEX_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F5;
        ///<summary>INTEL_parallel_arrays</summary>
        public const int NORMAL_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F6;
        ///<summary>INTEL_parallel_arrays</summary>
        public const int COLOR_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F7;
        ///<summary>INTEL_parallel_arrays</summary>
        public const int TEXTURE_COORD_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F8;
        ///<summary>HP_occlusion_test</summary>
        public const int OCCLUSION_TEST_HP = 0x8165;
        ///<summary>HP_occlusion_test</summary>
        public const int OCCLUSION_TEST_RESULT_HP = 0x8166;
        ///<summary>EXT_pixel_transform</summary>
        public const int PIXEL_TRANSFORM_2D_EXT = 0x8330;
        ///<summary>EXT_pixel_transform</summary>
        public const int PIXEL_MAG_FILTER_EXT = 0x8331;
        ///<summary>EXT_pixel_transform</summary>
        public const int PIXEL_MIN_FILTER_EXT = 0x8332;
        ///<summary>EXT_pixel_transform</summary>
        public const int PIXEL_CUBIC_WEIGHT_EXT = 0x8333;
        ///<summary>EXT_pixel_transform</summary>
        public const int CUBIC_EXT = 0x8334;
        ///<summary>EXT_pixel_transform</summary>
        public const int AVERAGE_EXT = 0x8335;
        ///<summary>EXT_pixel_transform</summary>
        public const int PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8336;
        ///<summary>EXT_pixel_transform</summary>
        public const int MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8337;
        ///<summary>EXT_pixel_transform</summary>
        public const int PIXEL_TRANSFORM_2D_MATRIX_EXT = 0x8338;
        ///<summary>EXT_shared_texture_palette</summary>
        public const int SHARED_TEXTURE_PALETTE_EXT = 0x81FB;
        ///<summary>EXT_separate_specular_color</summary>
        public const int LIGHT_MODEL_COLOR_CONTROL_EXT = 0x81F8;
        ///<summary>EXT_separate_specular_color</summary>
        public const int SINGLE_COLOR_EXT = 0x81F9;
        ///<summary>EXT_separate_specular_color</summary>
        public const int SEPARATE_SPECULAR_COLOR_EXT = 0x81FA;
        ///<summary>EXT_secondary_color</summary>
        public const int COLOR_SUM_EXT = 0x8458;
        ///<summary>EXT_secondary_color</summary>
        public const int CURRENT_SECONDARY_COLOR_EXT = 0x8459;
        ///<summary>EXT_secondary_color</summary>
        public const int SECONDARY_COLOR_ARRAY_SIZE_EXT = 0x845A;
        ///<summary>EXT_secondary_color</summary>
        public const int SECONDARY_COLOR_ARRAY_TYPE_EXT = 0x845B;
        ///<summary>EXT_secondary_color</summary>
        public const int SECONDARY_COLOR_ARRAY_STRIDE_EXT = 0x845C;
        ///<summary>EXT_secondary_color</summary>
        public const int SECONDARY_COLOR_ARRAY_POINTER_EXT = 0x845D;
        ///<summary>EXT_secondary_color</summary>
        public const int SECONDARY_COLOR_ARRAY_EXT = 0x845E;
        ///<summary>EXT_texture_perturb_normal</summary>
        public const int PERTURB_EXT = 0x85AE;
        ///<summary>EXT_texture_perturb_normal</summary>
        public const int TEXTURE_NORMAL_EXT = 0x85AF;
        ///<summary>EXT_fog_coord</summary>
        public const int FOG_COORDINATE_SOURCE_EXT = 0x8450;
        ///<summary>EXT_fog_coord</summary>
        public const int FOG_COORDINATE_EXT = 0x8451;
        ///<summary>EXT_fog_coord</summary>
        public const int FRAGMENT_DEPTH_EXT = 0x8452;
        ///<summary>EXT_fog_coord</summary>
        public const int CURRENT_FOG_COORDINATE_EXT = 0x8453;
        ///<summary>EXT_fog_coord</summary>
        public const int FOG_COORDINATE_ARRAY_TYPE_EXT = 0x8454;
        ///<summary>EXT_fog_coord</summary>
        public const int FOG_COORDINATE_ARRAY_STRIDE_EXT = 0x8455;
        ///<summary>EXT_fog_coord</summary>
        public const int FOG_COORDINATE_ARRAY_POINTER_EXT = 0x8456;
        ///<summary>EXT_fog_coord</summary>
        public const int FOG_COORDINATE_ARRAY_EXT = 0x8457;
        ///<summary>REND_screen_coordinates</summary>
        public const int SCREEN_COORDINATES_REND = 0x8490;
        ///<summary>REND_screen_coordinates</summary>
        public const int INVERTED_SCREEN_W_REND = 0x8491;
        ///<summary>EXT_coordinate_frame</summary>
        public const int TANGENT_ARRAY_EXT = 0x8439;
        ///<summary>EXT_coordinate_frame</summary>
        public const int BINORMAL_ARRAY_EXT = 0x843A;
        ///<summary>EXT_coordinate_frame</summary>
        public const int CURRENT_TANGENT_EXT = 0x843B;
        ///<summary>EXT_coordinate_frame</summary>
        public const int CURRENT_BINORMAL_EXT = 0x843C;
        ///<summary>EXT_coordinate_frame</summary>
        public const int TANGENT_ARRAY_TYPE_EXT = 0x843E;
        ///<summary>EXT_coordinate_frame</summary>
        public const int TANGENT_ARRAY_STRIDE_EXT = 0x843F;
        ///<summary>EXT_coordinate_frame</summary>
        public const int BINORMAL_ARRAY_TYPE_EXT = 0x8440;
        ///<summary>EXT_coordinate_frame</summary>
        public const int BINORMAL_ARRAY_STRIDE_EXT = 0x8441;
        ///<summary>EXT_coordinate_frame</summary>
        public const int TANGENT_ARRAY_POINTER_EXT = 0x8442;
        ///<summary>EXT_coordinate_frame</summary>
        public const int BINORMAL_ARRAY_POINTER_EXT = 0x8443;
        ///<summary>EXT_coordinate_frame</summary>
        public const int MAP1_TANGENT_EXT = 0x8444;
        ///<summary>EXT_coordinate_frame</summary>
        public const int MAP2_TANGENT_EXT = 0x8445;
        ///<summary>EXT_coordinate_frame</summary>
        public const int MAP1_BINORMAL_EXT = 0x8446;
        ///<summary>EXT_coordinate_frame</summary>
        public const int MAP2_BINORMAL_EXT = 0x8447;
        ///<summary>EXT_texture_env_combine</summary>
        public const int COMBINE_EXT = 0x8570;
        ///<summary>EXT_texture_env_combine</summary>
        public const int COMBINE_RGB_EXT = 0x8571;
        ///<summary>EXT_texture_env_combine</summary>
        public const int COMBINE_ALPHA_EXT = 0x8572;
        ///<summary>EXT_texture_env_combine</summary>
        public const int RGB_SCALE_EXT = 0x8573;
        ///<summary>EXT_texture_env_combine</summary>
        public const int ADD_SIGNED_EXT = 0x8574;
        ///<summary>EXT_texture_env_combine</summary>
        public const int INTERPOLATE_EXT = 0x8575;
        ///<summary>EXT_texture_env_combine</summary>
        public const int CONSTANT_EXT = 0x8576;
        ///<summary>EXT_texture_env_combine</summary>
        public const int PRIMARY_COLOR_EXT = 0x8577;
        ///<summary>EXT_texture_env_combine</summary>
        public const int PREVIOUS_EXT = 0x8578;
        ///<summary>EXT_texture_env_combine</summary>
        public const int SOURCE0_RGB_EXT = 0x8580;
        ///<summary>EXT_texture_env_combine</summary>
        public const int SOURCE1_RGB_EXT = 0x8581;
        ///<summary>EXT_texture_env_combine</summary>
        public const int SOURCE2_RGB_EXT = 0x8582;
        ///<summary>EXT_texture_env_combine</summary>
        public const int SOURCE0_ALPHA_EXT = 0x8588;
        ///<summary>EXT_texture_env_combine</summary>
        public const int SOURCE1_ALPHA_EXT = 0x8589;
        ///<summary>EXT_texture_env_combine</summary>
        public const int SOURCE2_ALPHA_EXT = 0x858A;
        ///<summary>EXT_texture_env_combine</summary>
        public const int OPERAND0_RGB_EXT = 0x8590;
        ///<summary>EXT_texture_env_combine</summary>
        public const int OPERAND1_RGB_EXT = 0x8591;
        ///<summary>EXT_texture_env_combine</summary>
        public const int OPERAND2_RGB_EXT = 0x8592;
        ///<summary>EXT_texture_env_combine</summary>
        public const int OPERAND0_ALPHA_EXT = 0x8598;
        ///<summary>EXT_texture_env_combine</summary>
        public const int OPERAND1_ALPHA_EXT = 0x8599;
        ///<summary>EXT_texture_env_combine</summary>
        public const int OPERAND2_ALPHA_EXT = 0x859A;
        ///<summary>APPLE_specular_vector</summary>
        public const int LIGHT_MODEL_SPECULAR_VECTOR_APPLE = 0x85B0;
        ///<summary>APPLE_transform_hint</summary>
        public const int TRANSFORM_HINT_APPLE = 0x85B1;
        ///<summary>SGIX_fog_scale</summary>
        public const int FOG_SCALE_SGIX = 0x81FC;
        ///<summary>SGIX_fog_scale</summary>
        public const int FOG_SCALE_VALUE_SGIX = 0x81FD;
        ///<summary>SUNX_constant_data</summary>
        public const int UNPACK_CONSTANT_DATA_SUNX = 0x81D5;
        ///<summary>SUNX_constant_data</summary>
        public const int TEXTURE_CONSTANT_DATA_SUNX = 0x81D6;
        ///<summary>SUN_global_alpha</summary>
        public const int GLOBAL_ALPHA_SUN = 0x81D9;
        ///<summary>SUN_global_alpha</summary>
        public const int GLOBAL_ALPHA_FACTOR_SUN = 0x81DA;
        ///<summary>SUN_triangle_list</summary>
        public const int RESTART_SUN = 0x0001;
        ///<summary>SUN_triangle_list</summary>
        public const int REPLACE_MIDDLE_SUN = 0x0002;
        ///<summary>SUN_triangle_list</summary>
        public const int REPLACE_OLDEST_SUN = 0x0003;
        ///<summary>SUN_triangle_list</summary>
        public const int TRIANGLE_LIST_SUN = 0x81D7;
        ///<summary>SUN_triangle_list</summary>
        public const int REPLACEMENT_CODE_SUN = 0x81D8;
        ///<summary>SUN_triangle_list</summary>
        public const int REPLACEMENT_CODE_ARRAY_SUN = 0x85C0;
        ///<summary>SUN_triangle_list</summary>
        public const int REPLACEMENT_CODE_ARRAY_TYPE_SUN = 0x85C1;
        ///<summary>SUN_triangle_list</summary>
        public const int REPLACEMENT_CODE_ARRAY_STRIDE_SUN = 0x85C2;
        ///<summary>SUN_triangle_list</summary>
        public const int REPLACEMENT_CODE_ARRAY_POINTER_SUN = 0x85C3;
        ///<summary>SUN_triangle_list</summary>
        public const int R1UI_V3F_SUN = 0x85C4;
        ///<summary>SUN_triangle_list</summary>
        public const int R1UI_C4UB_V3F_SUN = 0x85C5;
        ///<summary>SUN_triangle_list</summary>
        public const int R1UI_C3F_V3F_SUN = 0x85C6;
        ///<summary>SUN_triangle_list</summary>
        public const int R1UI_N3F_V3F_SUN = 0x85C7;
        ///<summary>SUN_triangle_list</summary>
        public const int R1UI_C4F_N3F_V3F_SUN = 0x85C8;
        ///<summary>SUN_triangle_list</summary>
        public const int R1UI_T2F_V3F_SUN = 0x85C9;
        ///<summary>SUN_triangle_list</summary>
        public const int R1UI_T2F_N3F_V3F_SUN = 0x85CA;
        ///<summary>SUN_triangle_list</summary>
        public const int R1UI_T2F_C4F_N3F_V3F_SUN = 0x85CB;
        ///<summary>EXT_blend_func_separate</summary>
        public const int BLEND_DST_RGB_EXT = 0x80C8;
        ///<summary>EXT_blend_func_separate</summary>
        public const int BLEND_SRC_RGB_EXT = 0x80C9;
        ///<summary>EXT_blend_func_separate</summary>
        public const int BLEND_DST_ALPHA_EXT = 0x80CA;
        ///<summary>EXT_blend_func_separate</summary>
        public const int BLEND_SRC_ALPHA_EXT = 0x80CB;
        ///<summary>INGR_color_clamp</summary>
        public const int RED_MIN_CLAMP_INGR = 0x8560;
        ///<summary>INGR_color_clamp</summary>
        public const int GREEN_MIN_CLAMP_INGR = 0x8561;
        ///<summary>INGR_color_clamp</summary>
        public const int BLUE_MIN_CLAMP_INGR = 0x8562;
        ///<summary>INGR_color_clamp</summary>
        public const int ALPHA_MIN_CLAMP_INGR = 0x8563;
        ///<summary>INGR_color_clamp</summary>
        public const int RED_MAX_CLAMP_INGR = 0x8564;
        ///<summary>INGR_color_clamp</summary>
        public const int GREEN_MAX_CLAMP_INGR = 0x8565;
        ///<summary>INGR_color_clamp</summary>
        public const int BLUE_MAX_CLAMP_INGR = 0x8566;
        ///<summary>INGR_color_clamp</summary>
        public const int ALPHA_MAX_CLAMP_INGR = 0x8567;
        ///<summary>INGR_interlace_read</summary>
        public const int INTERLACE_READ_INGR = 0x8568;
        ///<summary>EXT_stencil_wrap</summary>
        public const int INCR_WRAP_EXT = 0x8507;
        ///<summary>EXT_stencil_wrap</summary>
        public const int DECR_WRAP_EXT = 0x8508;
        ///<summary>EXT_422_pixels</summary>
        public const int _422_EXT = 0x80CC;
        ///<summary>EXT_422_pixels</summary>
        public const int _422_REV_EXT = 0x80CD;
        ///<summary>EXT_422_pixels</summary>
        public const int _422_AVERAGE_EXT = 0x80CE;
        ///<summary>EXT_422_pixels</summary>
        public const int _422_REV_AVERAGE_EXT = 0x80CF;
        ///<summary>NV_texgen_reflection</summary>
        public const int NORMAL_MAP_NV = 0x8511;
        ///<summary>NV_texgen_reflection</summary>
        public const int REFLECTION_MAP_NV = 0x8512;
        ///<summary>EXT_texture_cube_map</summary>
        public const int NORMAL_MAP_EXT = 0x8511;
        ///<summary>EXT_texture_cube_map</summary>
        public const int REFLECTION_MAP_EXT = 0x8512;
        ///<summary>EXT_texture_cube_map</summary>
        public const int TEXTURE_CUBE_MAP_EXT = 0x8513;
        ///<summary>EXT_texture_cube_map</summary>
        public const int TEXTURE_BINDING_CUBE_MAP_EXT = 0x8514;
        ///<summary>EXT_texture_cube_map</summary>
        public const int TEXTURE_CUBE_MAP_POSITIVE_X_EXT = 0x8515;
        ///<summary>EXT_texture_cube_map</summary>
        public const int TEXTURE_CUBE_MAP_NEGATIVE_X_EXT = 0x8516;
        ///<summary>EXT_texture_cube_map</summary>
        public const int TEXTURE_CUBE_MAP_POSITIVE_Y_EXT = 0x8517;
        ///<summary>EXT_texture_cube_map</summary>
        public const int TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT = 0x8518;
        ///<summary>EXT_texture_cube_map</summary>
        public const int TEXTURE_CUBE_MAP_POSITIVE_Z_EXT = 0x8519;
        ///<summary>EXT_texture_cube_map</summary>
        public const int TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT = 0x851A;
        ///<summary>EXT_texture_cube_map</summary>
        public const int PROXY_TEXTURE_CUBE_MAP_EXT = 0x851B;
        ///<summary>EXT_texture_cube_map</summary>
        public const int MAX_CUBE_MAP_TEXTURE_SIZE_EXT = 0x851C;
        ///<summary>SUN_convolution_border_modes</summary>
        public const int WRAP_BORDER_SUN = 0x81D4;
        ///<summary>EXT_texture_lod_bias</summary>
        public const int MAX_TEXTURE_LOD_BIAS_EXT = 0x84FD;
        ///<summary>EXT_texture_lod_bias</summary>
        public const int TEXTURE_FILTER_CONTROL_EXT = 0x8500;
        ///<summary>EXT_texture_lod_bias</summary>
        public const int TEXTURE_LOD_BIAS_EXT = 0x8501;
        ///<summary>EXT_texture_filter_anisotropic</summary>
        public const int TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE;
        ///<summary>EXT_texture_filter_anisotropic</summary>
        public const int MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF;
        ///<summary>EXT_vertex_weighting</summary>
        public const int MODELVIEW0_STACK_DEPTH_EXT = 0x0BA3;
        ///<summary>EXT_vertex_weighting</summary>
        public const int MODELVIEW1_STACK_DEPTH_EXT = 0x8502;
        ///<summary>EXT_vertex_weighting</summary>
        public const int MODELVIEW0_MATRIX_EXT = 0x0BA6;
        ///<summary>EXT_vertex_weighting</summary>
        public const int MODELVIEW1_MATRIX_EXT = 0x8506;
        ///<summary>EXT_vertex_weighting</summary>
        public const int VERTEX_WEIGHTING_EXT = 0x8509;
        ///<summary>EXT_vertex_weighting</summary>
        public const int MODELVIEW0_EXT = 0x1700;
        ///<summary>EXT_vertex_weighting</summary>
        public const int MODELVIEW1_EXT = 0x850A;
        ///<summary>EXT_vertex_weighting</summary>
        public const int CURRENT_VERTEX_WEIGHT_EXT = 0x850B;
        ///<summary>EXT_vertex_weighting</summary>
        public const int VERTEX_WEIGHT_ARRAY_EXT = 0x850C;
        ///<summary>EXT_vertex_weighting</summary>
        public const int VERTEX_WEIGHT_ARRAY_SIZE_EXT = 0x850D;
        ///<summary>EXT_vertex_weighting</summary>
        public const int VERTEX_WEIGHT_ARRAY_TYPE_EXT = 0x850E;
        ///<summary>EXT_vertex_weighting</summary>
        public const int VERTEX_WEIGHT_ARRAY_STRIDE_EXT = 0x850F;
        ///<summary>EXT_vertex_weighting</summary>
        public const int VERTEX_WEIGHT_ARRAY_POINTER_EXT = 0x8510;
        ///<summary>NV_light_max_exponent</summary>
        public const int MAX_SHININESS_NV = 0x8504;
        ///<summary>NV_light_max_exponent</summary>
        public const int MAX_SPOT_EXPONENT_NV = 0x8505;
        ///<summary>NV_vertex_array_range</summary>
        public const int VERTEX_ARRAY_RANGE_NV = 0x851D;
        ///<summary>NV_vertex_array_range</summary>
        public const int VERTEX_ARRAY_RANGE_LENGTH_NV = 0x851E;
        ///<summary>NV_vertex_array_range</summary>
        public const int VERTEX_ARRAY_RANGE_VALID_NV = 0x851F;
        ///<summary>NV_vertex_array_range</summary>
        public const int MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV = 0x8520;
        ///<summary>NV_vertex_array_range</summary>
        public const int VERTEX_ARRAY_RANGE_POINTER_NV = 0x8521;
        ///<summary>NV_register_combiners</summary>
        public const int REGISTER_COMBINERS_NV = 0x8522;
        ///<summary>NV_register_combiners</summary>
        public const int VARIABLE_A_NV = 0x8523;
        ///<summary>NV_register_combiners</summary>
        public const int VARIABLE_B_NV = 0x8524;
        ///<summary>NV_register_combiners</summary>
        public const int VARIABLE_C_NV = 0x8525;
        ///<summary>NV_register_combiners</summary>
        public const int VARIABLE_D_NV = 0x8526;
        ///<summary>NV_register_combiners</summary>
        public const int VARIABLE_E_NV = 0x8527;
        ///<summary>NV_register_combiners</summary>
        public const int VARIABLE_F_NV = 0x8528;
        ///<summary>NV_register_combiners</summary>
        public const int VARIABLE_G_NV = 0x8529;
        ///<summary>NV_register_combiners</summary>
        public const int CONSTANT_COLOR0_NV = 0x852A;
        ///<summary>NV_register_combiners</summary>
        public const int CONSTANT_COLOR1_NV = 0x852B;
        ///<summary>NV_register_combiners</summary>
        public const int PRIMARY_COLOR_NV = 0x852C;
        ///<summary>NV_register_combiners</summary>
        public const int SECONDARY_COLOR_NV = 0x852D;
        ///<summary>NV_register_combiners</summary>
        public const int SPARE0_NV = 0x852E;
        ///<summary>NV_register_combiners</summary>
        public const int SPARE1_NV = 0x852F;
        ///<summary>NV_register_combiners</summary>
        public const int DISCARD_NV = 0x8530;
        ///<summary>NV_register_combiners</summary>
        public const int E_TIMES_F_NV = 0x8531;
        ///<summary>NV_register_combiners</summary>
        public const int SPARE0_PLUS_SECONDARY_COLOR_NV = 0x8532;
        ///<summary>NV_register_combiners</summary>
        public const int UNSIGNED_IDENTITY_NV = 0x8536;
        ///<summary>NV_register_combiners</summary>
        public const int UNSIGNED_INVERT_NV = 0x8537;
        ///<summary>NV_register_combiners</summary>
        public const int EXPAND_NORMAL_NV = 0x8538;
        ///<summary>NV_register_combiners</summary>
        public const int EXPAND_NEGATE_NV = 0x8539;
        ///<summary>NV_register_combiners</summary>
        public const int HALF_BIAS_NORMAL_NV = 0x853A;
        ///<summary>NV_register_combiners</summary>
        public const int HALF_BIAS_NEGATE_NV = 0x853B;
        ///<summary>NV_register_combiners</summary>
        public const int SIGNED_IDENTITY_NV = 0x853C;
        ///<summary>NV_register_combiners</summary>
        public const int SIGNED_NEGATE_NV = 0x853D;
        ///<summary>NV_register_combiners</summary>
        public const int SCALE_BY_TWO_NV = 0x853E;
        ///<summary>NV_register_combiners</summary>
        public const int SCALE_BY_FOUR_NV = 0x853F;
        ///<summary>NV_register_combiners</summary>
        public const int SCALE_BY_ONE_HALF_NV = 0x8540;
        ///<summary>NV_register_combiners</summary>
        public const int BIAS_BY_NEGATIVE_ONE_HALF_NV = 0x8541;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER_INPUT_NV = 0x8542;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER_MAPPING_NV = 0x8543;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER_COMPONENT_USAGE_NV = 0x8544;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER_AB_DOT_PRODUCT_NV = 0x8545;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER_CD_DOT_PRODUCT_NV = 0x8546;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER_MUX_SUM_NV = 0x8547;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER_SCALE_NV = 0x8548;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER_BIAS_NV = 0x8549;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER_AB_OUTPUT_NV = 0x854A;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER_CD_OUTPUT_NV = 0x854B;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER_SUM_OUTPUT_NV = 0x854C;
        ///<summary>NV_register_combiners</summary>
        public const int MAX_GENERAL_COMBINERS_NV = 0x854D;
        ///<summary>NV_register_combiners</summary>
        public const int NUM_GENERAL_COMBINERS_NV = 0x854E;
        ///<summary>NV_register_combiners</summary>
        public const int COLOR_SUM_CLAMP_NV = 0x854F;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER0_NV = 0x8550;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER1_NV = 0x8551;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER2_NV = 0x8552;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER3_NV = 0x8553;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER4_NV = 0x8554;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER5_NV = 0x8555;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER6_NV = 0x8556;
        ///<summary>NV_register_combiners</summary>
        public const int COMBINER7_NV = 0x8557;
        ///<summary>NV_fog_distance</summary>
        public const int FOG_DISTANCE_MODE_NV = 0x855A;
        ///<summary>NV_fog_distance</summary>
        public const int EYE_RADIAL_NV = 0x855B;
        ///<summary>NV_fog_distance</summary>
        public const int EYE_PLANE_ABSOLUTE_NV = 0x855C;
        ///<summary>NV_texgen_emboss</summary>
        public const int EMBOSS_LIGHT_NV = 0x855D;
        ///<summary>NV_texgen_emboss</summary>
        public const int EMBOSS_CONSTANT_NV = 0x855E;
        ///<summary>NV_texgen_emboss</summary>
        public const int EMBOSS_MAP_NV = 0x855F;
        ///<summary>NV_texture_env_combine4</summary>
        public const int COMBINE4_NV = 0x8503;
        ///<summary>NV_texture_env_combine4</summary>
        public const int SOURCE3_RGB_NV = 0x8583;
        ///<summary>NV_texture_env_combine4</summary>
        public const int SOURCE3_ALPHA_NV = 0x858B;
        ///<summary>NV_texture_env_combine4</summary>
        public const int OPERAND3_RGB_NV = 0x8593;
        ///<summary>NV_texture_env_combine4</summary>
        public const int OPERAND3_ALPHA_NV = 0x859B;
        ///<summary>EXT_texture_compression_s3tc</summary>
        public const int COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0;
        ///<summary>EXT_texture_compression_s3tc</summary>
        public const int COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1;
        ///<summary>EXT_texture_compression_s3tc</summary>
        public const int COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2;
        ///<summary>EXT_texture_compression_s3tc</summary>
        public const int COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3;
        ///<summary>IBM_cull_vertex</summary>
        public const int CULL_VERTEX_IBM = 103050;
        ///<summary>IBM_vertex_array_lists</summary>
        public const int VERTEX_ARRAY_LIST_IBM = 103070;
        ///<summary>IBM_vertex_array_lists</summary>
        public const int NORMAL_ARRAY_LIST_IBM = 103071;
        ///<summary>IBM_vertex_array_lists</summary>
        public const int COLOR_ARRAY_LIST_IBM = 103072;
        ///<summary>IBM_vertex_array_lists</summary>
        public const int INDEX_ARRAY_LIST_IBM = 103073;
        ///<summary>IBM_vertex_array_lists</summary>
        public const int TEXTURE_COORD_ARRAY_LIST_IBM = 103074;
        ///<summary>IBM_vertex_array_lists</summary>
        public const int EDGE_FLAG_ARRAY_LIST_IBM = 103075;
        ///<summary>IBM_vertex_array_lists</summary>
        public const int FOG_COORDINATE_ARRAY_LIST_IBM = 103076;
        ///<summary>IBM_vertex_array_lists</summary>
        public const int SECONDARY_COLOR_ARRAY_LIST_IBM = 103077;
        ///<summary>IBM_vertex_array_lists</summary>
        public const int VERTEX_ARRAY_LIST_STRIDE_IBM = 103080;
        ///<summary>IBM_vertex_array_lists</summary>
        public const int NORMAL_ARRAY_LIST_STRIDE_IBM = 103081;
        ///<summary>IBM_vertex_array_lists</summary>
        public const int COLOR_ARRAY_LIST_STRIDE_IBM = 103082;
        ///<summary>IBM_vertex_array_lists</summary>
        public const int INDEX_ARRAY_LIST_STRIDE_IBM = 103083;
        ///<summary>IBM_vertex_array_lists</summary>
        public const int TEXTURE_COORD_ARRAY_LIST_STRIDE_IBM = 103084;
        ///<summary>IBM_vertex_array_lists</summary>
        public const int EDGE_FLAG_ARRAY_LIST_STRIDE_IBM = 103085;
        ///<summary>IBM_vertex_array_lists</summary>
        public const int FOG_COORDINATE_ARRAY_LIST_STRIDE_IBM = 103086;
        ///<summary>IBM_vertex_array_lists</summary>
        public const int SECONDARY_COLOR_ARRAY_LIST_STRIDE_IBM = 103087;
        ///<summary>SGIX_subsample</summary>
        public const int PACK_SUBSAMPLE_RATE_SGIX = 0x85A0;
        ///<summary>SGIX_subsample</summary>
        public const int UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1;
        ///<summary>SGIX_subsample</summary>
        public const int PIXEL_SUBSAMPLE_4444_SGIX = 0x85A2;
        ///<summary>SGIX_subsample</summary>
        public const int PIXEL_SUBSAMPLE_2424_SGIX = 0x85A3;
        ///<summary>SGIX_subsample</summary>
        public const int PIXEL_SUBSAMPLE_4242_SGIX = 0x85A4;
        ///<summary>SGIX_ycrcba</summary>
        public const int YCRCB_SGIX = 0x8318;
        ///<summary>SGIX_ycrcba</summary>
        public const int YCRCBA_SGIX = 0x8319;
        ///<summary>SGI_depth_pass_instrument</summary>
        public const int DEPTH_PASS_INSTRUMENT_SGIX = 0x8310;
        ///<summary>SGI_depth_pass_instrument</summary>
        public const int DEPTH_PASS_INSTRUMENT_COUNTERS_SGIX = 0x8311;
        ///<summary>SGI_depth_pass_instrument</summary>
        public const int DEPTH_PASS_INSTRUMENT_MAX_SGIX = 0x8312;
        ///<summary>3DFX_texture_compression_FXT1</summary>
        public const int COMPRESSED_RGB_FXT1_3DFX = 0x86B0;
        ///<summary>3DFX_texture_compression_FXT1</summary>
        public const int COMPRESSED_RGBA_FXT1_3DFX = 0x86B1;
        ///<summary>3DFX_multisample</summary>
        public const int MULTISAMPLE_3DFX = 0x86B2;
        ///<summary>3DFX_multisample</summary>
        public const int SAMPLE_BUFFERS_3DFX = 0x86B3;
        ///<summary>3DFX_multisample</summary>
        public const int SAMPLES_3DFX = 0x86B4;
        ///<summary>3DFX_multisample</summary>
        public const int MULTISAMPLE_BIT_3DFX = 0x20000000;
        ///<summary>EXT_multisample</summary>
        public const int MULTISAMPLE_EXT = 0x809D;
        ///<summary>EXT_multisample</summary>
        public const int SAMPLE_ALPHA_TO_MASK_EXT = 0x809E;
        ///<summary>EXT_multisample</summary>
        public const int SAMPLE_ALPHA_TO_ONE_EXT = 0x809F;
        ///<summary>EXT_multisample</summary>
        public const int SAMPLE_MASK_EXT = 0x80A0;
        ///<summary>EXT_multisample</summary>
        public const int _1PASS_EXT = 0x80A1;
        ///<summary>EXT_multisample</summary>
        public const int _2PASS_0_EXT = 0x80A2;
        ///<summary>EXT_multisample</summary>
        public const int _2PASS_1_EXT = 0x80A3;
        ///<summary>EXT_multisample</summary>
        public const int _4PASS_0_EXT = 0x80A4;
        ///<summary>EXT_multisample</summary>
        public const int _4PASS_1_EXT = 0x80A5;
        ///<summary>EXT_multisample</summary>
        public const int _4PASS_2_EXT = 0x80A6;
        ///<summary>EXT_multisample</summary>
        public const int _4PASS_3_EXT = 0x80A7;
        ///<summary>EXT_multisample</summary>
        public const int SAMPLE_BUFFERS_EXT = 0x80A8;
        ///<summary>EXT_multisample</summary>
        public const int SAMPLES_EXT = 0x80A9;
        ///<summary>EXT_multisample</summary>
        public const int SAMPLE_MASK_VALUE_EXT = 0x80AA;
        ///<summary>EXT_multisample</summary>
        public const int SAMPLE_MASK_INVERT_EXT = 0x80AB;
        ///<summary>EXT_multisample</summary>
        public const int SAMPLE_PATTERN_EXT = 0x80AC;
        ///<summary>EXT_multisample</summary>
        public const int MULTISAMPLE_BIT_EXT = 0x20000000;
        ///<summary>SGIX_vertex_preclip</summary>
        public const int VERTEX_PRECLIP_SGIX = 0x83EE;
        ///<summary>SGIX_vertex_preclip</summary>
        public const int VERTEX_PRECLIP_HINT_SGIX = 0x83EF;
        ///<summary>SGIX_convolution_accuracy</summary>
        public const int CONVOLUTION_HINT_SGIX = 0x8316;
        ///<summary>SGIX_resample</summary>
        public const int PACK_RESAMPLE_SGIX = 0x842C;
        ///<summary>SGIX_resample</summary>
        public const int UNPACK_RESAMPLE_SGIX = 0x842D;
        ///<summary>SGIX_resample</summary>
        public const int RESAMPLE_REPLICATE_SGIX = 0x842E;
        ///<summary>SGIX_resample</summary>
        public const int RESAMPLE_ZERO_FILL_SGIX = 0x842F;
        ///<summary>SGIX_resample</summary>
        public const int RESAMPLE_DECIMATE_SGIX = 0x8430;
        ///<summary>SGIS_point_line_texgen</summary>
        public const int EYE_DISTANCE_TO_POINT_SGIS = 0x81F0;
        ///<summary>SGIS_point_line_texgen</summary>
        public const int OBJECT_DISTANCE_TO_POINT_SGIS = 0x81F1;
        ///<summary>SGIS_point_line_texgen</summary>
        public const int EYE_DISTANCE_TO_LINE_SGIS = 0x81F2;
        ///<summary>SGIS_point_line_texgen</summary>
        public const int OBJECT_DISTANCE_TO_LINE_SGIS = 0x81F3;
        ///<summary>SGIS_point_line_texgen</summary>
        public const int EYE_POINT_SGIS = 0x81F4;
        ///<summary>SGIS_point_line_texgen</summary>
        public const int OBJECT_POINT_SGIS = 0x81F5;
        ///<summary>SGIS_point_line_texgen</summary>
        public const int EYE_LINE_SGIS = 0x81F6;
        ///<summary>SGIS_point_line_texgen</summary>
        public const int OBJECT_LINE_SGIS = 0x81F7;
        ///<summary>SGIS_texture_color_mask</summary>
        public const int TEXTURE_COLOR_WRITEMASK_SGIS = 0x81EF;
        ///<summary>EXT_texture_env_dot3</summary>
        public const int DOT3_RGB_EXT = 0x8740;
        ///<summary>EXT_texture_env_dot3</summary>
        public const int DOT3_RGBA_EXT = 0x8741;
        ///<summary>ATI_texture_mirror_once</summary>
        public const int MIRROR_CLAMP_ATI = 0x8742;
        ///<summary>ATI_texture_mirror_once</summary>
        public const int MIRROR_CLAMP_TO_EDGE_ATI = 0x8743;
        ///<summary>NV_fence</summary>
        public const int ALL_COMPLETED_NV = 0x84F2;
        ///<summary>NV_fence</summary>
        public const int FENCE_STATUS_NV = 0x84F3;
        ///<summary>NV_fence</summary>
        public const int FENCE_CONDITION_NV = 0x84F4;
        ///<summary>IBM_texture_mirrored_repeat</summary>
        public const int MIRRORED_REPEAT_IBM = 0x8370;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_2D_NV = 0x86C0;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_TRIANGULAR_2D_NV = 0x86C1;
        ///<summary>NV_evaluators</summary>
        public const int MAP_TESSELLATION_NV = 0x86C2;
        ///<summary>NV_evaluators</summary>
        public const int MAP_ATTRIB_U_ORDER_NV = 0x86C3;
        ///<summary>NV_evaluators</summary>
        public const int MAP_ATTRIB_V_ORDER_NV = 0x86C4;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_FRACTIONAL_TESSELLATION_NV = 0x86C5;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_VERTEX_ATTRIB0_NV = 0x86C6;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_VERTEX_ATTRIB1_NV = 0x86C7;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_VERTEX_ATTRIB2_NV = 0x86C8;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_VERTEX_ATTRIB3_NV = 0x86C9;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_VERTEX_ATTRIB4_NV = 0x86CA;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_VERTEX_ATTRIB5_NV = 0x86CB;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_VERTEX_ATTRIB6_NV = 0x86CC;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_VERTEX_ATTRIB7_NV = 0x86CD;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_VERTEX_ATTRIB8_NV = 0x86CE;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_VERTEX_ATTRIB9_NV = 0x86CF;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_VERTEX_ATTRIB10_NV = 0x86D0;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_VERTEX_ATTRIB11_NV = 0x86D1;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_VERTEX_ATTRIB12_NV = 0x86D2;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_VERTEX_ATTRIB13_NV = 0x86D3;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_VERTEX_ATTRIB14_NV = 0x86D4;
        ///<summary>NV_evaluators</summary>
        public const int EVAL_VERTEX_ATTRIB15_NV = 0x86D5;
        ///<summary>NV_evaluators</summary>
        public const int MAX_MAP_TESSELLATION_NV = 0x86D6;
        ///<summary>NV_evaluators</summary>
        public const int MAX_RATIONAL_EVAL_ORDER_NV = 0x86D7;
        ///<summary>NV_packed_depth_stencil</summary>
        public const int DEPTH_STENCIL_NV = 0x84F9;
        ///<summary>NV_packed_depth_stencil</summary>
        public const int UNSIGNED_INT_24_8_NV = 0x84FA;
        ///<summary>NV_register_combiners2</summary>
        public const int PER_STAGE_CONSTANTS_NV = 0x8535;
        ///<summary>NV_texture_rectangle</summary>
        public const int TEXTURE_RECTANGLE_NV = 0x84F5;
        ///<summary>NV_texture_rectangle</summary>
        public const int TEXTURE_BINDING_RECTANGLE_NV = 0x84F6;
        ///<summary>NV_texture_rectangle</summary>
        public const int PROXY_TEXTURE_RECTANGLE_NV = 0x84F7;
        ///<summary>NV_texture_rectangle</summary>
        public const int MAX_RECTANGLE_TEXTURE_SIZE_NV = 0x84F8;
        ///<summary>NV_texture_shader</summary>
        public const int OFFSET_TEXTURE_RECTANGLE_NV = 0x864C;
        ///<summary>NV_texture_shader</summary>
        public const int OFFSET_TEXTURE_RECTANGLE_SCALE_NV = 0x864D;
        ///<summary>NV_texture_shader</summary>
        public const int DOT_PRODUCT_TEXTURE_RECTANGLE_NV = 0x864E;
        ///<summary>NV_texture_shader</summary>
        public const int RGBA_UNSIGNED_DOT_PRODUCT_MAPPING_NV = 0x86D9;
        ///<summary>NV_texture_shader</summary>
        public const int UNSIGNED_INT_S8_S8_8_8_NV = 0x86DA;
        ///<summary>NV_texture_shader</summary>
        public const int UNSIGNED_INT_8_8_S8_S8_REV_NV = 0x86DB;
        ///<summary>NV_texture_shader</summary>
        public const int DSDT_MAG_INTENSITY_NV = 0x86DC;
        ///<summary>NV_texture_shader</summary>
        public const int SHADER_CONSISTENT_NV = 0x86DD;
        ///<summary>NV_texture_shader</summary>
        public const int TEXTURE_SHADER_NV = 0x86DE;
        ///<summary>NV_texture_shader</summary>
        public const int SHADER_OPERATION_NV = 0x86DF;
        ///<summary>NV_texture_shader</summary>
        public const int CULL_MODES_NV = 0x86E0;
        ///<summary>NV_texture_shader</summary>
        public const int OFFSET_TEXTURE_MATRIX_NV = 0x86E1;
        ///<summary>NV_texture_shader</summary>
        public const int OFFSET_TEXTURE_SCALE_NV = 0x86E2;
        ///<summary>NV_texture_shader</summary>
        public const int OFFSET_TEXTURE_BIAS_NV = 0x86E3;
        ///<summary>NV_texture_shader</summary>
        public const int OFFSET_TEXTURE_2D_MATRIX_NV = 0x86E1;
        ///<summary>NV_texture_shader</summary>
        public const int OFFSET_TEXTURE_2D_SCALE_NV = 0x86E2;
        ///<summary>NV_texture_shader</summary>
        public const int OFFSET_TEXTURE_2D_BIAS_NV = 0x86E3;
        ///<summary>NV_texture_shader</summary>
        public const int PREVIOUS_TEXTURE_INPUT_NV = 0x86E4;
        ///<summary>NV_texture_shader</summary>
        public const int CONST_EYE_NV = 0x86E5;
        ///<summary>NV_texture_shader</summary>
        public const int PASS_THROUGH_NV = 0x86E6;
        ///<summary>NV_texture_shader</summary>
        public const int CULL_FRAGMENT_NV = 0x86E7;
        ///<summary>NV_texture_shader</summary>
        public const int OFFSET_TEXTURE_2D_NV = 0x86E8;
        ///<summary>NV_texture_shader</summary>
        public const int DEPENDENT_AR_TEXTURE_2D_NV = 0x86E9;
        ///<summary>NV_texture_shader</summary>
        public const int DEPENDENT_GB_TEXTURE_2D_NV = 0x86EA;
        ///<summary>NV_texture_shader</summary>
        public const int DOT_PRODUCT_NV = 0x86EC;
        ///<summary>NV_texture_shader</summary>
        public const int DOT_PRODUCT_DEPTH_REPLACE_NV = 0x86ED;
        ///<summary>NV_texture_shader</summary>
        public const int DOT_PRODUCT_TEXTURE_2D_NV = 0x86EE;
        ///<summary>NV_texture_shader</summary>
        public const int DOT_PRODUCT_TEXTURE_CUBE_MAP_NV = 0x86F0;
        ///<summary>NV_texture_shader</summary>
        public const int DOT_PRODUCT_DIFFUSE_CUBE_MAP_NV = 0x86F1;
        ///<summary>NV_texture_shader</summary>
        public const int DOT_PRODUCT_REFLECT_CUBE_MAP_NV = 0x86F2;
        ///<summary>NV_texture_shader</summary>
        public const int DOT_PRODUCT_CONST_EYE_REFLECT_CUBE_MAP_NV = 0x86F3;
        ///<summary>NV_texture_shader</summary>
        public const int HILO_NV = 0x86F4;
        ///<summary>NV_texture_shader</summary>
        public const int DSDT_NV = 0x86F5;
        ///<summary>NV_texture_shader</summary>
        public const int DSDT_MAG_NV = 0x86F6;
        ///<summary>NV_texture_shader</summary>
        public const int DSDT_MAG_VIB_NV = 0x86F7;
        ///<summary>NV_texture_shader</summary>
        public const int HILO16_NV = 0x86F8;
        ///<summary>NV_texture_shader</summary>
        public const int SIGNED_HILO_NV = 0x86F9;
        ///<summary>NV_texture_shader</summary>
        public const int SIGNED_HILO16_NV = 0x86FA;
        ///<summary>NV_texture_shader</summary>
        public const int SIGNED_RGBA_NV = 0x86FB;
        ///<summary>NV_texture_shader</summary>
        public const int SIGNED_RGBA8_NV = 0x86FC;
        ///<summary>NV_texture_shader</summary>
        public const int SIGNED_RGB_NV = 0x86FE;
        ///<summary>NV_texture_shader</summary>
        public const int SIGNED_RGB8_NV = 0x86FF;
        ///<summary>NV_texture_shader</summary>
        public const int SIGNED_LUMINANCE_NV = 0x8701;
        ///<summary>NV_texture_shader</summary>
        public const int SIGNED_LUMINANCE8_NV = 0x8702;
        ///<summary>NV_texture_shader</summary>
        public const int SIGNED_LUMINANCE_ALPHA_NV = 0x8703;
        ///<summary>NV_texture_shader</summary>
        public const int SIGNED_LUMINANCE8_ALPHA8_NV = 0x8704;
        ///<summary>NV_texture_shader</summary>
        public const int SIGNED_ALPHA_NV = 0x8705;
        ///<summary>NV_texture_shader</summary>
        public const int SIGNED_ALPHA8_NV = 0x8706;
        ///<summary>NV_texture_shader</summary>
        public const int SIGNED_INTENSITY_NV = 0x8707;
        ///<summary>NV_texture_shader</summary>
        public const int SIGNED_INTENSITY8_NV = 0x8708;
        ///<summary>NV_texture_shader</summary>
        public const int DSDT8_NV = 0x8709;
        ///<summary>NV_texture_shader</summary>
        public const int DSDT8_MAG8_NV = 0x870A;
        ///<summary>NV_texture_shader</summary>
        public const int DSDT8_MAG8_INTENSITY8_NV = 0x870B;
        ///<summary>NV_texture_shader</summary>
        public const int SIGNED_RGB_UNSIGNED_ALPHA_NV = 0x870C;
        ///<summary>NV_texture_shader</summary>
        public const int SIGNED_RGB8_UNSIGNED_ALPHA8_NV = 0x870D;
        ///<summary>NV_texture_shader</summary>
        public const int HI_SCALE_NV = 0x870E;
        ///<summary>NV_texture_shader</summary>
        public const int LO_SCALE_NV = 0x870F;
        ///<summary>NV_texture_shader</summary>
        public const int DS_SCALE_NV = 0x8710;
        ///<summary>NV_texture_shader</summary>
        public const int DT_SCALE_NV = 0x8711;
        ///<summary>NV_texture_shader</summary>
        public const int MAGNITUDE_SCALE_NV = 0x8712;
        ///<summary>NV_texture_shader</summary>
        public const int VIBRANCE_SCALE_NV = 0x8713;
        ///<summary>NV_texture_shader</summary>
        public const int HI_BIAS_NV = 0x8714;
        ///<summary>NV_texture_shader</summary>
        public const int LO_BIAS_NV = 0x8715;
        ///<summary>NV_texture_shader</summary>
        public const int DS_BIAS_NV = 0x8716;
        ///<summary>NV_texture_shader</summary>
        public const int DT_BIAS_NV = 0x8717;
        ///<summary>NV_texture_shader</summary>
        public const int MAGNITUDE_BIAS_NV = 0x8718;
        ///<summary>NV_texture_shader</summary>
        public const int VIBRANCE_BIAS_NV = 0x8719;
        ///<summary>NV_texture_shader</summary>
        public const int TEXTURE_BORDER_VALUES_NV = 0x871A;
        ///<summary>NV_texture_shader</summary>
        public const int TEXTURE_HI_SIZE_NV = 0x871B;
        ///<summary>NV_texture_shader</summary>
        public const int TEXTURE_LO_SIZE_NV = 0x871C;
        ///<summary>NV_texture_shader</summary>
        public const int TEXTURE_DS_SIZE_NV = 0x871D;
        ///<summary>NV_texture_shader</summary>
        public const int TEXTURE_DT_SIZE_NV = 0x871E;
        ///<summary>NV_texture_shader</summary>
        public const int TEXTURE_MAG_SIZE_NV = 0x871F;
        ///<summary>NV_texture_shader2</summary>
        public const int DOT_PRODUCT_TEXTURE_3D_NV = 0x86EF;
        ///<summary>NV_vertex_array_range2</summary>
        public const int VERTEX_ARRAY_RANGE_WITHOUT_FLUSH_NV = 0x8533;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_PROGRAM_NV = 0x8620;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_STATE_PROGRAM_NV = 0x8621;
        ///<summary>NV_vertex_program</summary>
        public const int ATTRIB_ARRAY_SIZE_NV = 0x8623;
        ///<summary>NV_vertex_program</summary>
        public const int ATTRIB_ARRAY_STRIDE_NV = 0x8624;
        ///<summary>NV_vertex_program</summary>
        public const int ATTRIB_ARRAY_TYPE_NV = 0x8625;
        ///<summary>NV_vertex_program</summary>
        public const int CURRENT_ATTRIB_NV = 0x8626;
        ///<summary>NV_vertex_program</summary>
        public const int PROGRAM_LENGTH_NV = 0x8627;
        ///<summary>NV_vertex_program</summary>
        public const int PROGRAM_STRING_NV = 0x8628;
        ///<summary>NV_vertex_program</summary>
        public const int MODELVIEW_PROJECTION_NV = 0x8629;
        ///<summary>NV_vertex_program</summary>
        public const int IDENTITY_NV = 0x862A;
        ///<summary>NV_vertex_program</summary>
        public const int INVERSE_NV = 0x862B;
        ///<summary>NV_vertex_program</summary>
        public const int TRANSPOSE_NV = 0x862C;
        ///<summary>NV_vertex_program</summary>
        public const int INVERSE_TRANSPOSE_NV = 0x862D;
        ///<summary>NV_vertex_program</summary>
        public const int MAX_TRACK_MATRIX_STACK_DEPTH_NV = 0x862E;
        ///<summary>NV_vertex_program</summary>
        public const int MAX_TRACK_MATRICES_NV = 0x862F;
        ///<summary>NV_vertex_program</summary>
        public const int MATRIX0_NV = 0x8630;
        ///<summary>NV_vertex_program</summary>
        public const int MATRIX1_NV = 0x8631;
        ///<summary>NV_vertex_program</summary>
        public const int MATRIX2_NV = 0x8632;
        ///<summary>NV_vertex_program</summary>
        public const int MATRIX3_NV = 0x8633;
        ///<summary>NV_vertex_program</summary>
        public const int MATRIX4_NV = 0x8634;
        ///<summary>NV_vertex_program</summary>
        public const int MATRIX5_NV = 0x8635;
        ///<summary>NV_vertex_program</summary>
        public const int MATRIX6_NV = 0x8636;
        ///<summary>NV_vertex_program</summary>
        public const int MATRIX7_NV = 0x8637;
        ///<summary>NV_vertex_program</summary>
        public const int CURRENT_MATRIX_STACK_DEPTH_NV = 0x8640;
        ///<summary>NV_vertex_program</summary>
        public const int CURRENT_MATRIX_NV = 0x8641;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_PROGRAM_POINT_SIZE_NV = 0x8642;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_PROGRAM_TWO_SIDE_NV = 0x8643;
        ///<summary>NV_vertex_program</summary>
        public const int PROGRAM_PARAMETER_NV = 0x8644;
        ///<summary>NV_vertex_program</summary>
        public const int ATTRIB_ARRAY_POINTER_NV = 0x8645;
        ///<summary>NV_vertex_program</summary>
        public const int PROGRAM_TARGET_NV = 0x8646;
        ///<summary>NV_vertex_program</summary>
        public const int PROGRAM_RESIDENT_NV = 0x8647;
        ///<summary>NV_vertex_program</summary>
        public const int TRACK_MATRIX_NV = 0x8648;
        ///<summary>NV_vertex_program</summary>
        public const int TRACK_MATRIX_TRANSFORM_NV = 0x8649;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_PROGRAM_BINDING_NV = 0x864A;
        ///<summary>NV_vertex_program</summary>
        public const int PROGRAM_ERROR_POSITION_NV = 0x864B;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY0_NV = 0x8650;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY1_NV = 0x8651;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY2_NV = 0x8652;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY3_NV = 0x8653;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY4_NV = 0x8654;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY5_NV = 0x8655;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY6_NV = 0x8656;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY7_NV = 0x8657;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY8_NV = 0x8658;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY9_NV = 0x8659;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY10_NV = 0x865A;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY11_NV = 0x865B;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY12_NV = 0x865C;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY13_NV = 0x865D;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY14_NV = 0x865E;
        ///<summary>NV_vertex_program</summary>
        public const int VERTEX_ATTRIB_ARRAY15_NV = 0x865F;
        ///<summary>NV_vertex_program</summary>
        public const int MAP1_VERTEX_ATTRIB0_4_NV = 0x8660;
        ///<summary>NV_vertex_program</summary>
        public const int MAP1_VERTEX_ATTRIB1_4_NV = 0x8661;
        ///<summary>NV_vertex_program</summary>
        public const int MAP1_VERTEX_ATTRIB2_4_NV = 0x8662;
        ///<summary>NV_vertex_program</summary>
        public const int MAP1_VERTEX_ATTRIB3_4_NV = 0x8663;
        ///<summary>NV_vertex_program</summary>
        public const int MAP1_VERTEX_ATTRIB4_4_NV = 0x8664;
        ///<summary>NV_vertex_program</summary>
        public const int MAP1_VERTEX_ATTRIB5_4_NV = 0x8665;
        ///<summary>NV_vertex_program</summary>
        public const int MAP1_VERTEX_ATTRIB6_4_NV = 0x8666;
        ///<summary>NV_vertex_program</summary>
        public const int MAP1_VERTEX_ATTRIB7_4_NV = 0x8667;
        ///<summary>NV_vertex_program</summary>
        public const int MAP1_VERTEX_ATTRIB8_4_NV = 0x8668;
        ///<summary>NV_vertex_program</summary>
        public const int MAP1_VERTEX_ATTRIB9_4_NV = 0x8669;
        ///<summary>NV_vertex_program</summary>
        public const int MAP1_VERTEX_ATTRIB10_4_NV = 0x866A;
        ///<summary>NV_vertex_program</summary>
        public const int MAP1_VERTEX_ATTRIB11_4_NV = 0x866B;
        ///<summary>NV_vertex_program</summary>
        public const int MAP1_VERTEX_ATTRIB12_4_NV = 0x866C;
        ///<summary>NV_vertex_program</summary>
        public const int MAP1_VERTEX_ATTRIB13_4_NV = 0x866D;
        ///<summary>NV_vertex_program</summary>
        public const int MAP1_VERTEX_ATTRIB14_4_NV = 0x866E;
        ///<summary>NV_vertex_program</summary>
        public const int MAP1_VERTEX_ATTRIB15_4_NV = 0x866F;
        ///<summary>NV_vertex_program</summary>
        public const int MAP2_VERTEX_ATTRIB0_4_NV = 0x8670;
        ///<summary>NV_vertex_program</summary>
        public const int MAP2_VERTEX_ATTRIB1_4_NV = 0x8671;
        ///<summary>NV_vertex_program</summary>
        public const int MAP2_VERTEX_ATTRIB2_4_NV = 0x8672;
        ///<summary>NV_vertex_program</summary>
        public const int MAP2_VERTEX_ATTRIB3_4_NV = 0x8673;
        ///<summary>NV_vertex_program</summary>
        public const int MAP2_VERTEX_ATTRIB4_4_NV = 0x8674;
        ///<summary>NV_vertex_program</summary>
        public const int MAP2_VERTEX_ATTRIB5_4_NV = 0x8675;
        ///<summary>NV_vertex_program</summary>
        public const int MAP2_VERTEX_ATTRIB6_4_NV = 0x8676;
        ///<summary>NV_vertex_program</summary>
        public const int MAP2_VERTEX_ATTRIB7_4_NV = 0x8677;
        ///<summary>NV_vertex_program</summary>
        public const int MAP2_VERTEX_ATTRIB8_4_NV = 0x8678;
        ///<summary>NV_vertex_program</summary>
        public const int MAP2_VERTEX_ATTRIB9_4_NV = 0x8679;
        ///<summary>NV_vertex_program</summary>
        public const int MAP2_VERTEX_ATTRIB10_4_NV = 0x867A;
        ///<summary>NV_vertex_program</summary>
        public const int MAP2_VERTEX_ATTRIB11_4_NV = 0x867B;
        ///<summary>NV_vertex_program</summary>
        public const int MAP2_VERTEX_ATTRIB12_4_NV = 0x867C;
        ///<summary>NV_vertex_program</summary>
        public const int MAP2_VERTEX_ATTRIB13_4_NV = 0x867D;
        ///<summary>NV_vertex_program</summary>
        public const int MAP2_VERTEX_ATTRIB14_4_NV = 0x867E;
        ///<summary>NV_vertex_program</summary>
        public const int MAP2_VERTEX_ATTRIB15_4_NV = 0x867F;
        ///<summary>SGIX_texture_coordinate_clamp</summary>
        public const int TEXTURE_MAX_CLAMP_S_SGIX = 0x8369;
        ///<summary>SGIX_texture_coordinate_clamp</summary>
        public const int TEXTURE_MAX_CLAMP_T_SGIX = 0x836A;
        ///<summary>SGIX_texture_coordinate_clamp</summary>
        public const int TEXTURE_MAX_CLAMP_R_SGIX = 0x836B;
        ///<summary>SGIX_scalebias_hint</summary>
        public const int SCALEBIAS_HINT_SGIX = 0x8322;
        ///<summary>OML_interlace</summary>
        public const int INTERLACE_OML = 0x8980;
        ///<summary>OML_interlace</summary>
        public const int INTERLACE_READ_OML = 0x8981;
        ///<summary>OML_subsample</summary>
        public const int FORMAT_SUBSAMPLE_24_24_OML = 0x8982;
        ///<summary>OML_subsample</summary>
        public const int FORMAT_SUBSAMPLE_244_244_OML = 0x8983;
        ///<summary>OML_resample</summary>
        public const int PACK_RESAMPLE_OML = 0x8984;
        ///<summary>OML_resample</summary>
        public const int UNPACK_RESAMPLE_OML = 0x8985;
        ///<summary>OML_resample</summary>
        public const int RESAMPLE_REPLICATE_OML = 0x8986;
        ///<summary>OML_resample</summary>
        public const int RESAMPLE_ZERO_FILL_OML = 0x8987;
        ///<summary>OML_resample</summary>
        public const int RESAMPLE_AVERAGE_OML = 0x8988;
        ///<summary>OML_resample</summary>
        public const int RESAMPLE_DECIMATE_OML = 0x8989;
        ///<summary>NV_copy_depth_to_color</summary>
        public const int DEPTH_STENCIL_TO_RGBA_NV = 0x886E;
        ///<summary>NV_copy_depth_to_color</summary>
        public const int DEPTH_STENCIL_TO_BGRA_NV = 0x886F;
        ///<summary>ATI_envmap_bumpmap</summary>
        public const int BUMP_ROT_MATRIX_ATI = 0x8775;
        ///<summary>ATI_envmap_bumpmap</summary>
        public const int BUMP_ROT_MATRIX_SIZE_ATI = 0x8776;
        ///<summary>ATI_envmap_bumpmap</summary>
        public const int BUMP_NUM_TEX_UNITS_ATI = 0x8777;
        ///<summary>ATI_envmap_bumpmap</summary>
        public const int BUMP_TEX_UNITS_ATI = 0x8778;
        ///<summary>ATI_envmap_bumpmap</summary>
        public const int DUDV_ATI = 0x8779;
        ///<summary>ATI_envmap_bumpmap</summary>
        public const int DU8DV8_ATI = 0x877A;
        ///<summary>ATI_envmap_bumpmap</summary>
        public const int BUMP_ENVMAP_ATI = 0x877B;
        ///<summary>ATI_envmap_bumpmap</summary>
        public const int BUMP_TARGET_ATI = 0x877C;
        ///<summary>ATI_fragment_shader</summary>
        public const int FRAGMENT_SHADER_ATI = 0x8920;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_0_ATI = 0x8921;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_1_ATI = 0x8922;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_2_ATI = 0x8923;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_3_ATI = 0x8924;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_4_ATI = 0x8925;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_5_ATI = 0x8926;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_6_ATI = 0x8927;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_7_ATI = 0x8928;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_8_ATI = 0x8929;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_9_ATI = 0x892A;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_10_ATI = 0x892B;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_11_ATI = 0x892C;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_12_ATI = 0x892D;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_13_ATI = 0x892E;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_14_ATI = 0x892F;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_15_ATI = 0x8930;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_16_ATI = 0x8931;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_17_ATI = 0x8932;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_18_ATI = 0x8933;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_19_ATI = 0x8934;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_20_ATI = 0x8935;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_21_ATI = 0x8936;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_22_ATI = 0x8937;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_23_ATI = 0x8938;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_24_ATI = 0x8939;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_25_ATI = 0x893A;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_26_ATI = 0x893B;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_27_ATI = 0x893C;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_28_ATI = 0x893D;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_29_ATI = 0x893E;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_30_ATI = 0x893F;
        ///<summary>ATI_fragment_shader</summary>
        public const int REG_31_ATI = 0x8940;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_0_ATI = 0x8941;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_1_ATI = 0x8942;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_2_ATI = 0x8943;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_3_ATI = 0x8944;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_4_ATI = 0x8945;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_5_ATI = 0x8946;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_6_ATI = 0x8947;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_7_ATI = 0x8948;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_8_ATI = 0x8949;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_9_ATI = 0x894A;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_10_ATI = 0x894B;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_11_ATI = 0x894C;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_12_ATI = 0x894D;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_13_ATI = 0x894E;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_14_ATI = 0x894F;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_15_ATI = 0x8950;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_16_ATI = 0x8951;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_17_ATI = 0x8952;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_18_ATI = 0x8953;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_19_ATI = 0x8954;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_20_ATI = 0x8955;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_21_ATI = 0x8956;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_22_ATI = 0x8957;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_23_ATI = 0x8958;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_24_ATI = 0x8959;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_25_ATI = 0x895A;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_26_ATI = 0x895B;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_27_ATI = 0x895C;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_28_ATI = 0x895D;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_29_ATI = 0x895E;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_30_ATI = 0x895F;
        ///<summary>ATI_fragment_shader</summary>
        public const int CON_31_ATI = 0x8960;
        ///<summary>ATI_fragment_shader</summary>
        public const int MOV_ATI = 0x8961;
        ///<summary>ATI_fragment_shader</summary>
        public const int ADD_ATI = 0x8963;
        ///<summary>ATI_fragment_shader</summary>
        public const int MUL_ATI = 0x8964;
        ///<summary>ATI_fragment_shader</summary>
        public const int SUB_ATI = 0x8965;
        ///<summary>ATI_fragment_shader</summary>
        public const int DOT3_ATI = 0x8966;
        ///<summary>ATI_fragment_shader</summary>
        public const int DOT4_ATI = 0x8967;
        ///<summary>ATI_fragment_shader</summary>
        public const int MAD_ATI = 0x8968;
        ///<summary>ATI_fragment_shader</summary>
        public const int LERP_ATI = 0x8969;
        ///<summary>ATI_fragment_shader</summary>
        public const int CND_ATI = 0x896A;
        ///<summary>ATI_fragment_shader</summary>
        public const int CND0_ATI = 0x896B;
        ///<summary>ATI_fragment_shader</summary>
        public const int DOT2_ADD_ATI = 0x896C;
        ///<summary>ATI_fragment_shader</summary>
        public const int SECONDARY_INTERPOLATOR_ATI = 0x896D;
        ///<summary>ATI_fragment_shader</summary>
        public const int NUM_FRAGMENT_REGISTERS_ATI = 0x896E;
        ///<summary>ATI_fragment_shader</summary>
        public const int NUM_FRAGMENT_CONSTANTS_ATI = 0x896F;
        ///<summary>ATI_fragment_shader</summary>
        public const int NUM_PASSES_ATI = 0x8970;
        ///<summary>ATI_fragment_shader</summary>
        public const int NUM_INSTRUCTIONS_PER_PASS_ATI = 0x8971;
        ///<summary>ATI_fragment_shader</summary>
        public const int NUM_INSTRUCTIONS_TOTAL_ATI = 0x8972;
        ///<summary>ATI_fragment_shader</summary>
        public const int NUM_INPUT_INTERPOLATOR_COMPONENTS_ATI = 0x8973;
        ///<summary>ATI_fragment_shader</summary>
        public const int NUM_LOOPBACK_COMPONENTS_ATI = 0x8974;
        ///<summary>ATI_fragment_shader</summary>
        public const int COLOR_ALPHA_PAIRING_ATI = 0x8975;
        ///<summary>ATI_fragment_shader</summary>
        public const int SWIZZLE_STR_ATI = 0x8976;
        ///<summary>ATI_fragment_shader</summary>
        public const int SWIZZLE_STQ_ATI = 0x8977;
        ///<summary>ATI_fragment_shader</summary>
        public const int SWIZZLE_STR_DR_ATI = 0x8978;
        ///<summary>ATI_fragment_shader</summary>
        public const int SWIZZLE_STQ_DQ_ATI = 0x8979;
        ///<summary>ATI_fragment_shader</summary>
        public const int SWIZZLE_STRQ_ATI = 0x897A;
        ///<summary>ATI_fragment_shader</summary>
        public const int SWIZZLE_STRQ_DQ_ATI = 0x897B;
        ///<summary>ATI_fragment_shader</summary>
        public const int RED_BIT_ATI = 0x00000001;
        ///<summary>ATI_fragment_shader</summary>
        public const int GREEN_BIT_ATI = 0x00000002;
        ///<summary>ATI_fragment_shader</summary>
        public const int BLUE_BIT_ATI = 0x00000004;
        ///<summary>ATI_fragment_shader</summary>
        public const int _2X_BIT_ATI = 0x00000001;
        ///<summary>ATI_fragment_shader</summary>
        public const int _4X_BIT_ATI = 0x00000002;
        ///<summary>ATI_fragment_shader</summary>
        public const int _8X_BIT_ATI = 0x00000004;
        ///<summary>ATI_fragment_shader</summary>
        public const int HALF_BIT_ATI = 0x00000008;
        ///<summary>ATI_fragment_shader</summary>
        public const int QUARTER_BIT_ATI = 0x00000010;
        ///<summary>ATI_fragment_shader</summary>
        public const int EIGHTH_BIT_ATI = 0x00000020;
        ///<summary>ATI_fragment_shader</summary>
        public const int SATURATE_BIT_ATI = 0x00000040;
        ///<summary>ATI_fragment_shader</summary>
        public const int COMP_BIT_ATI = 0x00000002;
        ///<summary>ATI_fragment_shader</summary>
        public const int NEGATE_BIT_ATI = 0x00000004;
        ///<summary>ATI_fragment_shader</summary>
        public const int BIAS_BIT_ATI = 0x00000008;
        ///<summary>ATI_pn_triangles</summary>
        public const int PN_TRIANGLES_ATI = 0x87F0;
        ///<summary>ATI_pn_triangles</summary>
        public const int MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F1;
        ///<summary>ATI_pn_triangles</summary>
        public const int PN_TRIANGLES_POINT_MODE_ATI = 0x87F2;
        ///<summary>ATI_pn_triangles</summary>
        public const int PN_TRIANGLES_NORMAL_MODE_ATI = 0x87F3;
        ///<summary>ATI_pn_triangles</summary>
        public const int PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F4;
        ///<summary>ATI_pn_triangles</summary>
        public const int PN_TRIANGLES_POINT_MODE_LINEAR_ATI = 0x87F5;
        ///<summary>ATI_pn_triangles</summary>
        public const int PN_TRIANGLES_POINT_MODE_CUBIC_ATI = 0x87F6;
        ///<summary>ATI_pn_triangles</summary>
        public const int PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI = 0x87F7;
        ///<summary>ATI_pn_triangles</summary>
        public const int PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI = 0x87F8;
        ///<summary>ATI_vertex_array_object</summary>
        public const int STATIC_ATI = 0x8760;
        ///<summary>ATI_vertex_array_object</summary>
        public const int DYNAMIC_ATI = 0x8761;
        ///<summary>ATI_vertex_array_object</summary>
        public const int PRESERVE_ATI = 0x8762;
        ///<summary>ATI_vertex_array_object</summary>
        public const int DISCARD_ATI = 0x8763;
        ///<summary>ATI_vertex_array_object</summary>
        public const int OBJECT_BUFFER_SIZE_ATI = 0x8764;
        ///<summary>ATI_vertex_array_object</summary>
        public const int OBJECT_BUFFER_USAGE_ATI = 0x8765;
        ///<summary>ATI_vertex_array_object</summary>
        public const int ARRAY_OBJECT_BUFFER_ATI = 0x8766;
        ///<summary>ATI_vertex_array_object</summary>
        public const int ARRAY_OBJECT_OFFSET_ATI = 0x8767;
        ///<summary>EXT_vertex_shader</summary>
        public const int VERTEX_SHADER_EXT = 0x8780;
        ///<summary>EXT_vertex_shader</summary>
        public const int VERTEX_SHADER_BINDING_EXT = 0x8781;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_INDEX_EXT = 0x8782;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_NEGATE_EXT = 0x8783;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_DOT3_EXT = 0x8784;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_DOT4_EXT = 0x8785;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_MUL_EXT = 0x8786;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_ADD_EXT = 0x8787;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_MADD_EXT = 0x8788;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_FRAC_EXT = 0x8789;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_MAX_EXT = 0x878A;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_MIN_EXT = 0x878B;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_SET_GE_EXT = 0x878C;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_SET_LT_EXT = 0x878D;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_CLAMP_EXT = 0x878E;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_FLOOR_EXT = 0x878F;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_ROUND_EXT = 0x8790;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_EXP_BASE_2_EXT = 0x8791;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_LOG_BASE_2_EXT = 0x8792;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_POWER_EXT = 0x8793;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_RECIP_EXT = 0x8794;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_RECIP_SQRT_EXT = 0x8795;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_SUB_EXT = 0x8796;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_CROSS_PRODUCT_EXT = 0x8797;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_MULTIPLY_MATRIX_EXT = 0x8798;
        ///<summary>EXT_vertex_shader</summary>
        public const int OP_MOV_EXT = 0x8799;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_VERTEX_EXT = 0x879A;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_COLOR0_EXT = 0x879B;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_COLOR1_EXT = 0x879C;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD0_EXT = 0x879D;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD1_EXT = 0x879E;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD2_EXT = 0x879F;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD3_EXT = 0x87A0;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD4_EXT = 0x87A1;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD5_EXT = 0x87A2;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD6_EXT = 0x87A3;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD7_EXT = 0x87A4;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD8_EXT = 0x87A5;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD9_EXT = 0x87A6;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD10_EXT = 0x87A7;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD11_EXT = 0x87A8;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD12_EXT = 0x87A9;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD13_EXT = 0x87AA;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD14_EXT = 0x87AB;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD15_EXT = 0x87AC;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD16_EXT = 0x87AD;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD17_EXT = 0x87AE;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD18_EXT = 0x87AF;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD19_EXT = 0x87B0;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD20_EXT = 0x87B1;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD21_EXT = 0x87B2;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD22_EXT = 0x87B3;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD23_EXT = 0x87B4;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD24_EXT = 0x87B5;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD25_EXT = 0x87B6;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD26_EXT = 0x87B7;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD27_EXT = 0x87B8;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD28_EXT = 0x87B9;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD29_EXT = 0x87BA;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD30_EXT = 0x87BB;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_TEXTURE_COORD31_EXT = 0x87BC;
        ///<summary>EXT_vertex_shader</summary>
        public const int OUTPUT_FOG_EXT = 0x87BD;
        ///<summary>EXT_vertex_shader</summary>
        public const int SCALAR_EXT = 0x87BE;
        ///<summary>EXT_vertex_shader</summary>
        public const int VECTOR_EXT = 0x87BF;
        ///<summary>EXT_vertex_shader</summary>
        public const int MATRIX_EXT = 0x87C0;
        ///<summary>EXT_vertex_shader</summary>
        public const int VARIANT_EXT = 0x87C1;
        ///<summary>EXT_vertex_shader</summary>
        public const int INVARIANT_EXT = 0x87C2;
        ///<summary>EXT_vertex_shader</summary>
        public const int LOCAL_CONSTANT_EXT = 0x87C3;
        ///<summary>EXT_vertex_shader</summary>
        public const int LOCAL_EXT = 0x87C4;
        ///<summary>EXT_vertex_shader</summary>
        public const int MAX_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87C5;
        ///<summary>EXT_vertex_shader</summary>
        public const int MAX_VERTEX_SHADER_VARIANTS_EXT = 0x87C6;
        ///<summary>EXT_vertex_shader</summary>
        public const int MAX_VERTEX_SHADER_INVARIANTS_EXT = 0x87C7;
        ///<summary>EXT_vertex_shader</summary>
        public const int MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87C8;
        ///<summary>EXT_vertex_shader</summary>
        public const int MAX_VERTEX_SHADER_LOCALS_EXT = 0x87C9;
        ///<summary>EXT_vertex_shader</summary>
        public const int MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CA;
        ///<summary>EXT_vertex_shader</summary>
        public const int MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT = 0x87CB;
        ///<summary>EXT_vertex_shader</summary>
        public const int MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87CC;
        ///<summary>EXT_vertex_shader</summary>
        public const int MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT = 0x87CD;
        ///<summary>EXT_vertex_shader</summary>
        public const int MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT = 0x87CE;
        ///<summary>EXT_vertex_shader</summary>
        public const int VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CF;
        ///<summary>EXT_vertex_shader</summary>
        public const int VERTEX_SHADER_VARIANTS_EXT = 0x87D0;
        ///<summary>EXT_vertex_shader</summary>
        public const int VERTEX_SHADER_INVARIANTS_EXT = 0x87D1;
        ///<summary>EXT_vertex_shader</summary>
        public const int VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87D2;
        ///<summary>EXT_vertex_shader</summary>
        public const int VERTEX_SHADER_LOCALS_EXT = 0x87D3;
        ///<summary>EXT_vertex_shader</summary>
        public const int VERTEX_SHADER_OPTIMIZED_EXT = 0x87D4;
        ///<summary>EXT_vertex_shader</summary>
        public const int X_EXT = 0x87D5;
        ///<summary>EXT_vertex_shader</summary>
        public const int Y_EXT = 0x87D6;
        ///<summary>EXT_vertex_shader</summary>
        public const int Z_EXT = 0x87D7;
        ///<summary>EXT_vertex_shader</summary>
        public const int W_EXT = 0x87D8;
        ///<summary>EXT_vertex_shader</summary>
        public const int NEGATIVE_X_EXT = 0x87D9;
        ///<summary>EXT_vertex_shader</summary>
        public const int NEGATIVE_Y_EXT = 0x87DA;
        ///<summary>EXT_vertex_shader</summary>
        public const int NEGATIVE_Z_EXT = 0x87DB;
        ///<summary>EXT_vertex_shader</summary>
        public const int NEGATIVE_W_EXT = 0x87DC;
        ///<summary>EXT_vertex_shader</summary>
        public const int ZERO_EXT = 0x87DD;
        ///<summary>EXT_vertex_shader</summary>
        public const int ONE_EXT = 0x87DE;
        ///<summary>EXT_vertex_shader</summary>
        public const int NEGATIVE_ONE_EXT = 0x87DF;
        ///<summary>EXT_vertex_shader</summary>
        public const int NORMALIZED_RANGE_EXT = 0x87E0;
        ///<summary>EXT_vertex_shader</summary>
        public const int FULL_RANGE_EXT = 0x87E1;
        ///<summary>EXT_vertex_shader</summary>
        public const int CURRENT_VERTEX_EXT = 0x87E2;
        ///<summary>EXT_vertex_shader</summary>
        public const int MVP_MATRIX_EXT = 0x87E3;
        ///<summary>EXT_vertex_shader</summary>
        public const int VARIANT_VALUE_EXT = 0x87E4;
        ///<summary>EXT_vertex_shader</summary>
        public const int VARIANT_DATATYPE_EXT = 0x87E5;
        ///<summary>EXT_vertex_shader</summary>
        public const int VARIANT_ARRAY_STRIDE_EXT = 0x87E6;
        ///<summary>EXT_vertex_shader</summary>
        public const int VARIANT_ARRAY_TYPE_EXT = 0x87E7;
        ///<summary>EXT_vertex_shader</summary>
        public const int VARIANT_ARRAY_EXT = 0x87E8;
        ///<summary>EXT_vertex_shader</summary>
        public const int VARIANT_ARRAY_POINTER_EXT = 0x87E9;
        ///<summary>EXT_vertex_shader</summary>
        public const int INVARIANT_VALUE_EXT = 0x87EA;
        ///<summary>EXT_vertex_shader</summary>
        public const int INVARIANT_DATATYPE_EXT = 0x87EB;
        ///<summary>EXT_vertex_shader</summary>
        public const int LOCAL_CONSTANT_VALUE_EXT = 0x87EC;
        ///<summary>EXT_vertex_shader</summary>
        public const int LOCAL_CONSTANT_DATATYPE_EXT = 0x87ED;
        ///<summary>ATI_vertex_streams</summary>
        public const int MAX_VERTEX_STREAMS_ATI = 0x876B;
        ///<summary>ATI_vertex_streams</summary>
        public const int VERTEX_STREAM0_ATI = 0x876C;
        ///<summary>ATI_vertex_streams</summary>
        public const int VERTEX_STREAM1_ATI = 0x876D;
        ///<summary>ATI_vertex_streams</summary>
        public const int VERTEX_STREAM2_ATI = 0x876E;
        ///<summary>ATI_vertex_streams</summary>
        public const int VERTEX_STREAM3_ATI = 0x876F;
        ///<summary>ATI_vertex_streams</summary>
        public const int VERTEX_STREAM4_ATI = 0x8770;
        ///<summary>ATI_vertex_streams</summary>
        public const int VERTEX_STREAM5_ATI = 0x8771;
        ///<summary>ATI_vertex_streams</summary>
        public const int VERTEX_STREAM6_ATI = 0x8772;
        ///<summary>ATI_vertex_streams</summary>
        public const int VERTEX_STREAM7_ATI = 0x8773;
        ///<summary>ATI_vertex_streams</summary>
        public const int VERTEX_SOURCE_ATI = 0x8774;
        ///<summary>ATI_element_array</summary>
        public const int ELEMENT_ARRAY_ATI = 0x8768;
        ///<summary>ATI_element_array</summary>
        public const int ELEMENT_ARRAY_TYPE_ATI = 0x8769;
        ///<summary>ATI_element_array</summary>
        public const int ELEMENT_ARRAY_POINTER_ATI = 0x876A;
        ///<summary>SUN_mesh_array</summary>
        public const int QUAD_MESH_SUN = 0x8614;
        ///<summary>SUN_mesh_array</summary>
        public const int TRIANGLE_MESH_SUN = 0x8615;
        ///<summary>SUN_slice_accum</summary>
        public const int SLICE_ACCUM_SUN = 0x85CC;
        ///<summary>NV_multisample_filter_hint</summary>
        public const int MULTISAMPLE_FILTER_HINT_NV = 0x8534;
        ///<summary>NV_depth_clamp</summary>
        public const int DEPTH_CLAMP_NV = 0x864F;
        ///<summary>NV_occlusion_query</summary>
        public const int PIXEL_COUNTER_BITS_NV = 0x8864;
        ///<summary>NV_occlusion_query</summary>
        public const int CURRENT_OCCLUSION_QUERY_ID_NV = 0x8865;
        ///<summary>NV_occlusion_query</summary>
        public const int PIXEL_COUNT_NV = 0x8866;
        ///<summary>NV_occlusion_query</summary>
        public const int PIXEL_COUNT_AVAILABLE_NV = 0x8867;
        ///<summary>NV_point_sprite</summary>
        public const int POINT_SPRITE_NV = 0x8861;
        ///<summary>NV_point_sprite</summary>
        public const int COORD_REPLACE_NV = 0x8862;
        ///<summary>NV_point_sprite</summary>
        public const int POINT_SPRITE_R_MODE_NV = 0x8863;
        ///<summary>NV_texture_shader3</summary>
        public const int OFFSET_PROJECTIVE_TEXTURE_2D_NV = 0x8850;
        ///<summary>NV_texture_shader3</summary>
        public const int OFFSET_PROJECTIVE_TEXTURE_2D_SCALE_NV = 0x8851;
        ///<summary>NV_texture_shader3</summary>
        public const int OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8852;
        ///<summary>NV_texture_shader3</summary>
        public const int OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_SCALE_NV = 0x8853;
        ///<summary>NV_texture_shader3</summary>
        public const int OFFSET_HILO_TEXTURE_2D_NV = 0x8854;
        ///<summary>NV_texture_shader3</summary>
        public const int OFFSET_HILO_TEXTURE_RECTANGLE_NV = 0x8855;
        ///<summary>NV_texture_shader3</summary>
        public const int OFFSET_HILO_PROJECTIVE_TEXTURE_2D_NV = 0x8856;
        ///<summary>NV_texture_shader3</summary>
        public const int OFFSET_HILO_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8857;
        ///<summary>NV_texture_shader3</summary>
        public const int DEPENDENT_HILO_TEXTURE_2D_NV = 0x8858;
        ///<summary>NV_texture_shader3</summary>
        public const int DEPENDENT_RGB_TEXTURE_3D_NV = 0x8859;
        ///<summary>NV_texture_shader3</summary>
        public const int DEPENDENT_RGB_TEXTURE_CUBE_MAP_NV = 0x885A;
        ///<summary>NV_texture_shader3</summary>
        public const int DOT_PRODUCT_PASS_THROUGH_NV = 0x885B;
        ///<summary>NV_texture_shader3</summary>
        public const int DOT_PRODUCT_TEXTURE_1D_NV = 0x885C;
        ///<summary>NV_texture_shader3</summary>
        public const int DOT_PRODUCT_AFFINE_DEPTH_REPLACE_NV = 0x885D;
        ///<summary>NV_texture_shader3</summary>
        public const int HILO8_NV = 0x885E;
        ///<summary>NV_texture_shader3</summary>
        public const int SIGNED_HILO8_NV = 0x885F;
        ///<summary>NV_texture_shader3</summary>
        public const int FORCE_BLUE_TO_ONE_NV = 0x8860;
        ///<summary>EXT_stencil_two_side</summary>
        public const int STENCIL_TEST_TWO_SIDE_EXT = 0x8910;
        ///<summary>EXT_stencil_two_side</summary>
        public const int ACTIVE_STENCIL_FACE_EXT = 0x8911;
        ///<summary>ATI_text_fragment_shader</summary>
        public const int TEXT_FRAGMENT_SHADER_ATI = 0x8200;
        ///<summary>APPLE_client_storage</summary>
        public const int UNPACK_CLIENT_STORAGE_APPLE = 0x85B2;
        ///<summary>APPLE_element_array</summary>
        public const int ELEMENT_ARRAY_APPLE = 0x8A0C;
        ///<summary>APPLE_element_array</summary>
        public const int ELEMENT_ARRAY_TYPE_APPLE = 0x8A0D;
        ///<summary>APPLE_element_array</summary>
        public const int ELEMENT_ARRAY_POINTER_APPLE = 0x8A0E;
        ///<summary>APPLE_fence</summary>
        public const int DRAW_PIXELS_APPLE = 0x8A0A;
        ///<summary>APPLE_fence</summary>
        public const int FENCE_APPLE = 0x8A0B;
        ///<summary>APPLE_vertex_array_object</summary>
        public const int VERTEX_ARRAY_BINDING_APPLE = 0x85B5;
        ///<summary>APPLE_vertex_array_range</summary>
        public const int VERTEX_ARRAY_RANGE_APPLE = 0x851D;
        ///<summary>APPLE_vertex_array_range</summary>
        public const int VERTEX_ARRAY_RANGE_LENGTH_APPLE = 0x851E;
        ///<summary>APPLE_vertex_array_range</summary>
        public const int VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F;
        ///<summary>APPLE_vertex_array_range</summary>
        public const int VERTEX_ARRAY_RANGE_POINTER_APPLE = 0x8521;
        ///<summary>APPLE_vertex_array_range</summary>
        public const int STORAGE_CLIENT_APPLE = 0x85B4;
        ///<summary>APPLE_vertex_array_range</summary>
        public const int STORAGE_CACHED_APPLE = 0x85BE;
        ///<summary>APPLE_vertex_array_range</summary>
        public const int STORAGE_SHARED_APPLE = 0x85BF;
        ///<summary>APPLE_ycbcr_422</summary>
        public const int YCBCR_422_APPLE = 0x85B9;
        ///<summary>APPLE_ycbcr_422</summary>
        public const int UNSIGNED_SHORT_8_8_APPLE = 0x85BA;
        ///<summary>APPLE_ycbcr_422</summary>
        public const int UNSIGNED_SHORT_8_8_REV_APPLE = 0x85BB;
        ///<summary>S3_s3tc</summary>
        public const int RGB_S3TC = 0x83A0;
        ///<summary>S3_s3tc</summary>
        public const int RGB4_S3TC = 0x83A1;
        ///<summary>S3_s3tc</summary>
        public const int RGBA_S3TC = 0x83A2;
        ///<summary>S3_s3tc</summary>
        public const int RGBA4_S3TC = 0x83A3;
        ///<summary>ATI_draw_buffers</summary>
        public const int MAX_DRAW_BUFFERS_ATI = 0x8824;
        ///<summary>ATI_draw_buffers</summary>
        public const int DRAW_BUFFER0_ATI = 0x8825;
        ///<summary>ATI_draw_buffers</summary>
        public const int DRAW_BUFFER1_ATI = 0x8826;
        ///<summary>ATI_draw_buffers</summary>
        public const int DRAW_BUFFER2_ATI = 0x8827;
        ///<summary>ATI_draw_buffers</summary>
        public const int DRAW_BUFFER3_ATI = 0x8828;
        ///<summary>ATI_draw_buffers</summary>
        public const int DRAW_BUFFER4_ATI = 0x8829;
        ///<summary>ATI_draw_buffers</summary>
        public const int DRAW_BUFFER5_ATI = 0x882A;
        ///<summary>ATI_draw_buffers</summary>
        public const int DRAW_BUFFER6_ATI = 0x882B;
        ///<summary>ATI_draw_buffers</summary>
        public const int DRAW_BUFFER7_ATI = 0x882C;
        ///<summary>ATI_draw_buffers</summary>
        public const int DRAW_BUFFER8_ATI = 0x882D;
        ///<summary>ATI_draw_buffers</summary>
        public const int DRAW_BUFFER9_ATI = 0x882E;
        ///<summary>ATI_draw_buffers</summary>
        public const int DRAW_BUFFER10_ATI = 0x882F;
        ///<summary>ATI_draw_buffers</summary>
        public const int DRAW_BUFFER11_ATI = 0x8830;
        ///<summary>ATI_draw_buffers</summary>
        public const int DRAW_BUFFER12_ATI = 0x8831;
        ///<summary>ATI_draw_buffers</summary>
        public const int DRAW_BUFFER13_ATI = 0x8832;
        ///<summary>ATI_draw_buffers</summary>
        public const int DRAW_BUFFER14_ATI = 0x8833;
        ///<summary>ATI_draw_buffers</summary>
        public const int DRAW_BUFFER15_ATI = 0x8834;
        ///<summary>ATI_pixel_format_float</summary>
        public const int TYPE_RGBA_FLOAT_ATI = 0x8820;
        ///<summary>ATI_pixel_format_float</summary>
        public const int COLOR_CLEAR_UNCLAMPED_VALUE_ATI = 0x8835;
        ///<summary>ATI_texture_env_combine3</summary>
        public const int MODULATE_ADD_ATI = 0x8744;
        ///<summary>ATI_texture_env_combine3</summary>
        public const int MODULATE_SIGNED_ADD_ATI = 0x8745;
        ///<summary>ATI_texture_env_combine3</summary>
        public const int MODULATE_SUBTRACT_ATI = 0x8746;
        ///<summary>ATI_texture_float</summary>
        public const int RGBA_FLOAT32_ATI = 0x8814;
        ///<summary>ATI_texture_float</summary>
        public const int RGB_FLOAT32_ATI = 0x8815;
        ///<summary>ATI_texture_float</summary>
        public const int ALPHA_FLOAT32_ATI = 0x8816;
        ///<summary>ATI_texture_float</summary>
        public const int INTENSITY_FLOAT32_ATI = 0x8817;
        ///<summary>ATI_texture_float</summary>
        public const int LUMINANCE_FLOAT32_ATI = 0x8818;
        ///<summary>ATI_texture_float</summary>
        public const int LUMINANCE_ALPHA_FLOAT32_ATI = 0x8819;
        ///<summary>ATI_texture_float</summary>
        public const int RGBA_FLOAT16_ATI = 0x881A;
        ///<summary>ATI_texture_float</summary>
        public const int RGB_FLOAT16_ATI = 0x881B;
        ///<summary>ATI_texture_float</summary>
        public const int ALPHA_FLOAT16_ATI = 0x881C;
        ///<summary>ATI_texture_float</summary>
        public const int INTENSITY_FLOAT16_ATI = 0x881D;
        ///<summary>ATI_texture_float</summary>
        public const int LUMINANCE_FLOAT16_ATI = 0x881E;
        ///<summary>ATI_texture_float</summary>
        public const int LUMINANCE_ALPHA_FLOAT16_ATI = 0x881F;
        ///<summary>NV_float_buffer</summary>
        public const int FLOAT_R_NV = 0x8880;
        ///<summary>NV_float_buffer</summary>
        public const int FLOAT_RG_NV = 0x8881;
        ///<summary>NV_float_buffer</summary>
        public const int FLOAT_RGB_NV = 0x8882;
        ///<summary>NV_float_buffer</summary>
        public const int FLOAT_RGBA_NV = 0x8883;
        ///<summary>NV_float_buffer</summary>
        public const int FLOAT_R16_NV = 0x8884;
        ///<summary>NV_float_buffer</summary>
        public const int FLOAT_R32_NV = 0x8885;
        ///<summary>NV_float_buffer</summary>
        public const int FLOAT_RG16_NV = 0x8886;
        ///<summary>NV_float_buffer</summary>
        public const int FLOAT_RG32_NV = 0x8887;
        ///<summary>NV_float_buffer</summary>
        public const int FLOAT_RGB16_NV = 0x8888;
        ///<summary>NV_float_buffer</summary>
        public const int FLOAT_RGB32_NV = 0x8889;
        ///<summary>NV_float_buffer</summary>
        public const int FLOAT_RGBA16_NV = 0x888A;
        ///<summary>NV_float_buffer</summary>
        public const int FLOAT_RGBA32_NV = 0x888B;
        ///<summary>NV_float_buffer</summary>
        public const int TEXTURE_FLOAT_COMPONENTS_NV = 0x888C;
        ///<summary>NV_float_buffer</summary>
        public const int FLOAT_CLEAR_COLOR_VALUE_NV = 0x888D;
        ///<summary>NV_float_buffer</summary>
        public const int FLOAT_RGBA_MODE_NV = 0x888E;
        ///<summary>NV_fragment_program</summary>
        public const int MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV = 0x8868;
        ///<summary>NV_fragment_program</summary>
        public const int FRAGMENT_PROGRAM_NV = 0x8870;
        ///<summary>NV_fragment_program</summary>
        public const int MAX_TEXTURE_COORDS_NV = 0x8871;
        ///<summary>NV_fragment_program</summary>
        public const int MAX_TEXTURE_IMAGE_UNITS_NV = 0x8872;
        ///<summary>NV_fragment_program</summary>
        public const int FRAGMENT_PROGRAM_BINDING_NV = 0x8873;
        ///<summary>NV_fragment_program</summary>
        public const int PROGRAM_ERROR_STRING_NV = 0x8874;
        ///<summary>NV_half_float</summary>
        public const int HALF_FLOAT_NV = 0x140B;
        ///<summary>NV_pixel_data_range</summary>
        public const int WRITE_PIXEL_DATA_RANGE_NV = 0x8878;
        ///<summary>NV_pixel_data_range</summary>
        public const int READ_PIXEL_DATA_RANGE_NV = 0x8879;
        ///<summary>NV_pixel_data_range</summary>
        public const int WRITE_PIXEL_DATA_RANGE_LENGTH_NV = 0x887A;
        ///<summary>NV_pixel_data_range</summary>
        public const int READ_PIXEL_DATA_RANGE_LENGTH_NV = 0x887B;
        ///<summary>NV_pixel_data_range</summary>
        public const int WRITE_PIXEL_DATA_RANGE_POINTER_NV = 0x887C;
        ///<summary>NV_pixel_data_range</summary>
        public const int READ_PIXEL_DATA_RANGE_POINTER_NV = 0x887D;
        ///<summary>NV_primitive_restart</summary>
        public const int PRIMITIVE_RESTART_NV = 0x8558;
        ///<summary>NV_primitive_restart</summary>
        public const int PRIMITIVE_RESTART_INDEX_NV = 0x8559;
        ///<summary>NV_texture_expand_normal</summary>
        public const int TEXTURE_UNSIGNED_REMAP_MODE_NV = 0x888F;
        ///<summary>ATI_separate_stencil</summary>
        public const int STENCIL_BACK_FUNC_ATI = 0x8800;
        ///<summary>ATI_separate_stencil</summary>
        public const int STENCIL_BACK_FAIL_ATI = 0x8801;
        ///<summary>ATI_separate_stencil</summary>
        public const int STENCIL_BACK_PASS_DEPTH_FAIL_ATI = 0x8802;
        ///<summary>ATI_separate_stencil</summary>
        public const int STENCIL_BACK_PASS_DEPTH_PASS_ATI = 0x8803;
        ///<summary>OES_read_format</summary>
        public const int IMPLEMENTATION_COLOR_READ_TYPE_OES = 0x8B9A;
        ///<summary>OES_read_format</summary>
        public const int IMPLEMENTATION_COLOR_READ_FORMAT_OES = 0x8B9B;
        ///<summary>EXT_depth_bounds_test</summary>
        public const int DEPTH_BOUNDS_TEST_EXT = 0x8890;
        ///<summary>EXT_depth_bounds_test</summary>
        public const int DEPTH_BOUNDS_EXT = 0x8891;
        ///<summary>EXT_texture_mirror_clamp</summary>
        public const int MIRROR_CLAMP_EXT = 0x8742;
        ///<summary>EXT_texture_mirror_clamp</summary>
        public const int MIRROR_CLAMP_TO_EDGE_EXT = 0x8743;
        ///<summary>EXT_texture_mirror_clamp</summary>
        public const int MIRROR_CLAMP_TO_BORDER_EXT = 0x8912;
        ///<summary>EXT_blend_equation_separate</summary>
        public const int BLEND_EQUATION_RGB_EXT = 0x8009;
        ///<summary>EXT_blend_equation_separate</summary>
        public const int BLEND_EQUATION_ALPHA_EXT = 0x883D;
        ///<summary>MESA_pack_invert</summary>
        public const int PACK_INVERT_MESA = 0x8758;
        ///<summary>MESA_ycbcr_texture</summary>
        public const int UNSIGNED_SHORT_8_8_MESA = 0x85BA;
        ///<summary>MESA_ycbcr_texture</summary>
        public const int UNSIGNED_SHORT_8_8_REV_MESA = 0x85BB;
        ///<summary>MESA_ycbcr_texture</summary>
        public const int YCBCR_MESA = 0x8757;
        ///<summary>EXT_pixel_buffer_object</summary>
        public const int PIXEL_PACK_BUFFER_EXT = 0x88EB;
        ///<summary>EXT_pixel_buffer_object</summary>
        public const int PIXEL_UNPACK_BUFFER_EXT = 0x88EC;
        ///<summary>EXT_pixel_buffer_object</summary>
        public const int PIXEL_PACK_BUFFER_BINDING_EXT = 0x88ED;
        ///<summary>EXT_pixel_buffer_object</summary>
        public const int PIXEL_UNPACK_BUFFER_BINDING_EXT = 0x88EF;
        ///<summary>NV_fragment_program2</summary>
        public const int MAX_PROGRAM_EXEC_INSTRUCTIONS_NV = 0x88F4;
        ///<summary>NV_fragment_program2</summary>
        public const int MAX_PROGRAM_CALL_DEPTH_NV = 0x88F5;
        ///<summary>NV_fragment_program2</summary>
        public const int MAX_PROGRAM_IF_DEPTH_NV = 0x88F6;
        ///<summary>NV_fragment_program2</summary>
        public const int MAX_PROGRAM_LOOP_DEPTH_NV = 0x88F7;
        ///<summary>NV_fragment_program2</summary>
        public const int MAX_PROGRAM_LOOP_COUNT_NV = 0x88F8;
        ///<summary>EXT_framebuffer_object</summary>
        public const int INVALID_FRAMEBUFFER_OPERATION_EXT = 0x0506;
        ///<summary>EXT_framebuffer_object</summary>
        public const int MAX_RENDERBUFFER_SIZE_EXT = 0x84E8;
        ///<summary>EXT_framebuffer_object</summary>
        public const int FRAMEBUFFER_BINDING_EXT = 0x8CA6;
        ///<summary>EXT_framebuffer_object</summary>
        public const int RENDERBUFFER_BINDING_EXT = 0x8CA7;
        ///<summary>EXT_framebuffer_object</summary>
        public const int FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT = 0x8CD0;
        ///<summary>EXT_framebuffer_object</summary>
        public const int FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT = 0x8CD1;
        ///<summary>EXT_framebuffer_object</summary>
        public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT = 0x8CD2;
        ///<summary>EXT_framebuffer_object</summary>
        public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT = 0x8CD3;
        ///<summary>EXT_framebuffer_object</summary>
        public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT = 0x8CD4;
        ///<summary>EXT_framebuffer_object</summary>
        public const int FRAMEBUFFER_COMPLETE_EXT = 0x8CD5;
        ///<summary>EXT_framebuffer_object</summary>
        public const int FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT = 0x8CD6;
        ///<summary>EXT_framebuffer_object</summary>
        public const int FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT = 0x8CD7;
        ///<summary>EXT_framebuffer_object</summary>
        public const int FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT = 0x8CD9;
        ///<summary>EXT_framebuffer_object</summary>
        public const int FRAMEBUFFER_INCOMPLETE_FORMATS_EXT = 0x8CDA;
        ///<summary>EXT_framebuffer_object</summary>
        public const int FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT = 0x8CDB;
        ///<summary>EXT_framebuffer_object</summary>
        public const int FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT = 0x8CDC;
        ///<summary>EXT_framebuffer_object</summary>
        public const int FRAMEBUFFER_UNSUPPORTED_EXT = 0x8CDD;
        ///<summary>EXT_framebuffer_object</summary>
        public const int MAX_COLOR_ATTACHMENTS_EXT = 0x8CDF;
        ///<summary>EXT_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT0_EXT = 0x8CE0;
        ///<summary>EXT_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT1_EXT = 0x8CE1;
        ///<summary>EXT_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT2_EXT = 0x8CE2;
        ///<summary>EXT_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT3_EXT = 0x8CE3;
        ///<summary>EXT_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT4_EXT = 0x8CE4;
        ///<summary>EXT_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT5_EXT = 0x8CE5;
        ///<summary>EXT_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT6_EXT = 0x8CE6;
        ///<summary>EXT_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT7_EXT = 0x8CE7;
        ///<summary>EXT_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT8_EXT = 0x8CE8;
        ///<summary>EXT_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT9_EXT = 0x8CE9;
        ///<summary>EXT_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT10_EXT = 0x8CEA;
        ///<summary>EXT_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT11_EXT = 0x8CEB;
        ///<summary>EXT_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT12_EXT = 0x8CEC;
        ///<summary>EXT_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT13_EXT = 0x8CED;
        ///<summary>EXT_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT14_EXT = 0x8CEE;
        ///<summary>EXT_framebuffer_object</summary>
        public const int COLOR_ATTACHMENT15_EXT = 0x8CEF;
        ///<summary>EXT_framebuffer_object</summary>
        public const int DEPTH_ATTACHMENT_EXT = 0x8D00;
        ///<summary>EXT_framebuffer_object</summary>
        public const int STENCIL_ATTACHMENT_EXT = 0x8D20;
        ///<summary>EXT_framebuffer_object</summary>
        public const int FRAMEBUFFER_EXT = 0x8D40;
        ///<summary>EXT_framebuffer_object</summary>
        public const int RENDERBUFFER_EXT = 0x8D41;
        ///<summary>EXT_framebuffer_object</summary>
        public const int RENDERBUFFER_WIDTH_EXT = 0x8D42;
        ///<summary>EXT_framebuffer_object</summary>
        public const int RENDERBUFFER_HEIGHT_EXT = 0x8D43;
        ///<summary>EXT_framebuffer_object</summary>
        public const int RENDERBUFFER_INTERNAL_FORMAT_EXT = 0x8D44;
        ///<summary>EXT_framebuffer_object</summary>
        public const int STENCIL_INDEX1_EXT = 0x8D46;
        ///<summary>EXT_framebuffer_object</summary>
        public const int STENCIL_INDEX4_EXT = 0x8D47;
        ///<summary>EXT_framebuffer_object</summary>
        public const int STENCIL_INDEX8_EXT = 0x8D48;
        ///<summary>EXT_framebuffer_object</summary>
        public const int STENCIL_INDEX16_EXT = 0x8D49;
        ///<summary>EXT_framebuffer_object</summary>
        public const int RENDERBUFFER_RED_SIZE_EXT = 0x8D50;
        ///<summary>EXT_framebuffer_object</summary>
        public const int RENDERBUFFER_GREEN_SIZE_EXT = 0x8D51;
        ///<summary>EXT_framebuffer_object</summary>
        public const int RENDERBUFFER_BLUE_SIZE_EXT = 0x8D52;
        ///<summary>EXT_framebuffer_object</summary>
        public const int RENDERBUFFER_ALPHA_SIZE_EXT = 0x8D53;
        ///<summary>EXT_framebuffer_object</summary>
        public const int RENDERBUFFER_DEPTH_SIZE_EXT = 0x8D54;
        ///<summary>EXT_framebuffer_object</summary>
        public const int RENDERBUFFER_STENCIL_SIZE_EXT = 0x8D55;
        ///<summary>EXT_packed_depth_stencil</summary>
        public const int DEPTH_STENCIL_EXT = 0x84F9;
        ///<summary>EXT_packed_depth_stencil</summary>
        public const int UNSIGNED_INT_24_8_EXT = 0x84FA;
        ///<summary>EXT_packed_depth_stencil</summary>
        public const int DEPTH24_STENCIL8_EXT = 0x88F0;
        ///<summary>EXT_packed_depth_stencil</summary>
        public const int TEXTURE_STENCIL_SIZE_EXT = 0x88F1;
        ///<summary>EXT_stencil_clear_tag</summary>
        public const int STENCIL_TAG_BITS_EXT = 0x88F2;
        ///<summary>EXT_stencil_clear_tag</summary>
        public const int STENCIL_CLEAR_TAG_VALUE_EXT = 0x88F3;
        ///<summary>EXT_texture_sRGB</summary>
        public const int SRGB_EXT = 0x8C40;
        ///<summary>EXT_texture_sRGB</summary>
        public const int SRGB8_EXT = 0x8C41;
        ///<summary>EXT_texture_sRGB</summary>
        public const int SRGB_ALPHA_EXT = 0x8C42;
        ///<summary>EXT_texture_sRGB</summary>
        public const int SRGB8_ALPHA8_EXT = 0x8C43;
        ///<summary>EXT_texture_sRGB</summary>
        public const int SLUMINANCE_ALPHA_EXT = 0x8C44;
        ///<summary>EXT_texture_sRGB</summary>
        public const int SLUMINANCE8_ALPHA8_EXT = 0x8C45;
        ///<summary>EXT_texture_sRGB</summary>
        public const int SLUMINANCE_EXT = 0x8C46;
        ///<summary>EXT_texture_sRGB</summary>
        public const int SLUMINANCE8_EXT = 0x8C47;
        ///<summary>EXT_texture_sRGB</summary>
        public const int COMPRESSED_SRGB_EXT = 0x8C48;
        ///<summary>EXT_texture_sRGB</summary>
        public const int COMPRESSED_SRGB_ALPHA_EXT = 0x8C49;
        ///<summary>EXT_texture_sRGB</summary>
        public const int COMPRESSED_SLUMINANCE_EXT = 0x8C4A;
        ///<summary>EXT_texture_sRGB</summary>
        public const int COMPRESSED_SLUMINANCE_ALPHA_EXT = 0x8C4B;
        ///<summary>EXT_texture_sRGB</summary>
        public const int COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C;
        ///<summary>EXT_texture_sRGB</summary>
        public const int COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D;
        ///<summary>EXT_texture_sRGB</summary>
        public const int COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E;
        ///<summary>EXT_texture_sRGB</summary>
        public const int COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F;
        ///<summary>EXT_framebuffer_blit</summary>
        public const int READ_FRAMEBUFFER_EXT = 0x8CA8;
        ///<summary>EXT_framebuffer_blit</summary>
        public const int DRAW_FRAMEBUFFER_EXT = 0x8CA9;
        ///<summary>EXT_framebuffer_blit</summary>
        public const int DRAW_FRAMEBUFFER_BINDING_EXT = 0x8CA6;
        ///<summary>EXT_framebuffer_blit</summary>
        public const int READ_FRAMEBUFFER_BINDING_EXT = 0x8CAA;
        ///<summary>EXT_framebuffer_multisample</summary>
        public const int RENDERBUFFER_SAMPLES_EXT = 0x8CAB;
        ///<summary>EXT_framebuffer_multisample</summary>
        public const int FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT = 0x8D56;
        ///<summary>EXT_framebuffer_multisample</summary>
        public const int MAX_SAMPLES_EXT = 0x8D57;
        ///<summary>MESAX_texture_stack</summary>
        public const int TEXTURE_1D_STACK_MESAX = 0x8759;
        ///<summary>MESAX_texture_stack</summary>
        public const int TEXTURE_2D_STACK_MESAX = 0x875A;
        ///<summary>MESAX_texture_stack</summary>
        public const int PROXY_TEXTURE_1D_STACK_MESAX = 0x875B;
        ///<summary>MESAX_texture_stack</summary>
        public const int PROXY_TEXTURE_2D_STACK_MESAX = 0x875C;
        ///<summary>MESAX_texture_stack</summary>
        public const int TEXTURE_1D_STACK_BINDING_MESAX = 0x875D;
        ///<summary>MESAX_texture_stack</summary>
        public const int TEXTURE_2D_STACK_BINDING_MESAX = 0x875E;
        ///<summary>EXT_timer_query</summary>
        public const int TIME_ELAPSED_EXT = 0x88BF;
        ///<summary>APPLE_flush_buffer_range</summary>
        public const int BUFFER_SERIALIZED_MODIFY_APPLE = 0x8A12;
        ///<summary>APPLE_flush_buffer_range</summary>
        public const int BUFFER_FLUSHING_UNMAP_APPLE = 0x8A13;
        ///<summary>NV_gpu_program4</summary>
        public const int MIN_PROGRAM_TEXEL_OFFSET_NV = 0x8904;
        ///<summary>NV_gpu_program4</summary>
        public const int MAX_PROGRAM_TEXEL_OFFSET_NV = 0x8905;
        ///<summary>NV_gpu_program4</summary>
        public const int PROGRAM_ATTRIB_COMPONENTS_NV = 0x8906;
        ///<summary>NV_gpu_program4</summary>
        public const int PROGRAM_RESULT_COMPONENTS_NV = 0x8907;
        ///<summary>NV_gpu_program4</summary>
        public const int MAX_PROGRAM_ATTRIB_COMPONENTS_NV = 0x8908;
        ///<summary>NV_gpu_program4</summary>
        public const int MAX_PROGRAM_RESULT_COMPONENTS_NV = 0x8909;
        ///<summary>NV_gpu_program4</summary>
        public const int MAX_PROGRAM_GENERIC_ATTRIBS_NV = 0x8DA5;
        ///<summary>NV_gpu_program4</summary>
        public const int MAX_PROGRAM_GENERIC_RESULTS_NV = 0x8DA6;
        ///<summary>NV_geometry_program4</summary>
        public const int LINES_ADJACENCY_EXT = 0x000A;
        ///<summary>NV_geometry_program4</summary>
        public const int LINE_STRIP_ADJACENCY_EXT = 0x000B;
        ///<summary>NV_geometry_program4</summary>
        public const int TRIANGLES_ADJACENCY_EXT = 0x000C;
        ///<summary>NV_geometry_program4</summary>
        public const int TRIANGLE_STRIP_ADJACENCY_EXT = 0x000D;
        ///<summary>NV_geometry_program4</summary>
        public const int GEOMETRY_PROGRAM_NV = 0x8C26;
        ///<summary>NV_geometry_program4</summary>
        public const int MAX_PROGRAM_OUTPUT_VERTICES_NV = 0x8C27;
        ///<summary>NV_geometry_program4</summary>
        public const int MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV = 0x8C28;
        ///<summary>NV_geometry_program4</summary>
        public const int GEOMETRY_VERTICES_OUT_EXT = 0x8DDA;
        ///<summary>NV_geometry_program4</summary>
        public const int GEOMETRY_INPUT_TYPE_EXT = 0x8DDB;
        ///<summary>NV_geometry_program4</summary>
        public const int GEOMETRY_OUTPUT_TYPE_EXT = 0x8DDC;
        ///<summary>NV_geometry_program4</summary>
        public const int MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT = 0x8C29;
        ///<summary>NV_geometry_program4</summary>
        public const int FRAMEBUFFER_ATTACHMENT_LAYERED_EXT = 0x8DA7;
        ///<summary>NV_geometry_program4</summary>
        public const int FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT = 0x8DA8;
        ///<summary>NV_geometry_program4</summary>
        public const int FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT = 0x8DA9;
        ///<summary>NV_geometry_program4</summary>
        public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT = 0x8CD4;
        ///<summary>NV_geometry_program4</summary>
        public const int PROGRAM_POINT_SIZE_EXT = 0x8642;
        ///<summary>EXT_geometry_shader4</summary>
        public const int GEOMETRY_SHADER_EXT = 0x8DD9;
        ///<summary>EXT_geometry_shader4</summary>
        public const int MAX_GEOMETRY_VARYING_COMPONENTS_EXT = 0x8DDD;
        ///<summary>EXT_geometry_shader4</summary>
        public const int MAX_VERTEX_VARYING_COMPONENTS_EXT = 0x8DDE;
        ///<summary>EXT_geometry_shader4</summary>
        public const int MAX_VARYING_COMPONENTS_EXT = 0x8B4B;
        ///<summary>EXT_geometry_shader4</summary>
        public const int MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT = 0x8DDF;
        ///<summary>EXT_geometry_shader4</summary>
        public const int MAX_GEOMETRY_OUTPUT_VERTICES_EXT = 0x8DE0;
        ///<summary>EXT_geometry_shader4</summary>
        public const int MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT = 0x8DE1;
        ///<summary>NV_vertex_program4</summary>
        public const int VERTEX_ATTRIB_ARRAY_INTEGER_NV = 0x88FD;
        ///<summary>EXT_gpu_shader4</summary>
        public const int SAMPLER_1D_ARRAY_EXT = 0x8DC0;
        ///<summary>EXT_gpu_shader4</summary>
        public const int SAMPLER_2D_ARRAY_EXT = 0x8DC1;
        ///<summary>EXT_gpu_shader4</summary>
        public const int SAMPLER_BUFFER_EXT = 0x8DC2;
        ///<summary>EXT_gpu_shader4</summary>
        public const int SAMPLER_1D_ARRAY_SHADOW_EXT = 0x8DC3;
        ///<summary>EXT_gpu_shader4</summary>
        public const int SAMPLER_2D_ARRAY_SHADOW_EXT = 0x8DC4;
        ///<summary>EXT_gpu_shader4</summary>
        public const int SAMPLER_CUBE_SHADOW_EXT = 0x8DC5;
        ///<summary>EXT_gpu_shader4</summary>
        public const int UNSIGNED_INT_VEC2_EXT = 0x8DC6;
        ///<summary>EXT_gpu_shader4</summary>
        public const int UNSIGNED_INT_VEC3_EXT = 0x8DC7;
        ///<summary>EXT_gpu_shader4</summary>
        public const int UNSIGNED_INT_VEC4_EXT = 0x8DC8;
        ///<summary>EXT_gpu_shader4</summary>
        public const int INT_SAMPLER_1D_EXT = 0x8DC9;
        ///<summary>EXT_gpu_shader4</summary>
        public const int INT_SAMPLER_2D_EXT = 0x8DCA;
        ///<summary>EXT_gpu_shader4</summary>
        public const int INT_SAMPLER_3D_EXT = 0x8DCB;
        ///<summary>EXT_gpu_shader4</summary>
        public const int INT_SAMPLER_CUBE_EXT = 0x8DCC;
        ///<summary>EXT_gpu_shader4</summary>
        public const int INT_SAMPLER_2D_RECT_EXT = 0x8DCD;
        ///<summary>EXT_gpu_shader4</summary>
        public const int INT_SAMPLER_1D_ARRAY_EXT = 0x8DCE;
        ///<summary>EXT_gpu_shader4</summary>
        public const int INT_SAMPLER_2D_ARRAY_EXT = 0x8DCF;
        ///<summary>EXT_gpu_shader4</summary>
        public const int INT_SAMPLER_BUFFER_EXT = 0x8DD0;
        ///<summary>EXT_gpu_shader4</summary>
        public const int UNSIGNED_INT_SAMPLER_1D_EXT = 0x8DD1;
        ///<summary>EXT_gpu_shader4</summary>
        public const int UNSIGNED_INT_SAMPLER_2D_EXT = 0x8DD2;
        ///<summary>EXT_gpu_shader4</summary>
        public const int UNSIGNED_INT_SAMPLER_3D_EXT = 0x8DD3;
        ///<summary>EXT_gpu_shader4</summary>
        public const int UNSIGNED_INT_SAMPLER_CUBE_EXT = 0x8DD4;
        ///<summary>EXT_gpu_shader4</summary>
        public const int UNSIGNED_INT_SAMPLER_2D_RECT_EXT = 0x8DD5;
        ///<summary>EXT_gpu_shader4</summary>
        public const int UNSIGNED_INT_SAMPLER_1D_ARRAY_EXT = 0x8DD6;
        ///<summary>EXT_gpu_shader4</summary>
        public const int UNSIGNED_INT_SAMPLER_2D_ARRAY_EXT = 0x8DD7;
        ///<summary>EXT_gpu_shader4</summary>
        public const int UNSIGNED_INT_SAMPLER_BUFFER_EXT = 0x8DD8;
        ///<summary>EXT_packed_float</summary>
        public const int R11F_G11F_B10F_EXT = 0x8C3A;
        ///<summary>EXT_packed_float</summary>
        public const int UNSIGNED_INT_10F_11F_11F_REV_EXT = 0x8C3B;
        ///<summary>EXT_packed_float</summary>
        public const int RGBA_SIGNED_COMPONENTS_EXT = 0x8C3C;
        ///<summary>EXT_texture_array</summary>
        public const int TEXTURE_1D_ARRAY_EXT = 0x8C18;
        ///<summary>EXT_texture_array</summary>
        public const int PROXY_TEXTURE_1D_ARRAY_EXT = 0x8C19;
        ///<summary>EXT_texture_array</summary>
        public const int TEXTURE_2D_ARRAY_EXT = 0x8C1A;
        ///<summary>EXT_texture_array</summary>
        public const int PROXY_TEXTURE_2D_ARRAY_EXT = 0x8C1B;
        ///<summary>EXT_texture_array</summary>
        public const int TEXTURE_BINDING_1D_ARRAY_EXT = 0x8C1C;
        ///<summary>EXT_texture_array</summary>
        public const int TEXTURE_BINDING_2D_ARRAY_EXT = 0x8C1D;
        ///<summary>EXT_texture_array</summary>
        public const int MAX_ARRAY_TEXTURE_LAYERS_EXT = 0x88FF;
        ///<summary>EXT_texture_array</summary>
        public const int COMPARE_REF_DEPTH_TO_TEXTURE_EXT = 0x884E;
        ///<summary>EXT_texture_buffer_object</summary>
        public const int TEXTURE_BUFFER_EXT = 0x8C2A;
        ///<summary>EXT_texture_buffer_object</summary>
        public const int MAX_TEXTURE_BUFFER_SIZE_EXT = 0x8C2B;
        ///<summary>EXT_texture_buffer_object</summary>
        public const int TEXTURE_BINDING_BUFFER_EXT = 0x8C2C;
        ///<summary>EXT_texture_buffer_object</summary>
        public const int TEXTURE_BUFFER_DATA_STORE_BINDING_EXT = 0x8C2D;
        ///<summary>EXT_texture_buffer_object</summary>
        public const int TEXTURE_BUFFER_FORMAT_EXT = 0x8C2E;
        ///<summary>EXT_texture_compression_latc</summary>
        public const int COMPRESSED_LUMINANCE_LATC1_EXT = 0x8C70;
        ///<summary>EXT_texture_compression_latc</summary>
        public const int COMPRESSED_SIGNED_LUMINANCE_LATC1_EXT = 0x8C71;
        ///<summary>EXT_texture_compression_latc</summary>
        public const int COMPRESSED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C72;
        ///<summary>EXT_texture_compression_latc</summary>
        public const int COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C73;
        ///<summary>EXT_texture_compression_rgtc</summary>
        public const int COMPRESSED_RED_RGTC1_EXT = 0x8DBB;
        ///<summary>EXT_texture_compression_rgtc</summary>
        public const int COMPRESSED_SIGNED_RED_RGTC1_EXT = 0x8DBC;
        ///<summary>EXT_texture_compression_rgtc</summary>
        public const int COMPRESSED_RED_GREEN_RGTC2_EXT = 0x8DBD;
        ///<summary>EXT_texture_compression_rgtc</summary>
        public const int COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT = 0x8DBE;
        ///<summary>EXT_texture_shared_exponent</summary>
        public const int RGB9_E5_EXT = 0x8C3D;
        ///<summary>EXT_texture_shared_exponent</summary>
        public const int UNSIGNED_INT_5_9_9_9_REV_EXT = 0x8C3E;
        ///<summary>EXT_texture_shared_exponent</summary>
        public const int TEXTURE_SHARED_SIZE_EXT = 0x8C3F;
        ///<summary>NV_depth_buffer_float</summary>
        public const int DEPTH_COMPONENT32F_NV = 0x8DAB;
        ///<summary>NV_depth_buffer_float</summary>
        public const int DEPTH32F_STENCIL8_NV = 0x8DAC;
        ///<summary>NV_depth_buffer_float</summary>
        public const int FLOAT_32_UNSIGNED_INT_24_8_REV_NV = 0x8DAD;
        ///<summary>NV_depth_buffer_float</summary>
        public const int DEPTH_BUFFER_FLOAT_MODE_NV = 0x8DAF;
        ///<summary>NV_framebuffer_multisample_coverage</summary>
        public const int RENDERBUFFER_COVERAGE_SAMPLES_NV = 0x8CAB;
        ///<summary>NV_framebuffer_multisample_coverage</summary>
        public const int RENDERBUFFER_COLOR_SAMPLES_NV = 0x8E10;
        ///<summary>NV_framebuffer_multisample_coverage</summary>
        public const int MAX_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E11;
        ///<summary>NV_framebuffer_multisample_coverage</summary>
        public const int MULTISAMPLE_COVERAGE_MODES_NV = 0x8E12;
        ///<summary>EXT_framebuffer_sRGB</summary>
        public const int FRAMEBUFFER_SRGB_EXT = 0x8DB9;
        ///<summary>EXT_framebuffer_sRGB</summary>
        public const int FRAMEBUFFER_SRGB_CAPABLE_EXT = 0x8DBA;
        ///<summary>NV_parameter_buffer_object</summary>
        public const int MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV = 0x8DA0;
        ///<summary>NV_parameter_buffer_object</summary>
        public const int MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV = 0x8DA1;
        ///<summary>NV_parameter_buffer_object</summary>
        public const int VERTEX_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA2;
        ///<summary>NV_parameter_buffer_object</summary>
        public const int GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA3;
        ///<summary>NV_parameter_buffer_object</summary>
        public const int FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA4;
        ///<summary>NV_transform_feedback</summary>
        public const int BACK_PRIMARY_COLOR_NV = 0x8C77;
        ///<summary>NV_transform_feedback</summary>
        public const int BACK_SECONDARY_COLOR_NV = 0x8C78;
        ///<summary>NV_transform_feedback</summary>
        public const int TEXTURE_COORD_NV = 0x8C79;
        ///<summary>NV_transform_feedback</summary>
        public const int CLIP_DISTANCE_NV = 0x8C7A;
        ///<summary>NV_transform_feedback</summary>
        public const int VERTEX_ID_NV = 0x8C7B;
        ///<summary>NV_transform_feedback</summary>
        public const int PRIMITIVE_ID_NV = 0x8C7C;
        ///<summary>NV_transform_feedback</summary>
        public const int GENERIC_ATTRIB_NV = 0x8C7D;
        ///<summary>NV_transform_feedback</summary>
        public const int TRANSFORM_FEEDBACK_ATTRIBS_NV = 0x8C7E;
        ///<summary>NV_transform_feedback</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER_MODE_NV = 0x8C7F;
        ///<summary>NV_transform_feedback</summary>
        public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_NV = 0x8C80;
        ///<summary>NV_transform_feedback</summary>
        public const int ACTIVE_VARYINGS_NV = 0x8C81;
        ///<summary>NV_transform_feedback</summary>
        public const int ACTIVE_VARYING_MAX_LENGTH_NV = 0x8C82;
        ///<summary>NV_transform_feedback</summary>
        public const int TRANSFORM_FEEDBACK_VARYINGS_NV = 0x8C83;
        ///<summary>NV_transform_feedback</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER_START_NV = 0x8C84;
        ///<summary>NV_transform_feedback</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER_SIZE_NV = 0x8C85;
        ///<summary>NV_transform_feedback</summary>
        public const int TRANSFORM_FEEDBACK_RECORD_NV = 0x8C86;
        ///<summary>NV_transform_feedback</summary>
        public const int PRIMITIVES_GENERATED_NV = 0x8C87;
        ///<summary>NV_transform_feedback</summary>
        public const int TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_NV = 0x8C88;
        ///<summary>NV_transform_feedback</summary>
        public const int RASTERIZER_DISCARD_NV = 0x8C89;
        ///<summary>NV_transform_feedback</summary>
        public const int MAX_TRANSFORM_FEEDBACK_INTERLEAVED_ATTRIBS_NV = 0x8C8A;
        ///<summary>NV_transform_feedback</summary>
        public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_NV = 0x8C8B;
        ///<summary>NV_transform_feedback</summary>
        public const int INTERLEAVED_ATTRIBS_NV = 0x8C8C;
        ///<summary>NV_transform_feedback</summary>
        public const int SEPARATE_ATTRIBS_NV = 0x8C8D;
        ///<summary>NV_transform_feedback</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER_NV = 0x8C8E;
        ///<summary>NV_transform_feedback</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER_BINDING_NV = 0x8C8F;
        ///<summary>NV_transform_feedback</summary>
        public const int LAYER_NV = 0x8DAA;
        ///<summary>NV_transform_feedback</summary>
        public const int NEXT_BUFFER_NV = -2;
        ///<summary>NV_transform_feedback</summary>
        public const int SKIP_COMPONENTS4_NV = -3;
        ///<summary>NV_transform_feedback</summary>
        public const int SKIP_COMPONENTS3_NV = -4;
        ///<summary>NV_transform_feedback</summary>
        public const int SKIP_COMPONENTS2_NV = -5;
        ///<summary>NV_transform_feedback</summary>
        public const int SKIP_COMPONENTS1_NV = -6;
        ///<summary>EXT_bindable_uniform</summary>
        public const int MAX_VERTEX_BINDABLE_UNIFORMS_EXT = 0x8DE2;
        ///<summary>EXT_bindable_uniform</summary>
        public const int MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT = 0x8DE3;
        ///<summary>EXT_bindable_uniform</summary>
        public const int MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT = 0x8DE4;
        ///<summary>EXT_bindable_uniform</summary>
        public const int MAX_BINDABLE_UNIFORM_SIZE_EXT = 0x8DED;
        ///<summary>EXT_bindable_uniform</summary>
        public const int UNIFORM_BUFFER_EXT = 0x8DEE;
        ///<summary>EXT_bindable_uniform</summary>
        public const int UNIFORM_BUFFER_BINDING_EXT = 0x8DEF;
        ///<summary>EXT_texture_integer</summary>
        public const int RGBA32UI_EXT = 0x8D70;
        ///<summary>EXT_texture_integer</summary>
        public const int RGB32UI_EXT = 0x8D71;
        ///<summary>EXT_texture_integer</summary>
        public const int ALPHA32UI_EXT = 0x8D72;
        ///<summary>EXT_texture_integer</summary>
        public const int INTENSITY32UI_EXT = 0x8D73;
        ///<summary>EXT_texture_integer</summary>
        public const int LUMINANCE32UI_EXT = 0x8D74;
        ///<summary>EXT_texture_integer</summary>
        public const int LUMINANCE_ALPHA32UI_EXT = 0x8D75;
        ///<summary>EXT_texture_integer</summary>
        public const int RGBA16UI_EXT = 0x8D76;
        ///<summary>EXT_texture_integer</summary>
        public const int RGB16UI_EXT = 0x8D77;
        ///<summary>EXT_texture_integer</summary>
        public const int ALPHA16UI_EXT = 0x8D78;
        ///<summary>EXT_texture_integer</summary>
        public const int INTENSITY16UI_EXT = 0x8D79;
        ///<summary>EXT_texture_integer</summary>
        public const int LUMINANCE16UI_EXT = 0x8D7A;
        ///<summary>EXT_texture_integer</summary>
        public const int LUMINANCE_ALPHA16UI_EXT = 0x8D7B;
        ///<summary>EXT_texture_integer</summary>
        public const int RGBA8UI_EXT = 0x8D7C;
        ///<summary>EXT_texture_integer</summary>
        public const int RGB8UI_EXT = 0x8D7D;
        ///<summary>EXT_texture_integer</summary>
        public const int ALPHA8UI_EXT = 0x8D7E;
        ///<summary>EXT_texture_integer</summary>
        public const int INTENSITY8UI_EXT = 0x8D7F;
        ///<summary>EXT_texture_integer</summary>
        public const int LUMINANCE8UI_EXT = 0x8D80;
        ///<summary>EXT_texture_integer</summary>
        public const int LUMINANCE_ALPHA8UI_EXT = 0x8D81;
        ///<summary>EXT_texture_integer</summary>
        public const int RGBA32I_EXT = 0x8D82;
        ///<summary>EXT_texture_integer</summary>
        public const int RGB32I_EXT = 0x8D83;
        ///<summary>EXT_texture_integer</summary>
        public const int ALPHA32I_EXT = 0x8D84;
        ///<summary>EXT_texture_integer</summary>
        public const int INTENSITY32I_EXT = 0x8D85;
        ///<summary>EXT_texture_integer</summary>
        public const int LUMINANCE32I_EXT = 0x8D86;
        ///<summary>EXT_texture_integer</summary>
        public const int LUMINANCE_ALPHA32I_EXT = 0x8D87;
        ///<summary>EXT_texture_integer</summary>
        public const int RGBA16I_EXT = 0x8D88;
        ///<summary>EXT_texture_integer</summary>
        public const int RGB16I_EXT = 0x8D89;
        ///<summary>EXT_texture_integer</summary>
        public const int ALPHA16I_EXT = 0x8D8A;
        ///<summary>EXT_texture_integer</summary>
        public const int INTENSITY16I_EXT = 0x8D8B;
        ///<summary>EXT_texture_integer</summary>
        public const int LUMINANCE16I_EXT = 0x8D8C;
        ///<summary>EXT_texture_integer</summary>
        public const int LUMINANCE_ALPHA16I_EXT = 0x8D8D;
        ///<summary>EXT_texture_integer</summary>
        public const int RGBA8I_EXT = 0x8D8E;
        ///<summary>EXT_texture_integer</summary>
        public const int RGB8I_EXT = 0x8D8F;
        ///<summary>EXT_texture_integer</summary>
        public const int ALPHA8I_EXT = 0x8D90;
        ///<summary>EXT_texture_integer</summary>
        public const int INTENSITY8I_EXT = 0x8D91;
        ///<summary>EXT_texture_integer</summary>
        public const int LUMINANCE8I_EXT = 0x8D92;
        ///<summary>EXT_texture_integer</summary>
        public const int LUMINANCE_ALPHA8I_EXT = 0x8D93;
        ///<summary>EXT_texture_integer</summary>
        public const int RED_INTEGER_EXT = 0x8D94;
        ///<summary>EXT_texture_integer</summary>
        public const int GREEN_INTEGER_EXT = 0x8D95;
        ///<summary>EXT_texture_integer</summary>
        public const int BLUE_INTEGER_EXT = 0x8D96;
        ///<summary>EXT_texture_integer</summary>
        public const int ALPHA_INTEGER_EXT = 0x8D97;
        ///<summary>EXT_texture_integer</summary>
        public const int RGB_INTEGER_EXT = 0x8D98;
        ///<summary>EXT_texture_integer</summary>
        public const int RGBA_INTEGER_EXT = 0x8D99;
        ///<summary>EXT_texture_integer</summary>
        public const int BGR_INTEGER_EXT = 0x8D9A;
        ///<summary>EXT_texture_integer</summary>
        public const int BGRA_INTEGER_EXT = 0x8D9B;
        ///<summary>EXT_texture_integer</summary>
        public const int LUMINANCE_INTEGER_EXT = 0x8D9C;
        ///<summary>EXT_texture_integer</summary>
        public const int LUMINANCE_ALPHA_INTEGER_EXT = 0x8D9D;
        ///<summary>EXT_texture_integer</summary>
        public const int RGBA_INTEGER_MODE_EXT = 0x8D9E;
        ///<summary>NV_conditional_render</summary>
        public const int QUERY_WAIT_NV = 0x8E13;
        ///<summary>NV_conditional_render</summary>
        public const int QUERY_NO_WAIT_NV = 0x8E14;
        ///<summary>NV_conditional_render</summary>
        public const int QUERY_BY_REGION_WAIT_NV = 0x8E15;
        ///<summary>NV_conditional_render</summary>
        public const int QUERY_BY_REGION_NO_WAIT_NV = 0x8E16;
        ///<summary>NV_present_video</summary>
        public const int FRAME_NV = 0x8E26;
        ///<summary>NV_present_video</summary>
        public const int FIELDS_NV = 0x8E27;
        ///<summary>NV_present_video</summary>
        public const int CURRENT_TIME_NV = 0x8E28;
        ///<summary>NV_present_video</summary>
        public const int NUM_FILL_STREAMS_NV = 0x8E29;
        ///<summary>NV_present_video</summary>
        public const int PRESENT_TIME_NV = 0x8E2A;
        ///<summary>NV_present_video</summary>
        public const int PRESENT_DURATION_NV = 0x8E2B;
        ///<summary>EXT_transform_feedback</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER_EXT = 0x8C8E;
        ///<summary>EXT_transform_feedback</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER_START_EXT = 0x8C84;
        ///<summary>EXT_transform_feedback</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER_SIZE_EXT = 0x8C85;
        ///<summary>EXT_transform_feedback</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER_BINDING_EXT = 0x8C8F;
        ///<summary>EXT_transform_feedback</summary>
        public const int INTERLEAVED_ATTRIBS_EXT = 0x8C8C;
        ///<summary>EXT_transform_feedback</summary>
        public const int SEPARATE_ATTRIBS_EXT = 0x8C8D;
        ///<summary>EXT_transform_feedback</summary>
        public const int PRIMITIVES_GENERATED_EXT = 0x8C87;
        ///<summary>EXT_transform_feedback</summary>
        public const int TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_EXT = 0x8C88;
        ///<summary>EXT_transform_feedback</summary>
        public const int RASTERIZER_DISCARD_EXT = 0x8C89;
        ///<summary>EXT_transform_feedback</summary>
        public const int MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_EXT = 0x8C8A;
        ///<summary>EXT_transform_feedback</summary>
        public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_EXT = 0x8C8B;
        ///<summary>EXT_transform_feedback</summary>
        public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_EXT = 0x8C80;
        ///<summary>EXT_transform_feedback</summary>
        public const int TRANSFORM_FEEDBACK_VARYINGS_EXT = 0x8C83;
        ///<summary>EXT_transform_feedback</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER_MODE_EXT = 0x8C7F;
        ///<summary>EXT_transform_feedback</summary>
        public const int TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH_EXT = 0x8C76;
        ///<summary>EXT_direct_state_access</summary>
        public const int PROGRAM_MATRIX_EXT = 0x8E2D;
        ///<summary>EXT_direct_state_access</summary>
        public const int TRANSPOSE_PROGRAM_MATRIX_EXT = 0x8E2E;
        ///<summary>EXT_direct_state_access</summary>
        public const int PROGRAM_MATRIX_STACK_DEPTH_EXT = 0x8E2F;
        ///<summary>EXT_texture_swizzle</summary>
        public const int TEXTURE_SWIZZLE_R_EXT = 0x8E42;
        ///<summary>EXT_texture_swizzle</summary>
        public const int TEXTURE_SWIZZLE_G_EXT = 0x8E43;
        ///<summary>EXT_texture_swizzle</summary>
        public const int TEXTURE_SWIZZLE_B_EXT = 0x8E44;
        ///<summary>EXT_texture_swizzle</summary>
        public const int TEXTURE_SWIZZLE_A_EXT = 0x8E45;
        ///<summary>EXT_texture_swizzle</summary>
        public const int TEXTURE_SWIZZLE_RGBA_EXT = 0x8E46;
        ///<summary>NV_explicit_multisample</summary>
        public const int SAMPLE_POSITION_NV = 0x8E50;
        ///<summary>NV_explicit_multisample</summary>
        public const int SAMPLE_MASK_NV = 0x8E51;
        ///<summary>NV_explicit_multisample</summary>
        public const int SAMPLE_MASK_VALUE_NV = 0x8E52;
        ///<summary>NV_explicit_multisample</summary>
        public const int TEXTURE_BINDING_RENDERBUFFER_NV = 0x8E53;
        ///<summary>NV_explicit_multisample</summary>
        public const int TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV = 0x8E54;
        ///<summary>NV_explicit_multisample</summary>
        public const int TEXTURE_RENDERBUFFER_NV = 0x8E55;
        ///<summary>NV_explicit_multisample</summary>
        public const int SAMPLER_RENDERBUFFER_NV = 0x8E56;
        ///<summary>NV_explicit_multisample</summary>
        public const int INT_SAMPLER_RENDERBUFFER_NV = 0x8E57;
        ///<summary>NV_explicit_multisample</summary>
        public const int UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV = 0x8E58;
        ///<summary>NV_explicit_multisample</summary>
        public const int MAX_SAMPLE_MASK_WORDS_NV = 0x8E59;
        ///<summary>NV_transform_feedback2</summary>
        public const int TRANSFORM_FEEDBACK_NV = 0x8E22;
        ///<summary>NV_transform_feedback2</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER_PAUSED_NV = 0x8E23;
        ///<summary>NV_transform_feedback2</summary>
        public const int TRANSFORM_FEEDBACK_BUFFER_ACTIVE_NV = 0x8E24;
        ///<summary>NV_transform_feedback2</summary>
        public const int TRANSFORM_FEEDBACK_BINDING_NV = 0x8E25;
        ///<summary>ATI_meminfo</summary>
        public const int VBO_FREE_MEMORY_ATI = 0x87FB;
        ///<summary>ATI_meminfo</summary>
        public const int TEXTURE_FREE_MEMORY_ATI = 0x87FC;
        ///<summary>ATI_meminfo</summary>
        public const int RENDERBUFFER_FREE_MEMORY_ATI = 0x87FD;
        ///<summary>AMD_performance_monitor</summary>
        public const int COUNTER_TYPE_AMD = 0x8BC0;
        ///<summary>AMD_performance_monitor</summary>
        public const int COUNTER_RANGE_AMD = 0x8BC1;
        ///<summary>AMD_performance_monitor</summary>
        public const int UNSIGNED_INT64_AMD = 0x8BC2;
        ///<summary>AMD_performance_monitor</summary>
        public const int PERCENTAGE_AMD = 0x8BC3;
        ///<summary>AMD_performance_monitor</summary>
        public const int PERFMON_RESULT_AVAILABLE_AMD = 0x8BC4;
        ///<summary>AMD_performance_monitor</summary>
        public const int PERFMON_RESULT_SIZE_AMD = 0x8BC5;
        ///<summary>AMD_performance_monitor</summary>
        public const int PERFMON_RESULT_AMD = 0x8BC6;
        ///<summary>AMD_vertex_shader_tesselator</summary>
        public const int SAMPLER_BUFFER_AMD = 0x9001;
        ///<summary>AMD_vertex_shader_tesselator</summary>
        public const int INT_SAMPLER_BUFFER_AMD = 0x9002;
        ///<summary>AMD_vertex_shader_tesselator</summary>
        public const int UNSIGNED_INT_SAMPLER_BUFFER_AMD = 0x9003;
        ///<summary>AMD_vertex_shader_tesselator</summary>
        public const int TESSELLATION_MODE_AMD = 0x9004;
        ///<summary>AMD_vertex_shader_tesselator</summary>
        public const int TESSELLATION_FACTOR_AMD = 0x9005;
        ///<summary>AMD_vertex_shader_tesselator</summary>
        public const int DISCRETE_AMD = 0x9006;
        ///<summary>AMD_vertex_shader_tesselator</summary>
        public const int CONTINUOUS_AMD = 0x9007;
        ///<summary>EXT_provoking_vertex</summary>
        public const int QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION_EXT = 0x8E4C;
        ///<summary>EXT_provoking_vertex</summary>
        public const int FIRST_VERTEX_CONVENTION_EXT = 0x8E4D;
        ///<summary>EXT_provoking_vertex</summary>
        public const int LAST_VERTEX_CONVENTION_EXT = 0x8E4E;
        ///<summary>EXT_provoking_vertex</summary>
        public const int PROVOKING_VERTEX_EXT = 0x8E4F;
        ///<summary>EXT_texture_snorm</summary>
        public const int ALPHA_SNORM = 0x9010;
        ///<summary>EXT_texture_snorm</summary>
        public const int LUMINANCE_SNORM = 0x9011;
        ///<summary>EXT_texture_snorm</summary>
        public const int LUMINANCE_ALPHA_SNORM = 0x9012;
        ///<summary>EXT_texture_snorm</summary>
        public const int INTENSITY_SNORM = 0x9013;
        ///<summary>EXT_texture_snorm</summary>
        public const int ALPHA8_SNORM = 0x9014;
        ///<summary>EXT_texture_snorm</summary>
        public const int LUMINANCE8_SNORM = 0x9015;
        ///<summary>EXT_texture_snorm</summary>
        public const int LUMINANCE8_ALPHA8_SNORM = 0x9016;
        ///<summary>EXT_texture_snorm</summary>
        public const int INTENSITY8_SNORM = 0x9017;
        ///<summary>EXT_texture_snorm</summary>
        public const int ALPHA16_SNORM = 0x9018;
        ///<summary>EXT_texture_snorm</summary>
        public const int LUMINANCE16_SNORM = 0x9019;
        ///<summary>EXT_texture_snorm</summary>
        public const int LUMINANCE16_ALPHA16_SNORM = 0x901A;
        ///<summary>EXT_texture_snorm</summary>
        public const int INTENSITY16_SNORM = 0x901B;
        ///<summary>APPLE_texture_range</summary>
        public const int TEXTURE_RANGE_LENGTH_APPLE = 0x85B7;
        ///<summary>APPLE_texture_range</summary>
        public const int TEXTURE_RANGE_POINTER_APPLE = 0x85B8;
        ///<summary>APPLE_texture_range</summary>
        public const int TEXTURE_STORAGE_HINT_APPLE = 0x85BC;
        ///<summary>APPLE_texture_range</summary>
        public const int STORAGE_PRIVATE_APPLE = 0x85BD;
        ///<summary>APPLE_float_pixels</summary>
        public const int HALF_APPLE = 0x140B;
        ///<summary>APPLE_float_pixels</summary>
        public const int RGBA_FLOAT32_APPLE = 0x8814;
        ///<summary>APPLE_float_pixels</summary>
        public const int RGB_FLOAT32_APPLE = 0x8815;
        ///<summary>APPLE_float_pixels</summary>
        public const int ALPHA_FLOAT32_APPLE = 0x8816;
        ///<summary>APPLE_float_pixels</summary>
        public const int INTENSITY_FLOAT32_APPLE = 0x8817;
        ///<summary>APPLE_float_pixels</summary>
        public const int LUMINANCE_FLOAT32_APPLE = 0x8818;
        ///<summary>APPLE_float_pixels</summary>
        public const int LUMINANCE_ALPHA_FLOAT32_APPLE = 0x8819;
        ///<summary>APPLE_float_pixels</summary>
        public const int RGBA_FLOAT16_APPLE = 0x881A;
        ///<summary>APPLE_float_pixels</summary>
        public const int RGB_FLOAT16_APPLE = 0x881B;
        ///<summary>APPLE_float_pixels</summary>
        public const int ALPHA_FLOAT16_APPLE = 0x881C;
        ///<summary>APPLE_float_pixels</summary>
        public const int INTENSITY_FLOAT16_APPLE = 0x881D;
        ///<summary>APPLE_float_pixels</summary>
        public const int LUMINANCE_FLOAT16_APPLE = 0x881E;
        ///<summary>APPLE_float_pixels</summary>
        public const int LUMINANCE_ALPHA_FLOAT16_APPLE = 0x881F;
        ///<summary>APPLE_float_pixels</summary>
        public const int COLOR_FLOAT_APPLE = 0x8A0F;
        ///<summary>APPLE_vertex_program_evaluators</summary>
        public const int VERTEX_ATTRIB_MAP1_APPLE = 0x8A00;
        ///<summary>APPLE_vertex_program_evaluators</summary>
        public const int VERTEX_ATTRIB_MAP2_APPLE = 0x8A01;
        ///<summary>APPLE_vertex_program_evaluators</summary>
        public const int VERTEX_ATTRIB_MAP1_SIZE_APPLE = 0x8A02;
        ///<summary>APPLE_vertex_program_evaluators</summary>
        public const int VERTEX_ATTRIB_MAP1_COEFF_APPLE = 0x8A03;
        ///<summary>APPLE_vertex_program_evaluators</summary>
        public const int VERTEX_ATTRIB_MAP1_ORDER_APPLE = 0x8A04;
        ///<summary>APPLE_vertex_program_evaluators</summary>
        public const int VERTEX_ATTRIB_MAP1_DOMAIN_APPLE = 0x8A05;
        ///<summary>APPLE_vertex_program_evaluators</summary>
        public const int VERTEX_ATTRIB_MAP2_SIZE_APPLE = 0x8A06;
        ///<summary>APPLE_vertex_program_evaluators</summary>
        public const int VERTEX_ATTRIB_MAP2_COEFF_APPLE = 0x8A07;
        ///<summary>APPLE_vertex_program_evaluators</summary>
        public const int VERTEX_ATTRIB_MAP2_ORDER_APPLE = 0x8A08;
        ///<summary>APPLE_vertex_program_evaluators</summary>
        public const int VERTEX_ATTRIB_MAP2_DOMAIN_APPLE = 0x8A09;
        ///<summary>APPLE_aux_depth_stencil</summary>
        public const int AUX_DEPTH_STENCIL_APPLE = 0x8A14;
        ///<summary>APPLE_object_purgeable</summary>
        public const int BUFFER_OBJECT_APPLE = 0x85B3;
        ///<summary>APPLE_object_purgeable</summary>
        public const int RELEASED_APPLE = 0x8A19;
        ///<summary>APPLE_object_purgeable</summary>
        public const int VOLATILE_APPLE = 0x8A1A;
        ///<summary>APPLE_object_purgeable</summary>
        public const int RETAINED_APPLE = 0x8A1B;
        ///<summary>APPLE_object_purgeable</summary>
        public const int UNDEFINED_APPLE = 0x8A1C;
        ///<summary>APPLE_object_purgeable</summary>
        public const int PURGEABLE_APPLE = 0x8A1D;
        ///<summary>APPLE_row_bytes</summary>
        public const int PACK_ROW_BYTES_APPLE = 0x8A15;
        ///<summary>APPLE_row_bytes</summary>
        public const int UNPACK_ROW_BYTES_APPLE = 0x8A16;
        ///<summary>APPLE_rgb_422</summary>
        public const int RGB_422_APPLE = 0x8A1F;
        ///<summary>NV_video_capture</summary>
        public const int VIDEO_BUFFER_NV = 0x9020;
        ///<summary>NV_video_capture</summary>
        public const int VIDEO_BUFFER_BINDING_NV = 0x9021;
        ///<summary>NV_video_capture</summary>
        public const int FIELD_UPPER_NV = 0x9022;
        ///<summary>NV_video_capture</summary>
        public const int FIELD_LOWER_NV = 0x9023;
        ///<summary>NV_video_capture</summary>
        public const int NUM_VIDEO_CAPTURE_STREAMS_NV = 0x9024;
        ///<summary>NV_video_capture</summary>
        public const int NEXT_VIDEO_CAPTURE_BUFFER_STATUS_NV = 0x9025;
        ///<summary>NV_video_capture</summary>
        public const int VIDEO_CAPTURE_TO_422_SUPPORTED_NV = 0x9026;
        ///<summary>NV_video_capture</summary>
        public const int LAST_VIDEO_CAPTURE_STATUS_NV = 0x9027;
        ///<summary>NV_video_capture</summary>
        public const int VIDEO_BUFFER_PITCH_NV = 0x9028;
        ///<summary>NV_video_capture</summary>
        public const int VIDEO_COLOR_CONVERSION_MATRIX_NV = 0x9029;
        ///<summary>NV_video_capture</summary>
        public const int VIDEO_COLOR_CONVERSION_MAX_NV = 0x902A;
        ///<summary>NV_video_capture</summary>
        public const int VIDEO_COLOR_CONVERSION_MIN_NV = 0x902B;
        ///<summary>NV_video_capture</summary>
        public const int VIDEO_COLOR_CONVERSION_OFFSET_NV = 0x902C;
        ///<summary>NV_video_capture</summary>
        public const int VIDEO_BUFFER_INTERNAL_FORMAT_NV = 0x902D;
        ///<summary>NV_video_capture</summary>
        public const int PARTIAL_SUCCESS_NV = 0x902E;
        ///<summary>NV_video_capture</summary>
        public const int SUCCESS_NV = 0x902F;
        ///<summary>NV_video_capture</summary>
        public const int FAILURE_NV = 0x9030;
        ///<summary>NV_video_capture</summary>
        public const int YCBYCR8_422_NV = 0x9031;
        ///<summary>NV_video_capture</summary>
        public const int YCBAYCR8A_4224_NV = 0x9032;
        ///<summary>NV_video_capture</summary>
        public const int Z6Y10Z6CB10Z6Y10Z6CR10_422_NV = 0x9033;
        ///<summary>NV_video_capture</summary>
        public const int Z6Y10Z6CB10Z6A10Z6Y10Z6CR10Z6A10_4224_NV = 0x9034;
        ///<summary>NV_video_capture</summary>
        public const int Z4Y12Z4CB12Z4Y12Z4CR12_422_NV = 0x9035;
        ///<summary>NV_video_capture</summary>
        public const int Z4Y12Z4CB12Z4A12Z4Y12Z4CR12Z4A12_4224_NV = 0x9036;
        ///<summary>NV_video_capture</summary>
        public const int Z4Y12Z4CB12Z4CR12_444_NV = 0x9037;
        ///<summary>NV_video_capture</summary>
        public const int VIDEO_CAPTURE_FRAME_WIDTH_NV = 0x9038;
        ///<summary>NV_video_capture</summary>
        public const int VIDEO_CAPTURE_FRAME_HEIGHT_NV = 0x9039;
        ///<summary>NV_video_capture</summary>
        public const int VIDEO_CAPTURE_FIELD_UPPER_HEIGHT_NV = 0x903A;
        ///<summary>NV_video_capture</summary>
        public const int VIDEO_CAPTURE_FIELD_LOWER_HEIGHT_NV = 0x903B;
        ///<summary>NV_video_capture</summary>
        public const int VIDEO_CAPTURE_SURFACE_ORIGIN_NV = 0x903C;
        ///<summary>EXT_separate_shader_objects</summary>
        public const int ACTIVE_PROGRAM_EXT = 0x8B8D;
        ///<summary>NV_shader_buffer_load</summary>
        public const int BUFFER_GPU_ADDRESS_NV = 0x8F1D;
        ///<summary>NV_shader_buffer_load</summary>
        public const int GPU_ADDRESS_NV = 0x8F34;
        ///<summary>NV_shader_buffer_load</summary>
        public const int MAX_SHADER_BUFFER_ADDRESS_NV = 0x8F35;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int VERTEX_ATTRIB_ARRAY_UNIFIED_NV = 0x8F1E;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int ELEMENT_ARRAY_UNIFIED_NV = 0x8F1F;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int VERTEX_ATTRIB_ARRAY_ADDRESS_NV = 0x8F20;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int VERTEX_ARRAY_ADDRESS_NV = 0x8F21;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int NORMAL_ARRAY_ADDRESS_NV = 0x8F22;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int COLOR_ARRAY_ADDRESS_NV = 0x8F23;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int INDEX_ARRAY_ADDRESS_NV = 0x8F24;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int TEXTURE_COORD_ARRAY_ADDRESS_NV = 0x8F25;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int EDGE_FLAG_ARRAY_ADDRESS_NV = 0x8F26;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int SECONDARY_COLOR_ARRAY_ADDRESS_NV = 0x8F27;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int FOG_COORD_ARRAY_ADDRESS_NV = 0x8F28;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int ELEMENT_ARRAY_ADDRESS_NV = 0x8F29;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int VERTEX_ATTRIB_ARRAY_LENGTH_NV = 0x8F2A;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int VERTEX_ARRAY_LENGTH_NV = 0x8F2B;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int NORMAL_ARRAY_LENGTH_NV = 0x8F2C;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int COLOR_ARRAY_LENGTH_NV = 0x8F2D;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int INDEX_ARRAY_LENGTH_NV = 0x8F2E;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int TEXTURE_COORD_ARRAY_LENGTH_NV = 0x8F2F;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int EDGE_FLAG_ARRAY_LENGTH_NV = 0x8F30;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int SECONDARY_COLOR_ARRAY_LENGTH_NV = 0x8F31;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int FOG_COORD_ARRAY_LENGTH_NV = 0x8F32;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int ELEMENT_ARRAY_LENGTH_NV = 0x8F33;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int DRAW_INDIRECT_UNIFIED_NV = 0x8F40;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int DRAW_INDIRECT_ADDRESS_NV = 0x8F41;
        ///<summary>NV_vertex_buffer_unified_memory</summary>
        public const int DRAW_INDIRECT_LENGTH_NV = 0x8F42;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int MAX_IMAGE_UNITS_EXT = 0x8F38;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT = 0x8F39;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int IMAGE_BINDING_NAME_EXT = 0x8F3A;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int IMAGE_BINDING_LEVEL_EXT = 0x8F3B;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int IMAGE_BINDING_LAYERED_EXT = 0x8F3C;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int IMAGE_BINDING_LAYER_EXT = 0x8F3D;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int IMAGE_BINDING_ACCESS_EXT = 0x8F3E;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int IMAGE_1D_EXT = 0x904C;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int IMAGE_2D_EXT = 0x904D;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int IMAGE_3D_EXT = 0x904E;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int IMAGE_2D_RECT_EXT = 0x904F;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int IMAGE_CUBE_EXT = 0x9050;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int IMAGE_BUFFER_EXT = 0x9051;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int IMAGE_1D_ARRAY_EXT = 0x9052;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int IMAGE_2D_ARRAY_EXT = 0x9053;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int IMAGE_CUBE_MAP_ARRAY_EXT = 0x9054;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int IMAGE_2D_MULTISAMPLE_EXT = 0x9055;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9056;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int INT_IMAGE_1D_EXT = 0x9057;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int INT_IMAGE_2D_EXT = 0x9058;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int INT_IMAGE_3D_EXT = 0x9059;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int INT_IMAGE_2D_RECT_EXT = 0x905A;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int INT_IMAGE_CUBE_EXT = 0x905B;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int INT_IMAGE_BUFFER_EXT = 0x905C;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int INT_IMAGE_1D_ARRAY_EXT = 0x905D;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int INT_IMAGE_2D_ARRAY_EXT = 0x905E;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x905F;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int INT_IMAGE_2D_MULTISAMPLE_EXT = 0x9060;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9061;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_1D_EXT = 0x9062;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_2D_EXT = 0x9063;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_3D_EXT = 0x9064;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_2D_RECT_EXT = 0x9065;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_CUBE_EXT = 0x9066;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_BUFFER_EXT = 0x9067;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_1D_ARRAY_EXT = 0x9068;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_2D_ARRAY_EXT = 0x9069;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x906A;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x906B;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x906C;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int MAX_IMAGE_SAMPLES_EXT = 0x906D;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int IMAGE_BINDING_FORMAT_EXT = 0x906E;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT = 0x00000001;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int ELEMENT_ARRAY_BARRIER_BIT_EXT = 0x00000002;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int UNIFORM_BARRIER_BIT_EXT = 0x00000004;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int TEXTURE_FETCH_BARRIER_BIT_EXT = 0x00000008;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT = 0x00000020;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int COMMAND_BARRIER_BIT_EXT = 0x00000040;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int PIXEL_BUFFER_BARRIER_BIT_EXT = 0x00000080;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int TEXTURE_UPDATE_BARRIER_BIT_EXT = 0x00000100;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int BUFFER_UPDATE_BARRIER_BIT_EXT = 0x00000200;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int FRAMEBUFFER_BARRIER_BIT_EXT = 0x00000400;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int TRANSFORM_FEEDBACK_BARRIER_BIT_EXT = 0x00000800;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int ATOMIC_COUNTER_BARRIER_BIT_EXT = 0x00001000;
        ///<summary>EXT_shader_image_load_store</summary>
        public const int ALL_BARRIER_BITS_EXT = unchecked((int)0xFFFFFFFF);
        ///<summary>EXT_vertex_attrib_64bit</summary>
        public const int DOUBLE_VEC2_EXT = 0x8FFC;
        ///<summary>EXT_vertex_attrib_64bit</summary>
        public const int DOUBLE_VEC3_EXT = 0x8FFD;
        ///<summary>EXT_vertex_attrib_64bit</summary>
        public const int DOUBLE_VEC4_EXT = 0x8FFE;
        ///<summary>EXT_vertex_attrib_64bit</summary>
        public const int DOUBLE_MAT2_EXT = 0x8F46;
        ///<summary>EXT_vertex_attrib_64bit</summary>
        public const int DOUBLE_MAT3_EXT = 0x8F47;
        ///<summary>EXT_vertex_attrib_64bit</summary>
        public const int DOUBLE_MAT4_EXT = 0x8F48;
        ///<summary>EXT_vertex_attrib_64bit</summary>
        public const int DOUBLE_MAT2x3_EXT = 0x8F49;
        ///<summary>EXT_vertex_attrib_64bit</summary>
        public const int DOUBLE_MAT2x4_EXT = 0x8F4A;
        ///<summary>EXT_vertex_attrib_64bit</summary>
        public const int DOUBLE_MAT3x2_EXT = 0x8F4B;
        ///<summary>EXT_vertex_attrib_64bit</summary>
        public const int DOUBLE_MAT3x4_EXT = 0x8F4C;
        ///<summary>EXT_vertex_attrib_64bit</summary>
        public const int DOUBLE_MAT4x2_EXT = 0x8F4D;
        ///<summary>EXT_vertex_attrib_64bit</summary>
        public const int DOUBLE_MAT4x3_EXT = 0x8F4E;
        ///<summary>NV_gpu_program5</summary>
        public const int MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV = 0x8E5A;
        ///<summary>NV_gpu_program5</summary>
        public const int MIN_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5B;
        ///<summary>NV_gpu_program5</summary>
        public const int MAX_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5C;
        ///<summary>NV_gpu_program5</summary>
        public const int FRAGMENT_PROGRAM_INTERPOLATION_OFFSET_BITS_NV = 0x8E5D;
        ///<summary>NV_gpu_program5</summary>
        public const int MIN_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5E;
        ///<summary>NV_gpu_program5</summary>
        public const int MAX_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5F;
        ///<summary>NV_gpu_program5</summary>
        public const int MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV = 0x8F44;
        ///<summary>NV_gpu_program5</summary>
        public const int MAX_PROGRAM_SUBROUTINE_NUM_NV = 0x8F45;
        ///<summary>NV_gpu_shader5</summary>
        public const int INT64_NV = 0x140E;
        ///<summary>NV_gpu_shader5</summary>
        public const int UNSIGNED_INT64_NV = 0x140F;
        ///<summary>NV_gpu_shader5</summary>
        public const int INT8_NV = 0x8FE0;
        ///<summary>NV_gpu_shader5</summary>
        public const int INT8_VEC2_NV = 0x8FE1;
        ///<summary>NV_gpu_shader5</summary>
        public const int INT8_VEC3_NV = 0x8FE2;
        ///<summary>NV_gpu_shader5</summary>
        public const int INT8_VEC4_NV = 0x8FE3;
        ///<summary>NV_gpu_shader5</summary>
        public const int INT16_NV = 0x8FE4;
        ///<summary>NV_gpu_shader5</summary>
        public const int INT16_VEC2_NV = 0x8FE5;
        ///<summary>NV_gpu_shader5</summary>
        public const int INT16_VEC3_NV = 0x8FE6;
        ///<summary>NV_gpu_shader5</summary>
        public const int INT16_VEC4_NV = 0x8FE7;
        ///<summary>NV_gpu_shader5</summary>
        public const int INT64_VEC2_NV = 0x8FE9;
        ///<summary>NV_gpu_shader5</summary>
        public const int INT64_VEC3_NV = 0x8FEA;
        ///<summary>NV_gpu_shader5</summary>
        public const int INT64_VEC4_NV = 0x8FEB;
        ///<summary>NV_gpu_shader5</summary>
        public const int UNSIGNED_INT8_NV = 0x8FEC;
        ///<summary>NV_gpu_shader5</summary>
        public const int UNSIGNED_INT8_VEC2_NV = 0x8FED;
        ///<summary>NV_gpu_shader5</summary>
        public const int UNSIGNED_INT8_VEC3_NV = 0x8FEE;
        ///<summary>NV_gpu_shader5</summary>
        public const int UNSIGNED_INT8_VEC4_NV = 0x8FEF;
        ///<summary>NV_gpu_shader5</summary>
        public const int UNSIGNED_INT16_NV = 0x8FF0;
        ///<summary>NV_gpu_shader5</summary>
        public const int UNSIGNED_INT16_VEC2_NV = 0x8FF1;
        ///<summary>NV_gpu_shader5</summary>
        public const int UNSIGNED_INT16_VEC3_NV = 0x8FF2;
        ///<summary>NV_gpu_shader5</summary>
        public const int UNSIGNED_INT16_VEC4_NV = 0x8FF3;
        ///<summary>NV_gpu_shader5</summary>
        public const int UNSIGNED_INT64_VEC2_NV = 0x8FF5;
        ///<summary>NV_gpu_shader5</summary>
        public const int UNSIGNED_INT64_VEC3_NV = 0x8FF6;
        ///<summary>NV_gpu_shader5</summary>
        public const int UNSIGNED_INT64_VEC4_NV = 0x8FF7;
        ///<summary>NV_gpu_shader5</summary>
        public const int FLOAT16_NV = 0x8FF8;
        ///<summary>NV_gpu_shader5</summary>
        public const int FLOAT16_VEC2_NV = 0x8FF9;
        ///<summary>NV_gpu_shader5</summary>
        public const int FLOAT16_VEC3_NV = 0x8FFA;
        ///<summary>NV_gpu_shader5</summary>
        public const int FLOAT16_VEC4_NV = 0x8FFB;
        ///<summary>NV_shader_buffer_store</summary>
        public const int SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV = 0x00000010;
        ///<summary>NV_tessellation_program5</summary>
        public const int MAX_PROGRAM_PATCH_ATTRIBS_NV = 0x86D8;
        ///<summary>NV_tessellation_program5</summary>
        public const int TESS_CONTROL_PROGRAM_NV = 0x891E;
        ///<summary>NV_tessellation_program5</summary>
        public const int TESS_EVALUATION_PROGRAM_NV = 0x891F;
        ///<summary>NV_tessellation_program5</summary>
        public const int TESS_CONTROL_PROGRAM_PARAMETER_BUFFER_NV = 0x8C74;
        ///<summary>NV_tessellation_program5</summary>
        public const int TESS_EVALUATION_PROGRAM_PARAMETER_BUFFER_NV = 0x8C75;
        ///<summary>NV_multisample_coverage</summary>
        public const int COVERAGE_SAMPLES_NV = 0x80A9;
        ///<summary>NV_multisample_coverage</summary>
        public const int COLOR_SAMPLES_NV = 0x8E20;
        ///<summary>AMD_name_gen_delete</summary>
        public const int DATA_BUFFER_AMD = 0x9151;
        ///<summary>AMD_name_gen_delete</summary>
        public const int PERFORMANCE_MONITOR_AMD = 0x9152;
        ///<summary>AMD_name_gen_delete</summary>
        public const int QUERY_OBJECT_AMD = 0x9153;
        ///<summary>AMD_name_gen_delete</summary>
        public const int VERTEX_ARRAY_OBJECT_AMD = 0x9154;
        ///<summary>AMD_name_gen_delete</summary>
        public const int SAMPLER_OBJECT_AMD = 0x9155;
        ///<summary>AMD_debug_output</summary>
        public const int MAX_DEBUG_LOGGED_MESSAGES_AMD = 0x9144;
        ///<summary>AMD_debug_output</summary>
        public const int DEBUG_LOGGED_MESSAGES_AMD = 0x9145;
        ///<summary>AMD_debug_output</summary>
        public const int DEBUG_SEVERITY_HIGH_AMD = 0x9146;
        ///<summary>AMD_debug_output</summary>
        public const int DEBUG_SEVERITY_MEDIUM_AMD = 0x9147;
        ///<summary>AMD_debug_output</summary>
        public const int DEBUG_SEVERITY_LOW_AMD = 0x9148;
        ///<summary>AMD_debug_output</summary>
        public const int DEBUG_CATEGORY_API_ERROR_AMD = 0x9149;
        ///<summary>AMD_debug_output</summary>
        public const int DEBUG_CATEGORY_WINDOW_SYSTEM_AMD = 0x914A;
        ///<summary>AMD_debug_output</summary>
        public const int DEBUG_CATEGORY_DEPRECATION_AMD = 0x914B;
        ///<summary>AMD_debug_output</summary>
        public const int DEBUG_CATEGORY_UNDEFINED_BEHAVIOR_AMD = 0x914C;
        ///<summary>AMD_debug_output</summary>
        public const int DEBUG_CATEGORY_PERFORMANCE_AMD = 0x914D;
        ///<summary>AMD_debug_output</summary>
        public const int DEBUG_CATEGORY_SHADER_COMPILER_AMD = 0x914E;
        ///<summary>AMD_debug_output</summary>
        public const int DEBUG_CATEGORY_APPLICATION_AMD = 0x914F;
        ///<summary>AMD_debug_output</summary>
        public const int DEBUG_CATEGORY_OTHER_AMD = 0x9150;
        ///<summary>NV_vdpau_interop</summary>
        public const int SURFACE_STATE_NV = 0x86EB;
        ///<summary>NV_vdpau_interop</summary>
        public const int SURFACE_REGISTERED_NV = 0x86FD;
        ///<summary>NV_vdpau_interop</summary>
        public const int SURFACE_MAPPED_NV = 0x8700;
        ///<summary>NV_vdpau_interop</summary>
        public const int WRITE_DISCARD_NV = 0x88BE;
        ///<summary>AMD_depth_clamp_separate</summary>
        public const int DEPTH_CLAMP_NEAR_AMD = 0x901E;
        ///<summary>AMD_depth_clamp_separate</summary>
        public const int DEPTH_CLAMP_FAR_AMD = 0x901F;
        ///<summary>EXT_texture_sRGB_decode</summary>
        public const int TEXTURE_SRGB_DECODE_EXT = 0x8A48;
        ///<summary>EXT_texture_sRGB_decode</summary>
        public const int DECODE_EXT = 0x8A49;
        ///<summary>EXT_texture_sRGB_decode</summary>
        public const int SKIP_DECODE_EXT = 0x8A4A;
        ///<summary>NV_texture_multisample</summary>
        public const int TEXTURE_COVERAGE_SAMPLES_NV = 0x9045;
        ///<summary>NV_texture_multisample</summary>
        public const int TEXTURE_COLOR_SAMPLES_NV = 0x9046;
        ///<summary>AMD_blend_minmax_factor</summary>
        public const int FACTOR_MIN_AMD = 0x901C;
        ///<summary>AMD_blend_minmax_factor</summary>
        public const int FACTOR_MAX_AMD = 0x901D;
        ///<summary>AMD_sample_positions</summary>
        public const int SUBSAMPLE_DISTANCE_AMD = 0x883F;
        ///<summary>EXT_x11_sync_object</summary>
        public const int SYNC_X11_FENCE_EXT = 0x90E1;
        ///<summary>EXT_framebuffer_multisample_blit_scaled</summary>
        public const int SCALED_RESOLVE_FASTEST_EXT = 0x90BA;
        ///<summary>EXT_framebuffer_multisample_blit_scaled</summary>
        public const int SCALED_RESOLVE_NICEST_EXT = 0x90BB;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_FORMAT_SVG_NV = 0x9070;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_FORMAT_PS_NV = 0x9071;
        ///<summary>NV_path_rendering</summary>
        public const int STANDARD_FONT_NAME_NV = 0x9072;
        ///<summary>NV_path_rendering</summary>
        public const int SYSTEM_FONT_NAME_NV = 0x9073;
        ///<summary>NV_path_rendering</summary>
        public const int FILE_NAME_NV = 0x9074;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_STROKE_WIDTH_NV = 0x9075;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_END_CAPS_NV = 0x9076;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_INITIAL_END_CAP_NV = 0x9077;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_TERMINAL_END_CAP_NV = 0x9078;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_JOIN_STYLE_NV = 0x9079;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_MITER_LIMIT_NV = 0x907A;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_DASH_CAPS_NV = 0x907B;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_INITIAL_DASH_CAP_NV = 0x907C;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_TERMINAL_DASH_CAP_NV = 0x907D;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_DASH_OFFSET_NV = 0x907E;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_CLIENT_LENGTH_NV = 0x907F;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_FILL_MODE_NV = 0x9080;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_FILL_MASK_NV = 0x9081;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_FILL_COVER_MODE_NV = 0x9082;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_STROKE_COVER_MODE_NV = 0x9083;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_STROKE_MASK_NV = 0x9084;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_SAMPLE_QUALITY_NV = 0x9085;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_STROKE_BOUND_NV = 0x9086;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_STROKE_OVERSAMPLE_COUNT_NV = 0x9087;
        ///<summary>NV_path_rendering</summary>
        public const int COUNT_UP_NV = 0x9088;
        ///<summary>NV_path_rendering</summary>
        public const int COUNT_DOWN_NV = 0x9089;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_OBJECT_BOUNDING_BOX_NV = 0x908A;
        ///<summary>NV_path_rendering</summary>
        public const int CONVEX_HULL_NV = 0x908B;
        ///<summary>NV_path_rendering</summary>
        public const int MULTI_HULLS_NV = 0x908C;
        ///<summary>NV_path_rendering</summary>
        public const int BOUNDING_BOX_NV = 0x908D;
        ///<summary>NV_path_rendering</summary>
        public const int TRANSLATE_X_NV = 0x908E;
        ///<summary>NV_path_rendering</summary>
        public const int TRANSLATE_Y_NV = 0x908F;
        ///<summary>NV_path_rendering</summary>
        public const int TRANSLATE_2D_NV = 0x9090;
        ///<summary>NV_path_rendering</summary>
        public const int TRANSLATE_3D_NV = 0x9091;
        ///<summary>NV_path_rendering</summary>
        public const int AFFINE_2D_NV = 0x9092;
        ///<summary>NV_path_rendering</summary>
        public const int PROJECTIVE_2D_NV = 0x9093;
        ///<summary>NV_path_rendering</summary>
        public const int AFFINE_3D_NV = 0x9094;
        ///<summary>NV_path_rendering</summary>
        public const int PROJECTIVE_3D_NV = 0x9095;
        ///<summary>NV_path_rendering</summary>
        public const int TRANSPOSE_AFFINE_2D_NV = 0x9096;
        ///<summary>NV_path_rendering</summary>
        public const int TRANSPOSE_PROJECTIVE_2D_NV = 0x9097;
        ///<summary>NV_path_rendering</summary>
        public const int TRANSPOSE_AFFINE_3D_NV = 0x9098;
        ///<summary>NV_path_rendering</summary>
        public const int TRANSPOSE_PROJECTIVE_3D_NV = 0x9099;
        ///<summary>NV_path_rendering</summary>
        public const int UTF8_NV = 0x909A;
        ///<summary>NV_path_rendering</summary>
        public const int UTF16_NV = 0x909B;
        ///<summary>NV_path_rendering</summary>
        public const int BOUNDING_BOX_OF_BOUNDING_BOXES_NV = 0x909C;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_COMMAND_COUNT_NV = 0x909D;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_COORD_COUNT_NV = 0x909E;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_DASH_ARRAY_COUNT_NV = 0x909F;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_COMPUTED_LENGTH_NV = 0x90A0;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_FILL_BOUNDING_BOX_NV = 0x90A1;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_STROKE_BOUNDING_BOX_NV = 0x90A2;
        ///<summary>NV_path_rendering</summary>
        public const int SQUARE_NV = 0x90A3;
        ///<summary>NV_path_rendering</summary>
        public const int ROUND_NV = 0x90A4;
        ///<summary>NV_path_rendering</summary>
        public const int TRIANGULAR_NV = 0x90A5;
        ///<summary>NV_path_rendering</summary>
        public const int BEVEL_NV = 0x90A6;
        ///<summary>NV_path_rendering</summary>
        public const int MITER_REVERT_NV = 0x90A7;
        ///<summary>NV_path_rendering</summary>
        public const int MITER_TRUNCATE_NV = 0x90A8;
        ///<summary>NV_path_rendering</summary>
        public const int SKIP_MISSING_GLYPH_NV = 0x90A9;
        ///<summary>NV_path_rendering</summary>
        public const int USE_MISSING_GLYPH_NV = 0x90AA;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_ERROR_POSITION_NV = 0x90AB;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_FOG_GEN_MODE_NV = 0x90AC;
        ///<summary>NV_path_rendering</summary>
        public const int ACCUM_ADJACENT_PAIRS_NV = 0x90AD;
        ///<summary>NV_path_rendering</summary>
        public const int ADJACENT_PAIRS_NV = 0x90AE;
        ///<summary>NV_path_rendering</summary>
        public const int FIRST_TO_REST_NV = 0x90AF;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_GEN_MODE_NV = 0x90B0;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_GEN_COEFF_NV = 0x90B1;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_GEN_COLOR_FORMAT_NV = 0x90B2;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_GEN_COMPONENTS_NV = 0x90B3;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_STENCIL_FUNC_NV = 0x90B7;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_STENCIL_REF_NV = 0x90B8;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_STENCIL_VALUE_MASK_NV = 0x90B9;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV = 0x90BD;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_STENCIL_DEPTH_OFFSET_UNITS_NV = 0x90BE;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_COVER_DEPTH_FUNC_NV = 0x90BF;
        ///<summary>NV_path_rendering</summary>
        public const int PATH_DASH_OFFSET_RESET_NV = 0x90B4;
        ///<summary>NV_path_rendering</summary>
        public const int MOVE_TO_RESETS_NV = 0x90B5;
        ///<summary>NV_path_rendering</summary>
        public const int MOVE_TO_CONTINUES_NV = 0x90B6;
        ///<summary>NV_path_rendering</summary>
        public const int CLOSE_PATH_NV = 0x00;
        ///<summary>NV_path_rendering</summary>
        public const int MOVE_TO_NV = 0x02;
        ///<summary>NV_path_rendering</summary>
        public const int RELATIVE_MOVE_TO_NV = 0x03;
        ///<summary>NV_path_rendering</summary>
        public const int LINE_TO_NV = 0x04;
        ///<summary>NV_path_rendering</summary>
        public const int RELATIVE_LINE_TO_NV = 0x05;
        ///<summary>NV_path_rendering</summary>
        public const int HORIZONTAL_LINE_TO_NV = 0x06;
        ///<summary>NV_path_rendering</summary>
        public const int RELATIVE_HORIZONTAL_LINE_TO_NV = 0x07;
        ///<summary>NV_path_rendering</summary>
        public const int VERTICAL_LINE_TO_NV = 0x08;
        ///<summary>NV_path_rendering</summary>
        public const int RELATIVE_VERTICAL_LINE_TO_NV = 0x09;
        ///<summary>NV_path_rendering</summary>
        public const int QUADRATIC_CURVE_TO_NV = 0x0A;
        ///<summary>NV_path_rendering</summary>
        public const int RELATIVE_QUADRATIC_CURVE_TO_NV = 0x0B;
        ///<summary>NV_path_rendering</summary>
        public const int CUBIC_CURVE_TO_NV = 0x0C;
        ///<summary>NV_path_rendering</summary>
        public const int RELATIVE_CUBIC_CURVE_TO_NV = 0x0D;
        ///<summary>NV_path_rendering</summary>
        public const int SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0E;
        ///<summary>NV_path_rendering</summary>
        public const int RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0F;
        ///<summary>NV_path_rendering</summary>
        public const int SMOOTH_CUBIC_CURVE_TO_NV = 0x10;
        ///<summary>NV_path_rendering</summary>
        public const int RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV = 0x11;
        ///<summary>NV_path_rendering</summary>
        public const int SMALL_CCW_ARC_TO_NV = 0x12;
        ///<summary>NV_path_rendering</summary>
        public const int RELATIVE_SMALL_CCW_ARC_TO_NV = 0x13;
        ///<summary>NV_path_rendering</summary>
        public const int SMALL_CW_ARC_TO_NV = 0x14;
        ///<summary>NV_path_rendering</summary>
        public const int RELATIVE_SMALL_CW_ARC_TO_NV = 0x15;
        ///<summary>NV_path_rendering</summary>
        public const int LARGE_CCW_ARC_TO_NV = 0x16;
        ///<summary>NV_path_rendering</summary>
        public const int RELATIVE_LARGE_CCW_ARC_TO_NV = 0x17;
        ///<summary>NV_path_rendering</summary>
        public const int LARGE_CW_ARC_TO_NV = 0x18;
        ///<summary>NV_path_rendering</summary>
        public const int RELATIVE_LARGE_CW_ARC_TO_NV = 0x19;
        ///<summary>NV_path_rendering</summary>
        public const int RESTART_PATH_NV = 0xF0;
        ///<summary>NV_path_rendering</summary>
        public const int DUP_FIRST_CUBIC_CURVE_TO_NV = 0xF2;
        ///<summary>NV_path_rendering</summary>
        public const int DUP_LAST_CUBIC_CURVE_TO_NV = 0xF4;
        ///<summary>NV_path_rendering</summary>
        public const int RECT_NV = 0xF6;
        ///<summary>NV_path_rendering</summary>
        public const int CIRCULAR_CCW_ARC_TO_NV = 0xF8;
        ///<summary>NV_path_rendering</summary>
        public const int CIRCULAR_CW_ARC_TO_NV = 0xFA;
        ///<summary>NV_path_rendering</summary>
        public const int CIRCULAR_TANGENT_ARC_TO_NV = 0xFC;
        ///<summary>NV_path_rendering</summary>
        public const int ARC_TO_NV = 0xFE;
        ///<summary>NV_path_rendering</summary>
        public const int RELATIVE_ARC_TO_NV = 0xFF;
        ///<summary>NV_path_rendering</summary>
        public const int BOLD_BIT_NV = 0x01;
        ///<summary>NV_path_rendering</summary>
        public const int ITALIC_BIT_NV = 0x02;
        ///<summary>NV_path_rendering</summary>
        public const int GLYPH_WIDTH_BIT_NV = 0x01;
        ///<summary>NV_path_rendering</summary>
        public const int GLYPH_HEIGHT_BIT_NV = 0x02;
        ///<summary>NV_path_rendering</summary>
        public const int GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x04;
        ///<summary>NV_path_rendering</summary>
        public const int GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x08;
        ///<summary>NV_path_rendering</summary>
        public const int GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10;
        ///<summary>NV_path_rendering</summary>
        public const int GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20;
        ///<summary>NV_path_rendering</summary>
        public const int GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40;
        ///<summary>NV_path_rendering</summary>
        public const int GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80;
        ///<summary>NV_path_rendering</summary>
        public const int GLYPH_HAS_KERNING_NV = 0x100;
        ///<summary>NV_path_rendering</summary>
        public const int FONT_X_MIN_BOUNDS_NV = 0x00010000;
        ///<summary>NV_path_rendering</summary>
        public const int FONT_Y_MIN_BOUNDS_NV = 0x00020000;
        ///<summary>NV_path_rendering</summary>
        public const int FONT_X_MAX_BOUNDS_NV = 0x00040000;
        ///<summary>NV_path_rendering</summary>
        public const int FONT_Y_MAX_BOUNDS_NV = 0x00080000;
        ///<summary>NV_path_rendering</summary>
        public const int FONT_UNITS_PER_EM_NV = 0x00100000;
        ///<summary>NV_path_rendering</summary>
        public const int FONT_ASCENDER_NV = 0x00200000;
        ///<summary>NV_path_rendering</summary>
        public const int FONT_DESCENDER_NV = 0x00400000;
        ///<summary>NV_path_rendering</summary>
        public const int FONT_HEIGHT_NV = 0x00800000;
        ///<summary>NV_path_rendering</summary>
        public const int FONT_MAX_ADVANCE_WIDTH_NV = 0x01000000;
        ///<summary>NV_path_rendering</summary>
        public const int FONT_MAX_ADVANCE_HEIGHT_NV = 0x02000000;
        ///<summary>NV_path_rendering</summary>
        public const int FONT_UNDERLINE_POSITION_NV = 0x04000000;
        ///<summary>NV_path_rendering</summary>
        public const int FONT_UNDERLINE_THICKNESS_NV = 0x08000000;
        ///<summary>NV_path_rendering</summary>
        public const int FONT_HAS_KERNING_NV = 0x10000000;
        ///<summary>AMD_pinned_memory</summary>
        public const int EXTERNAL_VIRTUAL_MEMORY_BUFFER_AMD = 0x9160;
        ///<summary>AMD_stencil_operation_extended</summary>
        public const int SET_AMD = 0x874A;
        ///<summary>AMD_stencil_operation_extended</summary>
        public const int REPLACE_VALUE_AMD = 0x874B;
        ///<summary>AMD_stencil_operation_extended</summary>
        public const int STENCIL_OP_VALUE_AMD = 0x874C;
        ///<summary>AMD_stencil_operation_extended</summary>
        public const int STENCIL_BACK_OP_VALUE_AMD = 0x874D;
        ///<summary>AMD_query_buffer_object</summary>
        public const int QUERY_BUFFER_AMD = 0x9192;
        ///<summary>AMD_query_buffer_object</summary>
        public const int QUERY_BUFFER_BINDING_AMD = 0x9193;
        ///<summary>AMD_query_buffer_object</summary>
        public const int QUERY_RESULT_NO_WAIT_AMD = 0x9194;
        // TODO: add comments
        public enum DEBUG_TYPE { ERROR = 0x824C, DEPRECATED_BEHAVIOR = 0x824D, UNDEFINED_BEHAVIOR = 0x824E, PORTABILITY = 0x824F, PERFORMANCE = 0x8250, OTHER = 0x8251 };
        public enum DEBUG_SOURCE { API = 0x8246, WINDOW_SYSTEM = 0x8247, SHADER_COMPILER = 0x8248, THIRD_PARTY = 0x8249, APPLICATION = 0x824A, OTHER = 0x824B };
        public enum DEBUG_SEVERITY { HIGH = 0x9146, MEDIUM = 0x9147, LOW = 0x9148 };
        public enum ERROR { NO_ERROR = 0, INVALID_ENUM = 0x0500, INVALID_VALUE = 0x0501, INVALID_OPERATION = 0x0502, STACK_OVERFLOW = 0x0503, STACK_UNDERFLOW = 0x0504, OUT_OF_MEMORY = 0x0505, INVALID_FRAMEBUFFER_OPERATION = 0x0506 };
    }
}
