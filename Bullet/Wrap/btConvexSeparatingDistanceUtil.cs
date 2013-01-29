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

public class btConvexSeparatingDistanceUtil : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btConvexSeparatingDistanceUtil(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btConvexSeparatingDistanceUtil obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btConvexSeparatingDistanceUtil() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LinearMathPINVOKE.delete_btConvexSeparatingDistanceUtil(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btConvexSeparatingDistanceUtil(float boundingRadiusA, float boundingRadiusB) : this(LinearMathPINVOKE.new_btConvexSeparatingDistanceUtil(boundingRadiusA, boundingRadiusB), true) {
  }

  public float getConservativeSeparatingDistance() {
    float ret = LinearMathPINVOKE.btConvexSeparatingDistanceUtil_getConservativeSeparatingDistance(swigCPtr);
    return ret;
  }

  public void updateSeparatingDistance(btTransform transA, btTransform transB) {
    LinearMathPINVOKE.btConvexSeparatingDistanceUtil_updateSeparatingDistance(swigCPtr, btTransform.getCPtr(transA), btTransform.getCPtr(transB));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public void initSeparatingDistance(btVector3 separatingVector, float separatingDistance, btTransform transA, btTransform transB) {
    LinearMathPINVOKE.btConvexSeparatingDistanceUtil_initSeparatingDistance(swigCPtr, btVector3.getCPtr(separatingVector), separatingDistance, btTransform.getCPtr(transA), btTransform.getCPtr(transB));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
