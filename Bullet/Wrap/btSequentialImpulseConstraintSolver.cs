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

public class btSequentialImpulseConstraintSolver : IDisposable {
  private HandleRef swigCPtr;
  private SWIGTYPE_p_btConstraintSolver swigWrapPtr;
  protected bool swigCMemOwn;

  internal btSequentialImpulseConstraintSolver(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
    swigWrapPtr = new SWIGTYPE_p_btConstraintSolver(cPtr, true);
  }

  public SWIGTYPE_p_btConstraintSolver GetSwigPtr()
  {
      return swigWrapPtr;
  }


  public static HandleRef getCPtr(btSequentialImpulseConstraintSolver obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btSequentialImpulseConstraintSolver() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletDynamicsPINVOKE.delete_btSequentialImpulseConstraintSolver(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
        swigWrapPtr = new SWIGTYPE_p_btConstraintSolver(IntPtr.Zero, true);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btSequentialImpulseConstraintSolver() : this(BulletDynamicsPINVOKE.new_btSequentialImpulseConstraintSolver(), true) {
  }

  public virtual float solveGroup(SWIGTYPE_p_p_btCollisionObject bodies, int numBodies, SWIGTYPE_p_p_btPersistentManifold manifold, int numManifolds, SWIGTYPE_p_p_btTypedConstraint constraints, int numConstraints, SWIGTYPE_p_btContactSolverInfo info, SWIGTYPE_p_btIDebugDraw debugDrawer, SWIGTYPE_p_btStackAlloc stackAlloc, SWIGTYPE_p_btDispatcher dispatcher) {
    float ret = BulletDynamicsPINVOKE.btSequentialImpulseConstraintSolver_solveGroup(swigCPtr, SWIGTYPE_p_p_btCollisionObject.getCPtr(bodies), numBodies, SWIGTYPE_p_p_btPersistentManifold.getCPtr(manifold), numManifolds, SWIGTYPE_p_p_btTypedConstraint.getCPtr(constraints), numConstraints, SWIGTYPE_p_btContactSolverInfo.getCPtr(info), SWIGTYPE_p_btIDebugDraw.getCPtr(debugDrawer), SWIGTYPE_p_btStackAlloc.getCPtr(stackAlloc), SWIGTYPE_p_btDispatcher.getCPtr(dispatcher));
    if (BulletDynamicsPINVOKE.SWIGPendingException.Pending) throw BulletDynamicsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void reset() {
    BulletDynamicsPINVOKE.btSequentialImpulseConstraintSolver_reset(swigCPtr);
  }

  public uint btRand2() {
    uint ret = BulletDynamicsPINVOKE.btSequentialImpulseConstraintSolver_btRand2(swigCPtr);
    return ret;
  }

  public int btRandInt2(int n) {
    int ret = BulletDynamicsPINVOKE.btSequentialImpulseConstraintSolver_btRandInt2(swigCPtr, n);
    return ret;
  }

  public void setRandSeed(uint seed) {
    BulletDynamicsPINVOKE.btSequentialImpulseConstraintSolver_setRandSeed(swigCPtr, seed);
  }

  public uint getRandSeed() {
    uint ret = BulletDynamicsPINVOKE.btSequentialImpulseConstraintSolver_getRandSeed(swigCPtr);
    return ret;
  }

}

}
