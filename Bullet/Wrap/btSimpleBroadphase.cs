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

public class btSimpleBroadphase : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btSimpleBroadphase(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btSimpleBroadphase obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btSimpleBroadphase() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletCollisionPINVOKE.delete_btSimpleBroadphase(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btSimpleBroadphase(int maxProxies, SWIGTYPE_p_btOverlappingPairCache overlappingPairCache) : this(BulletCollisionPINVOKE.new_btSimpleBroadphase__SWIG_0(maxProxies, SWIGTYPE_p_btOverlappingPairCache.getCPtr(overlappingPairCache)), true) {
  }

  public btSimpleBroadphase(int maxProxies) : this(BulletCollisionPINVOKE.new_btSimpleBroadphase__SWIG_1(maxProxies), true) {
  }

  public btSimpleBroadphase() : this(BulletCollisionPINVOKE.new_btSimpleBroadphase__SWIG_2(), true) {
  }

  public static bool aabbOverlap(btSimpleBroadphaseProxy proxy0, btSimpleBroadphaseProxy proxy1) {
    bool ret = BulletCollisionPINVOKE.btSimpleBroadphase_aabbOverlap(btSimpleBroadphaseProxy.getCPtr(proxy0), btSimpleBroadphaseProxy.getCPtr(proxy1));
    return ret;
  }

  public virtual SWIGTYPE_p_btBroadphaseProxy createProxy(SWIGTYPE_p_btVector3 aabbMin, SWIGTYPE_p_btVector3 aabbMax, int shapeType, SWIGTYPE_p_void userPtr, short collisionFilterGroup, short collisionFilterMask, SWIGTYPE_p_btDispatcher dispatcher, SWIGTYPE_p_void multiSapProxy) {
    IntPtr cPtr = BulletCollisionPINVOKE.btSimpleBroadphase_createProxy(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(aabbMin), SWIGTYPE_p_btVector3.getCPtr(aabbMax), shapeType, SWIGTYPE_p_void.getCPtr(userPtr), collisionFilterGroup, collisionFilterMask, SWIGTYPE_p_btDispatcher.getCPtr(dispatcher), SWIGTYPE_p_void.getCPtr(multiSapProxy));
    SWIGTYPE_p_btBroadphaseProxy ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btBroadphaseProxy(cPtr, false);
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void calculateOverlappingPairs(SWIGTYPE_p_btDispatcher dispatcher) {
    BulletCollisionPINVOKE.btSimpleBroadphase_calculateOverlappingPairs(swigCPtr, SWIGTYPE_p_btDispatcher.getCPtr(dispatcher));
  }

  public virtual void destroyProxy(SWIGTYPE_p_btBroadphaseProxy proxy, SWIGTYPE_p_btDispatcher dispatcher) {
    BulletCollisionPINVOKE.btSimpleBroadphase_destroyProxy(swigCPtr, SWIGTYPE_p_btBroadphaseProxy.getCPtr(proxy), SWIGTYPE_p_btDispatcher.getCPtr(dispatcher));
  }

  public virtual void setAabb(SWIGTYPE_p_btBroadphaseProxy proxy, SWIGTYPE_p_btVector3 aabbMin, SWIGTYPE_p_btVector3 aabbMax, SWIGTYPE_p_btDispatcher dispatcher) {
    BulletCollisionPINVOKE.btSimpleBroadphase_setAabb(swigCPtr, SWIGTYPE_p_btBroadphaseProxy.getCPtr(proxy), SWIGTYPE_p_btVector3.getCPtr(aabbMin), SWIGTYPE_p_btVector3.getCPtr(aabbMax), SWIGTYPE_p_btDispatcher.getCPtr(dispatcher));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void getAabb(SWIGTYPE_p_btBroadphaseProxy proxy, SWIGTYPE_p_btVector3 aabbMin, SWIGTYPE_p_btVector3 aabbMax) {
    BulletCollisionPINVOKE.btSimpleBroadphase_getAabb(swigCPtr, SWIGTYPE_p_btBroadphaseProxy.getCPtr(proxy), SWIGTYPE_p_btVector3.getCPtr(aabbMin), SWIGTYPE_p_btVector3.getCPtr(aabbMax));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void rayTest(SWIGTYPE_p_btVector3 rayFrom, SWIGTYPE_p_btVector3 rayTo, SWIGTYPE_p_btBroadphaseRayCallback rayCallback, SWIGTYPE_p_btVector3 aabbMin, SWIGTYPE_p_btVector3 aabbMax) {
    BulletCollisionPINVOKE.btSimpleBroadphase_rayTest__SWIG_0(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(rayFrom), SWIGTYPE_p_btVector3.getCPtr(rayTo), SWIGTYPE_p_btBroadphaseRayCallback.getCPtr(rayCallback), SWIGTYPE_p_btVector3.getCPtr(aabbMin), SWIGTYPE_p_btVector3.getCPtr(aabbMax));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void rayTest(SWIGTYPE_p_btVector3 rayFrom, SWIGTYPE_p_btVector3 rayTo, SWIGTYPE_p_btBroadphaseRayCallback rayCallback, SWIGTYPE_p_btVector3 aabbMin) {
    BulletCollisionPINVOKE.btSimpleBroadphase_rayTest__SWIG_1(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(rayFrom), SWIGTYPE_p_btVector3.getCPtr(rayTo), SWIGTYPE_p_btBroadphaseRayCallback.getCPtr(rayCallback), SWIGTYPE_p_btVector3.getCPtr(aabbMin));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void rayTest(SWIGTYPE_p_btVector3 rayFrom, SWIGTYPE_p_btVector3 rayTo, SWIGTYPE_p_btBroadphaseRayCallback rayCallback) {
    BulletCollisionPINVOKE.btSimpleBroadphase_rayTest__SWIG_2(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(rayFrom), SWIGTYPE_p_btVector3.getCPtr(rayTo), SWIGTYPE_p_btBroadphaseRayCallback.getCPtr(rayCallback));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void aabbTest(SWIGTYPE_p_btVector3 aabbMin, SWIGTYPE_p_btVector3 aabbMax, SWIGTYPE_p_btBroadphaseAabbCallback callback) {
    BulletCollisionPINVOKE.btSimpleBroadphase_aabbTest(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(aabbMin), SWIGTYPE_p_btVector3.getCPtr(aabbMax), SWIGTYPE_p_btBroadphaseAabbCallback.getCPtr(callback));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_btOverlappingPairCache getOverlappingPairCache() {
    IntPtr cPtr = BulletCollisionPINVOKE.btSimpleBroadphase_getOverlappingPairCache__SWIG_0(swigCPtr);
    SWIGTYPE_p_btOverlappingPairCache ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btOverlappingPairCache(cPtr, false);
    return ret;
  }

  public bool testAabbOverlap(SWIGTYPE_p_btBroadphaseProxy proxy0, SWIGTYPE_p_btBroadphaseProxy proxy1) {
    bool ret = BulletCollisionPINVOKE.btSimpleBroadphase_testAabbOverlap(swigCPtr, SWIGTYPE_p_btBroadphaseProxy.getCPtr(proxy0), SWIGTYPE_p_btBroadphaseProxy.getCPtr(proxy1));
    return ret;
  }

  public virtual void getBroadphaseAabb(SWIGTYPE_p_btVector3 aabbMin, SWIGTYPE_p_btVector3 aabbMax) {
    BulletCollisionPINVOKE.btSimpleBroadphase_getBroadphaseAabb(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(aabbMin), SWIGTYPE_p_btVector3.getCPtr(aabbMax));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void printStats() {
    BulletCollisionPINVOKE.btSimpleBroadphase_printStats(swigCPtr);
  }

}

}
