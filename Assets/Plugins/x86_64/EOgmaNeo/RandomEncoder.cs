//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace eogmaneo {

public class RandomEncoder : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RandomEncoder(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RandomEncoder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RandomEncoder() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          eogmaneoPINVOKE.delete_RandomEncoder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public void create(int inputWidth, int inputHeight, int hiddenWidth, int hiddenHeight, int chunkSize, int radius, float initMinWeight, float initMaxWeight, uint seed, bool normalize) {
    eogmaneoPINVOKE.RandomEncoder_create(swigCPtr, inputWidth, inputHeight, hiddenWidth, hiddenHeight, chunkSize, radius, initMinWeight, initMaxWeight, seed, normalize);
  }

  public void clearHiddenStates() {
    eogmaneoPINVOKE.RandomEncoder_clearHiddenStates(swigCPtr);
  }

  public StdVeci activate(StdVecf input, ComputeSystem system, bool useDistanceMetric) {
    StdVeci ret = new StdVeci(eogmaneoPINVOKE.RandomEncoder_activate__SWIG_0(swigCPtr, StdVecf.getCPtr(input), ComputeSystem.getCPtr(system), useDistanceMetric), false);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StdVeci activate(StdVecf input, ComputeSystem system) {
    StdVeci ret = new StdVeci(eogmaneoPINVOKE.RandomEncoder_activate__SWIG_1(swigCPtr, StdVecf.getCPtr(input), ComputeSystem.getCPtr(system)), false);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StdVecf reconstruct(StdVeci hiddenStates, ComputeSystem system) {
    StdVecf ret = new StdVecf(eogmaneoPINVOKE.RandomEncoder_reconstruct(swigCPtr, StdVeci.getCPtr(hiddenStates), ComputeSystem.getCPtr(system)), false);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void learn(float alpha, float gamma, ComputeSystem system) {
    eogmaneoPINVOKE.RandomEncoder_learn(swigCPtr, alpha, gamma, ComputeSystem.getCPtr(system));
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public int getInputWidth() {
    int ret = eogmaneoPINVOKE.RandomEncoder_getInputWidth(swigCPtr);
    return ret;
  }

  public int getInputHeight() {
    int ret = eogmaneoPINVOKE.RandomEncoder_getInputHeight(swigCPtr);
    return ret;
  }

  public int getHiddenWidth() {
    int ret = eogmaneoPINVOKE.RandomEncoder_getHiddenWidth(swigCPtr);
    return ret;
  }

  public int getHiddenHeight() {
    int ret = eogmaneoPINVOKE.RandomEncoder_getHiddenHeight(swigCPtr);
    return ret;
  }

  public int getChunkSize() {
    int ret = eogmaneoPINVOKE.RandomEncoder_getChunkSize(swigCPtr);
    return ret;
  }

  public int getRadius() {
    int ret = eogmaneoPINVOKE.RandomEncoder_getRadius(swigCPtr);
    return ret;
  }

  public StdVeci getHiddenStates() {
    StdVeci ret = new StdVeci(eogmaneoPINVOKE.RandomEncoder_getHiddenStates(swigCPtr), false);
    return ret;
  }

  public RandomEncoder() : this(eogmaneoPINVOKE.new_RandomEncoder(), true) {
  }

}

}
