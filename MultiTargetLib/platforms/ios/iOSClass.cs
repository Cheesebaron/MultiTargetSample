using Foundation;
using UIKit;

namespace MultiTargetLib
{
    public class iOSClass : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var number = new NSNumber(1234);
        }
    }
}
