using System;
using Android.Content;
using Android.Runtime;
using Android.Views;

namespace MultiTargetLib
{
    [Register("multitargetlib.AndroidClass")]
    public class AndroidClass : View
    {
        public AndroidClass(Context context) : base(context)
        {
        }

        protected AndroidClass(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
    }
}
