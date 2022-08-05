using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.linka.linkaapikit.module.api", Managed="Com.Linka.Linkaapikit.Module.Api")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.linka.linkaapikit.module.helpers", Managed="Com.Linka.Linkaapikit.Module.Helpers")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.linka.linkaapikit.module.Lock.BLE", Managed="Com.Linka.Linkaapikit.Module.Lock.BLE")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.linka.linkaapikit.module.Lock.FirmwareAPI", Managed="Com.Linka.Linkaapikit.Module.Lock.FirmwareAPI")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.linka.linkaapikit.module.model", Managed="Com.Linka.Linkaapikit.Module.Model")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.linka.linkaapikit.module.widget", Managed="Com.Linka.Linkaapikit.Module.Widget")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.opencsv", Managed="Com.Opencsv")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.opencsv.bean", Managed="Com.Opencsv.Bean")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.opencsv.enums", Managed="Com.Opencsv.Enums")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.opencsv.stream.reader", Managed="Com.Opencsv.Stream.Reader")]

delegate char _JniMarshal_PP_C (IntPtr jnienv, IntPtr klass);
delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate long _JniMarshal_PP_J (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPB_V (IntPtr jnienv, IntPtr klass, sbyte p0);
delegate IntPtr _JniMarshal_PPC_L (IntPtr jnienv, IntPtr klass, char p0);
delegate IntPtr _JniMarshal_PPI_L (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate bool _JniMarshal_PPI_Z (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPIL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate void _JniMarshal_PPJ_V (IntPtr jnienv, IntPtr klass, long p0);
delegate int _JniMarshal_PPL_I (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPLI_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate void _JniMarshal_PPLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate IntPtr _JniMarshal_PPLIL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate bool _JniMarshal_PPLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2);
delegate IntPtr _JniMarshal_PPLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate bool _JniMarshal_PPLLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLLII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, int p3, int p4);
delegate bool _JniMarshal_PPLLLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate int _JniMarshal_PPLZ_I (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate IntPtr _JniMarshal_PPLZ_L (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate void _JniMarshal_PPLZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate bool _JniMarshal_PPLZI_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, int p2);
delegate IntPtr _JniMarshal_PPLZLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, IntPtr p2, IntPtr p3);
delegate bool _JniMarshal_PPLZLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, IntPtr p2, IntPtr p3);
delegate int _JniMarshal_PPLZZ_I (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, bool p2);
delegate void _JniMarshal_PPLZZI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, bool p2, int p3);
delegate IntPtr _JniMarshal_PPZ_L (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZI_V (IntPtr jnienv, IntPtr klass, bool p0, int p1);
delegate bool _JniMarshal_PPZI_Z (IntPtr jnienv, IntPtr klass, bool p0, int p1);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

