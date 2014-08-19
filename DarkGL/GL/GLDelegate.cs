using System;
using System.Text;

namespace DarkTech.DarkGL
{
    public class GLDelegate
    {
        #region 1.0
        public delegate void Accum(int op, float value);
        public delegate void AlphaFunc(int func, float reference);
        public delegate void Begin(int mode);
        public delegate void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap);
        public delegate void BlendFunc(int sfactor, int dfactor);
        public delegate void CallList(uint list);
        public delegate void CallLists(int n, int type, IntPtr lists);
        public delegate void Clear(int mask);
        public delegate void ClearAccum(float red, float green, float blue, float alpha);
        public delegate void ClearColor(float red, float green, float blue, float alpha);
        public delegate void ClearDepth(double depth);
        public delegate void ClearIndex(float c);
        public delegate void ClearStencil(int s);
        public delegate void ClipPlane(int plane, double[] equation);
        public delegate void Color3b(byte red, byte green, byte blue);
        public delegate void Color3bv(byte[] v);
        public delegate void Color3d(double red, double green, double blue);
        public delegate void Color3dv(double[] v);
        public delegate void Color3f(float red, float green, float blue);
        public delegate void Color3fv(float[] v);
        public delegate void Color3i(int red, int green, int blue);
        public delegate void Color3iv(int[] v);
        public delegate void Color3s(short red, short green, short blue);
        public delegate void Color3sv(short[] v);
        public delegate void Color3ub(byte red, byte green, byte blue);
        public delegate void Color3ubv(byte[] v);
        public delegate void Color3ui(uint red, uint green, uint blue);
        public delegate void Color3uiv(uint[] v);
        public delegate void Color3us(ushort red, ushort green, ushort blue);
        public delegate void Color3usv(ushort[] v);
        public delegate void Color4b(byte red, byte green, byte blue, byte alpha);
        public delegate void Color4bv(byte[] v);
        public delegate void Color4d(double red, double green, double blue, double alpha);
        public delegate void Color4dv(double[] v);
        public delegate void Color4f(float red, float green, float blue, float alpha);
        public delegate void Color4fv(float[] v);
        public delegate void Color4i(int red, int green, int blue, int alpha);
        public delegate void Color4iv(int[] v);
        public delegate void Color4s(short red, short green, short blue, short alpha);
        public delegate void Color4sv(short[] v);
        public delegate void Color4ub(byte red, byte green, byte blue, byte alpha);
        public delegate void Color4ubv(byte[] v);
        public delegate void Color4ui(uint red, uint green, uint blue, uint alpha);
        public delegate void Color4uiv(uint[] v);
        public delegate void Color4us(ushort red, ushort green, ushort blue, ushort alpha);
        public delegate void Color4usv(ushort[] v);
        public delegate void ColorMask(bool red, bool green, bool blue, bool alpha);
        public delegate void ColorMaterial(int face, int mode);
        public delegate void CopyPixels(int x, int y, int width, int height, int type);
        public delegate void CullFace(int mode);
        public delegate void DeleteLists(uint list, int range);
        public delegate void DepthFunc(int func);
        public delegate void DepthMask(bool flag);
        public delegate void DepthRange(double near, double far);
        public delegate void Disable(int cap);
        public delegate void DrawBuffer(int mode);
        public delegate void DrawPixels(int width, int height, int format, int type, IntPtr pixels);
        public delegate void EdgeFlag(bool flag);
        public delegate void EdgeFlagv(bool[] flag);
        public delegate void Enable(int cap);
        public delegate void End();
        public delegate void EndList();
        public delegate void EvalCoord1d(double u);
        public delegate void EvalCoord1dv(double[] u);
        public delegate void EvalCoord1dv_double(ref double u);
        public delegate void EvalCoord1f(float u);
        public delegate void EvalCoord1fv(float[] u);
        public delegate void EvalCoord1fv_float(ref float u);
        public delegate void EvalCoord2d(double u, double v);
        public delegate void EvalCoord2dv(double[] u);
        public delegate void EvalCoord2f(float u, float v);
        public delegate void EvalCoord2fv(float[] u);
        public delegate void EvalMesh1(int mode, int i1, int i2);
        public delegate void EvalMesh2(int mode, int i1, int i2, int j1, int j2);
        public delegate void EvalPoint1(int i);
        public delegate void EvalPoint2(int i, int j);
        public delegate void FeedbackBuffer(int size, int type, IntPtr buffer);
        public delegate void Finish();
        public delegate void Flush();
        public delegate void Fogf(int pname, float param);
        public delegate void Fogfv(int pname, float[] param);
        public delegate void Fogi(int pname, int param);
        public delegate void Fogiv(int pname, int[] param);
        public delegate void FrontFace(int mode);
        public delegate void Frustum(double left, double right, double bottom, double top, double zNear, double zFar);
        public delegate uint GenLists(int range);
        public delegate void GetBooleanv_bool(int pname, out bool param);
        public delegate void GetBooleanv(int pname, bool[] param);
        public delegate void GetClipPlane(int plane, double[] equation);
        public delegate void GetDoublev(int pname, double[] param);
        public delegate void GetDoublev_double(int pname, out double param);
        public delegate int GetError();
        public delegate void GetFloatv(int pname, float[] param);
        public delegate void GetFloatv_float(int pname, out float param);
        public delegate void GetIntegerv(int pname, int[] param);
        public delegate void GetIntegerv_int(int pname, out int param);
        public delegate void GetLightfv(int light, int pname, float[] param);
        public delegate void GetLightiv(int light, int pname, int[] param);
        public delegate void GetMapdv(int target, int query, double[] v);
        public delegate void GetMapfv(int target, int query, float[] v);
        public delegate void GetMapiv(int target, int query, int[] v);
        public delegate void GetMaterialfv(int face, int pname, float[] param);
        public delegate void GetMaterialiv(int face, int pname, int[] param);
        public delegate void GetPixelMapfv(int map, float[] values);
        public delegate void GetPixelMapuiv(int map, uint[] values);
        public delegate void GetPixelMapusv(int map, ushort[] values);
        public delegate void GetPolygonStipple(byte[] mask);
        public delegate IntPtr GetString(int name);
        public delegate void GetTexEnvfv(int target, int pname, float[] param);
        public delegate void GetTexEnviv(int target, int pname, int[] param);
        public delegate void GetTexGendv(int coord, int pname, double[] param);
        public delegate void GetTexGenfv(int coord, int pname, float[] param);
        public delegate void GetTexGeniv(int coord, int pname, int[] param);
        public delegate void GetTexImage(int target, int level, int format, int type, IntPtr pixels);
        public delegate void GetTexLevelParameterfv(int target, int level, int pname, float[] param);
        public delegate void GetTexLevelParameteriv(int target, int level, int pname, int[] param);
        public delegate void GetTexParameterfv(int target, int pname, float[] param);
        public delegate void GetTexParameteriv(int target, int pname, int[] param);
        public delegate void Hint(int target, int mode);
        public delegate void Indexd(double c);
        public delegate void Indexdv_double(ref double c);
        public delegate void Indexdv(double[] c);
        public delegate void Indexf(float c);
        public delegate void Indexfv_float(ref float c);
        public delegate void Indexfv(float[] c);
        public delegate void Indexi(int c);
        public delegate void Indexiv_int(ref int c);
        public delegate void Indexiv(int[] c);
        public delegate void IndexMask(uint mask);
        public delegate void Indexs(short c);
        public delegate void Indexsv(short[] c);
        public delegate void InitNames();
        public delegate bool IsEnabled(int cap);
        public delegate bool IsList(uint list);
        public delegate void Lightf(int light, int pname, float param);
        public delegate void Lightfv(int light, int pname, float[] param);
        public delegate void Lighti(int light, int pname, int param);
        public delegate void Lightiv(int light, int pname, int[] param);
        public delegate void LightModelf(int pname, float param);
        public delegate void LightModelfv(int pname, float[] param);
        public delegate void LightModeli(int pname, int param);
        public delegate void LightModeliv(int pname, int[] param);
        public delegate void LineStipple(int factor, ushort pattern);
        public delegate void LineWidth(float width);
        public delegate void ListBase(uint listBase);
        public delegate void LoadIdentity();
        public delegate void LoadMatrixd(double[] m);
        public delegate void LoadMatrixf(float[] m);
        public delegate void LoadName(uint name);
        public delegate void LogicOp(int opcode);
        public delegate void Map1d(int target, double u1, double u2, int stride, int order, double[] points);
        public delegate void Map1f(int target, float u1, float u2, int stride, int order, float[] points);
        public delegate void Map2d(int target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points);
        public delegate void Map2f(int target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points);
        public delegate void MapGrid1d(int un, double u1, double u2);
        public delegate void MapGrid1f(int un, float u1, float u2);
        public delegate void MapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);
        public delegate void MapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);
        public delegate void Materialf(int face, int pname, float param);
        public delegate void Materialfv(int face, int pname, float[] param);
        public delegate void Materiali(int face, int pname, int param);
        public delegate void Materialiv(int face, int pname, int[] param);
        public delegate void MatrixMode(int mode);
        public delegate void MultMatrixd(double[] m);
        public delegate void MultMatrixf(float[] m);
        public delegate void NewList(uint list, int mode);
        public delegate void Normal3b(byte nx, byte ny, byte nz);
        public delegate void Normal3bv(byte[] v);
        public delegate void Normal3d(double nx, double ny, double nz);
        public delegate void Normal3dv(double[] v);
        public delegate void Normal3f(float nx, float ny, float nz);
        public delegate void Normal3fv(float[] v);
        public delegate void Normal3i(int nx, int ny, int nz);
        public delegate void Normal3iv(int[] v);
        public delegate void Normal3s(short nx, short ny, short nz);
        public delegate void Normal3sv(short[] v);
        public delegate void Ortho(double left, double right, double bottom, double top, double zNear, double zFar);
        public delegate void PassThrough(float token);
        public delegate void PixelMapfv(int map, int mapsize, float[] values);
        public delegate void PixelMapuiv(int map, int mapsize, uint[] values);
        public delegate void PixelMapusv(int map, int mapsize, ushort[] values);
        public delegate void PixelStoref(int pname, float param);
        public delegate void PixelStorei(int pname, int param);
        public delegate void PixelTransferf(int pname, float param);
        public delegate void PixelTransferi(int pname, int param);
        public delegate void PixelZoom(float xfactor, float yfactor);
        public delegate void PointSize(float size);
        public delegate void PolygonMode(int face, int mode);
        public delegate void PolygonStipple(byte[] mask);
        public delegate void PopAttrib();
        public delegate void PopMatrix();
        public delegate void PopName();
        public delegate void PushAttrib(int mask);
        public delegate void PushMatrix();
        public delegate void PushName(uint name);
        public delegate void RasterPos2d(double x, double y);
        public delegate void RasterPos2dv(double[] v);
        public delegate void RasterPos2f(float x, float y);
        public delegate void RasterPos2fv(float[] v);
        public delegate void RasterPos2i(int x, int y);
        public delegate void RasterPos2iv(int[] v);
        public delegate void RasterPos2s(short x, short y);
        public delegate void RasterPos2sv(short[] v);
        public delegate void RasterPos3d(double x, double y, double z);
        public delegate void RasterPos3dv(double[] v);
        public delegate void RasterPos3f(float x, float y, float z);
        public delegate void RasterPos3fv(float[] v);
        public delegate void RasterPos3i(int x, int y, int z);
        public delegate void RasterPos3iv(int[] v);
        public delegate void RasterPos3s(short x, short y, short z);
        public delegate void RasterPos3sv(short[] v);
        public delegate void RasterPos4d(double x, double y, double z, double w);
        public delegate void RasterPos4dv(double[] v);
        public delegate void RasterPos4f(float x, float y, float z, float w);
        public delegate void RasterPos4fv(float[] v);
        public delegate void RasterPos4i(int x, int y, int z, int w);
        public delegate void RasterPos4iv(int[] v);
        public delegate void RasterPos4s(short x, short y, short z, short w);
        public delegate void RasterPos4sv(short[] v);
        public delegate void ReadBuffer(int mode);
        public delegate void ReadPixels(int x, int y, int width, int height, int format, int type, IntPtr pixels);
        public delegate void Rectd(double x1, double y1, double x2, double y2);
        public delegate void Rectdv(double[] v1, double[] v2);
        public delegate void Rectf(float x1, float y1, float x2, float y2);
        public delegate void Rectfv(float[] v1, float[] v2);
        public delegate void Recti(int x1, int y1, int x2, int y2);
        public delegate void Rectiv(int[] v1, int[] v2);
        public delegate void Rects(short x1, short y1, short x2, short y2);
        public delegate void Rectsv(short[] v1, short[] v2);
        public delegate int RenderMode(int mode);
        public delegate void Rotated(double angle, double x, double y, double z);
        public delegate void Rotatef(float angle, float x, float y, float z);
        public delegate void Scaled(double x, double y, double z);
        public delegate void Scalef(float x, float y, float z);
        public delegate void Scissor(int x, int y, int width, int height);
        public delegate void SelectBuffer(int size, IntPtr buffer);
        public delegate void ShadeModel(int mode);
        public delegate void StencilFunc(int func, int reference, uint mask);
        public delegate void StencilMask(uint mask);
        public delegate void StencilOp(int fail, int zfail, int zpass);
        public delegate void TexCoord1d(double s);
        public delegate void TexCoord1dv(double[] v);
        public delegate void TexCoord1dv_double(ref double v);
        public delegate void TexCoord1f(float s);
        public delegate void TexCoord1fv(float[] v);
        public delegate void TexCoord1fv_float(ref float v);
        public delegate void TexCoord1i(int s);
        public delegate void TexCoord1iv(int[] v);
        public delegate void TexCoord1iv_int(ref int v);
        public delegate void TexCoord1s(short s);
        public delegate void TexCoord1sv(short[] v);
        public delegate void TexCoord2d(double s, double t);
        public delegate void TexCoord2dv(double[] v);
        public delegate void TexCoord2f(float s, float t);
        public delegate void TexCoord2fv(float[] v);
        public delegate void TexCoord2i(int s, int t);
        public delegate void TexCoord2iv(int[] v);
        public delegate void TexCoord2s(short s, short t);
        public delegate void TexCoord2sv(short[] v);
        public delegate void TexCoord3d(double s, double t, double r);
        public delegate void TexCoord3dv(double[] v);
        public delegate void TexCoord3f(float s, float t, float r);
        public delegate void TexCoord3fv(float[] v);
        public delegate void TexCoord3i(int s, int t, int r);
        public delegate void TexCoord3iv(int[] v);
        public delegate void TexCoord3s(short s, short t, short r);
        public delegate void TexCoord3sv(short[] v);
        public delegate void TexCoord4d(double s, double t, double r, double q);
        public delegate void TexCoord4dv(double[] v);
        public delegate void TexCoord4f(float s, float t, float r, float q);
        public delegate void TexCoord4fv(float[] v);
        public delegate void TexCoord4i(int s, int t, int r, int q);
        public delegate void TexCoord4iv(int[] v);
        public delegate void TexCoord4s(short s, short t, short r, short q);
        public delegate void TexCoord4sv(short[] v);
        public delegate void TexEnvf(int target, int pname, float param);
        public delegate void TexEnvfv(int target, int pname, float[] param);
        public delegate void TexEnvi(int target, int pname, int param);
        public delegate void TexEnviv(int target, int pname, int[] param);
        public delegate void TexGend(int coord, int pname, double param);
        public delegate void TexGendv(int coord, int pname, double[] param);
        public delegate void TexGenf(int coord, int pname, float param);
        public delegate void TexGenfv(int coord, int pname, float[] param);
        public delegate void TexGeni(int coord, int pname, int param);
        public delegate void TexGeniv(int coord, int pname, int[] param);
        public delegate void TexImage1D(int target, int level, int internalformat, int width, int border, int format, int type, IntPtr pixels);
        public delegate void TexImage2D(int target, int level, int internalformat, int width, int height, int border, int format, int type, IntPtr pixels);
        public delegate void TexParameterf(int target, int pname, float param);
        public delegate void TexParameterfv(int target, int pname, float[] param);
        public delegate void TexParameteri(int target, int pname, int param);
        public delegate void TexParameteriv(int target, int pname, int[] param);
        public delegate void Translated(double x, double y, double z);
        public delegate void Translatef(float x, float y, float z);
        public delegate void Vertex2d(double x, double y);
        public delegate void Vertex2dv(double[] v);
        public delegate void Vertex2f(float x, float y);
        public delegate void Vertex2fv(float[] v);
        public delegate void Vertex2i(int x, int y);
        public delegate void Vertex2iv(int[] v);
        public delegate void Vertex2s(short x, short y);
        public delegate void Vertex2sv(short[] v);
        public delegate void Vertex3d(double x, double y, double z);
        public delegate void Vertex3dv(double[] v);
        public delegate void Vertex3f(float x, float y, float z);
        public delegate void Vertex3fv(float[] v);
        public delegate void Vertex3i(int x, int y, int z);
        public delegate void Vertex3iv(int[] v);
        public delegate void Vertex3s(short x, short y, short z);
        public delegate void Vertex3sv(short[] v);
        public delegate void Vertex4d(double x, double y, double z, double w);
        public delegate void Vertex4dv(double[] v);
        public delegate void Vertex4f(float x, float y, float z, float w);
        public delegate void Vertex4fv(float[] v);
        public delegate void Vertex4i(int x, int y, int z, int w);
        public delegate void Vertex4iv(int[] v);
        public delegate void Vertex4s(short x, short y, short z, short w);
        public delegate void Vertex4sv(short[] v);
        public delegate void Viewport(int x, int y, int width, int height);
        #endregion

        #region 1.1
        public delegate bool AreTexturesResident(int n, uint[] textures, bool[] residences);
        public delegate bool AreTexturesResident_uint_bool(int n, ref uint textures, out bool residences);
        public delegate void ArrayElement(int i);
        public delegate void BindTexture(int target, uint texture);
        public delegate void ColorPointer(int size, int type, int stride, IntPtr pointer);
        public delegate void CopyTexImage1D(int target, int level, int internalformat, int x, int y, int width, int border);
        public delegate void CopyTexImage2D(int target, int level, int internalformat, int x, int y, int width, int height, int border);
        public delegate void CopyTexSubImage1D(int target, int level, int xoffset, int x, int y, int width);
        public delegate void CopyTexSubImage2D(int target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        public delegate void DeleteTextures_uint(int n, ref uint textures);
        public delegate void DeleteTextures(int n, uint[] textures);
        public delegate void DisableClientState(int array);
        public delegate void DrawArrays(int mode, int first, int count);
        public delegate void DrawElements(int mode, int count, int type, IntPtr indices);
        public delegate void EdgeFlagPointer(int stride, IntPtr pointer);
        public delegate void EnableClientState(int array);
        public delegate void GenTextures_uint(int n, out uint textures);
        public delegate void GenTextures(int n, uint[] textures);
        public delegate void GetPointerv(int pname, IntPtr[] param);
        public delegate void IndexPointer(int type, int stride, IntPtr pointer);
        public delegate void Indexub(byte c);
        public delegate void Indexubv(byte[] c);
        public delegate void InterleavedArrays(int format, int stride, IntPtr pointer);
        public delegate bool IsTexture(uint texture);
        public delegate void NormalPointer(int type, int stride, IntPtr pointer);
        public delegate void PolygonOffset(float factor, float units);
        public delegate void PopClientAttrib();
        public delegate void PrioritizeTextures_uint_float(int n, ref uint textures, ref float priorities);
        public delegate void PrioritizeTextures(int n, uint[] textures, float[] priorities);
        public delegate void PushClientAttrib(int mask);
        public delegate void TexCoordPointer(int size, int type, int stride, IntPtr pointer);
        public delegate void TexSubImage1D(int target, int level, int xoffset, int width, int format, int type, IntPtr pixels);
        public delegate void TexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, int type, IntPtr pixels);
        public delegate void VertexPointer(int size, int type, int stride, IntPtr pointer);
        #endregion

        #region 1.2
        public delegate void BlendColor(float red, float green, float blue, float alpha);
        public delegate void BlendEquation(int mode);
        public delegate void ColorSubTable(int target, int start, int count, int format, int type, IntPtr data);
        public delegate void ColorTable(int target, int internalformat, int width, int format, int type, IntPtr table);
        public delegate void ColorTableParameterfv(int target, int pname, float[] param);
        public delegate void ColorTableParameteriv(int target, int pname, int[] param);
        public delegate void ConvolutionFilter1D(int target, int internalformat, int width, int format, int type, IntPtr image);
        public delegate void ConvolutionFilter2D(int target, int internalformat, int width, int height, int format, int type, IntPtr image);
        public delegate void ConvolutionParameterf(int target, int pname, float param);
        public delegate void ConvolutionParameterfv(int target, int pname, float[] param);
        public delegate void ConvolutionParameteri(int target, int pname, int param);
        public delegate void ConvolutionParameteriv(int target, int pname, int[] param);
        public delegate void CopyColorSubTable(int target, int start, int x, int y, int width);
        public delegate void CopyColorTable(int target, int internalformat, int x, int y, int width);
        public delegate void CopyConvolutionFilter1D(int target, int internalformat, int x, int y, int width);
        public delegate void CopyConvolutionFilter2D(int target, int internalformat, int x, int y, int width, int height);
        public delegate void CopyTexSubImage3D(int target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
        public delegate void DrawRangeElements(int mode, uint start, uint end, int count, int type, IntPtr indices);
        public delegate void GetColorTable(int target, int format, int type, IntPtr table);
        public delegate void GetColorTableParameterfv(int target, int pname, float[] param);
        public delegate void GetColorTableParameteriv(int target, int pname, int[] param);
        public delegate void GetConvolutionFilter(int target, int format, int type, IntPtr image);
        public delegate void GetConvolutionParameterfv(int target, int pname, float[] param);
        public delegate void GetConvolutionParameteriv(int target, int pname, int[] param);
        public delegate void GetHistogram(int target, bool reset, int format, int type, IntPtr values);
        public delegate void GetHistogramParameterfv(int target, int pname, float[] param);
        public delegate void GetHistogramParameteriv(int target, int pname, int[] param);
        public delegate void GetMinmax(int target, bool reset, int format, int type, IntPtr values);
        public delegate void GetMinmaxParameterfv(int target, int pname, float[] param);
        public delegate void GetMinmaxParameteriv(int target, int pname, int[] param);
        public delegate void GetSeparableFilter(int target, int format, int type, IntPtr row, IntPtr column, IntPtr span);
        public delegate void Histogram(int target, int width, int internalformat, bool sink);
        public delegate void Minmax(int target, int internalformat, bool sink);
        public delegate void ResetHistogram(int target);
        public delegate void ResetMinmax(int target);
        public delegate void SeparableFilter2D(int target, int internalformat, int width, int height, int format, int type, IntPtr row, IntPtr column);
        public delegate void TexImage3D(int target, int level, int internalformat, int width, int height, int depth, int border, int format, int type, IntPtr pixels);
        public delegate void TexSubImage3D(int target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int format, int type, IntPtr pixels);
        #endregion

        #region 1.3
        public delegate void ActiveTexture(int texture);
        public delegate void ClientActiveTexture(int texture);
        public delegate void CompressedTexImage1D(int target, int level, int internalformat, int width, int border, int imageSize, IntPtr data);
        public delegate void CompressedTexImage2D(int target, int level, int internalformat, int width, int height, int border, int imageSize, IntPtr data);
        public delegate void CompressedTexImage3D(int target, int level, int internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);
        public delegate void CompressedTexSubImage1D(int target, int level, int xoffset, int width, int format, int imageSize, IntPtr data);
        public delegate void CompressedTexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, int imageSize, IntPtr data);
        public delegate void CompressedTexSubImage3D(int target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int format, int imageSize, IntPtr data);
        public delegate void GetCompressedTexImage(int target, int level, IntPtr img);
        public delegate void LoadTransposeMatrixd(double[] m);
        public delegate void LoadTransposeMatrixf(float[] m);
        public delegate void MultiTexCoord1d(int target, double s);
        public delegate void MultiTexCoord1dv(int target, double[] v);
        public delegate void MultiTexCoord1dv_double(int target, ref double v);
        public delegate void MultiTexCoord1f(int target, float s);
        public delegate void MultiTexCoord1fv(int target, float[] v);
        public delegate void MultiTexCoord1fv_float(int target, ref float v);
        public delegate void MultiTexCoord1i(int target, int s);
        public delegate void MultiTexCoord1iv(int target, int[] v);
        public delegate void MultiTexCoord1iv_int(int target, ref int v);
        public delegate void MultiTexCoord1s(int target, short s);
        public delegate void MultiTexCoord1sv(int target, short[] v);
        public delegate void MultiTexCoord2d(int target, double s, double t);
        public delegate void MultiTexCoord2dv(int target, double[] v);
        public delegate void MultiTexCoord2f(int target, float s, float t);
        public delegate void MultiTexCoord2fv(int target, float[] v);
        public delegate void MultiTexCoord2i(int target, int s, int t);
        public delegate void MultiTexCoord2iv(int target, int[] v);
        public delegate void MultiTexCoord2s(int target, short s, short t);
        public delegate void MultiTexCoord2sv(int target, short[] v);
        public delegate void MultiTexCoord3d(int target, double s, double t, double r);
        public delegate void MultiTexCoord3dv(int target, double[] v);
        public delegate void MultiTexCoord3f(int target, float s, float t, float r);
        public delegate void MultiTexCoord3fv(int target, float[] v);
        public delegate void MultiTexCoord3i(int target, int s, int t, int r);
        public delegate void MultiTexCoord3iv(int target, int[] v);
        public delegate void MultiTexCoord3s(int target, short s, short t, short r);
        public delegate void MultiTexCoord3sv(int target, short[] v);
        public delegate void MultiTexCoord4d(int target, double s, double t, double r, double q);
        public delegate void MultiTexCoord4dv(int target, double[] v);
        public delegate void MultiTexCoord4f(int target, float s, float t, float r, float q);
        public delegate void MultiTexCoord4fv(int target, float[] v);
        public delegate void MultiTexCoord4i(int target, int s, int t, int r, int q);
        public delegate void MultiTexCoord4iv(int target, int[] v);
        public delegate void MultiTexCoord4s(int target, short s, short t, short r, short q);
        public delegate void MultiTexCoord4sv(int target, short[] v);
        public delegate void MultTransposeMatrixd(double[] m);
        public delegate void MultTransposeMatrixf(float[] m);
        public delegate void SampleCoverage(float value, bool invert);
        #endregion

        #region 1.4
        public delegate void BlendFuncSeparate(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
        public delegate void FogCoordd(double coord);
        public delegate void FogCoorddv_double(ref double coord);
        public delegate void FogCoorddv(double[] coord);
        public delegate void FogCoordf(float coord);
        public delegate void FogCoordfv(float[] coord);
        public delegate void FogCoordfv_float(ref float coord);
        public delegate void FogCoordPointer(int type, int stride, IntPtr pointer);
        public delegate void MultiDrawArrays(int mode, int[] first, int[] count, int drawcount);
        public delegate void MultiDrawElements(int mode, int[] count, int type, IntPtr indices, int drawcount);
        public delegate void PointParameterf(int pname, float param);
        public delegate void PointParameterfv(int pname, float[] param);
        public delegate void PointParameteri(int pname, int param);
        public delegate void PointParameteriv(int pname, int[] param);
        public delegate void SecondaryColor3b(byte red, byte green, byte blue);
        public delegate void SecondaryColor3bv(byte[] v);
        public delegate void SecondaryColor3d(double red, double green, double blue);
        public delegate void SecondaryColor3dv(double[] v);
        public delegate void SecondaryColor3f(float red, float green, float blue);
        public delegate void SecondaryColor3fv(float[] v);
        public delegate void SecondaryColor3i(int red, int green, int blue);
        public delegate void SecondaryColor3iv(int[] v);
        public delegate void SecondaryColor3s(short red, short green, short blue);
        public delegate void SecondaryColor3sv(short[] v);
        public delegate void SecondaryColor3ub(byte red, byte green, byte blue);
        public delegate void SecondaryColor3ubv(byte[] v);
        public delegate void SecondaryColor3ui(uint red, uint green, uint blue);
        public delegate void SecondaryColor3uiv(uint[] v);
        public delegate void SecondaryColor3us(ushort red, ushort green, ushort blue);
        public delegate void SecondaryColor3usv(ushort[] v);
        public delegate void SecondaryColorPointer(int size, int type, int stride, IntPtr pointer);
        public delegate void WindowPos2d(double x, double y);
        public delegate void WindowPos2dv(double[] v);
        public delegate void WindowPos2f(float x, float y);
        public delegate void WindowPos2fv(float[] v);
        public delegate void WindowPos2i(int x, int y);
        public delegate void WindowPos2iv(int[] v);
        public delegate void WindowPos2s(short x, short y);
        public delegate void WindowPos2sv(short[] v);
        public delegate void WindowPos3d(double x, double y, double z);
        public delegate void WindowPos3dv(double[] v);
        public delegate void WindowPos3f(float x, float y, float z);
        public delegate void WindowPos3fv(float[] v);
        public delegate void WindowPos3i(int x, int y, int z);
        public delegate void WindowPos3iv(int[] v);
        public delegate void WindowPos3s(short x, short y, short z);
        public delegate void WindowPos3sv(short[] v);
        #endregion

        #region 1.5
        public delegate void BeginQuery(int target, uint id);
        public delegate void BindBuffer(int target, uint buffer);
        public delegate void BufferData(int target, int size, IntPtr data, int usage);
        public delegate void BufferSubData(int target, int offset, int size, IntPtr data);
        public delegate void DeleteBuffers(int n, uint[] buffers);
        public delegate void DeleteBuffers_uint(int n, ref uint buffers);
        public delegate void DeleteQueries(int n, uint[] ids);
        public delegate void DeleteQueries_uint(int n, ref uint ids);
        public delegate void EndQuery(int target);
        public delegate void GenBuffers_uint(int n, out uint buffers);
        public delegate void GenBuffers(int n, uint[] buffers);
        public delegate void GenQueries_uint(int n, out uint ids);
        public delegate void GenQueries(int n, uint[] ids);
        public delegate void GetBufferParameteriv(int target, int pname, int[] param);
        public delegate void GetBufferPointerv(int target, int pname, IntPtr[] param);
        public delegate void GetBufferSubData(int target, int offset, int size, IntPtr data);
        public delegate void GetQueryiv(int target, int pname, int[] param);
        public delegate void GetQueryObjectiv(uint id, int pname, int[] param);
        public delegate void GetQueryObjectuiv(uint id, int pname, uint[] param);
        public delegate bool IsBuffer(uint buffer);
        public delegate bool IsQuery(uint id);
        public delegate IntPtr MapBuffer(int target, int access);
        public delegate bool UnmapBuffer(int target);
        #endregion

        #region 2.0
        public delegate void AttachShader(uint program, uint shader);
        public delegate void BindAttribLocation(uint program, uint index, StringBuilder name);
        public delegate void BlendEquationSeparate(int modeRGB, int modeAlpha);
        public delegate void CompileShader(uint shader);
        public delegate uint CreateProgram();
        public delegate uint CreateShader(int type);
        public delegate void DeleteProgram(uint program);
        public delegate void DeleteShader(uint shader);
        public delegate void DetachShader(uint program, uint shader);
        public delegate void DisableVertexAttribArray(uint index);
        public delegate void DrawBuffers_int(int n, ref int bufs);
        public delegate void DrawBuffers(int n, int[] bufs);
        public delegate void EnableVertexAttribArray(uint index);
        public delegate void GetActiveAttrib_int_int_int(uint program, uint index, int bufSize, out int length, out int size, out int type, StringBuilder name);
        public delegate void GetActiveAttrib(uint program, uint index, int bufSize, int[] length, int[] size, int[] type, StringBuilder name);
        public delegate void GetActiveUniform(uint program, uint index, int bufSize, int[] length, int[] size, int[] type, StringBuilder name);
        public delegate void GetActiveUniform_int_int_int(uint program, uint index, int bufSize, out int length, out int size, out int type, StringBuilder name);
        public delegate void GetAttachedShaders_int(uint program, int maxCount, out int count, uint[] obj);
        public delegate void GetAttachedShaders(uint program, int maxCount, int[] count, uint[] obj);
        public delegate int GetAttribLocation(uint program, StringBuilder name);
        public delegate void GetProgramInfoLog(uint program, int bufSize, int[] length, StringBuilder infoLog);
        public delegate void GetProgramInfoLog_int(uint program, int bufSize, out int length, StringBuilder infoLog);
        public delegate void GetProgramiv(uint program, int pname, int[] param);
        public delegate void GetShaderInfoLog(uint shader, int bufSize, int[] length, StringBuilder infoLog);
        public delegate void GetShaderInfoLog_int(uint shader, int bufSize, out int length, StringBuilder infoLog);
        public delegate void GetShaderiv(uint shader, int pname, int[] param);
        public delegate void GetShaderSource(uint shader, int bufSize, int[] length, StringBuilder source);
        public delegate void GetShaderSource_int(uint shader, int bufSize, out int length, StringBuilder source);
        public delegate void GetUniformfv(uint program, int location, float[] param);
        public delegate void GetUniformiv(uint program, int location, int[] param);
        public delegate int GetUniformLocation(uint program, StringBuilder name);
        public delegate void GetVertexAttribdv(uint index, int pname, double[] param);
        public delegate void GetVertexAttribfv(uint index, int pname, float[] param);
        public delegate void GetVertexAttribiv(uint index, int pname, int[] param);
        public delegate void GetVertexAttribPointerv(uint index, int pname, IntPtr[] pointer);
        public delegate bool IsProgram(uint program);
        public delegate bool IsShader(uint shader);
        public delegate void LinkProgram(uint program);
        public delegate void ShaderSource_int(uint shader, int count, string[] str, ref int length);
        public delegate void ShaderSource(uint shader, int count, string[] str, int[] length);
        public delegate void StencilFuncSeparate(int face, int func, int reference, uint mask);
        public delegate void StencilMaskSeparate(int face, uint mask);
        public delegate void StencilOpSeparate(int face, int sfail, int dpfail, int dppass);
        public delegate void Uniform1dv_double(int location, int count, ref double value);
        public delegate void Uniform1f(int location, float v0);
        public delegate void Uniform1fv_float(int location, int count, ref float value);
        public delegate void Uniform1fv(int location, int count, float[] value);
        public delegate void Uniform1i(int location, int v0);
        public delegate void Uniform1iv(int location, int count, int[] value);
        public delegate void Uniform2f(int location, float v0, float v1);
        public delegate void Uniform2fv(int location, int count, float[] value);
        public delegate void Uniform2i(int location, int v0, int v1);
        public delegate void Uniform2iv(int location, int count, int[] value);
        public delegate void Uniform3f(int location, float v0, float v1, float v2);
        public delegate void Uniform3fv(int location, int count, float[] value);
        public delegate void Uniform3i(int location, int v0, int v1, int v2);
        public delegate void Uniform3iv(int location, int count, int[] value);
        public delegate void Uniform4f(int location, float v0, float v1, float v2, float v3);
        public delegate void Uniform4fv(int location, int count, float[] value);
        public delegate void Uniform4i(int location, int v0, int v1, int v2, int v3);
        public delegate void Uniform4iv(int location, int count, int[] value);
        public delegate void UniformMatrix2fv(int location, int count, bool transpose, float[] value);
        public delegate void UniformMatrix3fv(int location, int count, bool transpose, float[] value);
        public delegate void UniformMatrix4fv(int location, int count, bool transpose, float[] value);
        public delegate void UseProgram(uint program);
        public delegate void ValidateProgram(uint program);
        public delegate void VertexAttrib1d(uint index, double x);
        public delegate void VertexAttrib1dv_double(uint index, ref double v);
        public delegate void VertexAttrib1dv(uint index, double[] v);
        public delegate void VertexAttrib1f(uint index, float x);
        public delegate void VertexAttrib1fv(uint index, float[] v);
        public delegate void VertexAttrib1fv_float(uint index, ref float v);
        public delegate void VertexAttrib1s(uint index, short x);
        public delegate void VertexAttrib1sv(uint index, short[] v);
        public delegate void VertexAttrib2d(uint index, double x, double y);
        public delegate void VertexAttrib2dv(uint index, double[] v);
        public delegate void VertexAttrib2f(uint index, float x, float y);
        public delegate void VertexAttrib2fv(uint index, float[] v);
        public delegate void VertexAttrib2s(uint index, short x, short y);
        public delegate void VertexAttrib2sv(uint index, short[] v);
        public delegate void VertexAttrib3d(uint index, double x, double y, double z);
        public delegate void VertexAttrib3dv(uint index, double[] v);
        public delegate void VertexAttrib3f(uint index, float x, float y, float z);
        public delegate void VertexAttrib3fv(uint index, float[] v);
        public delegate void VertexAttrib3s(uint index, short x, short y, short z);
        public delegate void VertexAttrib3sv(uint index, short[] v);
        public delegate void VertexAttrib4bv(uint index, byte[] v);
        public delegate void VertexAttrib4d(uint index, double x, double y, double z, double w);
        public delegate void VertexAttrib4dv(uint index, double[] v);
        public delegate void VertexAttrib4f(uint index, float x, float y, float z, float w);
        public delegate void VertexAttrib4fv(uint index, float[] v);
        public delegate void VertexAttrib4iv(uint index, int[] v);
        public delegate void VertexAttrib4Nbv(uint index, byte[] v);
        public delegate void VertexAttrib4Niv(uint index, int[] v);
        public delegate void VertexAttrib4Nsv(uint index, short[] v);
        public delegate void VertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w);
        public delegate void VertexAttrib4Nubv(uint index, byte[] v);
        public delegate void VertexAttrib4Nuiv(uint index, uint[] v);
        public delegate void VertexAttrib4Nusv(uint index, ushort[] v);
        public delegate void VertexAttrib4s(uint index, short x, short y, short z, short w);
        public delegate void VertexAttrib4sv(uint index, short[] v);
        public delegate void VertexAttrib4ubv(uint index, byte[] v);
        public delegate void VertexAttrib4uiv(uint index, uint[] v);
        public delegate void VertexAttrib4usv(uint index, ushort[] v);
        public delegate void VertexAttribPointer(uint index, int size, int type, bool normalized, int stride, IntPtr pointer);
        #endregion

        #region 2.1
        public delegate void UniformMatrix2x3fv(int location, int count, bool transpose, float[] value);
        public delegate void UniformMatrix2x4fv(int location, int count, bool transpose, float[] value);
        public delegate void UniformMatrix3x2fv(int location, int count, bool transpose, float[] value);
        public delegate void UniformMatrix3x4fv(int location, int count, bool transpose, float[] value);
        public delegate void UniformMatrix4x2fv(int location, int count, bool transpose, float[] value);
        public delegate void UniformMatrix4x3fv(int location, int count, bool transpose, float[] value);
        #endregion

        #region 3.0
        public delegate void BeginConditionalRender(uint id, int mode);
        public delegate void BeginTransformFeedback(int primitiveMode);
        public delegate void BindBufferBase(int target, uint index, uint buffer);
        public delegate void BindBufferRange(int target, uint index, uint buffer, int offset, int size);
        public delegate void BindFragDataLocation(uint program, uint color, StringBuilder name);
        public delegate void ClampColor(int target, int clamp);
        public delegate void ClearBufferfi(int buffer, int drawbuffer, float depth, int stencil);
        public delegate void ClearBufferfv(int buffer, int drawbuffer, float[] value);
        public delegate void ClearBufferiv(int buffer, int drawbuffer, int[] value);
        public delegate void ClearBufferuiv(int buffer, int drawbuffer, uint[] value);
        public delegate void ColorMaski(uint index, bool r, bool g, bool b, bool a);
        public delegate void Disablei(int target, uint index);
        public delegate void Enablei(int target, uint index);
        public delegate void EndConditionalRender();
        public delegate void EndTransformFeedback();
        public delegate void GetBooleani_v(int target, uint index, bool[] data);
        public delegate int GetFragDataLocation(uint program, StringBuilder name);
        public delegate void GetIntegeri_v(int target, uint index, int[] data);
        public delegate IntPtr GetStringi(int name, uint index);
        public delegate void GetTexParameterIiv(int target, int pname, int[] param);
        public delegate void GetTexParameterIuiv(int target, int pname, uint[] param);
        public delegate void GetTransformFeedbackVarying(uint program, uint index, int bufSize, int[] length, int[] size, int[] type, StringBuilder name);
        public delegate void GetTransformFeedbackVarying_int_int_int(uint program, uint index, int bufSize, out int length, out int size, out int type, StringBuilder name);
        public delegate void GetUniformuiv(uint program, int location, uint[] param);
        public delegate void GetVertexAttribIiv_int(uint index, int pname, out int param);
        public delegate void GetVertexAttribIiv(uint index, int pname, int[] param);
        public delegate void GetVertexAttribIuiv_uint(uint index, int pname, out uint param);
        public delegate void GetVertexAttribIuiv(uint index, int pname, uint[] param);
        public delegate bool IsEnabledi(int target, uint index);
        public delegate void TexParameterIiv(int target, int pname, int[] param);
        public delegate void TexParameterIuiv(int target, int pname, uint[] param);
        public delegate void TransformFeedbackVaryings(uint program, int count, string[] varyings, int bufferMode);
        public delegate void Uniform1ui(int location, uint v0);
        public delegate void Uniform1uiv(int location, int count, uint[] value);
        public delegate void Uniform2ui(int location, uint v0, uint v1);
        public delegate void Uniform2uiv(int location, int count, uint[] value);
        public delegate void Uniform3ui(int location, uint v0, uint v1, uint v2);
        public delegate void Uniform3uiv(int location, int count, uint[] value);
        public delegate void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3);
        public delegate void Uniform4uiv(int location, int count, uint[] value);
        public delegate void VertexAttribI1i(uint index, int x);
        public delegate void VertexAttribI1iv(uint index, int[] v);
        public delegate void VertexAttribI1iv_int(uint index, ref int v);
        public delegate void VertexAttribI1ui(uint index, uint x);
        public delegate void VertexAttribI1uiv_uint(uint index, ref uint v);
        public delegate void VertexAttribI1uiv(uint index, uint[] v);
        public delegate void VertexAttribI2i(uint index, int x, int y);
        public delegate void VertexAttribI2iv(uint index, int[] v);
        public delegate void VertexAttribI2ui(uint index, uint x, uint y);
        public delegate void VertexAttribI2uiv(uint index, uint[] v);
        public delegate void VertexAttribI3i(uint index, int x, int y, int z);
        public delegate void VertexAttribI3iv(uint index, int[] v);
        public delegate void VertexAttribI3ui(uint index, uint x, uint y, uint z);
        public delegate void VertexAttribI3uiv(uint index, uint[] v);
        public delegate void VertexAttribI4bv(uint index, byte[] v);
        public delegate void VertexAttribI4i(uint index, int x, int y, int z, int w);
        public delegate void VertexAttribI4iv(uint index, int[] v);
        public delegate void VertexAttribI4sv(uint index, short[] v);
        public delegate void VertexAttribI4ubv(uint index, byte[] v);
        public delegate void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w);
        public delegate void VertexAttribI4uiv(uint index, uint[] v);
        public delegate void VertexAttribI4usv(uint index, ushort[] v);
        public delegate void VertexAttribIPointer(uint index, int size, int type, int stride, IntPtr pointer);
        #endregion

        #region 3.1
        public delegate void DrawArraysInstanced(int mode, int first, int count, int instancecount);
        public delegate void DrawElementsInstanced(int mode, int count, int type, IntPtr indices, int instancecount);
        public delegate void PrimitiveRestartIndex(uint index);
        public delegate void TexBuffer(int target, int internalformat, uint buffer);
        #endregion

        #region 3.2
        public delegate void FramebufferTexture(int target, int attachment, uint texture, int level);
        public delegate void GetBufferParameteri64v(int target, int pname, long[] param);
        public delegate void GetInteger64i_v(int target, uint index, long[] data);
        #endregion

        #region 3.3
        public delegate void VertexAttribDivisor(uint index, uint divisor);
        #endregion

        #region 4.0
        public delegate void BlendEquationi(uint buf, int mode);
        public delegate void BlendEquationSeparatei(uint buf, int modeRGB, int modeAlpha);
        public delegate void BlendFunci(uint buf, int src, int dst);
        public delegate void BlendFuncSeparatei(uint buf, int srcRGB, int dstRGB, int srcAlpha, int dstAlpha);
        public delegate void MinSampleShading(float value);
        #endregion

        #region ARB
        public delegate void ActiveShaderProgram(uint pipeline, uint program);
        // Function ActiveTextureARB is alias for ActiveTexture.
        public delegate void AttachObject(uint containerObj, uint obj);
        // Function BeginQueryARB is alias for BeginQuery.
        public delegate void BeginQueryIndexed(int target, uint index, uint id);
        // Function BindAttribLocationARB is alias for BindAttribLocation.
        // Function BindBufferARB is alias for BindBuffer.
        public delegate void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, StringBuilder name);
        public delegate void BindFramebuffer(int target, uint framebuffer);
        public delegate void BindImageTexture(uint unit, uint texture, int level, bool layered, int layer, int access, int format);
        public delegate void BindProgram(int target, uint program);
        public delegate void BindProgramPipeline(uint pipeline);
        public delegate void BindRenderbuffer(int target, uint renderbuffer);
        public delegate void BindSampler(uint unit, uint sampler);
        public delegate void BindTransformFeedback(int target, uint id);
        public delegate void BindVertexArray(uint array);
        public delegate void BindVertexBuffer(uint bindingindex, uint buffer, int offset, int stride);
        // Function BlendEquationiARB is alias for BlendEquationi.
        // Function BlendEquationSeparateiARB is alias for BlendEquationSeparatei.
        // Function BlendFunciARB is alias for BlendFunci.
        // Function BlendFuncSeparateiARB is alias for BlendFuncSeparatei.
        public delegate void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, int mask, int filter);
        // Function BufferDataARB is alias for BufferData.
        // Function BufferSubDataARB is alias for BufferSubData.
        public delegate int CheckFramebufferStatus(int target);
        // Function ClampColorARB is alias for ClampColor.
        public delegate void ClearBufferData(int target, int internalformat, int format, int type, IntPtr data);
        public delegate void ClearBufferSubData(int target, int internalformat, int offset, int size, int format, int type, IntPtr data);
        public delegate void ClearDepthf(float d);
        public delegate void ClearNamedBufferData(uint buffer, int internalformat, int format, int type, IntPtr data);
        public delegate void ClearNamedBufferSubData(uint buffer, int internalformat, int format, int type, int offset, int size, IntPtr data);
        // Function ClientActiveTextureARB is alias for ClientActiveTexture.
        public delegate int ClientWaitSync(IntPtr sync, int flags, ulong timeout);
        public delegate void ColorP3ui(int type, uint color);
        public delegate void ColorP3uiv_uint(int type, ref uint color);
        public delegate void ColorP3uiv(int type, uint[] color);
        public delegate void ColorP4ui(int type, uint color);
        public delegate void ColorP4uiv(int type, uint[] color);
        public delegate void ColorP4uiv_uint(int type, ref uint color);
        // Function CompileShaderARB is alias for CompileShader.
        public delegate void CompileShaderInclude(uint shader, int count, string[] path, int[] length);
        // Function CompressedTexImage1DARB is alias for CompressedTexImage1D.
        // Function CompressedTexImage2DARB is alias for CompressedTexImage2D.
        // Function CompressedTexImage3DARB is alias for CompressedTexImage3D.
        // Function CompressedTexSubImage1DARB is alias for CompressedTexSubImage1D.
        // Function CompressedTexSubImage2DARB is alias for CompressedTexSubImage2D.
        // Function CompressedTexSubImage3DARB is alias for CompressedTexSubImage3D.
        public delegate void CopyBufferSubData(int readTarget, int writeTarget, int readOffset, int writeOffset, int size);
        public delegate void CopyImageSubData(uint srcName, int srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, int dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
        public delegate uint CreateProgramObject();
        public delegate uint CreateShaderObject(int shaderType);
        public delegate uint CreateShaderProgramv(int type, int count, string[] strings);
        public delegate IntPtr CreateSyncFromCLevent(IntPtr context, IntPtr clevents, int flags);
        public delegate void CurrentPaletteMatrix(int index);
        // Function DebugMessageCallbackARB is alias for .
        // Function DebugMessageControlARB is alias for .
        // Function DebugMessageInsertARB is alias for .
        // Function DeleteBuffersARB is alias for DeleteBuffers.
        public delegate void DeleteFramebuffers_uint(int n, ref uint framebuffers);
        public delegate void DeleteFramebuffers(int n, uint[] framebuffers);
        public delegate void DeleteNamedString(int namelen, StringBuilder name);
        public delegate void DeleteObject(uint obj);
        public delegate void DeleteProgramPipelines(int n, uint[] pipelines);
        public delegate void DeleteProgramPipelines_uint(int n, ref uint pipelines);
        public delegate void DeletePrograms(int n, uint[] programs);
        public delegate void DeletePrograms_uint(int n, ref uint programs);
        // Function DeleteQueriesARB is alias for DeleteQueries.
        public delegate void DeleteRenderbuffers(int n, uint[] renderbuffers);
        public delegate void DeleteRenderbuffers_uint(int n, ref uint renderbuffers);
        public delegate void DeleteSamplers(int count, uint[] samplers);
        public delegate void DeleteSync(IntPtr sync);
        public delegate void DeleteTransformFeedbacks_uint(int n, ref uint ids);
        public delegate void DeleteTransformFeedbacks(int n, uint[] ids);
        public delegate void DeleteVertexArrays_uint(int n, ref uint arrays);
        public delegate void DeleteVertexArrays(int n, uint[] arrays);
        public delegate void DepthRangeArrayv(uint first, int count, double[] v);
        public delegate void DepthRangef(float n, float f);
        public delegate void DepthRangeIndexed(uint index, double n, double f);
        public delegate void DetachObject(uint containerObj, uint attachedObj);
        // Function DisableVertexAttribArrayARB is alias for DisableVertexAttribArray.
        public delegate void DispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z);
        public delegate void DispatchComputeIndirect(int indirect);
        public delegate void DrawArraysIndirect(int mode, IntPtr indirect);
        // Function DrawArraysInstancedARB is alias for DrawArraysInstanced.
        public delegate void DrawArraysInstancedBaseInstance(int mode, int first, int count, int instancecount, uint baseinstance);
        // Function DrawBuffersARB is alias for DrawBuffers.
        public delegate void DrawElementsBaseVertex(int mode, int count, int type, IntPtr indices, int basevertex);
        public delegate void DrawElementsIndirect(int mode, int type, IntPtr indirect);
        // Function DrawElementsInstancedARB is alias for DrawElementsInstanced.
        public delegate void DrawElementsInstancedBaseInstance(int mode, int count, int type, IntPtr indices, int instancecount, uint baseinstance);
        public delegate void DrawElementsInstancedBaseVertex(int mode, int count, int type, IntPtr indices, int instancecount, int basevertex);
        public delegate void DrawElementsInstancedBaseVertexBaseInstance(int mode, int count, int type, IntPtr indices, int instancecount, int basevertex, uint baseinstance);
        public delegate void DrawRangeElementsBaseVertex(int mode, uint start, uint end, int count, int type, IntPtr indices, int basevertex);
        public delegate void DrawTransformFeedback(int mode, uint id);
        public delegate void DrawTransformFeedbackInstanced(int mode, uint id, int instancecount);
        public delegate void DrawTransformFeedbackStream(int mode, uint id, uint stream);
        public delegate void DrawTransformFeedbackStreamInstanced(int mode, uint id, uint stream, int instancecount);
        // Function EnableVertexAttribArrayARB is alias for EnableVertexAttribArray.
        // Function EndQueryARB is alias for EndQuery.
        public delegate void EndQueryIndexed(int target, uint index);
        public delegate IntPtr FenceSync(int condition, int flags);
        public delegate void FlushMappedBufferRange(int target, int offset, int length);
        public delegate void FramebufferParameteri(int target, int pname, int param);
        public delegate void FramebufferRenderbuffer(int target, int attachment, int renderbuffertarget, uint renderbuffer);
        // Function FramebufferTextureARB is alias for FramebufferTexture.
        public delegate void FramebufferTexture1D(int target, int attachment, int textarget, uint texture, int level);
        public delegate void FramebufferTexture2D(int target, int attachment, int textarget, uint texture, int level);
        public delegate void FramebufferTexture3D(int target, int attachment, int textarget, uint texture, int level, int zoffset);
        public delegate void FramebufferTextureFace(int target, int attachment, uint texture, int level, int face);
        public delegate void FramebufferTextureLayer(int target, int attachment, uint texture, int level, int layer);
        // Function FramebufferTextureLayerARB is alias for FramebufferTextureLayer.
        // Function GenBuffersARB is alias for GenBuffers.
        public delegate void GenerateMipmap(int target);
        public delegate void GenFramebuffers_uint(int n, out uint framebuffers);
        public delegate void GenFramebuffers(int n, uint[] framebuffers);
        public delegate void GenProgramPipelines_uint(int n, out uint pipelines);
        public delegate void GenProgramPipelines(int n, uint[] pipelines);
        public delegate void GenPrograms(int n, uint[] programs);
        public delegate void GenPrograms_uint(int n, out uint programs);
        // Function GenQueriesARB is alias for GenQueries.
        public delegate void GenRenderbuffers_uint(int n, out uint renderbuffers);
        public delegate void GenRenderbuffers(int n, uint[] renderbuffers);
        public delegate void GenSamplers(int count, uint[] samplers);
        public delegate void GenTransformFeedbacks(int n, uint[] ids);
        public delegate void GenTransformFeedbacks_uint(int n, out uint ids);
        public delegate void GenVertexArrays(int n, uint[] arrays);
        public delegate void GenVertexArrays_uint(int n, out uint arrays);
        public delegate void GetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, int pname, int[] param);
        // Function GetActiveAttribARB is alias for GetActiveAttrib.
        public delegate void GetActiveSubroutineName(uint program, int shadertype, uint index, int bufsize, int[] length, StringBuilder name);
        public delegate void GetActiveSubroutineName_int(uint program, int shadertype, uint index, int bufsize, out int length, StringBuilder name);
        public delegate void GetActiveSubroutineUniformiv(uint program, int shadertype, uint index, int pname, int[] values);
        public delegate void GetActiveSubroutineUniformName(uint program, int shadertype, uint index, int bufsize, int[] length, StringBuilder name);
        public delegate void GetActiveSubroutineUniformName_int(uint program, int shadertype, uint index, int bufsize, out int length, StringBuilder name);
        // Function GetActiveUniformARB is alias for GetActiveUniform.
        public delegate void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, int pname, int[] param);
        public delegate void GetActiveUniformBlockName_int(uint program, uint uniformBlockIndex, int bufSize, out int length, StringBuilder uniformBlockName);
        public delegate void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int[] length, StringBuilder uniformBlockName);
        public delegate void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, int[] length, StringBuilder uniformName);
        public delegate void GetActiveUniformName_int(uint program, uint uniformIndex, int bufSize, out int length, StringBuilder uniformName);
        public delegate void GetActiveUniformsiv(uint program, int uniformCount, uint[] uniformIndices, int pname, int[] param);
        public delegate void GetAttachedObjects(uint containerObj, int maxCount, int[] count, uint[] obj);
        public delegate void GetAttachedObjects_int(uint containerObj, int maxCount, out int count, uint[] obj);
        // Function GetAttribLocationARB is alias for GetAttribLocation.
        // Function GetBufferParameterivARB is alias for GetBufferParameteriv.
        // Function GetBufferPointervARB is alias for GetBufferPointerv.
        // Function GetBufferSubDataARB is alias for GetBufferSubData.
        // Function GetCompressedTexImageARB is alias for GetCompressedTexImage.
        // Function GetDebugMessageLogARB is alias for .
        public delegate void GetDoublei_v(int target, uint index, double[] data);
        public delegate void GetFloati_v(int target, uint index, float[] data);
        public delegate int GetFragDataIndex(uint program, StringBuilder name);
        public delegate void GetFramebufferAttachmentParameteriv(int target, int attachment, int pname, int[] param);
        public delegate void GetFramebufferParameteriv(int target, int pname, int[] param);
        public delegate int GetGraphicsResetStatus();
        public delegate uint GetHandle(int pname);
        public delegate void GetInfoLog(uint obj, int maxLength, int[] length, StringBuilder infoLog);
        public delegate void GetInfoLog_int(uint obj, int maxLength, out int length, StringBuilder infoLog);
        public delegate void GetInteger64v(int pname, long[] param);
        public delegate void GetInternalformati64v(int target, int internalformat, int pname, int bufSize, long[] param);
        public delegate void GetInternalformativ(int target, int internalformat, int pname, int bufSize, int[] param);
        public delegate void GetMultisamplefv(int pname, uint index, float[] val);
        public delegate void GetNamedFramebufferParameteriv(uint framebuffer, int pname, int[] param);
        public delegate void GetNamedString_int(int namelen, StringBuilder name, int bufSize, out int stringlen, StringBuilder str);
        public delegate void GetNamedString(int namelen, StringBuilder name, int bufSize, int[] stringlen, StringBuilder str);
        public delegate void GetNamedStringiv(int namelen, StringBuilder name, int pname, int[] param);
        public delegate void GetnColorTable(int target, int format, int type, int bufSize, IntPtr table);
        public delegate void GetnCompressedTexImage(int target, int lod, int bufSize, IntPtr img);
        public delegate void GetnConvolutionFilter(int target, int format, int type, int bufSize, IntPtr image);
        public delegate void GetnHistogram(int target, bool reset, int format, int type, int bufSize, IntPtr values);
        public delegate void GetnMapdv(int target, int query, int bufSize, double[] v);
        public delegate void GetnMapfv(int target, int query, int bufSize, float[] v);
        public delegate void GetnMapiv(int target, int query, int bufSize, int[] v);
        public delegate void GetnMinmax(int target, bool reset, int format, int type, int bufSize, IntPtr values);
        public delegate void GetnPixelMapfv(int map, int bufSize, float[] values);
        public delegate void GetnPixelMapuiv(int map, int bufSize, uint[] values);
        public delegate void GetnPixelMapusv(int map, int bufSize, ushort[] values);
        public delegate void GetnPolygonStipple(int bufSize, byte[] pattern);
        public delegate void GetnSeparableFilter(int target, int format, int type, int rowBufSize, IntPtr row, int columnBufSize, IntPtr column, IntPtr span);
        public delegate void GetnTexImage(int target, int level, int format, int type, int bufSize, IntPtr img);
        public delegate void GetnUniformdv(uint program, int location, int bufSize, double[] param);
        public delegate void GetnUniformfv(uint program, int location, int bufSize, float[] param);
        public delegate void GetnUniformiv(uint program, int location, int bufSize, int[] param);
        public delegate void GetnUniformuiv(uint program, int location, int bufSize, uint[] param);
        public delegate void GetObjectParameterfv(uint obj, int pname, float[] param);
        public delegate void GetObjectParameteriv(uint obj, int pname, int[] param);
        public delegate void GetProgramBinary_int_int(uint program, int bufSize, out int length, out int binaryFormat, IntPtr binary);
        public delegate void GetProgramBinary(uint program, int bufSize, int[] length, int[] binaryFormat, IntPtr binary);
        public delegate void GetProgramEnvParameterdv(int target, uint index, double[] param);
        public delegate void GetProgramEnvParameterfv(int target, uint index, float[] param);
        public delegate void GetProgramInterfaceiv(uint program, int programInterface, int pname, int[] param);
        public delegate void GetProgramivARB_int(int target, int pname, out int param);
        public delegate void GetProgramivARB(int target, int pname, int[] param);
        public delegate void GetProgramLocalParameterdv(int target, uint index, double[] param);
        public delegate void GetProgramLocalParameterfv(int target, uint index, float[] param);
        public delegate void GetProgramPipelineInfoLog(uint pipeline, int bufSize, int[] length, StringBuilder infoLog);
        public delegate void GetProgramPipelineInfoLog_int(uint pipeline, int bufSize, out int length, StringBuilder infoLog);
        public delegate void GetProgramPipelineiv(uint pipeline, int pname, int[] param);
        public delegate uint GetProgramResourceIndex(uint program, int programInterface, StringBuilder name);
        public delegate void GetProgramResourceiv(uint program, int programInterface, uint index, int propCount, int[] props, int bufSize, int[] length, int[] param);
        public delegate int GetProgramResourceLocation(uint program, int programInterface, StringBuilder name);
        public delegate int GetProgramResourceLocationIndex(uint program, int programInterface, StringBuilder name);
        public delegate void GetProgramResourceName(uint program, int programInterface, uint index, int bufSize, int[] length, StringBuilder name);
        public delegate void GetProgramStageiv_int(uint program, int shadertype, int pname, out int values);
        public delegate void GetProgramStageiv(uint program, int shadertype, int pname, int[] values);
        public delegate void GetProgramString(int target, int pname, IntPtr str);
        public delegate void GetQueryIndexediv(int target, uint index, int pname, int[] param);
        // Function GetQueryivARB is alias for GetQueryiv.
        public delegate void GetQueryObjecti64v(uint id, int pname, long[] param);
        // Function GetQueryObjectivARB is alias for GetQueryObjectiv.
        public delegate void GetQueryObjectui64v(uint id, int pname, ulong[] param);
        // Function GetQueryObjectuivARB is alias for GetQueryObjectuiv.
        public delegate void GetRenderbufferParameteriv(int target, int pname, int[] param);
        public delegate void GetSamplerParameterfv(uint sampler, int pname, float[] param);
        public delegate void GetSamplerParameterIiv(uint sampler, int pname, int[] param);
        public delegate void GetSamplerParameterIuiv(uint sampler, int pname, uint[] param);
        public delegate void GetSamplerParameteriv(uint sampler, int pname, int[] param);
        public delegate void GetShaderPrecisionFormat(int shadertype, int precisiontype, int[] range, int[] precision);
        // Function GetShaderSourceARB is alias for GetShaderSource.
        public delegate uint GetSubroutineIndex(uint program, int shadertype, StringBuilder name);
        public delegate int GetSubroutineUniformLocation(uint program, int shadertype, StringBuilder name);
        public delegate void GetSynciv_int(IntPtr sync, int pname, int bufSize, out int length, int[] values);
        public delegate void GetSynciv(IntPtr sync, int pname, int bufSize, int[] length, int[] values);
        public delegate uint GetUniformBlockIndex(uint program, StringBuilder uniformBlockName);
        public delegate void GetUniformdv(uint program, int location, double[] param);
        // Function GetUniformfvARB is alias for GetUniformfv.
        public delegate void GetUniformIndices(uint program, int uniformCount, string[] uniformNames, uint[] uniformIndices);
        // Function GetUniformivARB is alias for GetUniformiv.
        // Function GetUniformLocationARB is alias for GetUniformLocation.
        public delegate void GetUniformSubroutineuiv_uint(int shadertype, int location, out uint param);
        public delegate void GetUniformSubroutineuiv(int shadertype, int location, uint[] param);
        // Function GetVertexAttribdvARB is alias for GetVertexAttribdv.
        // Function GetVertexAttribfvARB is alias for GetVertexAttribfv.
        // Function GetVertexAttribivARB is alias for GetVertexAttribiv.
        public delegate void GetVertexAttribLdv(uint index, int pname, double[] param);
        // Function GetVertexAttribPointervARB is alias for GetVertexAttribPointerv.
        public delegate void InvalidateBufferData(uint buffer);
        public delegate void InvalidateBufferSubData(uint buffer, int offset, int length);
        public delegate void InvalidateFramebuffer(int target, int numAttachments, int[] attachments);
        public delegate void InvalidateSubFramebuffer(int target, int numAttachments, int[] attachments, int x, int y, int width, int height);
        public delegate void InvalidateTexImage(uint texture, int level);
        public delegate void InvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);
        // Function IsBufferARB is alias for IsBuffer.
        public delegate bool IsFramebuffer(uint framebuffer);
        public delegate bool IsNamedString(int namelen, StringBuilder name);
        // Function IsProgramARB is alias for IsProgram.
        public delegate bool IsProgramPipeline(uint pipeline);
        // Function IsQueryARB is alias for IsQuery.
        public delegate bool IsRenderbuffer(uint renderbuffer);
        public delegate bool IsSampler(uint sampler);
        public delegate bool IsSync(IntPtr sync);
        public delegate bool IsTransformFeedback(uint id);
        public delegate bool IsVertexArray(uint array);
        // Function LinkProgramARB is alias for LinkProgram.
        // Function LoadTransposeMatrixdARB is alias for LoadTransposeMatrixd.
        // Function LoadTransposeMatrixfARB is alias for LoadTransposeMatrixf.
        // Function MapBufferARB is alias for MapBuffer.
        public delegate IntPtr MapBufferRange(int target, int offset, int length, int access);
        public delegate void MatrixIndexPointer(int size, int type, int stride, IntPtr pointer);
        public delegate void MatrixIndexubv(int size, byte[] indices);
        public delegate void MatrixIndexuiv(int size, uint[] indices);
        public delegate void MatrixIndexusv(int size, ushort[] indices);
        public delegate void MemoryBarrier(int barriers);
        // Function MinSampleShadingARB is alias for MinSampleShading.
        public delegate void MultiDrawArraysIndirect(int mode, IntPtr indirect, int drawcount, int stride);
        public delegate void MultiDrawElementsBaseVertex(int mode, int[] count, int type, IntPtr indices, int drawcount, int[] basevertex);
        public delegate void MultiDrawElementsIndirect(int mode, int type, IntPtr indirect, int drawcount, int stride);
        // Function MultiTexCoord1dARB is alias for MultiTexCoord1d.
        // Function MultiTexCoord1dvARB is alias for MultiTexCoord1dv.
        // Function MultiTexCoord1fARB is alias for MultiTexCoord1f.
        // Function MultiTexCoord1fvARB is alias for MultiTexCoord1fv.
        // Function MultiTexCoord1iARB is alias for MultiTexCoord1i.
        // Function MultiTexCoord1ivARB is alias for MultiTexCoord1iv.
        // Function MultiTexCoord1sARB is alias for MultiTexCoord1s.
        // Function MultiTexCoord1svARB is alias for MultiTexCoord1sv.
        // Function MultiTexCoord2dARB is alias for MultiTexCoord2d.
        // Function MultiTexCoord2dvARB is alias for MultiTexCoord2dv.
        // Function MultiTexCoord2fARB is alias for MultiTexCoord2f.
        // Function MultiTexCoord2fvARB is alias for MultiTexCoord2fv.
        // Function MultiTexCoord2iARB is alias for MultiTexCoord2i.
        // Function MultiTexCoord2ivARB is alias for MultiTexCoord2iv.
        // Function MultiTexCoord2sARB is alias for MultiTexCoord2s.
        // Function MultiTexCoord2svARB is alias for MultiTexCoord2sv.
        // Function MultiTexCoord3dARB is alias for MultiTexCoord3d.
        // Function MultiTexCoord3dvARB is alias for MultiTexCoord3dv.
        // Function MultiTexCoord3fARB is alias for MultiTexCoord3f.
        // Function MultiTexCoord3fvARB is alias for MultiTexCoord3fv.
        // Function MultiTexCoord3iARB is alias for MultiTexCoord3i.
        // Function MultiTexCoord3ivARB is alias for MultiTexCoord3iv.
        // Function MultiTexCoord3sARB is alias for MultiTexCoord3s.
        // Function MultiTexCoord3svARB is alias for MultiTexCoord3sv.
        // Function MultiTexCoord4dARB is alias for MultiTexCoord4d.
        // Function MultiTexCoord4dvARB is alias for MultiTexCoord4dv.
        // Function MultiTexCoord4fARB is alias for MultiTexCoord4f.
        // Function MultiTexCoord4fvARB is alias for MultiTexCoord4fv.
        // Function MultiTexCoord4iARB is alias for MultiTexCoord4i.
        // Function MultiTexCoord4ivARB is alias for MultiTexCoord4iv.
        // Function MultiTexCoord4sARB is alias for MultiTexCoord4s.
        // Function MultiTexCoord4svARB is alias for MultiTexCoord4sv.
        public delegate void MultiTexCoordP1ui(int texture, int type, uint coords);
        public delegate void MultiTexCoordP1uiv_uint(int texture, int type, ref uint coords);
        public delegate void MultiTexCoordP1uiv(int texture, int type, uint[] coords);
        public delegate void MultiTexCoordP2ui(int texture, int type, uint coords);
        public delegate void MultiTexCoordP2uiv(int texture, int type, uint[] coords);
        public delegate void MultiTexCoordP2uiv_uint(int texture, int type, ref uint coords);
        public delegate void MultiTexCoordP3ui(int texture, int type, uint coords);
        public delegate void MultiTexCoordP3uiv(int texture, int type, uint[] coords);
        public delegate void MultiTexCoordP3uiv_uint(int texture, int type, ref uint coords);
        public delegate void MultiTexCoordP4ui(int texture, int type, uint coords);
        public delegate void MultiTexCoordP4uiv(int texture, int type, uint[] coords);
        public delegate void MultiTexCoordP4uiv_uint(int texture, int type, ref uint coords);
        // Function MultTransposeMatrixdARB is alias for MultTransposeMatrixd.
        // Function MultTransposeMatrixfARB is alias for MultTransposeMatrixf.
        public delegate void NamedFramebufferParameteri(uint framebuffer, int pname, int param);
        public delegate void NamedString(int type, int namelen, StringBuilder name, int stringlen, StringBuilder str);
        public delegate void NormalP3ui(int type, uint coords);
        public delegate void NormalP3uiv_uint(int type, ref uint coords);
        public delegate void NormalP3uiv(int type, uint[] coords);
        public delegate void PatchParameterfv(int pname, float[] values);
        public delegate void PatchParameteri(int pname, int value);
        public delegate void PauseTransformFeedback();
        // Function PointParameterfARB is alias for PointParameterf.
        // Function PointParameterfvARB is alias for PointParameterfv.
        public delegate void ProgramBinary(uint program, int binaryFormat, IntPtr binary, int length);
        public delegate void ProgramEnvParameter4d(int target, uint index, double x, double y, double z, double w);
        public delegate void ProgramEnvParameter4dv(int target, uint index, double[] param);
        public delegate void ProgramEnvParameter4f(int target, uint index, float x, float y, float z, float w);
        public delegate void ProgramEnvParameter4fv(int target, uint index, float[] param);
        public delegate void ProgramLocalParameter4d(int target, uint index, double x, double y, double z, double w);
        public delegate void ProgramLocalParameter4dv(int target, uint index, double[] param);
        public delegate void ProgramLocalParameter4f(int target, uint index, float x, float y, float z, float w);
        public delegate void ProgramLocalParameter4fv(int target, uint index, float[] param);
        public delegate void ProgramParameteri(uint program, int pname, int value);
        // Function ProgramParameteriARB is alias for ProgramParameteri.
        public delegate void ProgramString(int target, int format, int len, IntPtr str);
        public delegate void ProgramUniform1d(uint program, int location, double v0);
        public delegate void ProgramUniform1dv_double(uint program, int location, int count, ref double value);
        public delegate void ProgramUniform1dv(uint program, int location, int count, double[] value);
        public delegate void ProgramUniform1f(uint program, int location, float v0);
        public delegate void ProgramUniform1fv_float(uint program, int location, int count, ref float value);
        public delegate void ProgramUniform1fv(uint program, int location, int count, float[] value);
        public delegate void ProgramUniform1i(uint program, int location, int v0);
        public delegate void ProgramUniform1iv_int(uint program, int location, int count, ref int value);
        public delegate void ProgramUniform1iv(uint program, int location, int count, int[] value);
        public delegate void ProgramUniform1ui(uint program, int location, uint v0);
        public delegate void ProgramUniform1uiv_uint(uint program, int location, int count, ref uint value);
        public delegate void ProgramUniform1uiv(uint program, int location, int count, uint[] value);
        public delegate void ProgramUniform2d(uint program, int location, double v0, double v1);
        public delegate void ProgramUniform2dv(uint program, int location, int count, double[] value);
        public delegate void ProgramUniform2f(uint program, int location, float v0, float v1);
        public delegate void ProgramUniform2fv(uint program, int location, int count, float[] value);
        public delegate void ProgramUniform2i(uint program, int location, int v0, int v1);
        public delegate void ProgramUniform2iv(uint program, int location, int count, int[] value);
        public delegate void ProgramUniform2ui(uint program, int location, uint v0, uint v1);
        public delegate void ProgramUniform2uiv(uint program, int location, int count, uint[] value);
        public delegate void ProgramUniform3d(uint program, int location, double v0, double v1, double v2);
        public delegate void ProgramUniform3dv(uint program, int location, int count, double[] value);
        public delegate void ProgramUniform3f(uint program, int location, float v0, float v1, float v2);
        public delegate void ProgramUniform3fv(uint program, int location, int count, float[] value);
        public delegate void ProgramUniform3i(uint program, int location, int v0, int v1, int v2);
        public delegate void ProgramUniform3iv(uint program, int location, int count, int[] value);
        public delegate void ProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2);
        public delegate void ProgramUniform3uiv(uint program, int location, int count, uint[] value);
        public delegate void ProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3);
        public delegate void ProgramUniform4dv(uint program, int location, int count, double[] value);
        public delegate void ProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3);
        public delegate void ProgramUniform4fv(uint program, int location, int count, float[] value);
        public delegate void ProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3);
        public delegate void ProgramUniform4iv(uint program, int location, int count, int[] value);
        public delegate void ProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3);
        public delegate void ProgramUniform4uiv(uint program, int location, int count, uint[] value);
        public delegate void ProgramUniformMatrix2dv(uint program, int location, int count, bool transpose, double[] value);
        public delegate void ProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float[] value);
        public delegate void ProgramUniformMatrix2x3dv(uint program, int location, int count, bool transpose, double[] value);
        public delegate void ProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float[] value);
        public delegate void ProgramUniformMatrix2x4dv(uint program, int location, int count, bool transpose, double[] value);
        public delegate void ProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float[] value);
        public delegate void ProgramUniformMatrix3dv(uint program, int location, int count, bool transpose, double[] value);
        public delegate void ProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float[] value);
        public delegate void ProgramUniformMatrix3x2dv(uint program, int location, int count, bool transpose, double[] value);
        public delegate void ProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float[] value);
        public delegate void ProgramUniformMatrix3x4dv(uint program, int location, int count, bool transpose, double[] value);
        public delegate void ProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float[] value);
        public delegate void ProgramUniformMatrix4dv(uint program, int location, int count, bool transpose, double[] value);
        public delegate void ProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float[] value);
        public delegate void ProgramUniformMatrix4x2dv(uint program, int location, int count, bool transpose, double[] value);
        public delegate void ProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float[] value);
        public delegate void ProgramUniformMatrix4x3dv(uint program, int location, int count, bool transpose, double[] value);
        public delegate void ProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float[] value);
        public delegate void ProvokingVertex(int mode);
        public delegate void QueryCounter(uint id, int target);
        public delegate void ReadnPixels(int x, int y, int width, int height, int format, int type, int bufSize, IntPtr data);
        public delegate void ReleaseShaderCompiler();
        public delegate void RenderbufferStorage(int target, int internalformat, int width, int height);
        public delegate void RenderbufferStorageMultisample(int target, int samples, int internalformat, int width, int height);
        public delegate void ResumeTransformFeedback();
        // Function SampleCoverageARB is alias for SampleCoverage.
        public delegate void SampleMaski(uint index, int mask);
        public delegate void SamplerParameterf(uint sampler, int pname, float param);
        public delegate void SamplerParameterfv(uint sampler, int pname, float[] param);
        public delegate void SamplerParameteri(uint sampler, int pname, int param);
        public delegate void SamplerParameterIiv(uint sampler, int pname, int[] param);
        public delegate void SamplerParameterIuiv(uint sampler, int pname, uint[] param);
        public delegate void SamplerParameteriv(uint sampler, int pname, int[] param);
        public delegate void ScissorArrayv(uint first, int count, int[] v);
        public delegate void ScissorIndexed(uint index, int left, int bottom, int width, int height);
        public delegate void ScissorIndexedv(uint index, int[] v);
        public delegate void SecondaryColorP3ui(int type, uint color);
        public delegate void SecondaryColorP3uiv(int type, uint[] color);
        public delegate void SecondaryColorP3uiv_uint(int type, ref uint color);
        public delegate void ShaderBinary(int count, uint[] shaders, int binaryformat, IntPtr binary, int length);
        // Function ShaderSourceARB is alias for ShaderSource.
        public delegate void ShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding);
        // Function TexBufferARB is alias for TexBuffer.
        public delegate void TexBufferRange(int target, int internalformat, uint buffer, int offset, int size);
        public delegate void TexCoordP1ui(int type, uint coords);
        public delegate void TexCoordP1uiv_uint(int type, ref uint coords);
        public delegate void TexCoordP1uiv(int type, uint[] coords);
        public delegate void TexCoordP2ui(int type, uint coords);
        public delegate void TexCoordP2uiv(int type, uint[] coords);
        public delegate void TexCoordP2uiv_uint(int type, ref uint coords);
        public delegate void TexCoordP3ui(int type, uint coords);
        public delegate void TexCoordP3uiv(int type, uint[] coords);
        public delegate void TexCoordP3uiv_uint(int type, ref uint coords);
        public delegate void TexCoordP4ui(int type, uint coords);
        public delegate void TexCoordP4uiv(int type, uint[] coords);
        public delegate void TexCoordP4uiv_uint(int type, ref uint coords);
        public delegate void TexImage2DMultisample(int target, int samples, int internalformat, int width, int height, bool fixedsamplelocations);
        public delegate void TexImage3DMultisample(int target, int samples, int internalformat, int width, int height, int depth, bool fixedsamplelocations);
        public delegate void TexStorage1D(int target, int levels, int internalformat, int width);
        public delegate void TexStorage2D(int target, int levels, int internalformat, int width, int height);
        public delegate void TexStorage2DMultisample(int target, int samples, int internalformat, int width, int height, bool fixedsamplelocations);
        public delegate void TexStorage3D(int target, int levels, int internalformat, int width, int height, int depth);
        public delegate void TexStorage3DMultisample(int target, int samples, int internalformat, int width, int height, int depth, bool fixedsamplelocations);
        public delegate void TextureBufferRange(uint texture, int target, int internalformat, uint buffer, int offset, int size);
        public delegate void TextureStorage1D(uint texture, int target, int levels, int internalformat, int width);
        public delegate void TextureStorage2D(uint texture, int target, int levels, int internalformat, int width, int height);
        public delegate void TextureStorage2DMultisample(uint texture, int target, int samples, int internalformat, int width, int height, bool fixedsamplelocations);
        public delegate void TextureStorage3D(uint texture, int target, int levels, int internalformat, int width, int height, int depth);
        public delegate void TextureStorage3DMultisample(uint texture, int target, int samples, int internalformat, int width, int height, int depth, bool fixedsamplelocations);
        public delegate void TextureView(uint texture, int target, uint origtexture, int internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
        public delegate void Uniform1d(int location, double x);
        public delegate void Uniform1dv(int location, int count, double[] value);
        // Function Uniform1fARB is alias for Uniform1f.
        // Function Uniform1fvARB is alias for Uniform1fv.
        // Function Uniform1iARB is alias for Uniform1i.
        // Function Uniform1ivARB is alias for Uniform1iv.
        public delegate void Uniform2d(int location, double x, double y);
        public delegate void Uniform2dv(int location, int count, double[] value);
        // Function Uniform2fARB is alias for Uniform2f.
        // Function Uniform2fvARB is alias for Uniform2fv.
        // Function Uniform2iARB is alias for Uniform2i.
        // Function Uniform2ivARB is alias for Uniform2iv.
        public delegate void Uniform3d(int location, double x, double y, double z);
        public delegate void Uniform3dv(int location, int count, double[] value);
        // Function Uniform3fARB is alias for Uniform3f.
        // Function Uniform3fvARB is alias for Uniform3fv.
        // Function Uniform3iARB is alias for Uniform3i.
        // Function Uniform3ivARB is alias for Uniform3iv.
        public delegate void Uniform4d(int location, double x, double y, double z, double w);
        public delegate void Uniform4dv(int location, int count, double[] value);
        // Function Uniform4fARB is alias for Uniform4f.
        // Function Uniform4fvARB is alias for Uniform4fv.
        // Function Uniform4iARB is alias for Uniform4i.
        // Function Uniform4ivARB is alias for Uniform4iv.
        public delegate void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);
        public delegate void UniformMatrix2dv(int location, int count, bool transpose, double[] value);
        // Function UniformMatrix2fvARB is alias for UniformMatrix2fv.
        public delegate void UniformMatrix2x3dv(int location, int count, bool transpose, double[] value);
        public delegate void UniformMatrix2x4dv(int location, int count, bool transpose, double[] value);
        public delegate void UniformMatrix3dv(int location, int count, bool transpose, double[] value);
        // Function UniformMatrix3fvARB is alias for UniformMatrix3fv.
        public delegate void UniformMatrix3x2dv(int location, int count, bool transpose, double[] value);
        public delegate void UniformMatrix3x4dv(int location, int count, bool transpose, double[] value);
        public delegate void UniformMatrix4dv(int location, int count, bool transpose, double[] value);
        // Function UniformMatrix4fvARB is alias for UniformMatrix4fv.
        public delegate void UniformMatrix4x2dv(int location, int count, bool transpose, double[] value);
        public delegate void UniformMatrix4x3dv(int location, int count, bool transpose, double[] value);
        public delegate void UniformSubroutinesuiv(int shadertype, int count, uint[] indices);
        // Function UnmapBufferARB is alias for UnmapBuffer.
        public delegate void UseProgramObject(uint programObj);
        public delegate void UseProgramStages(uint pipeline, int stages, uint program);
        // Function ValidateProgramARB is alias for ValidateProgram.
        public delegate void ValidateProgramPipeline(uint pipeline);
        public delegate void VertexArrayBindVertexBuffer(uint vaobj, uint bindingindex, uint buffer, int offset, int stride);
        public delegate void VertexArrayVertexAttribBinding(uint vaobj, uint attribindex, uint bindingindex);
        public delegate void VertexArrayVertexAttribFormat(uint vaobj, uint attribindex, int size, int type, bool normalized, uint relativeoffset);
        public delegate void VertexArrayVertexAttribIFormat(uint vaobj, uint attribindex, int size, int type, uint relativeoffset);
        public delegate void VertexArrayVertexAttribLFormat(uint vaobj, uint attribindex, int size, int type, uint relativeoffset);
        public delegate void VertexArrayVertexBindingDivisor(uint vaobj, uint bindingindex, uint divisor);
        // Function VertexAttrib1dARB is alias for VertexAttrib1d.
        // Function VertexAttrib1dvARB is alias for VertexAttrib1dv.
        // Function VertexAttrib1fARB is alias for VertexAttrib1f.
        // Function VertexAttrib1fvARB is alias for VertexAttrib1fv.
        // Function VertexAttrib1sARB is alias for VertexAttrib1s.
        // Function VertexAttrib1svARB is alias for VertexAttrib1sv.
        // Function VertexAttrib2dARB is alias for VertexAttrib2d.
        // Function VertexAttrib2dvARB is alias for VertexAttrib2dv.
        // Function VertexAttrib2fARB is alias for VertexAttrib2f.
        // Function VertexAttrib2fvARB is alias for VertexAttrib2fv.
        // Function VertexAttrib2sARB is alias for VertexAttrib2s.
        // Function VertexAttrib2svARB is alias for VertexAttrib2sv.
        // Function VertexAttrib3dARB is alias for VertexAttrib3d.
        // Function VertexAttrib3dvARB is alias for VertexAttrib3dv.
        // Function VertexAttrib3fARB is alias for VertexAttrib3f.
        // Function VertexAttrib3fvARB is alias for VertexAttrib3fv.
        // Function VertexAttrib3sARB is alias for VertexAttrib3s.
        // Function VertexAttrib3svARB is alias for VertexAttrib3sv.
        // Function VertexAttrib4bvARB is alias for VertexAttrib4bv.
        // Function VertexAttrib4dARB is alias for VertexAttrib4d.
        // Function VertexAttrib4dvARB is alias for VertexAttrib4dv.
        // Function VertexAttrib4fARB is alias for VertexAttrib4f.
        // Function VertexAttrib4fvARB is alias for VertexAttrib4fv.
        // Function VertexAttrib4ivARB is alias for VertexAttrib4iv.
        // Function VertexAttrib4NbvARB is alias for VertexAttrib4Nbv.
        // Function VertexAttrib4NivARB is alias for VertexAttrib4Niv.
        // Function VertexAttrib4NsvARB is alias for VertexAttrib4Nsv.
        // Function VertexAttrib4NubARB is alias for VertexAttrib4Nub.
        // Function VertexAttrib4NubvARB is alias for VertexAttrib4Nubv.
        // Function VertexAttrib4NuivARB is alias for VertexAttrib4Nuiv.
        // Function VertexAttrib4NusvARB is alias for VertexAttrib4Nusv.
        // Function VertexAttrib4sARB is alias for VertexAttrib4s.
        // Function VertexAttrib4svARB is alias for VertexAttrib4sv.
        // Function VertexAttrib4ubvARB is alias for VertexAttrib4ubv.
        // Function VertexAttrib4uivARB is alias for VertexAttrib4uiv.
        // Function VertexAttrib4usvARB is alias for VertexAttrib4usv.
        public delegate void VertexAttribBinding(uint attribindex, uint bindingindex);
        // Function VertexAttribDivisorARB is alias for VertexAttribDivisor.
        public delegate void VertexAttribFormat(uint attribindex, int size, int type, bool normalized, uint relativeoffset);
        public delegate void VertexAttribIFormat(uint attribindex, int size, int type, uint relativeoffset);
        public delegate void VertexAttribL1d(uint index, double x);
        public delegate void VertexAttribL1dv(uint index, double[] v);
        public delegate void VertexAttribL1dv_double(uint index, ref double v);
        public delegate void VertexAttribL2d(uint index, double x, double y);
        public delegate void VertexAttribL2dv(uint index, double[] v);
        public delegate void VertexAttribL3d(uint index, double x, double y, double z);
        public delegate void VertexAttribL3dv(uint index, double[] v);
        public delegate void VertexAttribL4d(uint index, double x, double y, double z, double w);
        public delegate void VertexAttribL4dv(uint index, double[] v);
        public delegate void VertexAttribLFormat(uint attribindex, int size, int type, uint relativeoffset);
        public delegate void VertexAttribLPointer(uint index, int size, int type, int stride, IntPtr pointer);
        public delegate void VertexAttribP1ui(uint index, int type, bool normalized, uint value);
        public delegate void VertexAttribP1uiv(uint index, int type, bool normalized, uint[] value);
        public delegate void VertexAttribP1uiv_uint(uint index, int type, bool normalized, ref uint value);
        public delegate void VertexAttribP2ui(uint index, int type, bool normalized, uint value);
        public delegate void VertexAttribP2uiv_uint(uint index, int type, bool normalized, ref uint value);
        public delegate void VertexAttribP2uiv(uint index, int type, bool normalized, uint[] value);
        public delegate void VertexAttribP3ui(uint index, int type, bool normalized, uint value);
        public delegate void VertexAttribP3uiv_uint(uint index, int type, bool normalized, ref uint value);
        public delegate void VertexAttribP3uiv(uint index, int type, bool normalized, uint[] value);
        public delegate void VertexAttribP4ui(uint index, int type, bool normalized, uint value);
        public delegate void VertexAttribP4uiv(uint index, int type, bool normalized, uint[] value);
        public delegate void VertexAttribP4uiv_uint(uint index, int type, bool normalized, ref uint value);
        // Function VertexAttribPointerARB is alias for VertexAttribPointer.
        public delegate void VertexBindingDivisor(uint bindingindex, uint divisor);
        public delegate void VertexBlend(int count);
        public delegate void VertexP2ui(int type, uint value);
        public delegate void VertexP2uiv(int type, uint[] value);
        public delegate void VertexP2uiv_uint(int type, ref uint value);
        public delegate void VertexP3ui(int type, uint value);
        public delegate void VertexP3uiv_uint(int type, ref uint value);
        public delegate void VertexP3uiv(int type, uint[] value);
        public delegate void VertexP4ui(int type, uint value);
        public delegate void VertexP4uiv_uint(int type, ref uint value);
        public delegate void VertexP4uiv(int type, uint[] value);
        public delegate void ViewportArrayv(uint first, int count, float[] v);
        public delegate void ViewportIndexedf(uint index, float x, float y, float w, float h);
        public delegate void ViewportIndexedfv(uint index, float[] v);
        public delegate void WaitSync(IntPtr sync, int flags, ulong timeout);
        public delegate void Weightbv(int size, byte[] weights);
        public delegate void Weightdv(int size, double[] weights);
        public delegate void Weightfv(int size, float[] weights);
        public delegate void Weightiv(int size, int[] weights);
        public delegate void WeightPointer(int size, int type, int stride, IntPtr pointer);
        public delegate void Weightsv(int size, short[] weights);
        public delegate void Weightubv(int size, byte[] weights);
        public delegate void Weightuiv(int size, uint[] weights);
        public delegate void Weightusv(int size, ushort[] weights);
        // Function WindowPos2dARB is alias for WindowPos2d.
        // Function WindowPos2dvARB is alias for WindowPos2dv.
        // Function WindowPos2fARB is alias for WindowPos2f.
        // Function WindowPos2fvARB is alias for WindowPos2fv.
        // Function WindowPos2iARB is alias for WindowPos2i.
        // Function WindowPos2ivARB is alias for WindowPos2iv.
        // Function WindowPos2sARB is alias for WindowPos2s.
        // Function WindowPos2svARB is alias for WindowPos2sv.
        // Function WindowPos3dARB is alias for WindowPos3d.
        // Function WindowPos3dvARB is alias for WindowPos3dv.
        // Function WindowPos3fARB is alias for WindowPos3f.
        // Function WindowPos3fvARB is alias for WindowPos3fv.
        // Function WindowPos3iARB is alias for WindowPos3i.
        // Function WindowPos3ivARB is alias for WindowPos3iv.
        // Function WindowPos3sARB is alias for WindowPos3s.
        // Function WindowPos3svARB is alias for WindowPos3sv.
        #endregion

        #region KHR
        public delegate void DebugMessageCallback(GLDEBUGPROC callback, IntPtr userParam);
        public delegate void DebugMessageControl(int source, int type, int severity, int count, uint[] ids, bool enabled);
        public delegate void DebugMessageInsert(int source, int type, uint id, int severity, int length, StringBuilder buf);
        public delegate uint GetDebugMessageLog(uint count, int bufsize, int[] sources, int[] types, uint[] ids, int[] severities, int[] lengths, StringBuilder messageLog);
        public delegate void GetObjectLabel(int identifier, uint name, int bufSize, int[] length, StringBuilder label);
        public delegate void GetObjectPtrLabel(IntPtr ptr, int bufSize, int[] length, StringBuilder label);
        public delegate void ObjectLabel(int identifier, uint name, int length, StringBuilder label);
        public delegate void ObjectPtrLabel(IntPtr ptr, int length, StringBuilder label);
        public delegate void PopDebugGroup();
        public delegate void PushDebugGroup(int source, uint id, int length, StringBuilder message);
        #endregion

        #region EXT
        public delegate void ActiveProgram(uint program);
        public delegate void ActiveStencilFace(int face);
        public delegate void ApplyTexture(int mode);
        // Function AreTexturesResidentEXT is alias for AreTexturesResident.
        // Function ArrayElementEXT is alias for ArrayElement.
        // Function BeginTransformFeedbackEXT is alias for BeginTransformFeedback.
        public delegate void BeginVertexShader();
        // Function BindBufferBaseEXT is alias for BindBufferBase.
        public delegate void BindBufferOffset(int target, uint index, uint buffer, int offset);
        // Function BindBufferRangeEXT is alias for BindBufferRange.
        // Function BindFragDataLocationEXT is alias for BindFragDataLocation.
        // Function BindFramebufferEXT is alias for BindFramebuffer.
        // Function BindImageTextureEXT is alias for BindImageTexture.
        public delegate uint BindLightParameter(int light, int value);
        public delegate uint BindMaterialParameter(int face, int value);
        public delegate void BindMultiTexture(int texunit, int target, uint texture);
        public delegate uint BindParameter(int value);
        // Function BindRenderbufferEXT is alias for BindRenderbuffer.
        public delegate uint BindTexGenParameter(int unit, int coord, int value);
        // Function BindTextureEXT is alias for BindTexture.
        public delegate uint BindTextureUnitParameter(int unit, int value);
        public delegate void BindVertexShader(uint id);
        public delegate void Binormal3b(byte bx, byte by, byte bz);
        public delegate void Binormal3bv(byte[] v);
        public delegate void Binormal3d(double bx, double by, double bz);
        public delegate void Binormal3dv(double[] v);
        public delegate void Binormal3f(float bx, float by, float bz);
        public delegate void Binormal3fv(float[] v);
        public delegate void Binormal3i(int bx, int by, int bz);
        public delegate void Binormal3iv(int[] v);
        public delegate void Binormal3s(short bx, short by, short bz);
        public delegate void Binormal3sv(short[] v);
        public delegate void BinormalPointer(int type, int stride, IntPtr pointer);
        // Function BlendColorEXT is alias for BlendColor.
        // Function BlendEquationEXT is alias for BlendEquation.
        // Function BlendEquationSeparateEXT is alias for BlendEquationSeparate.
        // Function BlendFuncSeparateEXT is alias for BlendFuncSeparate.
        // Function BlitFramebufferEXT is alias for BlitFramebuffer.
        // Function CheckFramebufferStatusEXT is alias for CheckFramebufferStatus.
        public delegate int CheckNamedFramebufferStatus(uint framebuffer, int target);
        public delegate void ClearColorIi(int red, int green, int blue, int alpha);
        public delegate void ClearColorIui(uint red, uint green, uint blue, uint alpha);
        public delegate void ClientAttribDefault(int mask);
        public delegate void ColorMaskIndexed(uint index, bool r, bool g, bool b, bool a);
        public delegate void ColorPointerEXT(int size, int type, int stride, int count, IntPtr pointer);
        // Function ColorSubTableEXT is alias for ColorSubTable.
        // Function ColorTableEXT is alias for ColorTable.
        public delegate void CompressedMultiTexImage1D(int texunit, int target, int level, int internalformat, int width, int border, int imageSize, IntPtr bits);
        public delegate void CompressedMultiTexImage2D(int texunit, int target, int level, int internalformat, int width, int height, int border, int imageSize, IntPtr bits);
        public delegate void CompressedMultiTexImage3D(int texunit, int target, int level, int internalformat, int width, int height, int depth, int border, int imageSize, IntPtr bits);
        public delegate void CompressedMultiTexSubImage1D(int texunit, int target, int level, int xoffset, int width, int format, int imageSize, IntPtr bits);
        public delegate void CompressedMultiTexSubImage2D(int texunit, int target, int level, int xoffset, int yoffset, int width, int height, int format, int imageSize, IntPtr bits);
        public delegate void CompressedMultiTexSubImage3D(int texunit, int target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int format, int imageSize, IntPtr bits);
        public delegate void CompressedTextureImage1D(uint texture, int target, int level, int internalformat, int width, int border, int imageSize, IntPtr bits);
        public delegate void CompressedTextureImage2D(uint texture, int target, int level, int internalformat, int width, int height, int border, int imageSize, IntPtr bits);
        public delegate void CompressedTextureImage3D(uint texture, int target, int level, int internalformat, int width, int height, int depth, int border, int imageSize, IntPtr bits);
        public delegate void CompressedTextureSubImage1D(uint texture, int target, int level, int xoffset, int width, int format, int imageSize, IntPtr bits);
        public delegate void CompressedTextureSubImage2D(uint texture, int target, int level, int xoffset, int yoffset, int width, int height, int format, int imageSize, IntPtr bits);
        public delegate void CompressedTextureSubImage3D(uint texture, int target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int format, int imageSize, IntPtr bits);
        // Function ConvolutionFilter1DEXT is alias for ConvolutionFilter1D.
        // Function ConvolutionFilter2DEXT is alias for ConvolutionFilter2D.
        // Function ConvolutionParameterfEXT is alias for ConvolutionParameterf.
        // Function ConvolutionParameterfvEXT is alias for ConvolutionParameterfv.
        // Function ConvolutionParameteriEXT is alias for ConvolutionParameteri.
        // Function ConvolutionParameterivEXT is alias for ConvolutionParameteriv.
        // Function CopyColorSubTableEXT is alias for CopyColorSubTable.
        // Function CopyConvolutionFilter1DEXT is alias for CopyConvolutionFilter1D.
        // Function CopyConvolutionFilter2DEXT is alias for CopyConvolutionFilter2D.
        public delegate void CopyMultiTexImage1D(int texunit, int target, int level, int internalformat, int x, int y, int width, int border);
        public delegate void CopyMultiTexImage2D(int texunit, int target, int level, int internalformat, int x, int y, int width, int height, int border);
        public delegate void CopyMultiTexSubImage1D(int texunit, int target, int level, int xoffset, int x, int y, int width);
        public delegate void CopyMultiTexSubImage2D(int texunit, int target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        public delegate void CopyMultiTexSubImage3D(int texunit, int target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
        // Function CopyTexImage1DEXT is alias for CopyTexImage1D.
        // Function CopyTexImage2DEXT is alias for CopyTexImage2D.
        // Function CopyTexSubImage1DEXT is alias for CopyTexSubImage1D.
        // Function CopyTexSubImage2DEXT is alias for CopyTexSubImage2D.
        // Function CopyTexSubImage3DEXT is alias for CopyTexSubImage3D.
        public delegate void CopyTextureImage1D(uint texture, int target, int level, int internalformat, int x, int y, int width, int border);
        public delegate void CopyTextureImage2D(uint texture, int target, int level, int internalformat, int x, int y, int width, int height, int border);
        public delegate void CopyTextureSubImage1D(uint texture, int target, int level, int xoffset, int x, int y, int width);
        public delegate void CopyTextureSubImage2D(uint texture, int target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        public delegate void CopyTextureSubImage3D(uint texture, int target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
        public delegate uint CreateShaderProgram(int type, StringBuilder str);
        public delegate void CullParameterdv(int pname, double[] param);
        public delegate void CullParameterfv(int pname, float[] param);
        // Function DeleteFramebuffersEXT is alias for DeleteFramebuffers.
        // Function DeleteRenderbuffersEXT is alias for DeleteRenderbuffers.
        // Function DeleteTexturesEXT is alias for DeleteTextures.
        public delegate void DeleteVertexShader(uint id);
        public delegate void DepthBounds(double zmin, double zmax);
        public delegate void DisableClientStateIndexed(int array, uint index);
        public delegate void DisableIndexed(int target, uint index);
        public delegate void DisableVariantClientState(uint id);
        // Function DrawArraysEXT is alias for DrawArrays.
        // Function DrawArraysInstancedEXT is alias for DrawArraysInstanced.
        // Function DrawElementsInstancedEXT is alias for DrawElementsInstanced.
        // Function DrawRangeElementsEXT is alias for DrawRangeElements.
        public delegate void EdgeFlagPointerEXT(int stride, int count, IntPtr pointer);
        public delegate void EnableClientStateIndexed(int array, uint index);
        public delegate void EnableIndexed(int target, uint index);
        public delegate void EnableVariantClientState(uint id);
        // Function EndTransformFeedbackEXT is alias for EndTransformFeedback.
        public delegate void EndVertexShader();
        public delegate void ExtractComponent(uint res, uint src, uint num);
        public delegate void FlushMappedNamedBufferRange(uint buffer, int offset, int length);
        // Function FogCoorddEXT is alias for FogCoordd.
        // Function FogCoorddvEXT is alias for FogCoorddv.
        // Function FogCoordfEXT is alias for FogCoordf.
        // Function FogCoordfvEXT is alias for FogCoordfv.
        // Function FogCoordPointerEXT is alias for FogCoordPointer.
        public delegate void FramebufferDrawBuffer(uint framebuffer, int mode);
        public delegate void FramebufferDrawBuffers(uint framebuffer, int n, int[] bufs);
        public delegate void FramebufferDrawBuffers_int(uint framebuffer, int n, ref int bufs);
        public delegate void FramebufferReadBuffer(uint framebuffer, int mode);
        // Function FramebufferRenderbufferEXT is alias for FramebufferRenderbuffer.
        // Function FramebufferTexture1DEXT is alias for FramebufferTexture1D.
        // Function FramebufferTexture2DEXT is alias for FramebufferTexture2D.
        // Function FramebufferTexture3DEXT is alias for FramebufferTexture3D.
        // Function GenerateMipmapEXT is alias for GenerateMipmap.
        public delegate void GenerateMultiTexMipmap(int texunit, int target);
        public delegate void GenerateTextureMipmap(uint texture, int target);
        // Function GenFramebuffersEXT is alias for GenFramebuffers.
        // Function GenRenderbuffersEXT is alias for GenRenderbuffers.
        public delegate uint GenSymbols(int datatype, int storagetype, int range, uint components);
        // Function GenTexturesEXT is alias for GenTextures.
        public delegate uint GenVertexShaders(uint range);
        public delegate void GetBooleanIndexedv(int target, uint index, bool[] data);
        // Function GetColorTableEXT is alias for GetColorTable.
        // Function GetColorTableParameterfvEXT is alias for GetColorTableParameterfv.
        // Function GetColorTableParameterivEXT is alias for GetColorTableParameteriv.
        public delegate void GetCompressedMultiTexImage(int texunit, int target, int lod, IntPtr img);
        public delegate void GetCompressedTextureImage(uint texture, int target, int lod, IntPtr img);
        // Function GetConvolutionFilterEXT is alias for GetConvolutionFilter.
        // Function GetConvolutionParameterfvEXT is alias for GetConvolutionParameterfv.
        // Function GetConvolutionParameterivEXT is alias for GetConvolutionParameteriv.
        public delegate void GetDoubleIndexedv(int target, uint index, double[] data);
        public delegate void GetFloatIndexedv(int target, uint index, float[] data);
        // Function GetFragDataLocationEXT is alias for GetFragDataLocation.
        // Function GetFramebufferAttachmentParameterivEXT is alias for GetFramebufferAttachmentParameteriv.
        public delegate void GetFramebufferParameterivEXT(uint framebuffer, int pname, int[] param);
        // Function GetHistogramEXT is alias for GetHistogram.
        // Function GetHistogramParameterfvEXT is alias for GetHistogramParameterfv.
        // Function GetHistogramParameterivEXT is alias for GetHistogramParameteriv.
        public delegate void GetIntegerIndexedv(int target, uint index, int[] data);
        public delegate void GetInvariantBooleanv(uint id, int value, bool[] data);
        public delegate void GetInvariantFloatv(uint id, int value, float[] data);
        public delegate void GetInvariantIntegerv(uint id, int value, int[] data);
        public delegate void GetLocalConstantBooleanv(uint id, int value, bool[] data);
        public delegate void GetLocalConstantFloatv(uint id, int value, float[] data);
        public delegate void GetLocalConstantIntegerv(uint id, int value, int[] data);
        // Function GetMinmaxEXT is alias for GetMinmax.
        // Function GetMinmaxParameterfvEXT is alias for GetMinmaxParameterfv.
        // Function GetMinmaxParameterivEXT is alias for GetMinmaxParameteriv.
        public delegate void GetMultiTexEnvfv(int texunit, int target, int pname, float[] param);
        public delegate void GetMultiTexEnviv(int texunit, int target, int pname, int[] param);
        public delegate void GetMultiTexGendv(int texunit, int coord, int pname, double[] param);
        public delegate void GetMultiTexGenfv(int texunit, int coord, int pname, float[] param);
        public delegate void GetMultiTexGeniv(int texunit, int coord, int pname, int[] param);
        public delegate void GetMultiTexImage(int texunit, int target, int level, int format, int type, IntPtr pixels);
        public delegate void GetMultiTexLevelParameterfv(int texunit, int target, int level, int pname, float[] param);
        public delegate void GetMultiTexLevelParameteriv(int texunit, int target, int level, int pname, int[] param);
        public delegate void GetMultiTexParameterfv(int texunit, int target, int pname, float[] param);
        public delegate void GetMultiTexParameterIiv(int texunit, int target, int pname, int[] param);
        public delegate void GetMultiTexParameterIuiv(int texunit, int target, int pname, uint[] param);
        public delegate void GetMultiTexParameteriv(int texunit, int target, int pname, int[] param);
        public delegate void GetNamedBufferParameteriv(uint buffer, int pname, int[] param);
        public delegate void GetNamedBufferPointerv(uint buffer, int pname, IntPtr[] param);
        public delegate void GetNamedBufferSubData(uint buffer, int offset, int size, IntPtr data);
        public delegate void GetNamedFramebufferAttachmentParameteriv(uint framebuffer, int attachment, int pname, int[] param);
        public delegate void GetNamedProgramiv_int(uint program, int target, int pname, out int param);
        public delegate void GetNamedProgramiv(uint program, int target, int pname, int[] param);
        public delegate void GetNamedProgramLocalParameterdv(uint program, int target, uint index, double[] param);
        public delegate void GetNamedProgramLocalParameterfv(uint program, int target, uint index, float[] param);
        public delegate void GetNamedProgramLocalParameterIiv(uint program, int target, uint index, int[] param);
        public delegate void GetNamedProgramLocalParameterIuiv(uint program, int target, uint index, uint[] param);
        public delegate void GetNamedProgramString(uint program, int target, int pname, IntPtr str);
        public delegate void GetNamedRenderbufferParameteriv(uint renderbuffer, int pname, int[] param);
        public delegate void GetPointerIndexedv(int target, uint index, IntPtr[] data);
        // Function GetPointervEXT is alias for GetPointerv.
        // Function GetQueryObjecti64vEXT is alias for GetQueryObjecti64v.
        // Function GetQueryObjectui64vEXT is alias for GetQueryObjectui64v.
        // Function GetRenderbufferParameterivEXT is alias for GetRenderbufferParameteriv.
        // Function GetSeparableFilterEXT is alias for GetSeparableFilter.
        // Function GetTexParameterIivEXT is alias for GetTexParameterIiv.
        // Function GetTexParameterIuivEXT is alias for GetTexParameterIuiv.
        public delegate void GetTextureImage(uint texture, int target, int level, int format, int type, IntPtr pixels);
        public delegate void GetTextureLevelParameterfv(uint texture, int target, int level, int pname, float[] param);
        public delegate void GetTextureLevelParameteriv(uint texture, int target, int level, int pname, int[] param);
        public delegate void GetTextureParameterfv(uint texture, int target, int pname, float[] param);
        public delegate void GetTextureParameterIiv(uint texture, int target, int pname, int[] param);
        public delegate void GetTextureParameterIuiv(uint texture, int target, int pname, uint[] param);
        public delegate void GetTextureParameteriv(uint texture, int target, int pname, int[] param);
        // Function GetTransformFeedbackVaryingEXT is alias for GetTransformFeedbackVarying.
        public delegate int GetUniformBufferSize(uint program, int location);
        public delegate int GetUniformOffset(uint program, int location);
        // Function GetUniformuivEXT is alias for GetUniformuiv.
        public delegate void GetVariantBooleanv(uint id, int value, bool[] data);
        public delegate void GetVariantFloatv(uint id, int value, float[] data);
        public delegate void GetVariantIntegerv(uint id, int value, int[] data);
        public delegate void GetVariantPointerv(uint id, int value, IntPtr[] data);
        // Function GetVertexAttribLdvEXT is alias for GetVertexAttribLdv.
        // Function HistogramEXT is alias for Histogram.
        public delegate IntPtr ImportSync(int external_sync_type, int external_sync, int flags);
        public delegate void IndexFunc(int func, float reference);
        public delegate void IndexMaterial(int face, int mode);
        public delegate void IndexPointerEXT(int type, int stride, int count, IntPtr pointer);
        public delegate void InsertComponent(uint res, uint src, uint num);
        public delegate bool IsEnabledIndexed(int target, uint index);
        // Function IsFramebufferEXT is alias for IsFramebuffer.
        // Function IsRenderbufferEXT is alias for IsRenderbuffer.
        // Function IsTextureEXT is alias for IsTexture.
        public delegate bool IsVariantEnabled(uint id, int cap);
        public delegate void LockArrays(int first, int count);
        public delegate IntPtr MapNamedBuffer(uint buffer, int access);
        public delegate IntPtr MapNamedBufferRange(uint buffer, int offset, int length, int access);
        public delegate void MatrixFrustum(int mode, double left, double right, double bottom, double top, double zNear, double zFar);
        public delegate void MatrixLoadd(int mode, double[] m);
        public delegate void MatrixLoadf(int mode, float[] m);
        public delegate void MatrixLoadIdentity(int mode);
        public delegate void MatrixLoadTransposed(int mode, double[] m);
        public delegate void MatrixLoadTransposef(int mode, float[] m);
        public delegate void MatrixMultd(int mode, double[] m);
        public delegate void MatrixMultf(int mode, float[] m);
        public delegate void MatrixMultTransposed(int mode, double[] m);
        public delegate void MatrixMultTransposef(int mode, float[] m);
        public delegate void MatrixOrtho(int mode, double left, double right, double bottom, double top, double zNear, double zFar);
        public delegate void MatrixPop(int mode);
        public delegate void MatrixPush(int mode);
        public delegate void MatrixRotated(int mode, double angle, double x, double y, double z);
        public delegate void MatrixRotatef(int mode, float angle, float x, float y, float z);
        public delegate void MatrixScaled(int mode, double x, double y, double z);
        public delegate void MatrixScalef(int mode, float x, float y, float z);
        public delegate void MatrixTranslated(int mode, double x, double y, double z);
        public delegate void MatrixTranslatef(int mode, float x, float y, float z);
        // Function MemoryBarrierEXT is alias for MemoryBarrier.
        // Function MinmaxEXT is alias for Minmax.
        // Function MultiDrawArraysEXT is alias for MultiDrawArrays.
        public delegate void MultiDrawElementsEXT(int mode, int[] count, int type, IntPtr[] indices, int primcount);
        public delegate void MultiTexBuffer(int texunit, int target, int internalformat, uint buffer);
        public delegate void MultiTexCoordPointer(int texunit, int size, int type, int stride, IntPtr pointer);
        public delegate void MultiTexEnvf(int texunit, int target, int pname, float param);
        public delegate void MultiTexEnvfv(int texunit, int target, int pname, float[] param);
        public delegate void MultiTexEnvi(int texunit, int target, int pname, int param);
        public delegate void MultiTexEnviv(int texunit, int target, int pname, int[] param);
        public delegate void MultiTexGend(int texunit, int coord, int pname, double param);
        public delegate void MultiTexGendv(int texunit, int coord, int pname, double[] param);
        public delegate void MultiTexGenf(int texunit, int coord, int pname, float param);
        public delegate void MultiTexGenfv(int texunit, int coord, int pname, float[] param);
        public delegate void MultiTexGeni(int texunit, int coord, int pname, int param);
        public delegate void MultiTexGeniv(int texunit, int coord, int pname, int[] param);
        public delegate void MultiTexImage1D(int texunit, int target, int level, int internalformat, int width, int border, int format, int type, IntPtr pixels);
        public delegate void MultiTexImage2D(int texunit, int target, int level, int internalformat, int width, int height, int border, int format, int type, IntPtr pixels);
        public delegate void MultiTexImage3D(int texunit, int target, int level, int internalformat, int width, int height, int depth, int border, int format, int type, IntPtr pixels);
        public delegate void MultiTexParameterf(int texunit, int target, int pname, float param);
        public delegate void MultiTexParameterfv(int texunit, int target, int pname, float[] param);
        public delegate void MultiTexParameteri(int texunit, int target, int pname, int param);
        public delegate void MultiTexParameterIiv(int texunit, int target, int pname, int[] param);
        public delegate void MultiTexParameterIuiv(int texunit, int target, int pname, uint[] param);
        public delegate void MultiTexParameteriv(int texunit, int target, int pname, int[] param);
        public delegate void MultiTexRenderbuffer(int texunit, int target, uint renderbuffer);
        public delegate void MultiTexSubImage1D(int texunit, int target, int level, int xoffset, int width, int format, int type, IntPtr pixels);
        public delegate void MultiTexSubImage2D(int texunit, int target, int level, int xoffset, int yoffset, int width, int height, int format, int type, IntPtr pixels);
        public delegate void MultiTexSubImage3D(int texunit, int target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int format, int type, IntPtr pixels);
        public delegate void NamedBufferData(uint buffer, int size, IntPtr data, int usage);
        public delegate void NamedBufferSubData(uint buffer, int offset, int size, IntPtr data);
        public delegate void NamedCopyBufferSubData(uint readBuffer, uint writeBuffer, int readOffset, int writeOffset, int size);
        public delegate void NamedFramebufferRenderbuffer(uint framebuffer, int attachment, int renderbuffertarget, uint renderbuffer);
        public delegate void NamedFramebufferTexture(uint framebuffer, int attachment, uint texture, int level);
        public delegate void NamedFramebufferTexture1D(uint framebuffer, int attachment, int textarget, uint texture, int level);
        public delegate void NamedFramebufferTexture2D(uint framebuffer, int attachment, int textarget, uint texture, int level);
        public delegate void NamedFramebufferTexture3D(uint framebuffer, int attachment, int textarget, uint texture, int level, int zoffset);
        public delegate void NamedFramebufferTextureFace(uint framebuffer, int attachment, uint texture, int level, int face);
        public delegate void NamedFramebufferTextureLayer(uint framebuffer, int attachment, uint texture, int level, int layer);
        public delegate void NamedProgramLocalParameter4d(uint program, int target, uint index, double x, double y, double z, double w);
        public delegate void NamedProgramLocalParameter4dv(uint program, int target, uint index, double[] param);
        public delegate void NamedProgramLocalParameter4f(uint program, int target, uint index, float x, float y, float z, float w);
        public delegate void NamedProgramLocalParameter4fv(uint program, int target, uint index, float[] param);
        public delegate void NamedProgramLocalParameterI4i(uint program, int target, uint index, int x, int y, int z, int w);
        public delegate void NamedProgramLocalParameterI4iv(uint program, int target, uint index, int[] param);
        public delegate void NamedProgramLocalParameterI4ui(uint program, int target, uint index, uint x, uint y, uint z, uint w);
        public delegate void NamedProgramLocalParameterI4uiv(uint program, int target, uint index, uint[] param);
        public delegate void NamedProgramLocalParameters4fv(uint program, int target, uint index, int count, float[] param);
        public delegate void NamedProgramLocalParametersI4iv(uint program, int target, uint index, int count, int[] param);
        public delegate void NamedProgramLocalParametersI4uiv(uint program, int target, uint index, int count, uint[] param);
        public delegate void NamedProgramString(uint program, int target, int format, int len, IntPtr str);
        public delegate void NamedRenderbufferStorage(uint renderbuffer, int internalformat, int width, int height);
        public delegate void NamedRenderbufferStorageMultisample(uint renderbuffer, int samples, int internalformat, int width, int height);
        public delegate void NamedRenderbufferStorageMultisampleCoverage(uint renderbuffer, int coverageSamples, int colorSamples, int internalformat, int width, int height);
        public delegate void NormalPointerEXT(int type, int stride, int count, IntPtr pointer);
        public delegate void PixelTransformParameterf(int target, int pname, float param);
        public delegate void PixelTransformParameterfv(int target, int pname, float[] param);
        public delegate void PixelTransformParameterfv_float(int target, int pname, ref float param);
        public delegate void PixelTransformParameteri(int target, int pname, int param);
        public delegate void PixelTransformParameteriv(int target, int pname, int[] param);
        public delegate void PixelTransformParameteriv_int(int target, int pname, ref int param);
        // Function PointParameterfEXT is alias for PointParameterf.
        // Function PointParameterfvEXT is alias for PointParameterfv.
        // Function PolygonOffsetEXT is alias for PolygonOffset.
        // Function PrioritizeTexturesEXT is alias for PrioritizeTextures.
        public delegate void ProgramEnvParameters4fv(int target, uint index, int count, float[] param);
        public delegate void ProgramLocalParameters4fv(int target, uint index, int count, float[] param);
        // Function ProgramParameteriEXT is alias for ProgramParameteri.
        // Function ProgramUniform1dEXT is alias for ProgramUniform1d.
        // Function ProgramUniform1dvEXT is alias for ProgramUniform1dv.
        // Function ProgramUniform1fEXT is alias for ProgramUniform1f.
        // Function ProgramUniform1fvEXT is alias for ProgramUniform1fv.
        // Function ProgramUniform1iEXT is alias for ProgramUniform1i.
        // Function ProgramUniform1ivEXT is alias for ProgramUniform1iv.
        // Function ProgramUniform1uiEXT is alias for ProgramUniform1ui.
        // Function ProgramUniform1uivEXT is alias for ProgramUniform1uiv.
        // Function ProgramUniform2dEXT is alias for ProgramUniform2d.
        // Function ProgramUniform2dvEXT is alias for ProgramUniform2dv.
        // Function ProgramUniform2fEXT is alias for ProgramUniform2f.
        // Function ProgramUniform2fvEXT is alias for ProgramUniform2fv.
        // Function ProgramUniform2iEXT is alias for ProgramUniform2i.
        // Function ProgramUniform2ivEXT is alias for ProgramUniform2iv.
        // Function ProgramUniform2uiEXT is alias for ProgramUniform2ui.
        // Function ProgramUniform2uivEXT is alias for ProgramUniform2uiv.
        // Function ProgramUniform3dEXT is alias for ProgramUniform3d.
        // Function ProgramUniform3dvEXT is alias for ProgramUniform3dv.
        // Function ProgramUniform3fEXT is alias for ProgramUniform3f.
        // Function ProgramUniform3fvEXT is alias for ProgramUniform3fv.
        // Function ProgramUniform3iEXT is alias for ProgramUniform3i.
        // Function ProgramUniform3ivEXT is alias for ProgramUniform3iv.
        // Function ProgramUniform3uiEXT is alias for ProgramUniform3ui.
        // Function ProgramUniform3uivEXT is alias for ProgramUniform3uiv.
        // Function ProgramUniform4dEXT is alias for ProgramUniform4d.
        // Function ProgramUniform4dvEXT is alias for ProgramUniform4dv.
        // Function ProgramUniform4fEXT is alias for ProgramUniform4f.
        // Function ProgramUniform4fvEXT is alias for ProgramUniform4fv.
        // Function ProgramUniform4iEXT is alias for ProgramUniform4i.
        // Function ProgramUniform4ivEXT is alias for ProgramUniform4iv.
        // Function ProgramUniform4uiEXT is alias for ProgramUniform4ui.
        // Function ProgramUniform4uivEXT is alias for ProgramUniform4uiv.
        // Function ProgramUniformMatrix2dvEXT is alias for ProgramUniformMatrix2dv.
        // Function ProgramUniformMatrix2fvEXT is alias for ProgramUniformMatrix2fv.
        // Function ProgramUniformMatrix2x3dvEXT is alias for ProgramUniformMatrix2x3dv.
        // Function ProgramUniformMatrix2x3fvEXT is alias for ProgramUniformMatrix2x3fv.
        // Function ProgramUniformMatrix2x4dvEXT is alias for ProgramUniformMatrix2x4dv.
        // Function ProgramUniformMatrix2x4fvEXT is alias for ProgramUniformMatrix2x4fv.
        // Function ProgramUniformMatrix3dvEXT is alias for ProgramUniformMatrix3dv.
        // Function ProgramUniformMatrix3fvEXT is alias for ProgramUniformMatrix3fv.
        // Function ProgramUniformMatrix3x2dvEXT is alias for ProgramUniformMatrix3x2dv.
        // Function ProgramUniformMatrix3x2fvEXT is alias for ProgramUniformMatrix3x2fv.
        // Function ProgramUniformMatrix3x4dvEXT is alias for ProgramUniformMatrix3x4dv.
        // Function ProgramUniformMatrix3x4fvEXT is alias for ProgramUniformMatrix3x4fv.
        // Function ProgramUniformMatrix4dvEXT is alias for ProgramUniformMatrix4dv.
        // Function ProgramUniformMatrix4fvEXT is alias for ProgramUniformMatrix4fv.
        // Function ProgramUniformMatrix4x2dvEXT is alias for ProgramUniformMatrix4x2dv.
        // Function ProgramUniformMatrix4x2fvEXT is alias for ProgramUniformMatrix4x2fv.
        // Function ProgramUniformMatrix4x3dvEXT is alias for ProgramUniformMatrix4x3dv.
        // Function ProgramUniformMatrix4x3fvEXT is alias for ProgramUniformMatrix4x3fv.
        // Function ProvokingVertexEXT is alias for ProvokingVertex.
        public delegate void PushClientAttribDefault(int mask);
        // Function RenderbufferStorageEXT is alias for RenderbufferStorage.
        // Function RenderbufferStorageMultisampleEXT is alias for RenderbufferStorageMultisample.
        // Function ResetHistogramEXT is alias for ResetHistogram.
        // Function ResetMinmaxEXT is alias for ResetMinmax.
        public delegate void SampleMask(float value, bool invert);
        public delegate void SamplePattern(int pattern);
        // Function SecondaryColor3bEXT is alias for SecondaryColor3b.
        // Function SecondaryColor3bvEXT is alias for SecondaryColor3bv.
        // Function SecondaryColor3dEXT is alias for SecondaryColor3d.
        // Function SecondaryColor3dvEXT is alias for SecondaryColor3dv.
        // Function SecondaryColor3fEXT is alias for SecondaryColor3f.
        // Function SecondaryColor3fvEXT is alias for SecondaryColor3fv.
        // Function SecondaryColor3iEXT is alias for SecondaryColor3i.
        // Function SecondaryColor3ivEXT is alias for SecondaryColor3iv.
        // Function SecondaryColor3sEXT is alias for SecondaryColor3s.
        // Function SecondaryColor3svEXT is alias for SecondaryColor3sv.
        // Function SecondaryColor3ubEXT is alias for SecondaryColor3ub.
        // Function SecondaryColor3ubvEXT is alias for SecondaryColor3ubv.
        // Function SecondaryColor3uiEXT is alias for SecondaryColor3ui.
        // Function SecondaryColor3uivEXT is alias for SecondaryColor3uiv.
        // Function SecondaryColor3usEXT is alias for SecondaryColor3us.
        // Function SecondaryColor3usvEXT is alias for SecondaryColor3usv.
        // Function SecondaryColorPointerEXT is alias for SecondaryColorPointer.
        // Function SeparableFilter2DEXT is alias for SeparableFilter2D.
        public delegate void SetInvariant(uint id, int type, IntPtr addr);
        public delegate void SetLocalConstant(uint id, int type, IntPtr addr);
        public delegate void ShaderOp1(int op, uint res, uint arg1);
        public delegate void ShaderOp2(int op, uint res, uint arg1, uint arg2);
        public delegate void ShaderOp3(int op, uint res, uint arg1, uint arg2, uint arg3);
        public delegate void StencilClearTag(int stencilTagBits, uint stencilClearTag);
        public delegate void Swizzle(uint res, uint input, int outX, int outY, int outZ, int outW);
        public delegate void Tangent3b(byte tx, byte ty, byte tz);
        public delegate void Tangent3bv(byte[] v);
        public delegate void Tangent3d(double tx, double ty, double tz);
        public delegate void Tangent3dv(double[] v);
        public delegate void Tangent3f(float tx, float ty, float tz);
        public delegate void Tangent3fv(float[] v);
        public delegate void Tangent3i(int tx, int ty, int tz);
        public delegate void Tangent3iv(int[] v);
        public delegate void Tangent3s(short tx, short ty, short tz);
        public delegate void Tangent3sv(short[] v);
        public delegate void TangentPointer(int type, int stride, IntPtr pointer);
        // Function TexBufferEXT is alias for TexBuffer.
        public delegate void TexCoordPointerEXT(int size, int type, int stride, int count, IntPtr pointer);
        // Function TexImage3DEXT is alias for TexImage3D.
        // Function TexParameterIivEXT is alias for TexParameterIiv.
        // Function TexParameterIuivEXT is alias for TexParameterIuiv.
        // Function TexSubImage1DEXT is alias for TexSubImage1D.
        // Function TexSubImage2DEXT is alias for TexSubImage2D.
        // Function TexSubImage3DEXT is alias for TexSubImage3D.
        public delegate void TextureBuffer(uint texture, int target, int internalformat, uint buffer);
        public delegate void TextureImage1D(uint texture, int target, int level, int internalformat, int width, int border, int format, int type, IntPtr pixels);
        public delegate void TextureImage2D(uint texture, int target, int level, int internalformat, int width, int height, int border, int format, int type, IntPtr pixels);
        public delegate void TextureImage3D(uint texture, int target, int level, int internalformat, int width, int height, int depth, int border, int format, int type, IntPtr pixels);
        public delegate void TextureLight(int pname);
        public delegate void TextureMaterial(int face, int mode);
        public delegate void TextureNormal(int mode);
        public delegate void TextureParameterf(uint texture, int target, int pname, float param);
        public delegate void TextureParameterfv(uint texture, int target, int pname, float[] param);
        public delegate void TextureParameteri(uint texture, int target, int pname, int param);
        public delegate void TextureParameterIiv(uint texture, int target, int pname, int[] param);
        public delegate void TextureParameterIuiv(uint texture, int target, int pname, uint[] param);
        public delegate void TextureParameteriv(uint texture, int target, int pname, int[] param);
        public delegate void TextureRenderbuffer(uint texture, int target, uint renderbuffer);
        public delegate void TextureSubImage1D(uint texture, int target, int level, int xoffset, int width, int format, int type, IntPtr pixels);
        public delegate void TextureSubImage2D(uint texture, int target, int level, int xoffset, int yoffset, int width, int height, int format, int type, IntPtr pixels);
        public delegate void TextureSubImage3D(uint texture, int target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int format, int type, IntPtr pixels);
        // Function TransformFeedbackVaryingsEXT is alias for TransformFeedbackVaryings.
        // Function Uniform1uiEXT is alias for Uniform1ui.
        // Function Uniform1uivEXT is alias for Uniform1uiv.
        // Function Uniform2uiEXT is alias for Uniform2ui.
        // Function Uniform2uivEXT is alias for Uniform2uiv.
        // Function Uniform3uiEXT is alias for Uniform3ui.
        // Function Uniform3uivEXT is alias for Uniform3uiv.
        // Function Uniform4uiEXT is alias for Uniform4ui.
        // Function Uniform4uivEXT is alias for Uniform4uiv.
        public delegate void UniformBuffer(uint program, int location, uint buffer);
        public delegate void UnlockArrays();
        public delegate bool UnmapNamedBuffer(uint buffer);
        public delegate void UseShaderProgram(int type, uint program);
        public delegate void Variantbv(uint id, byte[] addr);
        public delegate void Variantdv(uint id, double[] addr);
        public delegate void Variantfv(uint id, float[] addr);
        public delegate void Variantiv(uint id, int[] addr);
        public delegate void VariantPointer(uint id, int type, uint stride, IntPtr addr);
        public delegate void Variantsv(uint id, short[] addr);
        public delegate void Variantubv(uint id, byte[] addr);
        public delegate void Variantuiv(uint id, uint[] addr);
        public delegate void Variantusv(uint id, ushort[] addr);
        public delegate void VertexArrayVertexAttribLOffset(uint vaobj, uint buffer, uint index, int size, int type, int stride, int offset);
        // Function VertexAttribL1dEXT is alias for VertexAttribL1d.
        // Function VertexAttribL1dvEXT is alias for VertexAttribL1dv.
        // Function VertexAttribL2dEXT is alias for VertexAttribL2d.
        // Function VertexAttribL2dvEXT is alias for VertexAttribL2dv.
        // Function VertexAttribL3dEXT is alias for VertexAttribL3d.
        // Function VertexAttribL3dvEXT is alias for VertexAttribL3dv.
        // Function VertexAttribL4dEXT is alias for VertexAttribL4d.
        // Function VertexAttribL4dvEXT is alias for VertexAttribL4dv.
        // Function VertexAttribLPointerEXT is alias for VertexAttribLPointer.
        public delegate void VertexPointerEXT(int size, int type, int stride, int count, IntPtr pointer);
        public delegate void VertexWeightf(float weight);
        public delegate void VertexWeightfv(float[] weight);
        public delegate void VertexWeightfv_float(ref float weight);
        public delegate void VertexWeightPointer(int size, int type, int stride, IntPtr pointer);
        public delegate void WriteMask(uint res, uint input, int outX, int outY, int outZ, int outW);
        #endregion

        #region SGIS
        public delegate void DetailTexFunc(int target, int n, float[] points);
        public delegate void FogFunc(int n, float[] points);
        public delegate void GetDetailTexFunc(int target, float[] points);
        public delegate void GetFogFunc(float[] points);
        public delegate void GetPixelTexGenParameterfv(int pname, float[] param);
        public delegate void GetPixelTexGenParameteriv(int pname, int[] param);
        public delegate void GetSharpenTexFunc(int target, float[] points);
        public delegate void GetTexFilterFunc(int target, int filter, float[] weights);
        public delegate void PixelTexGenParameterf(int pname, float param);
        public delegate void PixelTexGenParameterfv(int pname, float[] param);
        public delegate void PixelTexGenParameteri(int pname, int param);
        public delegate void PixelTexGenParameteriv(int pname, int[] param);
        // Function PointParameterfSGIS is alias for PointParameterf.
        // Function PointParameterfvSGIS is alias for PointParameterfv.
        // Function SampleMaskSGIS is alias for SampleMaskEXT.
        // Function SamplePatternSGIS is alias for SamplePatternEXT.
        public delegate void SharpenTexFunc(int target, int n, float[] points);
        public delegate void TexFilterFunc(int target, int filter, int n, float[] weights);
        public delegate void TexFilterFunc_float(int target, int filter, int n, ref float weights);
        public delegate void TexImage4D(int target, int level, int internalformat, int width, int height, int depth, int size4d, int border, int format, int type, IntPtr pixels);
        public delegate void TexSubImage4D(int target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, int format, int type, IntPtr pixels);
        public delegate void TextureColorMask(bool red, bool green, bool blue, bool alpha);
        #endregion

        #region SGI
        // Function ColorTableSGI is alias for ColorTable.
        // Function ColorTableParameterfvSGI is alias for ColorTableParameterfv.
        // Function ColorTableParameterivSGI is alias for ColorTableParameteriv.
        // Function CopyColorTableSGI is alias for CopyColorTable.
        // Function GetColorTableSGI is alias for GetColorTable.
        // Function GetColorTableParameterfvSGI is alias for GetColorTableParameterfv.
        // Function GetColorTableParameterivSGI is alias for GetColorTableParameteriv.
        #endregion

        #region SGIX
        public delegate void AsyncMarker(uint marker);
        public delegate void Deform(int mask);
        public delegate void DeformationMap3d(int target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double[] points);
        public delegate void DeformationMap3f(int target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float[] points);
        public delegate void DeleteAsyncMarkers(uint marker, int range);
        public delegate int FinishAsync_uint(out uint markerp);
        public delegate int FinishAsync(uint[] markerp);
        public delegate void FlushRaster();
        public delegate void FragmentColorMaterial(int face, int mode);
        public delegate void FragmentLightf(int light, int pname, float param);
        public delegate void FragmentLightfv(int light, int pname, float[] param);
        public delegate void FragmentLighti(int light, int pname, int param);
        public delegate void FragmentLightiv(int light, int pname, int[] param);
        public delegate void FragmentLightModelf(int pname, float param);
        public delegate void FragmentLightModelfv(int pname, float[] param);
        public delegate void FragmentLightModeli(int pname, int param);
        public delegate void FragmentLightModeliv(int pname, int[] param);
        public delegate void FragmentMaterialf(int face, int pname, float param);
        public delegate void FragmentMaterialfv(int face, int pname, float[] param);
        public delegate void FragmentMateriali(int face, int pname, int param);
        public delegate void FragmentMaterialiv(int face, int pname, int[] param);
        public delegate void FrameZoom(int factor);
        public delegate uint GenAsyncMarkers(int range);
        public delegate void GetFragmentLightfv(int light, int pname, float[] param);
        public delegate void GetFragmentLightiv(int light, int pname, int[] param);
        public delegate void GetFragmentMaterialfv(int face, int pname, float[] param);
        public delegate void GetFragmentMaterialiv(int face, int pname, int[] param);
        public delegate int GetInstruments();
        public delegate void GetListParameterfv(uint list, int pname, float[] param);
        public delegate void GetListParameteriv(uint list, int pname, int[] param);
        public delegate void IglooInterface(int pname, IntPtr param);
        public delegate void InstrumentsBuffer(int size, IntPtr buffer);
        public delegate bool IsAsyncMarker(uint marker);
        public delegate void LightEnvi(int pname, int param);
        public delegate void ListParameterf(uint list, int pname, float param);
        public delegate void ListParameterfv(uint list, int pname, float[] param);
        public delegate void ListParameteri(uint list, int pname, int param);
        public delegate void ListParameteriv(uint list, int pname, int[] param);
        public delegate void LoadIdentityDeformationMap(int mask);
        public delegate void PixelTexGen(int mode);
        public delegate int PollAsync(uint[] markerp);
        public delegate int PollAsync_uint(out uint markerp);
        public delegate int PollInstruments(int[] marker_p);
        public delegate int PollInstruments_int(out int marker_p);
        public delegate void ReadInstruments(int marker);
        public delegate void ReferencePlane(double[] equation);
        public delegate void SpriteParameterf(int pname, float param);
        public delegate void SpriteParameterfv(int pname, float[] param);
        public delegate void SpriteParameteri(int pname, int param);
        public delegate void SpriteParameteriv(int pname, int[] param);
        public delegate void StartInstruments();
        public delegate void StopInstruments(int marker);
        public delegate void TagSampleBuffer();
        #endregion

        #region HP
        public delegate void GetImageTransformParameterfv(int target, int pname, float[] param);
        public delegate void GetImageTransformParameteriv(int target, int pname, int[] param);
        public delegate void ImageTransformParameterf(int target, int pname, float param);
        public delegate void ImageTransformParameterfv(int target, int pname, float[] param);
        public delegate void ImageTransformParameteri(int target, int pname, int param);
        public delegate void ImageTransformParameteriv(int target, int pname, int[] param);
        #endregion

        #region PGI
        // Function HintPGI is alias for Hint.
        #endregion

        #region INTEL
        public delegate void ColorPointerv(int size, int type, IntPtr pointer);
        public delegate void NormalPointerv(int type, IntPtr pointer);
        public delegate void TexCoordPointerv(int size, int type, IntPtr pointer);
        public delegate void VertexPointerv(int size, int type, IntPtr pointer);
        #endregion

        #region SUNX
        public delegate void FinishTexture();
        #endregion

        #region SUN
        public delegate void Color3fVertex3f(float r, float g, float b, float x, float y, float z);
        public delegate void Color3fVertex3fv(float[] c, float[] v);
        public delegate void Color4fNormal3fVertex3f(float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
        public delegate void Color4fNormal3fVertex3fv(float[] c, float[] n, float[] v);
        public delegate void Color4ubVertex2f(byte r, byte g, byte b, byte a, float x, float y);
        public delegate void Color4ubVertex2fv(byte[] c, float[] v);
        public delegate void Color4ubVertex3f(byte r, byte g, byte b, byte a, float x, float y, float z);
        public delegate void Color4ubVertex3fv(byte[] c, float[] v);
        public delegate void DrawMeshArrays(int mode, int first, int count, int width);
        public delegate void GlobalAlphaFactorb(byte factor);
        public delegate void GlobalAlphaFactord(double factor);
        public delegate void GlobalAlphaFactorf(float factor);
        public delegate void GlobalAlphaFactori(int factor);
        public delegate void GlobalAlphaFactors(short factor);
        public delegate void GlobalAlphaFactorub(byte factor);
        public delegate void GlobalAlphaFactorui(uint factor);
        public delegate void GlobalAlphaFactorus(ushort factor);
        public delegate void Normal3fVertex3f(float nx, float ny, float nz, float x, float y, float z);
        public delegate void Normal3fVertex3fv(float[] n, float[] v);
        public delegate void ReplacementCodePointer(int type, int stride, IntPtr pointer);
        public delegate void ReplacementCodeub(byte code);
        public delegate void ReplacementCodeubv(byte[] code);
        public delegate void ReplacementCodeui(uint code);
        public delegate void ReplacementCodeuiColor3fVertex3f(uint rc, float r, float g, float b, float x, float y, float z);
        public delegate void ReplacementCodeuiColor3fVertex3fv(uint[] rc, float[] c, float[] v);
        public delegate void ReplacementCodeuiColor4fNormal3fVertex3f(uint rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
        public delegate void ReplacementCodeuiColor4fNormal3fVertex3fv(uint[] rc, float[] c, float[] n, float[] v);
        public delegate void ReplacementCodeuiColor4ubVertex3f(uint rc, byte r, byte g, byte b, byte a, float x, float y, float z);
        public delegate void ReplacementCodeuiColor4ubVertex3fv(uint[] rc, byte[] c, float[] v);
        public delegate void ReplacementCodeuiNormal3fVertex3f(uint rc, float nx, float ny, float nz, float x, float y, float z);
        public delegate void ReplacementCodeuiNormal3fVertex3fv(uint[] rc, float[] n, float[] v);
        public delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3f(uint rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
        public delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fv(uint[] rc, float[] tc, float[] c, float[] n, float[] v);
        public delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3f(uint rc, float s, float t, float nx, float ny, float nz, float x, float y, float z);
        public delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fv(uint[] rc, float[] tc, float[] n, float[] v);
        public delegate void ReplacementCodeuiTexCoord2fVertex3f(uint rc, float s, float t, float x, float y, float z);
        public delegate void ReplacementCodeuiTexCoord2fVertex3fv(uint[] rc, float[] tc, float[] v);
        public delegate void ReplacementCodeuiv(uint[] code);
        public delegate void ReplacementCodeuiVertex3f(uint rc, float x, float y, float z);
        public delegate void ReplacementCodeuiVertex3fv(uint[] rc, float[] v);
        public delegate void ReplacementCodeus(ushort code);
        public delegate void ReplacementCodeusv(ushort[] code);
        public delegate void TexCoord2fColor3fVertex3f(float s, float t, float r, float g, float b, float x, float y, float z);
        public delegate void TexCoord2fColor3fVertex3fv(float[] tc, float[] c, float[] v);
        public delegate void TexCoord2fColor4fNormal3fVertex3f(float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
        public delegate void TexCoord2fColor4fNormal3fVertex3fv(float[] tc, float[] c, float[] n, float[] v);
        public delegate void TexCoord2fColor4ubVertex3f(float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z);
        public delegate void TexCoord2fColor4ubVertex3fv(float[] tc, byte[] c, float[] v);
        public delegate void TexCoord2fNormal3fVertex3f(float s, float t, float nx, float ny, float nz, float x, float y, float z);
        public delegate void TexCoord2fNormal3fVertex3fv(float[] tc, float[] n, float[] v);
        public delegate void TexCoord2fVertex3f(float s, float t, float x, float y, float z);
        public delegate void TexCoord2fVertex3fv(float[] tc, float[] v);
        public delegate void TexCoord4fColor4fNormal3fVertex4f(float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w);
        public delegate void TexCoord4fColor4fNormal3fVertex4fv(float[] tc, float[] c, float[] n, float[] v);
        public delegate void TexCoord4fVertex4f(float s, float t, float p, float q, float x, float y, float z, float w);
        public delegate void TexCoord4fVertex4fv(float[] tc, float[] v);
        #endregion

        #region INGR
        // Function BlendFuncSeparateINGR is alias for BlendFuncSeparate.
        #endregion

        #region NV
        public delegate void ActiveVarying(uint program, StringBuilder name);
        public delegate bool AreProgramsResident(int n, uint[] programs, bool[] residences);
        public delegate bool AreProgramsResident_uint_bool(int n, ref uint programs, out bool residences);
        // Function BeginConditionalRenderNV is alias for BeginConditionalRender.
        public delegate void BeginOcclusionQuery(uint id);
        // Function BeginTransformFeedbackNV is alias for BeginTransformFeedback.
        public delegate void BeginVideoCapture(uint video_capture_slot);
        // Function BindBufferBaseNV is alias for BindBufferBase.
        // Function BindBufferOffsetNV is alias for BindBufferOffsetEXT.
        // Function BindBufferRangeNV is alias for BindBufferRange.
        // Function BindProgramNV is alias for BindProgramARB.
        // Function BindTransformFeedbackNV is alias for BindTransformFeedback.
        public delegate void BindVideoCaptureStreamBuffer(uint video_capture_slot, uint stream, int frame_region, int offset);
        public delegate void BindVideoCaptureStreamTexture(uint video_capture_slot, uint stream, int frame_region, int target, uint texture);
        public delegate void BufferAddressRange(int pname, uint index, ulong address, int length);
        public delegate void ClearDepthd(double depth);
        public delegate void Color3h(ushort red, ushort green, ushort blue);
        public delegate void Color3hv(ushort[] v);
        public delegate void Color4h(ushort red, ushort green, ushort blue, ushort alpha);
        public delegate void Color4hv(ushort[] v);
        public delegate void ColorFormat(int size, int type, int stride);
        public delegate void CombinerInput(int stage, int portion, int variable, int input, int mapping, int componentUsage);
        public delegate void CombinerOutput(int stage, int portion, int abOutput, int cdOutput, int sumOutput, int scale, int bias, bool abDotProduct, bool cdDotProduct, bool muxSum);
        public delegate void CombinerParameterf(int pname, float param);
        public delegate void CombinerParameterfv(int pname, float[] param);
        public delegate void CombinerParameteri(int pname, int param);
        public delegate void CombinerParameteriv(int pname, int[] param);
        public delegate void CombinerStageParameterfv(int stage, int pname, float[] param);
        // Function CopyImageSubDataNV is alias for CopyImageSubData.
        public delegate void CopyPath(uint resultPath, uint srcPath);
        public delegate void CoverFillPath(uint path, int coverMode);
        public delegate void CoverFillPathInstanced(int numPaths, int pathNameType, IntPtr paths, uint pathBase, int coverMode, int transformType, float[] transformValues);
        public delegate void CoverStrokePath(uint path, int coverMode);
        public delegate void CoverStrokePathInstanced(int numPaths, int pathNameType, IntPtr paths, uint pathBase, int coverMode, int transformType, float[] transformValues);
        public delegate void DeleteFences(int n, uint[] fences);
        public delegate void DeleteFences_uint(int n, ref uint fences);
        public delegate void DeleteOcclusionQueries_uint(int n, ref uint ids);
        public delegate void DeleteOcclusionQueries(int n, uint[] ids);
        public delegate void DeletePaths(uint path, int range);
        // Function DeleteProgramsNV is alias for DeleteProgramsARB.
        // Function DeleteTransformFeedbacksNV is alias for DeleteTransformFeedbacks.
        public delegate void DepthBoundsd(double zmin, double zmax);
        public delegate void DepthRanged(double zNear, double zFar);
        // Function DrawTransformFeedbackNV is alias for DrawTransformFeedback.
        public delegate void EdgeFlagFormat(int stride);
        // Function EndConditionalRenderNV is alias for EndConditionalRender.
        public delegate void EndOcclusionQuery();
        // Function EndTransformFeedbackNV is alias for EndTransformFeedback.
        public delegate void EndVideoCapture(uint video_capture_slot);
        public delegate void EvalMaps(int target, int mode);
        public delegate void ExecuteProgram(int target, uint id, float[] param);
        public delegate void FinalCombinerInput(int variable, int input, int mapping, int componentUsage);
        public delegate void FinishFence(uint fence);
        public delegate void FlushPixelDataRange(int target);
        public delegate void FlushVertexArrayRange();
        public delegate void FogCoordFormat(int type, int stride);
        public delegate void FogCoordh(ushort fog);
        public delegate void FogCoordhv(ushort[] fog);
        // Function FramebufferTextureEXT is alias for FramebufferTexture.
        // Function FramebufferTextureFaceEXT is alias for FramebufferTextureFaceARB.
        // Function FramebufferTextureLayerEXT is alias for FramebufferTextureLayer.
        public delegate void GenFences(int n, uint[] fences);
        public delegate void GenFences_uint(int n, out uint fences);
        public delegate void GenOcclusionQueries_uint(int n, out uint ids);
        public delegate void GenOcclusionQueries(int n, uint[] ids);
        public delegate uint GenPaths(int range);
        // Function GenProgramsNV is alias for GenProgramsARB.
        // Function GenTransformFeedbacksNV is alias for GenTransformFeedbacks.
        public delegate void GetActiveVarying_int_int_int(uint program, uint index, int bufSize, out int length, out int size, out int type, StringBuilder name);
        public delegate void GetActiveVarying(uint program, uint index, int bufSize, int[] length, int[] size, int[] type, StringBuilder name);
        public delegate void GetBufferParameterui64v(int target, int pname, ulong[] param);
        public delegate void GetCombinerInputParameterfv(int stage, int portion, int variable, int pname, float[] param);
        public delegate void GetCombinerInputParameteriv(int stage, int portion, int variable, int pname, int[] param);
        public delegate void GetCombinerOutputParameterfv(int stage, int portion, int pname, float[] param);
        public delegate void GetCombinerOutputParameteriv(int stage, int portion, int pname, int[] param);
        public delegate void GetCombinerStageParameterfv(int stage, int pname, float[] param);
        public delegate void GetFenceiv(uint fence, int pname, int[] param);
        public delegate void GetFinalCombinerInputParameterfv(int variable, int pname, float[] param);
        public delegate void GetFinalCombinerInputParameteriv(int variable, int pname, int[] param);
        public delegate ulong GetImageHandle(uint texture, int level, bool layered, int layer, int format);
        public delegate void GetIntegerui64i_v(int value, uint index, ulong[] result);
        public delegate void GetIntegerui64v(int value, ulong[] result);
        public delegate void GetMapAttribParameterfv(int target, uint index, int pname, float[] param);
        public delegate void GetMapAttribParameteriv(int target, uint index, int pname, int[] param);
        public delegate void GetMapControlPoints(int target, uint index, int type, int ustride, int vstride, bool packed, IntPtr points);
        public delegate void GetMapParameterfv(int target, int pname, float[] param);
        public delegate void GetMapParameteriv(int target, int pname, int[] param);
        // Function GetMultisamplefvNV is alias for GetMultisamplefv.
        public delegate void GetNamedBufferParameterui64v(uint buffer, int pname, ulong[] param);
        public delegate void GetOcclusionQueryiv(uint id, int pname, int[] param);
        public delegate void GetOcclusionQueryuiv(uint id, int pname, uint[] param);
        public delegate void GetPathColorGenfv(int color, int pname, float[] value);
        public delegate void GetPathColorGeniv(int color, int pname, int[] value);
        public delegate void GetPathCommands(uint path, byte[] commands);
        public delegate void GetPathCoords(uint path, float[] coords);
        public delegate void GetPathDashArray(uint path, float[] dashArray);
        public delegate float GetPathLength(uint path, int startSegment, int numSegments);
        public delegate void GetPathMetricRange(int metricQueryMask, uint firstPathName, int numPaths, int stride, float[] metrics);
        public delegate void GetPathMetrics(int metricQueryMask, int numPaths, int pathNameType, IntPtr paths, uint pathBase, int stride, float[] metrics);
        public delegate void GetPathParameterfv(uint path, int pname, float[] value);
        public delegate void GetPathParameteriv(uint path, int pname, int[] value);
        public delegate void GetPathSpacing(int pathListMode, int numPaths, int pathNameType, IntPtr paths, uint pathBase, float advanceScale, float kerningScale, int transformType, float[] returnedSpacing);
        public delegate void GetPathTexGenfv(int texCoordSet, int pname, float[] value);
        public delegate void GetPathTexGeniv(int texCoordSet, int pname, int[] value);
        public delegate void GetProgramEnvParameterIiv(int target, uint index, int[] param);
        public delegate void GetProgramEnvParameterIuiv(int target, uint index, uint[] param);
        // Function GetProgramivNV is alias for GetProgramiv.
        public delegate void GetProgramLocalParameterIiv(int target, uint index, int[] param);
        public delegate void GetProgramLocalParameterIuiv(int target, uint index, uint[] param);
        public delegate void GetProgramNamedParameterdv(uint id, int len, byte[] name, double[] param);
        public delegate void GetProgramNamedParameterfv(uint id, int len, byte[] name, float[] param);
        public delegate void GetProgramParameterdv(int target, uint index, int pname, double[] param);
        public delegate void GetProgramParameterfv(int target, uint index, int pname, float[] param);
        public delegate void GetProgramStringNV(uint id, int pname, byte[] program);
        public delegate void GetProgramSubroutineParameteruiv(int target, uint index, uint[] param);
        public delegate ulong GetTextureHandle(uint texture);
        public delegate ulong GetTextureSamplerHandle(uint texture, uint sampler);
        public delegate void GetTrackMatrixiv(int target, uint address, int pname, int[] param);
        public delegate void GetTrackMatrixiv_int(int target, uint address, int pname, out int param);
        public delegate void GetTransformFeedbackVaryingNV_int(uint program, uint index, out int location);
        public delegate void GetTransformFeedbackVaryingNV(uint program, uint index, int[] location);
        public delegate void GetUniformi64v(uint program, int location, long[] param);
        public delegate void GetUniformui64v(uint program, int location, ulong[] param);
        public delegate int GetVaryingLocation(uint program, StringBuilder name);
        // Function GetVertexAttribdvNV is alias for GetVertexAttribdv.
        // Function GetVertexAttribfvNV is alias for GetVertexAttribfv.
        // Function GetVertexAttribIivEXT is alias for GetVertexAttribIiv.
        // Function GetVertexAttribIuivEXT is alias for GetVertexAttribIuiv.
        // Function GetVertexAttribivNV is alias for GetVertexAttribiv.
        public delegate void GetVertexAttribLi64v(uint index, int pname, long[] param);
        public delegate void GetVertexAttribLui64v(uint index, int pname, ulong[] param);
        // Function GetVertexAttribPointervNV is alias for GetVertexAttribPointerv.
        public delegate void GetVideoCaptureiv(uint video_capture_slot, int pname, int[] param);
        public delegate void GetVideoCaptureStreamdv(uint video_capture_slot, uint stream, int pname, double[] param);
        public delegate void GetVideoCaptureStreamfv(uint video_capture_slot, uint stream, int pname, float[] param);
        public delegate void GetVideoCaptureStreamiv(uint video_capture_slot, uint stream, int pname, int[] param);
        public delegate void GetVideoi64v(uint video_slot, int pname, long[] param);
        public delegate void GetVideoiv(uint video_slot, int pname, int[] param);
        public delegate void GetVideoui64v(uint video_slot, int pname, ulong[] param);
        public delegate void GetVideouiv(uint video_slot, int pname, uint[] param);
        public delegate void IndexFormat(int type, int stride);
        public delegate void InterpolatePaths(uint resultPath, uint pathA, uint pathB, float weight);
        public delegate bool IsBufferResident(int target);
        public delegate bool IsFence(uint fence);
        public delegate bool IsImageHandleResident(ulong handle);
        public delegate bool IsNamedBufferResident(uint buffer);
        public delegate bool IsOcclusionQuery(uint id);
        public delegate bool IsPath(uint path);
        public delegate bool IsPointInFillPath(uint path, uint mask, float x, float y);
        public delegate bool IsPointInStrokePath(uint path, float x, float y);
        // Function IsProgramNV is alias for IsProgram.
        public delegate bool IsTextureHandleResident(ulong handle);
        // Function IsTransformFeedbackNV is alias for IsTransformFeedback.
        public delegate void LoadProgram(int target, uint id, int len, byte[] program);
        public delegate void MakeBufferNonResident(int target);
        public delegate void MakeBufferResident(int target, int access);
        public delegate void MakeImageHandleNonResident(ulong handle);
        public delegate void MakeImageHandleResident(ulong handle, int access);
        public delegate void MakeNamedBufferNonResident(uint buffer);
        public delegate void MakeNamedBufferResident(uint buffer, int access);
        public delegate void MakeTextureHandleNonResident(ulong handle);
        public delegate void MakeTextureHandleResident(ulong handle);
        public delegate void MapControlPoints(int target, uint index, int type, int ustride, int vstride, int uorder, int vorder, bool packed, IntPtr points);
        public delegate void MapParameterfv(int target, int pname, float[] param);
        public delegate void MapParameteriv(int target, int pname, int[] param);
        public delegate void MultiTexCoord1h(int target, ushort s);
        public delegate void MultiTexCoord1hv(int target, ushort[] v);
        public delegate void MultiTexCoord2h(int target, ushort s, ushort t);
        public delegate void MultiTexCoord2hv(int target, ushort[] v);
        public delegate void MultiTexCoord3h(int target, ushort s, ushort t, ushort r);
        public delegate void MultiTexCoord3hv(int target, ushort[] v);
        public delegate void MultiTexCoord4h(int target, ushort s, ushort t, ushort r, ushort q);
        public delegate void MultiTexCoord4hv(int target, ushort[] v);
        public delegate void Normal3h(ushort nx, ushort ny, ushort nz);
        public delegate void Normal3hv(ushort[] v);
        public delegate void NormalFormat(int type, int stride);
        public delegate void PathColorGen(int color, int genMode, int colorFormat, float[] coeffs);
        public delegate void PathCommands(uint path, int numCommands, byte[] commands, int numCoords, int coordType, IntPtr coords);
        public delegate void PathCoords(uint path, int numCoords, int coordType, IntPtr coords);
        public delegate void PathCoverDepthFunc(int func);
        public delegate void PathDashArray(uint path, int dashCount, float[] dashArray);
        public delegate void PathFogGen(int genMode);
        public delegate void PathGlyphRange(uint firstPathName, int fontTarget, IntPtr fontName, int fontStyle, uint firstGlyph, int numGlyphs, int handleMissingGlyphs, uint pathParameterTemplate, float emScale);
        public delegate void PathGlyphs(uint firstPathName, int fontTarget, IntPtr fontName, int fontStyle, int numGlyphs, int type, IntPtr charcodes, int handleMissingGlyphs, uint pathParameterTemplate, float emScale);
        public delegate void PathParameterf(uint path, int pname, float value);
        public delegate void PathParameterfv(uint path, int pname, float[] value);
        public delegate void PathParameteri(uint path, int pname, int value);
        public delegate void PathParameteriv(uint path, int pname, int[] value);
        public delegate void PathStencilDepthOffset(float factor, float units);
        public delegate void PathStencilFunc(int func, int reference, uint mask);
        public delegate void PathString(uint path, int format, int length, IntPtr pathString);
        public delegate void PathSubCommands(uint path, int commandStart, int commandsToDelete, int numCommands, byte[] commands, int numCoords, int coordType, IntPtr coords);
        public delegate void PathSubCoords(uint path, int coordStart, int numCoords, int coordType, IntPtr coords);
        public delegate void PathTexGen(int texCoordSet, int genMode, int components, float[] coeffs);
        // Function PauseTransformFeedbackNV is alias for PauseTransformFeedback.
        public delegate void PixelDataRange(int target, int length, IntPtr pointer);
        public delegate bool PointAlongPath(uint path, int startSegment, int numSegments, float distance, float[] x, float[] y, float[] tangentX, float[] tangentY);
        public delegate bool PointAlongPath_float_float_float_float(uint path, int startSegment, int numSegments, float distance, out float x, out float y, out float tangentX, out float tangentY);
        // Function PointParameteriNV is alias for PointParameteri.
        // Function PointParameterivNV is alias for PointParameteriv.
        public delegate void PresentFrameDualFill(uint video_slot, ulong minPresentTime, uint beginPresentTimeId, uint presentDurationId, int type, int target0, uint fill0, int target1, uint fill1, int target2, uint fill2, int target3, uint fill3);
        public delegate void PresentFrameKeyed(uint video_slot, ulong minPresentTime, uint beginPresentTimeId, uint presentDurationId, int type, int target0, uint fill0, uint key0, int target1, uint fill1, uint key1);
        public delegate void PrimitiveRestart();
        // Function PrimitiveRestartIndexNV is alias for PrimitiveRestartIndex.
        public delegate void ProgramBufferParametersfv(int target, uint buffer, uint index, int count, float[] param);
        public delegate void ProgramBufferParametersIiv(int target, uint buffer, uint index, int count, int[] param);
        public delegate void ProgramBufferParametersIuiv(int target, uint buffer, uint index, int count, uint[] param);
        public delegate void ProgramEnvParameterI4i(int target, uint index, int x, int y, int z, int w);
        public delegate void ProgramEnvParameterI4iv(int target, uint index, int[] param);
        public delegate void ProgramEnvParameterI4ui(int target, uint index, uint x, uint y, uint z, uint w);
        public delegate void ProgramEnvParameterI4uiv(int target, uint index, uint[] param);
        public delegate void ProgramEnvParametersI4iv(int target, uint index, int count, int[] param);
        public delegate void ProgramEnvParametersI4uiv(int target, uint index, int count, uint[] param);
        public delegate void ProgramLocalParameterI4i(int target, uint index, int x, int y, int z, int w);
        public delegate void ProgramLocalParameterI4iv(int target, uint index, int[] param);
        public delegate void ProgramLocalParameterI4ui(int target, uint index, uint x, uint y, uint z, uint w);
        public delegate void ProgramLocalParameterI4uiv(int target, uint index, uint[] param);
        public delegate void ProgramLocalParametersI4iv(int target, uint index, int count, int[] param);
        public delegate void ProgramLocalParametersI4uiv(int target, uint index, int count, uint[] param);
        public delegate void ProgramNamedParameter4d(uint id, int len, byte[] name, double x, double y, double z, double w);
        public delegate void ProgramNamedParameter4dv(uint id, int len, byte[] name, double[] v);
        public delegate void ProgramNamedParameter4f(uint id, int len, byte[] name, float x, float y, float z, float w);
        public delegate void ProgramNamedParameter4fv(uint id, int len, byte[] name, float[] v);
        public delegate void ProgramParameter4d(int target, uint index, double x, double y, double z, double w);
        public delegate void ProgramParameter4dv(int target, uint index, double[] v);
        public delegate void ProgramParameter4f(int target, uint index, float x, float y, float z, float w);
        public delegate void ProgramParameter4fv(int target, uint index, float[] v);
        public delegate void ProgramParameters4dv(int target, uint index, int count, double[] v);
        public delegate void ProgramParameters4fv(int target, uint index, int count, float[] v);
        public delegate void ProgramSubroutineParametersuiv(int target, int count, uint[] param);
        public delegate void ProgramUniform1i64(uint program, int location, long x);
        public delegate void ProgramUniform1i64v(uint program, int location, int count, long[] value);
        public delegate void ProgramUniform1ui64(uint program, int location, ulong x);
        public delegate void ProgramUniform1ui64v(uint program, int location, int count, ulong[] value);
        public delegate void ProgramUniform2i64(uint program, int location, long x, long y);
        public delegate void ProgramUniform2i64v(uint program, int location, int count, long[] value);
        public delegate void ProgramUniform2ui64(uint program, int location, ulong x, ulong y);
        public delegate void ProgramUniform2ui64v(uint program, int location, int count, ulong[] value);
        public delegate void ProgramUniform3i64(uint program, int location, long x, long y, long z);
        public delegate void ProgramUniform3i64v(uint program, int location, int count, long[] value);
        public delegate void ProgramUniform3ui64(uint program, int location, ulong x, ulong y, ulong z);
        public delegate void ProgramUniform3ui64v(uint program, int location, int count, ulong[] value);
        public delegate void ProgramUniform4i64(uint program, int location, long x, long y, long z, long w);
        public delegate void ProgramUniform4i64v(uint program, int location, int count, long[] value);
        public delegate void ProgramUniform4ui64(uint program, int location, ulong x, ulong y, ulong z, ulong w);
        public delegate void ProgramUniform4ui64v(uint program, int location, int count, ulong[] value);
        public delegate void ProgramUniformHandleui64(uint program, int location, ulong value);
        public delegate void ProgramUniformHandleui64v(uint program, int location, int count, ulong[] values);
        public delegate void ProgramUniformui64(uint program, int location, ulong value);
        public delegate void ProgramUniformui64v(uint program, int location, int count, ulong[] value);
        public delegate void ProgramVertexLimit(int target, int limit);
        public delegate void RenderbufferStorageMultisampleCoverage(int target, int coverageSamples, int colorSamples, int internalformat, int width, int height);
        public delegate void RequestResidentPrograms_uint(int n, ref uint programs);
        public delegate void RequestResidentPrograms(int n, uint[] programs);
        // Function ResumeTransformFeedbackNV is alias for ResumeTransformFeedback.
        public delegate void SampleMaskIndexed(uint index, int mask);
        public delegate void SecondaryColor3h(ushort red, ushort green, ushort blue);
        public delegate void SecondaryColor3hv(ushort[] v);
        public delegate void SecondaryColorFormat(int size, int type, int stride);
        public delegate void SetFence(uint fence, int condition);
        public delegate void StencilFillPath(uint path, int fillMode, uint mask);
        public delegate void StencilFillPathInstanced(int numPaths, int pathNameType, IntPtr paths, uint pathBase, int fillMode, uint mask, int transformType, float[] transformValues);
        public delegate void StencilStrokePath(uint path, int reference, uint mask);
        public delegate void StencilStrokePathInstanced(int numPaths, int pathNameType, IntPtr paths, uint pathBase, int reference, uint mask, int transformType, float[] transformValues);
        public delegate bool TestFence(uint fence);
        public delegate void TexCoord1h(ushort s);
        public delegate void TexCoord1hv(ushort[] v);
        public delegate void TexCoord2h(ushort s, ushort t);
        public delegate void TexCoord2hv(ushort[] v);
        public delegate void TexCoord3h(ushort s, ushort t, ushort r);
        public delegate void TexCoord3hv(ushort[] v);
        public delegate void TexCoord4h(ushort s, ushort t, ushort r, ushort q);
        public delegate void TexCoord4hv(ushort[] v);
        public delegate void TexCoordFormat(int size, int type, int stride);
        public delegate void TexImage2DMultisampleCoverage(int target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, bool fixedSampleLocations);
        public delegate void TexImage3DMultisampleCoverage(int target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, int depth, bool fixedSampleLocations);
        public delegate void TexRenderbuffer(int target, uint renderbuffer);
        public delegate void TextureBarrier();
        public delegate void TextureImage2DMultisample(uint texture, int target, int samples, int internalFormat, int width, int height, bool fixedSampleLocations);
        public delegate void TextureImage2DMultisampleCoverage(uint texture, int target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, bool fixedSampleLocations);
        public delegate void TextureImage3DMultisample(uint texture, int target, int samples, int internalFormat, int width, int height, int depth, bool fixedSampleLocations);
        public delegate void TextureImage3DMultisampleCoverage(uint texture, int target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, int depth, bool fixedSampleLocations);
        public delegate void TrackMatrix(int target, uint address, int matrix, int transform);
        public delegate void TransformFeedbackAttribs(uint count, int[] attribs, int bufferMode);
        public delegate void TransformFeedbackStreamAttribs(int count, int[] attribs, int nbuffers, int[] bufstreams, int bufferMode);
        public delegate void TransformFeedbackVaryingsNV(uint program, int count, int[] locations, int bufferMode);
        public delegate void TransformPath(uint resultPath, uint srcPath, int transformType, float[] transformValues);
        public delegate void Uniform1i64(int location, long x);
        public delegate void Uniform1i64v(int location, int count, long[] value);
        public delegate void Uniform1ui64(int location, ulong x);
        public delegate void Uniform1ui64v(int location, int count, ulong[] value);
        public delegate void Uniform2i64(int location, long x, long y);
        public delegate void Uniform2i64v(int location, int count, long[] value);
        public delegate void Uniform2ui64(int location, ulong x, ulong y);
        public delegate void Uniform2ui64v(int location, int count, ulong[] value);
        public delegate void Uniform3i64(int location, long x, long y, long z);
        public delegate void Uniform3i64v(int location, int count, long[] value);
        public delegate void Uniform3ui64(int location, ulong x, ulong y, ulong z);
        public delegate void Uniform3ui64v(int location, int count, ulong[] value);
        public delegate void Uniform4i64(int location, long x, long y, long z, long w);
        public delegate void Uniform4i64v(int location, int count, long[] value);
        public delegate void Uniform4ui64(int location, ulong x, ulong y, ulong z, ulong w);
        public delegate void Uniform4ui64v(int location, int count, ulong[] value);
        public delegate void UniformHandleui64(int location, ulong value);
        public delegate void UniformHandleui64v(int location, int count, ulong[] value);
        public delegate void Uniformui64(int location, ulong value);
        public delegate void Uniformui64v(int location, int count, ulong[] value);
        public delegate void VDPAUFini();
        public delegate void VDPAUGetSurfaceiv(IntPtr surface, int pname, int bufSize, int[] length, int[] values);
        public delegate void VDPAUInit(IntPtr vdpDevice, IntPtr getProcAddress);
        public delegate void VDPAUIsSurface(IntPtr surface);
        public delegate void VDPAUMapSurfaces(int numSurfaces, IntPtr[] surfaces);
        public delegate IntPtr VDPAURegisterOutputSurface(IntPtr vdpSurface, int target, int numTextureNames, uint[] textureNames);
        public delegate IntPtr VDPAURegisterVideoSurface(IntPtr vdpSurface, int target, int numTextureNames, uint[] textureNames);
        public delegate void VDPAUSurfaceAccess(IntPtr surface, int access);
        public delegate void VDPAUUnmapSurfaces(int numSurface, IntPtr[] surfaces);
        public delegate void VDPAUUnregisterSurface(IntPtr surface);
        public delegate void Vertex2h(ushort x, ushort y);
        public delegate void Vertex2hv(ushort[] v);
        public delegate void Vertex3h(ushort x, ushort y, ushort z);
        public delegate void Vertex3hv(ushort[] v);
        public delegate void Vertex4h(ushort x, ushort y, ushort z, ushort w);
        public delegate void Vertex4hv(ushort[] v);
        public delegate void VertexArrayRange(int length, IntPtr pointer);
        // Function VertexAttrib1dNV is alias for VertexAttrib1d.
        // Function VertexAttrib1dvNV is alias for VertexAttrib1dv.
        // Function VertexAttrib1fNV is alias for VertexAttrib1f.
        // Function VertexAttrib1fvNV is alias for VertexAttrib1fv.
        public delegate void VertexAttrib1h(uint index, ushort x);
        public delegate void VertexAttrib1hv(uint index, ushort[] v);
        // Function VertexAttrib1sNV is alias for VertexAttrib1s.
        // Function VertexAttrib1svNV is alias for VertexAttrib1sv.
        // Function VertexAttrib2dNV is alias for VertexAttrib2d.
        // Function VertexAttrib2dvNV is alias for VertexAttrib2dv.
        // Function VertexAttrib2fNV is alias for VertexAttrib2f.
        // Function VertexAttrib2fvNV is alias for VertexAttrib2fv.
        public delegate void VertexAttrib2h(uint index, ushort x, ushort y);
        public delegate void VertexAttrib2hv(uint index, ushort[] v);
        // Function VertexAttrib2sNV is alias for VertexAttrib2s.
        // Function VertexAttrib2svNV is alias for VertexAttrib2sv.
        // Function VertexAttrib3dNV is alias for VertexAttrib3d.
        // Function VertexAttrib3dvNV is alias for VertexAttrib3dv.
        // Function VertexAttrib3fNV is alias for VertexAttrib3f.
        // Function VertexAttrib3fvNV is alias for VertexAttrib3fv.
        public delegate void VertexAttrib3h(uint index, ushort x, ushort y, ushort z);
        public delegate void VertexAttrib3hv(uint index, ushort[] v);
        // Function VertexAttrib3sNV is alias for VertexAttrib3s.
        // Function VertexAttrib3svNV is alias for VertexAttrib3sv.
        // Function VertexAttrib4dNV is alias for VertexAttrib4d.
        // Function VertexAttrib4dvNV is alias for VertexAttrib4dv.
        // Function VertexAttrib4fNV is alias for VertexAttrib4f.
        // Function VertexAttrib4fvNV is alias for VertexAttrib4fv.
        public delegate void VertexAttrib4h(uint index, ushort x, ushort y, ushort z, ushort w);
        public delegate void VertexAttrib4hv(uint index, ushort[] v);
        // Function VertexAttrib4sNV is alias for VertexAttrib4s.
        // Function VertexAttrib4svNV is alias for VertexAttrib4sv.
        public delegate void VertexAttrib4ub(uint index, byte x, byte y, byte z, byte w);
        // Function VertexAttrib4ubvNV is alias for VertexAttrib4ubv.
        public delegate void VertexAttribFormatNV(uint index, int size, int type, bool normalized, int stride);
        // Function VertexAttribI1iEXT is alias for VertexAttribI1i.
        // Function VertexAttribI1ivEXT is alias for VertexAttribI1iv.
        // Function VertexAttribI1uiEXT is alias for VertexAttribI1ui.
        // Function VertexAttribI1uivEXT is alias for VertexAttribI1uiv.
        // Function VertexAttribI2iEXT is alias for VertexAttribI2i.
        // Function VertexAttribI2ivEXT is alias for VertexAttribI2iv.
        // Function VertexAttribI2uiEXT is alias for VertexAttribI2ui.
        // Function VertexAttribI2uivEXT is alias for VertexAttribI2uiv.
        // Function VertexAttribI3iEXT is alias for VertexAttribI3i.
        // Function VertexAttribI3ivEXT is alias for VertexAttribI3iv.
        // Function VertexAttribI3uiEXT is alias for VertexAttribI3ui.
        // Function VertexAttribI3uivEXT is alias for VertexAttribI3uiv.
        // Function VertexAttribI4bvEXT is alias for VertexAttribI4bv.
        // Function VertexAttribI4iEXT is alias for VertexAttribI4i.
        // Function VertexAttribI4ivEXT is alias for VertexAttribI4iv.
        // Function VertexAttribI4svEXT is alias for VertexAttribI4sv.
        // Function VertexAttribI4ubvEXT is alias for VertexAttribI4ubv.
        // Function VertexAttribI4uiEXT is alias for VertexAttribI4ui.
        // Function VertexAttribI4uivEXT is alias for VertexAttribI4uiv.
        // Function VertexAttribI4usvEXT is alias for VertexAttribI4usv.
        public delegate void VertexAttribIFormatNV(uint index, int size, int type, int stride);
        // Function VertexAttribIPointerEXT is alias for VertexAttribIPointer.
        public delegate void VertexAttribL1i64(uint index, long x);
        public delegate void VertexAttribL1i64v(uint index, long[] v);
        public delegate void VertexAttribL1ui64(uint index, ulong x);
        public delegate void VertexAttribL1ui64v(uint index, ulong[] v);
        public delegate void VertexAttribL2i64(uint index, long x, long y);
        public delegate void VertexAttribL2i64v(uint index, long[] v);
        public delegate void VertexAttribL2ui64(uint index, ulong x, ulong y);
        public delegate void VertexAttribL2ui64v(uint index, ulong[] v);
        public delegate void VertexAttribL3i64(uint index, long x, long y, long z);
        public delegate void VertexAttribL3i64v(uint index, long[] v);
        public delegate void VertexAttribL3ui64(uint index, ulong x, ulong y, ulong z);
        public delegate void VertexAttribL3ui64v(uint index, ulong[] v);
        public delegate void VertexAttribL4i64(uint index, long x, long y, long z, long w);
        public delegate void VertexAttribL4i64v(uint index, long[] v);
        public delegate void VertexAttribL4ui64(uint index, ulong x, ulong y, ulong z, ulong w);
        public delegate void VertexAttribL4ui64v(uint index, ulong[] v);
        public delegate void VertexAttribLFormatNV(uint index, int size, int type, int stride);
        public delegate void VertexAttribPointerNV(uint index, int fsize, int type, int stride, IntPtr pointer);
        public delegate void VertexAttribs1dv(uint index, int count, double[] v);
        public delegate void VertexAttribs1fv(uint index, int count, float[] v);
        public delegate void VertexAttribs1hv(uint index, int n, ushort[] v);
        public delegate void VertexAttribs1sv(uint index, int count, short[] v);
        public delegate void VertexAttribs2dv(uint index, int count, double[] v);
        public delegate void VertexAttribs2fv(uint index, int count, float[] v);
        public delegate void VertexAttribs2hv(uint index, int n, ushort[] v);
        public delegate void VertexAttribs2sv(uint index, int count, short[] v);
        public delegate void VertexAttribs3dv(uint index, int count, double[] v);
        public delegate void VertexAttribs3fv(uint index, int count, float[] v);
        public delegate void VertexAttribs3hv(uint index, int n, ushort[] v);
        public delegate void VertexAttribs3sv(uint index, int count, short[] v);
        public delegate void VertexAttribs4dv(uint index, int count, double[] v);
        public delegate void VertexAttribs4fv(uint index, int count, float[] v);
        public delegate void VertexAttribs4hv(uint index, int n, ushort[] v);
        public delegate void VertexAttribs4sv(uint index, int count, short[] v);
        public delegate void VertexAttribs4ubv(uint index, int count, byte[] v);
        public delegate void VertexFormat(int size, int type, int stride);
        public delegate void VertexWeighth(ushort weight);
        public delegate void VertexWeighthv(ushort[] weight);
        public delegate int VideoCapture(uint video_capture_slot, uint[] sequence_num, ulong[] capture_time);
        public delegate void VideoCaptureStreamParameterdv(uint video_capture_slot, uint stream, int pname, double[] param);
        public delegate void VideoCaptureStreamParameterfv(uint video_capture_slot, uint stream, int pname, float[] param);
        public delegate void VideoCaptureStreamParameteriv(uint video_capture_slot, uint stream, int pname, int[] param);
        public delegate void WeightPaths(uint resultPath, int numPaths, uint[] paths, float[] weights);
        #endregion

        #region MESA
        public delegate void ResizeBuffers();
        // Function WindowPos2dMESA is alias for WindowPos2d.
        // Function WindowPos2dvMESA is alias for WindowPos2dv.
        // Function WindowPos2fMESA is alias for WindowPos2f.
        // Function WindowPos2fvMESA is alias for WindowPos2fv.
        // Function WindowPos2iMESA is alias for WindowPos2i.
        // Function WindowPos2ivMESA is alias for WindowPos2iv.
        // Function WindowPos2sMESA is alias for WindowPos2s.
        // Function WindowPos2svMESA is alias for WindowPos2sv.
        // Function WindowPos3dMESA is alias for WindowPos3d.
        // Function WindowPos3dvMESA is alias for WindowPos3dv.
        // Function WindowPos3fMESA is alias for WindowPos3f.
        // Function WindowPos3fvMESA is alias for WindowPos3fv.
        // Function WindowPos3iMESA is alias for WindowPos3i.
        // Function WindowPos3ivMESA is alias for WindowPos3iv.
        // Function WindowPos3sMESA is alias for WindowPos3s.
        // Function WindowPos3svMESA is alias for WindowPos3sv.
        public delegate void WindowPos4d(double x, double y, double z, double w);
        public delegate void WindowPos4dv(double[] v);
        public delegate void WindowPos4f(float x, float y, float z, float w);
        public delegate void WindowPos4fv(float[] v);
        public delegate void WindowPos4i(int x, int y, int z, int w);
        public delegate void WindowPos4iv(int[] v);
        public delegate void WindowPos4s(short x, short y, short z, short w);
        public delegate void WindowPos4sv(short[] v);
        #endregion

        #region IBM
        public delegate void ColorPointerList(int size, int type, int stride, IntPtr pointer, int ptrstride);
        public delegate void EdgeFlagPointerList(int stride, IntPtr pointer, int ptrstride);
        public delegate void FogCoordPointerList(int type, int stride, IntPtr pointer, int ptrstride);
        public delegate void IndexPointerList(int type, int stride, IntPtr pointer, int ptrstride);
        public delegate void MultiModeDrawArrays(int[] mode, int[] first, int[] count, int primcount, int modestride);
        public delegate void MultiModeDrawElements(int[] mode, int[] count, int type, IntPtr indices, int primcount, int modestride);
        public delegate void NormalPointerList(int type, int stride, IntPtr pointer, int ptrstride);
        public delegate void SecondaryColorPointerList(int size, int type, int stride, IntPtr pointer, int ptrstride);
        public delegate void TexCoordPointerList(int size, int type, int stride, IntPtr pointer, int ptrstride);
        public delegate void VertexPointerList(int size, int type, int stride, IntPtr pointer, int ptrstride);
        #endregion

        #region 3DFX
        public delegate void TbufferMask(uint mask);
        #endregion

        #region ATI
        public delegate void AlphaFragmentOp1(int op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod);
        public delegate void AlphaFragmentOp2(int op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod);
        public delegate void AlphaFragmentOp3(int op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod);
        public delegate void ArrayObject(int array, int size, int type, int stride, uint buffer, uint offset);
        public delegate void BeginFragmentShader();
        public delegate void BindFragmentShader(uint id);
        public delegate void ClientActiveVertexStream(int stream);
        public delegate void ColorFragmentOp1(int op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod);
        public delegate void ColorFragmentOp2(int op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod);
        public delegate void ColorFragmentOp3(int op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod);
        public delegate void DeleteFragmentShader(uint id);
        // Function DrawBuffersATI is alias for DrawBuffers.
        public delegate void DrawElementArray(int mode, int count);
        public delegate void DrawRangeElementArray(int mode, uint start, uint end, int count);
        public delegate void ElementPointer(int type, IntPtr pointer);
        public delegate void EndFragmentShader();
        public delegate void FreeObjectBuffer(uint buffer);
        public delegate uint GenFragmentShaders(uint range);
        public delegate void GetArrayObjectfv_float(int array, int pname, out float param);
        public delegate void GetArrayObjectfv(int array, int pname, float[] param);
        public delegate void GetArrayObjectiv_int(int array, int pname, out int param);
        public delegate void GetArrayObjectiv(int array, int pname, int[] param);
        public delegate void GetObjectBufferfv(uint buffer, int pname, float[] param);
        public delegate void GetObjectBufferfv_float(uint buffer, int pname, out float param);
        public delegate void GetObjectBufferiv(uint buffer, int pname, int[] param);
        public delegate void GetObjectBufferiv_int(uint buffer, int pname, out int param);
        public delegate void GetTexBumpParameterfv(int pname, float[] param);
        public delegate void GetTexBumpParameteriv(int pname, int[] param);
        public delegate void GetVariantArrayObjectfv_float(uint id, int pname, out float param);
        public delegate void GetVariantArrayObjectfv(uint id, int pname, float[] param);
        public delegate void GetVariantArrayObjectiv_int(uint id, int pname, out int param);
        public delegate void GetVariantArrayObjectiv(uint id, int pname, int[] param);
        public delegate void GetVertexAttribArrayObjectfv(uint index, int pname, float[] param);
        public delegate void GetVertexAttribArrayObjectiv(uint index, int pname, int[] param);
        public delegate bool IsObjectBuffer(uint buffer);
        public delegate IntPtr MapObjectBuffer(uint buffer);
        public delegate uint NewObjectBuffer(int size, IntPtr pointer, int usage);
        public delegate void NormalStream3b(int stream, byte nx, byte ny, byte nz);
        public delegate void NormalStream3bv(int stream, byte[] coords);
        public delegate void NormalStream3d(int stream, double nx, double ny, double nz);
        public delegate void NormalStream3dv(int stream, double[] coords);
        public delegate void NormalStream3f(int stream, float nx, float ny, float nz);
        public delegate void NormalStream3fv(int stream, float[] coords);
        public delegate void NormalStream3i(int stream, int nx, int ny, int nz);
        public delegate void NormalStream3iv(int stream, int[] coords);
        public delegate void NormalStream3s(int stream, short nx, short ny, short nz);
        public delegate void NormalStream3sv(int stream, short[] coords);
        public delegate void PassTexCoord(uint dst, uint coord, int swizzle);
        public delegate void PNTrianglesf(int pname, float param);
        public delegate void PNTrianglesi(int pname, int param);
        public delegate void SampleMap(uint dst, uint interp, int swizzle);
        public delegate void SetFragmentShaderConstant(uint dst, float[] value);
        // Function StencilFuncSeparateATI is alias for StencilFuncSeparate.
        // Function StencilOpSeparateATI is alias for StencilOpSeparate.
        public delegate void TexBumpParameterfv(int pname, float[] param);
        public delegate void TexBumpParameteriv(int pname, int[] param);
        public delegate void UnmapObjectBuffer(uint buffer);
        public delegate void UpdateObjectBuffer(uint buffer, uint offset, int size, IntPtr pointer, int preserve);
        public delegate void VariantArrayObject(uint id, int type, int stride, uint buffer, uint offset);
        public delegate void VertexAttribArrayObject(uint index, int size, int type, bool normalized, int stride, uint buffer, uint offset);
        public delegate void VertexBlendEnvf(int pname, float param);
        public delegate void VertexBlendEnvi(int pname, int param);
        public delegate void VertexStream1d(int stream, double x);
        public delegate void VertexStream1dv(int stream, double[] coords);
        public delegate void VertexStream1dv_double(int stream, ref double coords);
        public delegate void VertexStream1f(int stream, float x);
        public delegate void VertexStream1fv(int stream, float[] coords);
        public delegate void VertexStream1fv_float(int stream, ref float coords);
        public delegate void VertexStream1i(int stream, int x);
        public delegate void VertexStream1iv_int(int stream, ref int coords);
        public delegate void VertexStream1iv(int stream, int[] coords);
        public delegate void VertexStream1s(int stream, short x);
        public delegate void VertexStream1sv(int stream, short[] coords);
        public delegate void VertexStream2d(int stream, double x, double y);
        public delegate void VertexStream2dv(int stream, double[] coords);
        public delegate void VertexStream2f(int stream, float x, float y);
        public delegate void VertexStream2fv(int stream, float[] coords);
        public delegate void VertexStream2i(int stream, int x, int y);
        public delegate void VertexStream2iv(int stream, int[] coords);
        public delegate void VertexStream2s(int stream, short x, short y);
        public delegate void VertexStream2sv(int stream, short[] coords);
        public delegate void VertexStream3d(int stream, double x, double y, double z);
        public delegate void VertexStream3dv(int stream, double[] coords);
        public delegate void VertexStream3f(int stream, float x, float y, float z);
        public delegate void VertexStream3fv(int stream, float[] coords);
        public delegate void VertexStream3i(int stream, int x, int y, int z);
        public delegate void VertexStream3iv(int stream, int[] coords);
        public delegate void VertexStream3s(int stream, short x, short y, short z);
        public delegate void VertexStream3sv(int stream, short[] coords);
        public delegate void VertexStream4d(int stream, double x, double y, double z, double w);
        public delegate void VertexStream4dv(int stream, double[] coords);
        public delegate void VertexStream4f(int stream, float x, float y, float z, float w);
        public delegate void VertexStream4fv(int stream, float[] coords);
        public delegate void VertexStream4i(int stream, int x, int y, int z, int w);
        public delegate void VertexStream4iv(int stream, int[] coords);
        public delegate void VertexStream4s(int stream, short x, short y, short z, short w);
        public delegate void VertexStream4sv(int stream, short[] coords);
        #endregion

        #region APPLE
        // Function BindVertexArrayAPPLE is alias for BindVertexArray.
        public delegate void BufferParameteri(int target, int pname, int param);
        // Function DeleteFencesAPPLE is alias for DeleteFencesNV.
        // Function DeleteVertexArraysAPPLE is alias for DeleteVertexArrays.
        public delegate void DisableVertexAttrib(uint index, int pname);
        public delegate void DrawElementArrayAPPLE(int mode, int first, int count);
        public delegate void DrawRangeElementArrayAPPLE(int mode, uint start, uint end, int first, int count);
        // Function ElementPointerAPPLE is alias for ElementPointerATI.
        public delegate void EnableVertexAttrib(uint index, int pname);
        // Function FinishFenceAPPLE is alias for FinishFenceNV.
        public delegate void FinishObject(int obj, int name);
        // Function FlushMappedBufferRangeAPPLE is alias for FlushMappedBufferRange.
        public delegate void FlushVertexArrayRangeAPPLE(int length, IntPtr pointer);
        // Function GenFencesAPPLE is alias for GenFencesNV.
        // Function GenVertexArraysAPPLE is alias for GenVertexArrays.
        public delegate void GetObjectParameterivAPPLE(int objectType, uint name, int pname, int[] param);
        public delegate void GetTexParameterPointerv(int target, int pname, IntPtr[] param);
        // Function IsFenceAPPLE is alias for IsFenceNV.
        // Function IsVertexArrayAPPLE is alias for IsVertexArray.
        public delegate bool IsVertexAttribEnabled(uint index, int pname);
        public delegate void MapVertexAttrib1d(uint index, uint size, double u1, double u2, int stride, int order, double[] points);
        public delegate void MapVertexAttrib1f(uint index, uint size, float u1, float u2, int stride, int order, float[] points);
        public delegate void MapVertexAttrib2d(uint index, uint size, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points);
        public delegate void MapVertexAttrib2f(uint index, uint size, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points);
        public delegate void MultiDrawElementArray(int mode, int[] first, int[] count, int primcount);
        public delegate void MultiDrawRangeElementArray(int mode, uint start, uint end, int[] first, int[] count, int primcount);
        public delegate int ObjectPurgeable(int objectType, uint name, int option);
        public delegate int ObjectUnpurgeable(int objectType, uint name, int option);
        public delegate void SetFenceAPPLE(uint fence);
        // Function TestFenceAPPLE is alias for TestFenceNV.
        public delegate bool TestObject(int obj, uint name);
        public delegate void TextureRange(int target, int length, IntPtr pointer);
        public delegate void VertexArrayParameteri(int pname, int param);
        // Function VertexArrayRangeAPPLE is alias for VertexArrayRangeNV.
        #endregion

        #region GREMEDY
        public delegate void FrameTerminator();
        public delegate void StringMarker(int len, IntPtr str);
        #endregion

        #region AMD
        public delegate void BeginPerfMonitor(uint monitor);
        public delegate void BlendEquationIndexed(uint buf, int mode);
        public delegate void BlendEquationSeparateIndexed(uint buf, int modeRGB, int modeAlpha);
        public delegate void BlendFuncIndexed(uint buf, int src, int dst);
        public delegate void BlendFuncSeparateIndexed(uint buf, int srcRGB, int dstRGB, int srcAlpha, int dstAlpha);
        public delegate void DebugMessageCallbackAMD(GLDEBUGPROCAMD callback, IntPtr userParam);
        public delegate void DebugMessageEnable(int category, int severity, int count, uint[] ids, bool enabled);
        public delegate void DebugMessageInsertAMD(int category, int severity, uint id, int length, StringBuilder buf);
        public delegate void DeleteNames(int identifier, uint num, uint[] names);
        public delegate void DeletePerfMonitors_uint(int n, out uint monitors);
        public delegate void DeletePerfMonitors(int n, uint[] monitors);
        public delegate void EndPerfMonitor(uint monitor);
        public delegate void GenNames(int identifier, uint num, uint[] names);
        public delegate void GenPerfMonitors(int n, uint[] monitors);
        public delegate void GenPerfMonitors_uint(int n, out uint monitors);
        public delegate uint GetDebugMessageLogAMD(uint count, int bufsize, int[] categories, uint[] severities, uint[] ids, int[] lengths, StringBuilder message);
        public delegate void GetPerfMonitorCounterData(uint monitor, int pname, int dataSize, uint[] data, int[] bytesWritten);
        public delegate void GetPerfMonitorCounterData_int(uint monitor, int pname, int dataSize, uint[] data, out int bytesWritten);
        public delegate void GetPerfMonitorCounterInfo(uint group, uint counter, int pname, IntPtr data);
        public delegate void GetPerfMonitorCounters(uint group, int[] numCounters, int[] maxActiveCounters, int counterSize, uint[] counters);
        public delegate void GetPerfMonitorCounters_int_int(uint group, out int numCounters, out int maxActiveCounters, int counterSize, uint[] counters);
        public delegate void GetPerfMonitorCounterString(uint group, uint counter, int bufSize, int[] length, StringBuilder counterString);
        public delegate void GetPerfMonitorCounterString_int(uint group, uint counter, int bufSize, out int length, StringBuilder counterString);
        public delegate void GetPerfMonitorGroups_int(out int numGroups, int groupsSize, uint[] groups);
        public delegate void GetPerfMonitorGroups(int[] numGroups, int groupsSize, uint[] groups);
        public delegate void GetPerfMonitorGroupString_int(uint group, int bufSize, out int length, StringBuilder groupString);
        public delegate void GetPerfMonitorGroupString(uint group, int bufSize, int[] length, StringBuilder groupString);
        public delegate bool IsName(int identifier, uint name);
        // Function MultiDrawArraysIndirectAMD is alias for MultiDrawArraysIndirect.
        // Function MultiDrawElementsIndirectAMD is alias for MultiDrawElementsIndirect.
        public delegate void SelectPerfMonitorCounters(uint monitor, bool enable, uint group, int numCounters, uint[] counterList);
        public delegate void SetMultisamplefv(int pname, uint index, float[] val);
        public delegate void StencilOpValue(int face, uint value);
        public delegate void TessellationFactor(float factor);
        public delegate void TessellationMode(int mode);
        #endregion
    }
}
