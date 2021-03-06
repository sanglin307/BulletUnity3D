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

public class btSoftBodyJointData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btSoftBodyJointData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btSoftBodyJointData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btSoftBodyJointData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletSoftBodyPINVOKE.delete_btSoftBodyJointData(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_void m_bodyA {
    set {
      BulletSoftBodyPINVOKE.btSoftBodyJointData_m_bodyA_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      IntPtr cPtr = BulletSoftBodyPINVOKE.btSoftBodyJointData_m_bodyA_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_void m_bodyB {
    set {
      BulletSoftBodyPINVOKE.btSoftBodyJointData_m_bodyB_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      IntPtr cPtr = BulletSoftBodyPINVOKE.btSoftBodyJointData_m_bodyB_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_btVector3FloatData m_refs {
    set {
      BulletSoftBodyPINVOKE.btSoftBodyJointData_m_refs_set(swigCPtr, SWIGTYPE_p_btVector3FloatData.getCPtr(value));
    } 
    get {
      IntPtr cPtr = BulletSoftBodyPINVOKE.btSoftBodyJointData_m_refs_get(swigCPtr);
      SWIGTYPE_p_btVector3FloatData ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btVector3FloatData(cPtr, false);
      return ret;
    } 
  }

  public float m_cfm {
    set {
      BulletSoftBodyPINVOKE.btSoftBodyJointData_m_cfm_set(swigCPtr, value);
    } 
    get {
      float ret = BulletSoftBodyPINVOKE.btSoftBodyJointData_m_cfm_get(swigCPtr);
      return ret;
    } 
  }

  public float m_erp {
    set {
      BulletSoftBodyPINVOKE.btSoftBodyJointData_m_erp_set(swigCPtr, value);
    } 
    get {
      float ret = BulletSoftBodyPINVOKE.btSoftBodyJointData_m_erp_get(swigCPtr);
      return ret;
    } 
  }

  public float m_split {
    set {
      BulletSoftBodyPINVOKE.btSoftBodyJointData_m_split_set(swigCPtr, value);
    } 
    get {
      float ret = BulletSoftBodyPINVOKE.btSoftBodyJointData_m_split_get(swigCPtr);
      return ret;
    } 
  }

  public int m_delete {
    set {
      BulletSoftBodyPINVOKE.btSoftBodyJointData_m_delete_set(swigCPtr, value);
    } 
    get {
      int ret = BulletSoftBodyPINVOKE.btSoftBodyJointData_m_delete_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_btVector3FloatData m_relPosition {
    set {
      BulletSoftBodyPINVOKE.btSoftBodyJointData_m_relPosition_set(swigCPtr, SWIGTYPE_p_btVector3FloatData.getCPtr(value));
    } 
    get {
      IntPtr cPtr = BulletSoftBodyPINVOKE.btSoftBodyJointData_m_relPosition_get(swigCPtr);
      SWIGTYPE_p_btVector3FloatData ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_btVector3FloatData(cPtr, false);
      return ret;
    } 
  }

  public int m_bodyAtype {
    set {
      BulletSoftBodyPINVOKE.btSoftBodyJointData_m_bodyAtype_set(swigCPtr, value);
    } 
    get {
      int ret = BulletSoftBodyPINVOKE.btSoftBodyJointData_m_bodyAtype_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bodyBtype {
    set {
      BulletSoftBodyPINVOKE.btSoftBodyJointData_m_bodyBtype_set(swigCPtr, value);
    } 
    get {
      int ret = BulletSoftBodyPINVOKE.btSoftBodyJointData_m_bodyBtype_get(swigCPtr);
      return ret;
    } 
  }

  public int m_jointType {
    set {
      BulletSoftBodyPINVOKE.btSoftBodyJointData_m_jointType_set(swigCPtr, value);
    } 
    get {
      int ret = BulletSoftBodyPINVOKE.btSoftBodyJointData_m_jointType_get(swigCPtr);
      return ret;
    } 
  }

  public int m_pad {
    set {
      BulletSoftBodyPINVOKE.btSoftBodyJointData_m_pad_set(swigCPtr, value);
    } 
    get {
      int ret = BulletSoftBodyPINVOKE.btSoftBodyJointData_m_pad_get(swigCPtr);
      return ret;
    } 
  }

  public btSoftBodyJointData() : this(BulletSoftBodyPINVOKE.new_btSoftBodyJointData(), true) {
  }

}

}
