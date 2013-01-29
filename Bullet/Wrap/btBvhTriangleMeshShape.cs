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

public class btBvhTriangleMeshShape : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;
  private SWIGTYPE_p_btCollisionShape swigWrapPtr;

  internal btBvhTriangleMeshShape(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
    swigWrapPtr = new SWIGTYPE_p_btCollisionShape(cPtr, true);
  }

  public SWIGTYPE_p_btCollisionShape GetSwigPtr()
  {
      return swigWrapPtr;
  }

  internal static HandleRef getCPtr(btBvhTriangleMeshShape obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btBvhTriangleMeshShape() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletCollisionPINVOKE.delete_btBvhTriangleMeshShape(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
        swigWrapPtr = new SWIGTYPE_p_btCollisionShape(IntPtr.Zero, true);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btBvhTriangleMeshShape(SWIGTYPE_p_btStridingMeshInterface meshInterface, bool useQuantizedAabbCompression, bool buildBvh) : this(BulletCollisionPINVOKE.new_btBvhTriangleMeshShape__SWIG_0(SWIGTYPE_p_btStridingMeshInterface.getCPtr(meshInterface), useQuantizedAabbCompression, buildBvh), true) {
  }

  public btBvhTriangleMeshShape(SWIGTYPE_p_btStridingMeshInterface meshInterface, bool useQuantizedAabbCompression) : this(BulletCollisionPINVOKE.new_btBvhTriangleMeshShape__SWIG_1(SWIGTYPE_p_btStridingMeshInterface.getCPtr(meshInterface), useQuantizedAabbCompression), true) {
  }

  public btBvhTriangleMeshShape(SWIGTYPE_p_btStridingMeshInterface meshInterface, bool useQuantizedAabbCompression, SWIGTYPE_p_btVector3 bvhAabbMin, SWIGTYPE_p_btVector3 bvhAabbMax, bool buildBvh) : this(BulletCollisionPINVOKE.new_btBvhTriangleMeshShape__SWIG_2(SWIGTYPE_p_btStridingMeshInterface.getCPtr(meshInterface), useQuantizedAabbCompression, SWIGTYPE_p_btVector3.getCPtr(bvhAabbMin), SWIGTYPE_p_btVector3.getCPtr(bvhAabbMax), buildBvh), true) {
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public btBvhTriangleMeshShape(SWIGTYPE_p_btStridingMeshInterface meshInterface, bool useQuantizedAabbCompression, SWIGTYPE_p_btVector3 bvhAabbMin, SWIGTYPE_p_btVector3 bvhAabbMax) : this(BulletCollisionPINVOKE.new_btBvhTriangleMeshShape__SWIG_3(SWIGTYPE_p_btStridingMeshInterface.getCPtr(meshInterface), useQuantizedAabbCompression, SWIGTYPE_p_btVector3.getCPtr(bvhAabbMin), SWIGTYPE_p_btVector3.getCPtr(bvhAabbMax)), true) {
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getOwnsBvh() {
    bool ret = BulletCollisionPINVOKE.btBvhTriangleMeshShape_getOwnsBvh(swigCPtr);
    return ret;
  }

  public void performRaycast(SWIGTYPE_p_btTriangleCallback callback, SWIGTYPE_p_btVector3 raySource, SWIGTYPE_p_btVector3 rayTarget) {
    BulletCollisionPINVOKE.btBvhTriangleMeshShape_performRaycast(swigCPtr, SWIGTYPE_p_btTriangleCallback.getCPtr(callback), SWIGTYPE_p_btVector3.getCPtr(raySource), SWIGTYPE_p_btVector3.getCPtr(rayTarget));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void performConvexcast(SWIGTYPE_p_btTriangleCallback callback, SWIGTYPE_p_btVector3 boxSource, SWIGTYPE_p_btVector3 boxTarget, SWIGTYPE_p_btVector3 boxMin, SWIGTYPE_p_btVector3 boxMax) {
    BulletCollisionPINVOKE.btBvhTriangleMeshShape_performConvexcast(swigCPtr, SWIGTYPE_p_btTriangleCallback.getCPtr(callback), SWIGTYPE_p_btVector3.getCPtr(boxSource), SWIGTYPE_p_btVector3.getCPtr(boxTarget), SWIGTYPE_p_btVector3.getCPtr(boxMin), SWIGTYPE_p_btVector3.getCPtr(boxMax));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void processAllTriangles(SWIGTYPE_p_btTriangleCallback callback, SWIGTYPE_p_btVector3 aabbMin, SWIGTYPE_p_btVector3 aabbMax) {
    BulletCollisionPINVOKE.btBvhTriangleMeshShape_processAllTriangles(swigCPtr, SWIGTYPE_p_btTriangleCallback.getCPtr(callback), SWIGTYPE_p_btVector3.getCPtr(aabbMin), SWIGTYPE_p_btVector3.getCPtr(aabbMax));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void refitTree(SWIGTYPE_p_btVector3 aabbMin, SWIGTYPE_p_btVector3 aabbMax) {
    BulletCollisionPINVOKE.btBvhTriangleMeshShape_refitTree(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(aabbMin), SWIGTYPE_p_btVector3.getCPtr(aabbMax));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void partialRefitTree(SWIGTYPE_p_btVector3 aabbMin, SWIGTYPE_p_btVector3 aabbMax) {
    BulletCollisionPINVOKE.btBvhTriangleMeshShape_partialRefitTree(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(aabbMin), SWIGTYPE_p_btVector3.getCPtr(aabbMax));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string getName() {
    string ret = BulletCollisionPINVOKE.btBvhTriangleMeshShape_getName(swigCPtr);
    return ret;
  }

  public virtual void setLocalScaling(SWIGTYPE_p_btVector3 scaling) {
    BulletCollisionPINVOKE.btBvhTriangleMeshShape_setLocalScaling(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(scaling));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_btOptimizedBvh getOptimizedBvh() {
    IntPtr cPtr = BulletCollisionPINVOKE.btBvhTriangleMeshShape_getOptimizedBvh(swigCPtr);
    SWIGTYPE_p_btOptimizedBvh ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btOptimizedBvh(cPtr, false);
    return ret;
  }

  public void setOptimizedBvh(SWIGTYPE_p_btOptimizedBvh bvh, SWIGTYPE_p_btVector3 localScaling) {
    BulletCollisionPINVOKE.btBvhTriangleMeshShape_setOptimizedBvh__SWIG_0(swigCPtr, SWIGTYPE_p_btOptimizedBvh.getCPtr(bvh), SWIGTYPE_p_btVector3.getCPtr(localScaling));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setOptimizedBvh(SWIGTYPE_p_btOptimizedBvh bvh) {
    BulletCollisionPINVOKE.btBvhTriangleMeshShape_setOptimizedBvh__SWIG_1(swigCPtr, SWIGTYPE_p_btOptimizedBvh.getCPtr(bvh));
  }

  public void buildOptimizedBvh() {
    BulletCollisionPINVOKE.btBvhTriangleMeshShape_buildOptimizedBvh(swigCPtr);
  }

  public bool usesQuantizedAabbCompression() {
    bool ret = BulletCollisionPINVOKE.btBvhTriangleMeshShape_usesQuantizedAabbCompression(swigCPtr);
    return ret;
  }

  public void setTriangleInfoMap(SWIGTYPE_p_btTriangleInfoMap triangleInfoMap) {
    BulletCollisionPINVOKE.btBvhTriangleMeshShape_setTriangleInfoMap(swigCPtr, SWIGTYPE_p_btTriangleInfoMap.getCPtr(triangleInfoMap));
  }

  public SWIGTYPE_p_btTriangleInfoMap getTriangleInfoMap() {
    IntPtr cPtr = BulletCollisionPINVOKE.btBvhTriangleMeshShape_getTriangleInfoMap__SWIG_0(swigCPtr);
    SWIGTYPE_p_btTriangleInfoMap ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btTriangleInfoMap(cPtr, false);
    return ret;
  }

  public virtual int calculateSerializeBufferSize() {
    int ret = BulletCollisionPINVOKE.btBvhTriangleMeshShape_calculateSerializeBufferSize(swigCPtr);
    return ret;
  }

  public virtual string serialize(SWIGTYPE_p_void dataBuffer, SWIGTYPE_p_btSerializer serializer) {
    string ret = BulletCollisionPINVOKE.btBvhTriangleMeshShape_serialize(swigCPtr, SWIGTYPE_p_void.getCPtr(dataBuffer), SWIGTYPE_p_btSerializer.getCPtr(serializer));
    return ret;
  }

  public virtual void serializeSingleBvh(SWIGTYPE_p_btSerializer serializer) {
    BulletCollisionPINVOKE.btBvhTriangleMeshShape_serializeSingleBvh(swigCPtr, SWIGTYPE_p_btSerializer.getCPtr(serializer));
  }

  public virtual void serializeSingleTriangleInfoMap(SWIGTYPE_p_btSerializer serializer) {
    BulletCollisionPINVOKE.btBvhTriangleMeshShape_serializeSingleTriangleInfoMap(swigCPtr, SWIGTYPE_p_btSerializer.getCPtr(serializer));
  }

}

}
