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

public class btTriangleMeshShape : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btTriangleMeshShape(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btTriangleMeshShape obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btTriangleMeshShape() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletCollisionPINVOKE.delete_btTriangleMeshShape(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual SWIGTYPE_p_btVector3 localGetSupportingVertex(SWIGTYPE_p_btVector3 vec) {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletCollisionPINVOKE.btTriangleMeshShape_localGetSupportingVertex(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(vec)), true);
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_btVector3 localGetSupportingVertexWithoutMargin(SWIGTYPE_p_btVector3 vec) {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletCollisionPINVOKE.btTriangleMeshShape_localGetSupportingVertexWithoutMargin(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(vec)), true);
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void recalcLocalAabb() {
    BulletCollisionPINVOKE.btTriangleMeshShape_recalcLocalAabb(swigCPtr);
  }

  public virtual void getAabb(SWIGTYPE_p_btTransform t, SWIGTYPE_p_btVector3 aabbMin, SWIGTYPE_p_btVector3 aabbMax) {
    BulletCollisionPINVOKE.btTriangleMeshShape_getAabb(swigCPtr, SWIGTYPE_p_btTransform.getCPtr(t), SWIGTYPE_p_btVector3.getCPtr(aabbMin), SWIGTYPE_p_btVector3.getCPtr(aabbMax));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void processAllTriangles(SWIGTYPE_p_btTriangleCallback callback, SWIGTYPE_p_btVector3 aabbMin, SWIGTYPE_p_btVector3 aabbMax) {
    BulletCollisionPINVOKE.btTriangleMeshShape_processAllTriangles(swigCPtr, SWIGTYPE_p_btTriangleCallback.getCPtr(callback), SWIGTYPE_p_btVector3.getCPtr(aabbMin), SWIGTYPE_p_btVector3.getCPtr(aabbMax));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void calculateLocalInertia(float mass, SWIGTYPE_p_btVector3 inertia) {
    BulletCollisionPINVOKE.btTriangleMeshShape_calculateLocalInertia(swigCPtr, mass, SWIGTYPE_p_btVector3.getCPtr(inertia));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setLocalScaling(SWIGTYPE_p_btVector3 scaling) {
    BulletCollisionPINVOKE.btTriangleMeshShape_setLocalScaling(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(scaling));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_btVector3 getLocalScaling() {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletCollisionPINVOKE.btTriangleMeshShape_getLocalScaling(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_btStridingMeshInterface getMeshInterface() {
    IntPtr cPtr = BulletCollisionPINVOKE.btTriangleMeshShape_getMeshInterface__SWIG_0(swigCPtr);
    SWIGTYPE_p_btStridingMeshInterface ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btStridingMeshInterface(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_btVector3 getLocalAabbMin() {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletCollisionPINVOKE.btTriangleMeshShape_getLocalAabbMin(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_btVector3 getLocalAabbMax() {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletCollisionPINVOKE.btTriangleMeshShape_getLocalAabbMax(swigCPtr), false);
    return ret;
  }

  public virtual string getName() {
    string ret = BulletCollisionPINVOKE.btTriangleMeshShape_getName(swigCPtr);
    return ret;
  }

}

}
