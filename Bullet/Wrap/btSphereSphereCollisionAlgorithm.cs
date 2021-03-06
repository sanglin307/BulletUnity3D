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

public class btSphereSphereCollisionAlgorithm : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btSphereSphereCollisionAlgorithm(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btSphereSphereCollisionAlgorithm obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btSphereSphereCollisionAlgorithm() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletCollisionPINVOKE.delete_btSphereSphereCollisionAlgorithm(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btSphereSphereCollisionAlgorithm(SWIGTYPE_p_btPersistentManifold mf, SWIGTYPE_p_btCollisionAlgorithmConstructionInfo ci, SWIGTYPE_p_btCollisionObjectWrapper col0Wrap, SWIGTYPE_p_btCollisionObjectWrapper col1Wrap) : this(BulletCollisionPINVOKE.new_btSphereSphereCollisionAlgorithm__SWIG_0(SWIGTYPE_p_btPersistentManifold.getCPtr(mf), SWIGTYPE_p_btCollisionAlgorithmConstructionInfo.getCPtr(ci), SWIGTYPE_p_btCollisionObjectWrapper.getCPtr(col0Wrap), SWIGTYPE_p_btCollisionObjectWrapper.getCPtr(col1Wrap)), true) {
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public btSphereSphereCollisionAlgorithm(SWIGTYPE_p_btCollisionAlgorithmConstructionInfo ci) : this(BulletCollisionPINVOKE.new_btSphereSphereCollisionAlgorithm__SWIG_1(SWIGTYPE_p_btCollisionAlgorithmConstructionInfo.getCPtr(ci)), true) {
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void processCollision(SWIGTYPE_p_btCollisionObjectWrapper body0Wrap, SWIGTYPE_p_btCollisionObjectWrapper body1Wrap, SWIGTYPE_p_btDispatcherInfo dispatchInfo, SWIGTYPE_p_btManifoldResult resultOut) {
    BulletCollisionPINVOKE.btSphereSphereCollisionAlgorithm_processCollision(swigCPtr, SWIGTYPE_p_btCollisionObjectWrapper.getCPtr(body0Wrap), SWIGTYPE_p_btCollisionObjectWrapper.getCPtr(body1Wrap), SWIGTYPE_p_btDispatcherInfo.getCPtr(dispatchInfo), SWIGTYPE_p_btManifoldResult.getCPtr(resultOut));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual float calculateTimeOfImpact(btCollisionObject body0, btCollisionObject body1, SWIGTYPE_p_btDispatcherInfo dispatchInfo, SWIGTYPE_p_btManifoldResult resultOut) {
    float ret = BulletCollisionPINVOKE.btSphereSphereCollisionAlgorithm_calculateTimeOfImpact(swigCPtr, btCollisionObject.getCPtr(body0), btCollisionObject.getCPtr(body1), SWIGTYPE_p_btDispatcherInfo.getCPtr(dispatchInfo), SWIGTYPE_p_btManifoldResult.getCPtr(resultOut));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void getAllContactManifolds(SWIGTYPE_p_btManifoldArray manifoldArray) {
    BulletCollisionPINVOKE.btSphereSphereCollisionAlgorithm_getAllContactManifolds(swigCPtr, SWIGTYPE_p_btManifoldArray.getCPtr(manifoldArray));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
