using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.linphone.core.tutorials", Managed="Org.Linphone.Core.Tutorials")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.linphone.core.util", Managed="Org.Linphone.Core.Util")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.linphone.mediastream", Managed="Org.Linphone.Mediastream")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.linphone.mediastream.video", Managed="Org.Linphone.Mediastream.Video")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.linphone.mediastream.video.capture", Managed="Org.Linphone.Mediastream.Video.Capture")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.linphone.mediastream.video.capture.hwconf", Managed="Org.Linphone.Mediastream.Video.Capture.Hwconf")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.linphone.mediastream.video.display", Managed="Org.Linphone.Mediastream.Video.Display")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.linphone.tools", Managed="Org.Linphone.Tools")]

delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PPI_L (IntPtr jnienv, IntPtr klass, int p0);
delegate bool _JniMarshal_PPIIIZ_Z (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, bool p3);
delegate void _JniMarshal_PPIL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate void _JniMarshal_PPJ_V (IntPtr jnienv, IntPtr klass, long p0);
delegate int _JniMarshal_PPL_I (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPLI_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLLIII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, int p3, int p4, int p5);
delegate void _JniMarshal_PPLZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
