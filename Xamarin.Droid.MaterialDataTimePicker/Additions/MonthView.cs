using System;
using Android.Runtime;

namespace Com.Wdullaer.MaterialDateTimePicker.Date
{
    public abstract partial class MonthView
    {
        protected internal partial class MonthViewTouchHelper
        {
            static Delegate cb_getVisibleVirtualViews_Ljava_util_List_;
#pragma warning disable 0169
            static Delegate GetGetVisibleVirtualViews_Ljava_util_List_Handler()
            {
                if (cb_getVisibleVirtualViews_Ljava_util_List_ == null)
                    cb_getVisibleVirtualViews_Ljava_util_List_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_GetVisibleVirtualViews_Ljava_util_List_);
                return cb_getVisibleVirtualViews_Ljava_util_List_;
            }

            static void n_GetVisibleVirtualViews_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Wdullaer.MaterialDateTimePicker.Date.MonthView.MonthViewTouchHelper __this = global::Java.Lang.Object.GetObject<global::Com.Wdullaer.MaterialDateTimePicker.Date.MonthView.MonthViewTouchHelper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.GetVisibleVirtualViews(p0);
            }
#pragma warning restore 0169

            static IntPtr id_getVisibleVirtualViews_Ljava_util_List_;
            // Metadata.xml XPath method reference: path="/api/package[@name='com.wdullaer.materialdatetimepicker.date']/class[@name='MonthView.MonthViewTouchHelper']/method[@name='getVisibleVirtualViews' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;']]"
            [Register("getVisibleVirtualViews", "(Ljava/util/List;)V", "GetGetVisibleVirtualViews_Ljava_util_List_Handler")]
            protected override unsafe void GetVisibleVirtualViews(global::System.Collections.Generic.IList<global::Java.Lang.Integer> virtualViewIds)
            {
                if (id_getVisibleVirtualViews_Ljava_util_List_ == IntPtr.Zero)
                    id_getVisibleVirtualViews_Ljava_util_List_ = JNIEnv.GetMethodID(class_ref, "getVisibleVirtualViews", "(Ljava/util/List;)V");
                IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle(virtualViewIds);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_p0);

                    if (GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(Handle, id_getVisibleVirtualViews_Ljava_util_List_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getVisibleVirtualViews", "(Ljava/util/List;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_p0);
                }
            }
        }
    }

}