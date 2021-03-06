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

public class btSerializer : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btSerializer(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btSerializer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btSerializer() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LinearMathPINVOKE.delete_btSerializer(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual SWIGTYPE_p_unsigned_char getBufferPointer() {
    IntPtr cPtr = LinearMathPINVOKE.btSerializer_getBufferPointer(swigCPtr);
    SWIGTYPE_p_unsigned_char ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
    return ret;
  }

  public virtual int getCurrentBufferSize() {
    int ret = LinearMathPINVOKE.btSerializer_getCurrentBufferSize(swigCPtr);
    return ret;
  }

  public virtual btChunk allocate(uint size, int numElements) {
    IntPtr cPtr = LinearMathPINVOKE.btSerializer_allocate(swigCPtr, size, numElements);
    btChunk ret = (cPtr == IntPtr.Zero) ? null : new btChunk(cPtr, false);
    return ret;
  }

  public virtual void finalizeChunk(btChunk chunk, string structType, int chunkCode, SWIGTYPE_p_void oldPtr) {
    LinearMathPINVOKE.btSerializer_finalizeChunk(swigCPtr, btChunk.getCPtr(chunk), structType, chunkCode, SWIGTYPE_p_void.getCPtr(oldPtr));
  }

  public virtual SWIGTYPE_p_void findPointer(SWIGTYPE_p_void oldPtr) {
    IntPtr cPtr = LinearMathPINVOKE.btSerializer_findPointer(swigCPtr, SWIGTYPE_p_void.getCPtr(oldPtr));
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_void getUniquePointer(SWIGTYPE_p_void oldPtr) {
    IntPtr cPtr = LinearMathPINVOKE.btSerializer_getUniquePointer(swigCPtr, SWIGTYPE_p_void.getCPtr(oldPtr));
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public virtual void startSerialization() {
    LinearMathPINVOKE.btSerializer_startSerialization(swigCPtr);
  }

  public virtual void finishSerialization() {
    LinearMathPINVOKE.btSerializer_finishSerialization(swigCPtr);
  }

  public virtual string findNameForPointer(SWIGTYPE_p_void ptr) {
    string ret = LinearMathPINVOKE.btSerializer_findNameForPointer(swigCPtr, SWIGTYPE_p_void.getCPtr(ptr));
    return ret;
  }

  public virtual void registerNameForPointer(SWIGTYPE_p_void ptr, string name) {
    LinearMathPINVOKE.btSerializer_registerNameForPointer(swigCPtr, SWIGTYPE_p_void.getCPtr(ptr), name);
  }

  public virtual void serializeName(string ptr) {
    LinearMathPINVOKE.btSerializer_serializeName(swigCPtr, ptr);
  }

  public virtual int getSerializationFlags() {
    int ret = LinearMathPINVOKE.btSerializer_getSerializationFlags(swigCPtr);
    return ret;
  }

  public virtual void setSerializationFlags(int flags) {
    LinearMathPINVOKE.btSerializer_setSerializationFlags(swigCPtr, flags);
  }

}

}
