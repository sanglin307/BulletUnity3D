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

public class btClock : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btClock(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btClock obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btClock() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LinearMathPINVOKE.delete_btClock(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btClock() : this(LinearMathPINVOKE.new_btClock__SWIG_0(), true) {
  }

  public btClock(btClock other) : this(LinearMathPINVOKE.new_btClock__SWIG_1(btClock.getCPtr(other)), true) {
    if (LinearMathPINVOKE.SWIGPendingException.Pending) throw LinearMathPINVOKE.SWIGPendingException.Retrieve();
  }

  public void reset() {
    LinearMathPINVOKE.btClock_reset(swigCPtr);
  }

  public uint getTimeMilliseconds() {
    uint ret = LinearMathPINVOKE.btClock_getTimeMilliseconds(swigCPtr);
    return ret;
  }

  public uint getTimeMicroseconds() {
    uint ret = LinearMathPINVOKE.btClock_getTimeMicroseconds(swigCPtr);
    return ret;
  }

}

}