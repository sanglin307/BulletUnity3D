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

public class btTypedObject : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btTypedObject(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btTypedObject obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btTypedObject() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LinearMathPINVOKE.delete_btTypedObject(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btTypedObject(int objectType) : this(LinearMathPINVOKE.new_btTypedObject(objectType), true) {
  }

  public int m_objectType {
    set {
      LinearMathPINVOKE.btTypedObject_m_objectType_set(swigCPtr, value);
    } 
    get {
      int ret = LinearMathPINVOKE.btTypedObject_m_objectType_get(swigCPtr);
      return ret;
    } 
  }

  public int getObjectType() {
    int ret = LinearMathPINVOKE.btTypedObject_getObjectType(swigCPtr);
    return ret;
  }

}

}
