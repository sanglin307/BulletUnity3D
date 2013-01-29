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

public class btAlignedObjectArraybtFace : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal btAlignedObjectArraybtFace(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(btAlignedObjectArraybtFace obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~btAlignedObjectArraybtFace() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BulletCollisionPINVOKE.delete_btAlignedObjectArraybtFace(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public btAlignedObjectArraybtFace() : this(BulletCollisionPINVOKE.new_btAlignedObjectArraybtFace__SWIG_0(), true) {
  }

  public btAlignedObjectArraybtFace(btAlignedObjectArraybtFace otherArray) : this(BulletCollisionPINVOKE.new_btAlignedObjectArraybtFace__SWIG_1(btAlignedObjectArraybtFace.getCPtr(otherArray)), true) {
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public int size() {
    int ret = BulletCollisionPINVOKE.btAlignedObjectArraybtFace_size(swigCPtr);
    return ret;
  }

  public btFace at(int n) {
    btFace ret = new btFace(BulletCollisionPINVOKE.btAlignedObjectArraybtFace_at__SWIG_0(swigCPtr, n), false);
    return ret;
  }

  public void clear() {
    BulletCollisionPINVOKE.btAlignedObjectArraybtFace_clear(swigCPtr);
  }

  public void pop_back() {
    BulletCollisionPINVOKE.btAlignedObjectArraybtFace_pop_back(swigCPtr);
  }

  public void resizeNoInitialize(int newsize) {
    BulletCollisionPINVOKE.btAlignedObjectArraybtFace_resizeNoInitialize(swigCPtr, newsize);
  }

  public void resize(int newsize, btFace fillData) {
    BulletCollisionPINVOKE.btAlignedObjectArraybtFace_resize__SWIG_0(swigCPtr, newsize, btFace.getCPtr(fillData));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void resize(int newsize) {
    BulletCollisionPINVOKE.btAlignedObjectArraybtFace_resize__SWIG_1(swigCPtr, newsize);
  }

  public btFace expandNonInitializing() {
    btFace ret = new btFace(BulletCollisionPINVOKE.btAlignedObjectArraybtFace_expandNonInitializing(swigCPtr), false);
    return ret;
  }

  public btFace expand(btFace fillValue) {
    btFace ret = new btFace(BulletCollisionPINVOKE.btAlignedObjectArraybtFace_expand__SWIG_0(swigCPtr, btFace.getCPtr(fillValue)), false);
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public btFace expand() {
    btFace ret = new btFace(BulletCollisionPINVOKE.btAlignedObjectArraybtFace_expand__SWIG_1(swigCPtr), false);
    return ret;
  }

  public void push_back(btFace _Val) {
    BulletCollisionPINVOKE.btAlignedObjectArraybtFace_push_back(swigCPtr, btFace.getCPtr(_Val));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public int capacity() {
    int ret = BulletCollisionPINVOKE.btAlignedObjectArraybtFace_capacity(swigCPtr);
    return ret;
  }

  public void reserve(int _Count) {
    BulletCollisionPINVOKE.btAlignedObjectArraybtFace_reserve(swigCPtr, _Count);
  }

  public void swap(int index0, int index1) {
    BulletCollisionPINVOKE.btAlignedObjectArraybtFace_swap(swigCPtr, index0, index1);
  }

  public int findBinarySearch(btFace key) {
    int ret = BulletCollisionPINVOKE.btAlignedObjectArraybtFace_findBinarySearch(swigCPtr, btFace.getCPtr(key));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int findLinearSearch(btFace key) {
    int ret = BulletCollisionPINVOKE.btAlignedObjectArraybtFace_findLinearSearch(swigCPtr, btFace.getCPtr(key));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void remove(btFace key) {
    BulletCollisionPINVOKE.btAlignedObjectArraybtFace_remove(swigCPtr, btFace.getCPtr(key));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void initializeFromBuffer(SWIGTYPE_p_void buffer, int size, int capacity) {
    BulletCollisionPINVOKE.btAlignedObjectArraybtFace_initializeFromBuffer(swigCPtr, SWIGTYPE_p_void.getCPtr(buffer), size, capacity);
  }

  public void copyFromArray(btAlignedObjectArraybtFace otherArray) {
    BulletCollisionPINVOKE.btAlignedObjectArraybtFace_copyFromArray(swigCPtr, btAlignedObjectArraybtFace.getCPtr(otherArray));
    if (BulletCollisionPINVOKE.SWIGPendingException.Pending) throw BulletCollisionPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
