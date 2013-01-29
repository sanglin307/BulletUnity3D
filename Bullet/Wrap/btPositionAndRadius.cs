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

public class btPositionAndRadius : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btPositionAndRadius(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btPositionAndRadius obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btPositionAndRadius() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletCollisionPINVOKE.delete_btPositionAndRadius(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_btVector3FloatData m_pos {
    set {
      BulletCollisionPINVOKE.btPositionAndRadius_m_pos_set(swigCPtr, SWIGTYPE_p_btVector3FloatData.getCPtr(value));
      if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_btVector3FloatData ret = new SWIGTYPE_p_btVector3FloatData(BulletCollisionPINVOKE.btPositionAndRadius_m_pos_get(swigCPtr), true);
      if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float m_radius {
    set {
      BulletCollisionPINVOKE.btPositionAndRadius_m_radius_set(swigCPtr, value);
    } 
    get {
      float ret = BulletCollisionPINVOKE.btPositionAndRadius_m_radius_get(swigCPtr);
      return ret;
    } 
  }

  public btPositionAndRadius() : this(BulletCollisionPINVOKE.new_btPositionAndRadius(), true) {
  }

}

}