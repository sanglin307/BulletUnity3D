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

public class btHashInt : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btHashInt(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btHashInt obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btHashInt() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LinearMathPINVOKE.delete_btHashInt(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btHashInt(int uid) : this(LinearMathPINVOKE.new_btHashInt(uid), true) {
  }

  public int getUid1() {
    int ret = LinearMathPINVOKE.btHashInt_getUid1(swigCPtr);
    return ret;
  }

  public void setUid1(int uid) {
    LinearMathPINVOKE.btHashInt_setUid1(swigCPtr, uid);
  }

  public bool equals(btHashInt other) {
    bool ret = LinearMathPINVOKE.btHashInt_equals(swigCPtr, btHashInt.getCPtr(other));
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getHash() {
    uint ret = LinearMathPINVOKE.btHashInt_getHash(swigCPtr);
    return ret;
  }

}

}
