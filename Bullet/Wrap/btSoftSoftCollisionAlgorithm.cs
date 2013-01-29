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

public class btSoftSoftCollisionAlgorithm : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btSoftSoftCollisionAlgorithm(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btSoftSoftCollisionAlgorithm obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btSoftSoftCollisionAlgorithm() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletSoftBodyPINVOKE.delete_btSoftSoftCollisionAlgorithm(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btSoftSoftCollisionAlgorithm(SWIGTYPE_p_btCollisionAlgorithmConstructionInfo ci) : this(BulletSoftBodyPINVOKE.new_btSoftSoftCollisionAlgorithm__SWIG_0(SWIGTYPE_p_btCollisionAlgorithmConstructionInfo.getCPtr(ci)), true) {
    if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void processCollision(SWIGTYPE_p_btCollisionObjectWrapper body0Wrap, SWIGTYPE_p_btCollisionObjectWrapper body1Wrap, SWIGTYPE_p_btDispatcherInfo dispatchInfo, SWIGTYPE_p_btManifoldResult resultOut) {
    BulletSoftBodyPINVOKE.btSoftSoftCollisionAlgorithm_processCollision(swigCPtr, SWIGTYPE_p_btCollisionObjectWrapper.getCPtr(body0Wrap), SWIGTYPE_p_btCollisionObjectWrapper.getCPtr(body1Wrap), SWIGTYPE_p_btDispatcherInfo.getCPtr(dispatchInfo), SWIGTYPE_p_btManifoldResult.getCPtr(resultOut));
    if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual float calculateTimeOfImpact(SWIGTYPE_p_btCollisionObject body0, SWIGTYPE_p_btCollisionObject body1, SWIGTYPE_p_btDispatcherInfo dispatchInfo, SWIGTYPE_p_btManifoldResult resultOut) {
    float ret = BulletSoftBodyPINVOKE.btSoftSoftCollisionAlgorithm_calculateTimeOfImpact(swigCPtr, SWIGTYPE_p_btCollisionObject.getCPtr(body0), SWIGTYPE_p_btCollisionObject.getCPtr(body1), SWIGTYPE_p_btDispatcherInfo.getCPtr(dispatchInfo), SWIGTYPE_p_btManifoldResult.getCPtr(resultOut));
    if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void getAllContactManifolds(SWIGTYPE_p_btManifoldArray manifoldArray) {
    BulletSoftBodyPINVOKE.btSoftSoftCollisionAlgorithm_getAllContactManifolds(swigCPtr, SWIGTYPE_p_btManifoldArray.getCPtr(manifoldArray));
    if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
  }

  public btSoftSoftCollisionAlgorithm(SWIGTYPE_p_btPersistentManifold mf, SWIGTYPE_p_btCollisionAlgorithmConstructionInfo ci, SWIGTYPE_p_btCollisionObjectWrapper body0Wrap, SWIGTYPE_p_btCollisionObjectWrapper body1Wrap) : this(BulletSoftBodyPINVOKE.new_btSoftSoftCollisionAlgorithm__SWIG_1(SWIGTYPE_p_btPersistentManifold.getCPtr(mf), SWIGTYPE_p_btCollisionAlgorithmConstructionInfo.getCPtr(ci), SWIGTYPE_p_btCollisionObjectWrapper.getCPtr(body0Wrap), SWIGTYPE_p_btCollisionObjectWrapper.getCPtr(body1Wrap)), true) {
    if (BulletSoftBodyPINVOKE.SWIGPendingException.Pending) throw BulletSoftBodyPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
