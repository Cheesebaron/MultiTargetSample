using MultiTargetLib;
using System;
using UIKit;

namespace SampleApp.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();

            var iosClass = new iOSClass();
            var commonClass = new CommonClass();
        }
    }
}