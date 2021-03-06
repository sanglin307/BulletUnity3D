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

public class btDiscreteDynamicsWorld : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btDiscreteDynamicsWorld(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }


  // convert swigtype to object , linyuan add 
  public static btDiscreteDynamicsWorld GetObjectFromSwigPtr(SWIGTYPE_p_btDiscreteDynamicsWorld ptr)
  {
      HandleRef handle = SWIGTYPE_p_btDiscreteDynamicsWorld.getCPtr(ptr);
      if (handle.Wrapper == null || handle.Handle == IntPtr.Zero)
      {
          return null;
      }

      return new btDiscreteDynamicsWorld(handle.Handle, false);
  }

 

  internal static HandleRef getCPtr(btDiscreteDynamicsWorld obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btDiscreteDynamicsWorld() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletDynamicsPINVOKE.delete_btDiscreteDynamicsWorld(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btDiscreteDynamicsWorld(SWIGTYPE_p_btDispatcher dispatcher, SWIGTYPE_p_btBroadphaseInterface pairCache, SWIGTYPE_p_btConstraintSolver constraintSolver, SWIGTYPE_p_btCollisionConfiguration collisionConfiguration) : this(BulletDynamicsPINVOKE.new_btDiscreteDynamicsWorld(SWIGTYPE_p_btDispatcher.getCPtr(dispatcher), SWIGTYPE_p_btBroadphaseInterface.getCPtr(pairCache), SWIGTYPE_p_btConstraintSolver.getCPtr(constraintSolver), SWIGTYPE_p_btCollisionConfiguration.getCPtr(collisionConfiguration)), true) {
  }

  public virtual int stepSimulation(float timeStep, int maxSubSteps, float fixedTimeStep) {
    int ret = BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_stepSimulation__SWIG_0(swigCPtr, timeStep, maxSubSteps, fixedTimeStep);
    return ret;
  }

  public virtual int stepSimulation(float timeStep, int maxSubSteps) {
    int ret = BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_stepSimulation__SWIG_1(swigCPtr, timeStep, maxSubSteps);
    return ret;
  }

  public virtual int stepSimulation(float timeStep) {
    int ret = BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_stepSimulation__SWIG_2(swigCPtr, timeStep);
    return ret;
  }

  public virtual void synchronizeMotionStates() {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_synchronizeMotionStates(swigCPtr);
  }

  public void synchronizeSingleMotionState(btRigidBody body) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_synchronizeSingleMotionState(swigCPtr, btRigidBody.getCPtr(body));
  }

  public virtual void addConstraint(SWIGTYPE_p_btTypedConstraint constraint, bool disableCollisionsBetweenLinkedBodies) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_addConstraint__SWIG_0(swigCPtr, SWIGTYPE_p_btTypedConstraint.getCPtr(constraint), disableCollisionsBetweenLinkedBodies);
  }

  public virtual void addConstraint(SWIGTYPE_p_btTypedConstraint constraint) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_addConstraint__SWIG_1(swigCPtr, SWIGTYPE_p_btTypedConstraint.getCPtr(constraint));
  }

  public virtual void removeConstraint(SWIGTYPE_p_btTypedConstraint constraint) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_removeConstraint(swigCPtr, SWIGTYPE_p_btTypedConstraint.getCPtr(constraint));
  }

  public virtual void addAction(SWIGTYPE_p_btActionInterface arg0) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_addAction(swigCPtr, SWIGTYPE_p_btActionInterface.getCPtr(arg0));
  }

  public virtual void removeAction(SWIGTYPE_p_btActionInterface arg0) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_removeAction(swigCPtr, SWIGTYPE_p_btActionInterface.getCPtr(arg0));
  }

  public SWIGTYPE_p_btSimulationIslandManager getSimulationIslandManager() {
    IntPtr cPtr = BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_getSimulationIslandManager__SWIG_0(swigCPtr);
    SWIGTYPE_p_btSimulationIslandManager ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btSimulationIslandManager(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_btCollisionWorld getCollisionWorld() {
    IntPtr cPtr = BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_getCollisionWorld(swigCPtr);
    SWIGTYPE_p_btCollisionWorld ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btCollisionWorld(cPtr, false);
    return ret;
  }

  public virtual void setGravity(SWIGTYPE_p_btVector3 gravity) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_setGravity(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(gravity));
    if (BulletDynamicsPINVOKE.SWIGPendingException.Pending) throw BulletDynamicsPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_btVector3 getGravity() {
    SWIGTYPE_p_btVector3 ret = new SWIGTYPE_p_btVector3(BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_getGravity(swigCPtr), true);
    return ret;
  }

  public virtual void addCollisionObject(SWIGTYPE_p_btCollisionObject collisionObject, short collisionFilterGroup, short collisionFilterMask) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_addCollisionObject__SWIG_0(swigCPtr, SWIGTYPE_p_btCollisionObject.getCPtr(collisionObject), collisionFilterGroup, collisionFilterMask);
  }

  public virtual void addCollisionObject(SWIGTYPE_p_btCollisionObject collisionObject, short collisionFilterGroup) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_addCollisionObject__SWIG_1(swigCPtr, SWIGTYPE_p_btCollisionObject.getCPtr(collisionObject), collisionFilterGroup);
  }

  public virtual void addCollisionObject(SWIGTYPE_p_btCollisionObject collisionObject) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_addCollisionObject__SWIG_2(swigCPtr, SWIGTYPE_p_btCollisionObject.getCPtr(collisionObject));
  }

  public virtual void addRigidBody(btRigidBody body) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_addRigidBody__SWIG_0(swigCPtr, btRigidBody.getCPtr(body));
  }

  public virtual void addRigidBody(btRigidBody body, short group, short mask) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_addRigidBody__SWIG_1(swigCPtr, btRigidBody.getCPtr(body), group, mask);
  }

  public virtual void removeRigidBody(btRigidBody body) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_removeRigidBody(swigCPtr, btRigidBody.getCPtr(body));
  }

  public virtual void removeCollisionObject(SWIGTYPE_p_btCollisionObject collisionObject) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_removeCollisionObject(swigCPtr, SWIGTYPE_p_btCollisionObject.getCPtr(collisionObject));
  }

  public void debugDrawConstraint(SWIGTYPE_p_btTypedConstraint constraint) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_debugDrawConstraint(swigCPtr, SWIGTYPE_p_btTypedConstraint.getCPtr(constraint));
  }

  public virtual void debugDrawWorld() {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_debugDrawWorld(swigCPtr);
  }

  public virtual void setConstraintSolver(SWIGTYPE_p_btConstraintSolver solver) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_setConstraintSolver(swigCPtr, SWIGTYPE_p_btConstraintSolver.getCPtr(solver));
  }

  public virtual SWIGTYPE_p_btConstraintSolver getConstraintSolver() {
    IntPtr cPtr = BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_getConstraintSolver(swigCPtr);
    SWIGTYPE_p_btConstraintSolver ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btConstraintSolver(cPtr, false);
    return ret;
  }

  public virtual int getNumConstraints() {
    int ret = BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_getNumConstraints(swigCPtr);
    return ret;
  }

  public virtual SWIGTYPE_p_btTypedConstraint getConstraint(int index) {
    IntPtr cPtr = BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_getConstraint__SWIG_0(swigCPtr, index);
    SWIGTYPE_p_btTypedConstraint ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btTypedConstraint(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_btDynamicsWorldType getWorldType() {
    SWIGTYPE_p_btDynamicsWorldType ret = new SWIGTYPE_p_btDynamicsWorldType(BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_getWorldType(swigCPtr), true);
    return ret;
  }

  public virtual void clearForces() {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_clearForces(swigCPtr);
  }

  public virtual void applyGravity() {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_applyGravity(swigCPtr);
  }

  public virtual void setNumTasks(int numTasks) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_setNumTasks(swigCPtr, numTasks);
  }

  public virtual void updateVehicles(float timeStep) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_updateVehicles(swigCPtr, timeStep);
  }

  public virtual void addVehicle(SWIGTYPE_p_btActionInterface vehicle) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_addVehicle(swigCPtr, SWIGTYPE_p_btActionInterface.getCPtr(vehicle));
  }

  public virtual void removeVehicle(SWIGTYPE_p_btActionInterface vehicle) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_removeVehicle(swigCPtr, SWIGTYPE_p_btActionInterface.getCPtr(vehicle));
  }

  public virtual void addCharacter(SWIGTYPE_p_btActionInterface character) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_addCharacter(swigCPtr, SWIGTYPE_p_btActionInterface.getCPtr(character));
  }

  public virtual void removeCharacter(SWIGTYPE_p_btActionInterface character) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_removeCharacter(swigCPtr, SWIGTYPE_p_btActionInterface.getCPtr(character));
  }

  public void setSynchronizeAllMotionStates(bool synchronizeAll) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_setSynchronizeAllMotionStates(swigCPtr, synchronizeAll);
  }

  public bool getSynchronizeAllMotionStates() {
    bool ret = BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_getSynchronizeAllMotionStates(swigCPtr);
    return ret;
  }

  public void setApplySpeculativeContactRestitution(bool enable) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_setApplySpeculativeContactRestitution(swigCPtr, enable);
  }

  public bool getApplySpeculativeContactRestitution() {
    bool ret = BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_getApplySpeculativeContactRestitution(swigCPtr);
    return ret;
  }

  public virtual void serialize(SWIGTYPE_p_btSerializer serializer) {
    BulletDynamicsPINVOKE.btDiscreteDynamicsWorld_serialize(swigCPtr, SWIGTYPE_p_btSerializer.getCPtr(serializer));
  }

}

}
