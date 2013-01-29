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

public class btCollisionObject : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btCollisionObject(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btCollisionObject obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btCollisionObject() {
    Dispose();
  }

  public static btCollisionObject GetObjectFromSwigPtr(SWIGTYPE_p_btCollisionObject ptr)
  {
      HandleRef handle = SWIGTYPE_p_btCollisionObject.getCPtr(ptr);
      if (handle.Wrapper == null || handle.Handle == IntPtr.Zero)
      {
          return null;
      }

      return new btCollisionObject(handle.Handle, false);
  }
		
  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletCollisionPINVOKE.delete_btCollisionObject(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public bool mergesSimulationIslands() {
    bool ret = BulletCollisionPINVOKE.btCollisionObject_mergesSimulationIslands(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_btVector3 getAnisotropicFriction() {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletCollisionPINVOKE.btCollisionObject_getAnisotropicFriction(swigCPtr), false);
    return ret;
  }

  public void setAnisotropicFriction(SWIGTYPE_p_btVector3 anisotropicFriction, int frictionMode) {
    BulletCollisionPINVOKE.btCollisionObject_setAnisotropicFriction__SWIG_0(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(anisotropicFriction), frictionMode);
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setAnisotropicFriction(SWIGTYPE_p_btVector3 anisotropicFriction) {
    BulletCollisionPINVOKE.btCollisionObject_setAnisotropicFriction__SWIG_1(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(anisotropicFriction));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool hasAnisotropicFriction(int frictionMode) {
    bool ret = BulletCollisionPINVOKE.btCollisionObject_hasAnisotropicFriction__SWIG_0(swigCPtr, frictionMode);
    return ret;
  }

  public bool hasAnisotropicFriction() {
    bool ret = BulletCollisionPINVOKE.btCollisionObject_hasAnisotropicFriction__SWIG_1(swigCPtr);
    return ret;
  }

  public void setContactProcessingThreshold(float contactProcessingThreshold) {
    BulletCollisionPINVOKE.btCollisionObject_setContactProcessingThreshold(swigCPtr, contactProcessingThreshold);
  }

  public float getContactProcessingThreshold() {
    float ret = BulletCollisionPINVOKE.btCollisionObject_getContactProcessingThreshold(swigCPtr);
    return ret;
  }

  public bool isStaticObject() {
    bool ret = BulletCollisionPINVOKE.btCollisionObject_isStaticObject(swigCPtr);
    return ret;
  }

  public bool isKinematicObject() {
    bool ret = BulletCollisionPINVOKE.btCollisionObject_isKinematicObject(swigCPtr);
    return ret;
  }

  public bool isStaticOrKinematicObject() {
    bool ret = BulletCollisionPINVOKE.btCollisionObject_isStaticOrKinematicObject(swigCPtr);
    return ret;
  }

  public bool hasContactResponse() {
    bool ret = BulletCollisionPINVOKE.btCollisionObject_hasContactResponse(swigCPtr);
    return ret;
  }

  public btCollisionObject() : this(BulletCollisionPINVOKE.new_btCollisionObject(), true) {
  }

  public virtual void setCollisionShape(SWIGTYPE_p_btCollisionShape collisionShape) {
    BulletCollisionPINVOKE.btCollisionObject_setCollisionShape(swigCPtr, SWIGTYPE_p_btCollisionShape.getCPtr(collisionShape));
  }

  public SWIGTYPE_p_btCollisionShape getCollisionShape() {
    IntPtr cPtr = BulletCollisionPINVOKE.btCollisionObject_getCollisionShape__SWIG_0(swigCPtr);
    SWIGTYPE_p_btCollisionShape ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btCollisionShape(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_void internalGetExtensionPointer() {
    IntPtr cPtr = BulletCollisionPINVOKE.btCollisionObject_internalGetExtensionPointer(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public void internalSetExtensionPointer(SWIGTYPE_p_void pointer) {
    BulletCollisionPINVOKE.btCollisionObject_internalSetExtensionPointer(swigCPtr, SWIGTYPE_p_void.getCPtr(pointer));
  }

  public int getActivationState() {
    int ret = BulletCollisionPINVOKE.btCollisionObject_getActivationState(swigCPtr);
    return ret;
  }

  public void setActivationState(int newState) {
    BulletCollisionPINVOKE.btCollisionObject_setActivationState(swigCPtr, newState);
  }

  public void setDeactivationTime(float time) {
    BulletCollisionPINVOKE.btCollisionObject_setDeactivationTime(swigCPtr, time);
  }

  public float getDeactivationTime() {
    float ret = BulletCollisionPINVOKE.btCollisionObject_getDeactivationTime(swigCPtr);
    return ret;
  }

  public void forceActivationState(int newState) {
    BulletCollisionPINVOKE.btCollisionObject_forceActivationState(swigCPtr, newState);
  }

  public void activate(bool forceActivation) {
    BulletCollisionPINVOKE.btCollisionObject_activate__SWIG_0(swigCPtr, forceActivation);
  }

  public void activate() {
    BulletCollisionPINVOKE.btCollisionObject_activate__SWIG_1(swigCPtr);
  }

  public bool isActive() {
    bool ret = BulletCollisionPINVOKE.btCollisionObject_isActive(swigCPtr);
    return ret;
  }

  public void setRestitution(float rest) {
    BulletCollisionPINVOKE.btCollisionObject_setRestitution(swigCPtr, rest);
  }

  public float getRestitution() {
    float ret = BulletCollisionPINVOKE.btCollisionObject_getRestitution(swigCPtr);
    return ret;
  }

  public void setFriction(float frict) {
    BulletCollisionPINVOKE.btCollisionObject_setFriction(swigCPtr, frict);
  }

  public float getFriction() {
    float ret = BulletCollisionPINVOKE.btCollisionObject_getFriction(swigCPtr);
    return ret;
  }

  public void setRollingFriction(float frict) {
    BulletCollisionPINVOKE.btCollisionObject_setRollingFriction(swigCPtr, frict);
  }

  public float getRollingFriction() {
    float ret = BulletCollisionPINVOKE.btCollisionObject_getRollingFriction(swigCPtr);
    return ret;
  }

  public int getInternalType() {
    int ret = BulletCollisionPINVOKE.btCollisionObject_getInternalType(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_btTransform getWorldTransform() {
    SWIGTYPE_p_btTransform ret = new SWIGTYPE_p_btTransform(BulletCollisionPINVOKE.btCollisionObject_getWorldTransform__SWIG_0(swigCPtr), false);
    return ret;
  }

  public void setWorldTransform(SWIGTYPE_p_btTransform worldTrans) {
    BulletCollisionPINVOKE.btCollisionObject_setWorldTransform(swigCPtr, SWIGTYPE_p_btTransform.getCPtr(worldTrans));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_btBroadphaseProxy getBroadphaseHandle() {
    IntPtr cPtr = BulletCollisionPINVOKE.btCollisionObject_getBroadphaseHandle__SWIG_0(swigCPtr);
    SWIGTYPE_p_btBroadphaseProxy ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btBroadphaseProxy(cPtr, false);
    return ret;
  }

  public void setBroadphaseHandle(SWIGTYPE_p_btBroadphaseProxy handle) {
    BulletCollisionPINVOKE.btCollisionObject_setBroadphaseHandle(swigCPtr, SWIGTYPE_p_btBroadphaseProxy.getCPtr(handle));
  }

  public SWIGTYPE_p_btTransform getInterpolationWorldTransform() {
    SWIGTYPE_p_btTransform ret = new SWIGTYPE_p_btTransform(BulletCollisionPINVOKE.btCollisionObject_getInterpolationWorldTransform__SWIG_0(swigCPtr), false);
    return ret;
  }

  public void setInterpolationWorldTransform(SWIGTYPE_p_btTransform trans) {
    BulletCollisionPINVOKE.btCollisionObject_setInterpolationWorldTransform(swigCPtr, SWIGTYPE_p_btTransform.getCPtr(trans));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setInterpolationLinearVelocity(SWIGTYPE_p_btVector3 linvel) {
    BulletCollisionPINVOKE.btCollisionObject_setInterpolationLinearVelocity(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(linvel));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setInterpolationAngularVelocity(SWIGTYPE_p_btVector3 angvel) {
    BulletCollisionPINVOKE.btCollisionObject_setInterpolationAngularVelocity(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(angvel));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_btVector3 getInterpolationLinearVelocity() {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletCollisionPINVOKE.btCollisionObject_getInterpolationLinearVelocity(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_btVector3 getInterpolationAngularVelocity() {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletCollisionPINVOKE.btCollisionObject_getInterpolationAngularVelocity(swigCPtr), false);
    return ret;
  }

  public int getIslandTag() {
    int ret = BulletCollisionPINVOKE.btCollisionObject_getIslandTag(swigCPtr);
    return ret;
  }

  public void setIslandTag(int tag) {
    BulletCollisionPINVOKE.btCollisionObject_setIslandTag(swigCPtr, tag);
  }

  public int getCompanionId() {
    int ret = BulletCollisionPINVOKE.btCollisionObject_getCompanionId(swigCPtr);
    return ret;
  }

  public void setCompanionId(int id) {
    BulletCollisionPINVOKE.btCollisionObject_setCompanionId(swigCPtr, id);
  }

  public float getHitFraction() {
    float ret = BulletCollisionPINVOKE.btCollisionObject_getHitFraction(swigCPtr);
    return ret;
  }

  public void setHitFraction(float hitFraction) {
    BulletCollisionPINVOKE.btCollisionObject_setHitFraction(swigCPtr, hitFraction);
  }

  public int getCollisionFlags() {
    int ret = BulletCollisionPINVOKE.btCollisionObject_getCollisionFlags(swigCPtr);
    return ret;
  }

  public void setCollisionFlags(int flags) {
    BulletCollisionPINVOKE.btCollisionObject_setCollisionFlags(swigCPtr, flags);
  }

  public float getCcdSweptSphereRadius() {
    float ret = BulletCollisionPINVOKE.btCollisionObject_getCcdSweptSphereRadius(swigCPtr);
    return ret;
  }

  public void setCcdSweptSphereRadius(float radius) {
    BulletCollisionPINVOKE.btCollisionObject_setCcdSweptSphereRadius(swigCPtr, radius);
  }

  public float getCcdMotionThreshold() {
    float ret = BulletCollisionPINVOKE.btCollisionObject_getCcdMotionThreshold(swigCPtr);
    return ret;
  }

  public float getCcdSquareMotionThreshold() {
    float ret = BulletCollisionPINVOKE.btCollisionObject_getCcdSquareMotionThreshold(swigCPtr);
    return ret;
  }

  public void setCcdMotionThreshold(float ccdMotionThreshold) {
    BulletCollisionPINVOKE.btCollisionObject_setCcdMotionThreshold(swigCPtr, ccdMotionThreshold);
  }

  public SWIGTYPE_p_void getUserPointer() {
    IntPtr cPtr = BulletCollisionPINVOKE.btCollisionObject_getUserPointer(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public void setUserPointer(SWIGTYPE_p_void userPointer) {
    BulletCollisionPINVOKE.btCollisionObject_setUserPointer(swigCPtr, SWIGTYPE_p_void.getCPtr(userPointer));
  }

  public bool checkCollideWith(btCollisionObject co) {
    bool ret = BulletCollisionPINVOKE.btCollisionObject_checkCollideWith(swigCPtr, btCollisionObject.getCPtr(co));
    return ret;
  }

  public virtual int calculateSerializeBufferSize() {
    int ret = BulletCollisionPINVOKE.btCollisionObject_calculateSerializeBufferSize(swigCPtr);
    return ret;
  }

  public virtual string serialize(SWIGTYPE_p_void dataBuffer, SWIGTYPE_p_btSerializer serializer) {
    string ret = BulletCollisionPINVOKE.btCollisionObject_serialize(swigCPtr, SWIGTYPE_p_void.getCPtr(dataBuffer), SWIGTYPE_p_btSerializer.getCPtr(serializer));
    return ret;
  }

  public virtual void serializeSingleObject(SWIGTYPE_p_btSerializer serializer) {
    BulletCollisionPINVOKE.btCollisionObject_serializeSingleObject(swigCPtr, SWIGTYPE_p_btSerializer.getCPtr(serializer));
  }

  public enum CollisionFlags {
    CF_STATIC_OBJECT = 1,
    CF_KINEMATIC_OBJECT = 2,
    CF_NO_CONTACT_RESPONSE = 4,
    CF_CUSTOM_MATERIAL_CALLBACK = 8,
    CF_CHARACTER_OBJECT = 16,
    CF_DISABLE_VISUALIZE_OBJECT = 32,
    CF_DISABLE_SPU_COLLISION_PROCESSING = 64
  }

  public enum CollisionObjectTypes {
    CO_COLLISION_OBJECT = 1,
    CO_RIGID_BODY = 2,
    CO_GHOST_OBJECT = 4,
    CO_SOFT_BODY = 8,
    CO_HF_FLUID = 16,
    CO_USER_TYPE = 32
  }

  public enum AnisotropicFrictionFlags {
    CF_ANISOTROPIC_FRICTION_DISABLED = 0,
    CF_ANISOTROPIC_FRICTION = 1,
    CF_ANISOTROPIC_ROLLING_FRICTION = 2
  }

}

}