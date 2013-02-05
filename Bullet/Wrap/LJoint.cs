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

public class LJoint : Joint {
  private HandleRef swigCPtr;

  internal LJoint(IntPtr cPtr, bool cMemoryOwn) : base(BulletSoftBodyPINVOKE.LJoint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(LJoint obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~LJoint() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletSoftBodyPINVOKE.delete_LJoint(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public SWIGTYPE_p_btVector3 m_rpos {
    set {
      BulletSoftBodyPINVOKE.LJoint_m_rpos_set(swigCPtr, SWIGTYPE_p_btVector3.getCPtr(value));
    } 
    get {
      IntPtr cPtr = BulletSoftBodyPINVOKE.LJoint_m_rpos_get(swigCPtr);
      SWIGTYPE_p_btVector3 ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btVector3(cPtr, false);
      return ret;
    } 
  }

  public override void Prepare(float dt, int iterations) {
    BulletSoftBodyPINVOKE.LJoint_Prepare(swigCPtr, dt, iterations);
  }

  public override void Solve(float dt, float sor) {
    BulletSoftBodyPINVOKE.LJoint_Solve(swigCPtr, dt, sor);
  }

  public override void Terminate(float dt) {
    BulletSoftBodyPINVOKE.LJoint_Terminate(swigCPtr, dt);
  }

  public override SWIGTYPE_p_Joint__eType___ Type() {
    SWIGTYPE_p_Joint__eType___ ret = new SWIGTYPE_p_Joint__eType___(BulletSoftBodyPINVOKE.LJoint_Type(swigCPtr), true);
    return ret;
  }

  public LJoint() : this(BulletSoftBodyPINVOKE.new_LJoint(), true) {
  }

}

}