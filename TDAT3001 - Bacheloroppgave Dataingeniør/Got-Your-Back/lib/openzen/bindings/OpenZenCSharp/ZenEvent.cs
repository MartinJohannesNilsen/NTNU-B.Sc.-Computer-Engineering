//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ZenEvent : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ZenEvent(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ZenEvent obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ZenEvent() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OpenZenPINVOKE.delete_ZenEvent(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ZenEventType eventType {
    set {
      OpenZenPINVOKE.ZenEvent_eventType_set(swigCPtr, (int)value);
    } 
    get {
      ZenEventType ret = (ZenEventType)OpenZenPINVOKE.ZenEvent_eventType_get(swigCPtr);
      return ret;
    } 
  }

  public ZenSensorHandle_t sensor {
    set {
      OpenZenPINVOKE.ZenEvent_sensor_set(swigCPtr, ZenSensorHandle_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = OpenZenPINVOKE.ZenEvent_sensor_get(swigCPtr);
      ZenSensorHandle_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new ZenSensorHandle_t(cPtr, false);
      return ret;
    } 
  }

  public ZenComponentHandle_t component {
    set {
      OpenZenPINVOKE.ZenEvent_component_set(swigCPtr, ZenComponentHandle_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = OpenZenPINVOKE.ZenEvent_component_get(swigCPtr);
      ZenComponentHandle_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new ZenComponentHandle_t(cPtr, false);
      return ret;
    } 
  }

  public ZenEventData data {
    set {
      OpenZenPINVOKE.ZenEvent_data_set(swigCPtr, ZenEventData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = OpenZenPINVOKE.ZenEvent_data_get(swigCPtr);
      ZenEventData ret = (cPtr == global::System.IntPtr.Zero) ? null : new ZenEventData(cPtr, false);
      return ret;
    } 
  }

  public ZenEvent() : this(OpenZenPINVOKE.new_ZenEvent(), true) {
  }

}
