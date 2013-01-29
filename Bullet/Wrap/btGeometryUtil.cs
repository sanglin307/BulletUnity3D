/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace BulletCSharp {

using System;
using System.Runtime.InteropServices;

public class btGeometryUtil : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btGeometryUtil(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btGeometryUtil obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btGeometryUtil() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LinearMathPINVOKE.delete_btGeometryUtil(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static void getPlaneEquationsFromVertices(SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t vertices, SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t planeEquationsOut) {
    LinearMathPINVOKE.btGeometryUtil_getPlaneEquationsFromVertices(SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t.getCPtr(vertices), SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t.getCPtr(planeEquationsOut));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void getVerticesFromPlaneEquations(SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t planeEquations, SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t verticesOut) {
    LinearMathPINVOKE.btGeometryUtil_getVerticesFromPlaneEquations(SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t.getCPtr(planeEquations), SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t.getCPtr(verticesOut));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public static bool isInside(SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t vertices, btVector3 planeNormal, float margin) {
    bool ret = LinearMathPINVOKE.btGeometryUtil_isInside(SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t.getCPtr(vertices), btVector3.getCPtr(planeNormal), margin);
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool isPointInsidePlanes(SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t planeEquations, btVector3 point, float margin) {
    bool ret = LinearMathPINVOKE.btGeometryUtil_isPointInsidePlanes(SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t.getCPtr(planeEquations), btVector3.getCPtr(point), margin);
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool areVerticesBehindPlane(btVector3 planeNormal, SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t vertices, float margin) {
    bool ret = LinearMathPINVOKE.btGeometryUtil_areVerticesBehindPlane(btVector3.getCPtr(planeNormal), SWIGTYPE_p_btAlignedObjectArrayT_btVector3_t.getCPtr(vertices), margin);
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public btGeometryUtil() : this(LinearMathPINVOKE.new_btGeometryUtil(), true) {
  }

}

}
