using System;

using UIKit;
using Foundation;
using CoreGraphics;

namespace Calculator.iOS
{
    public partial class MyViewController : UIViewController
    {
        public MyViewController() : base("MyViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            buttonNewCalculation.ContentEdgeInsets = new UIEdgeInsets(20, 20, 20, 20);
            buttonNewCalculation.Layer.CornerRadius = 5;
            plusButton.Layer.CornerRadius = 5;
            minusButton.Layer.CornerRadius = 5;
            leftInput.BorderStyle = UITextBorderStyle.None;
            rightInput.BorderStyle = UITextBorderStyle.None;
            leftInput.BackgroundColor = UIColor.White;
            rightInput.BackgroundColor = UIColor.White;
            leftInput.Layer.CornerRadius = 5;
            rightInput.Layer.CornerRadius = 5;



            keyboardNotification = UIKeyboard.Notifications.ObserveWillChangeFrame(KeyboardFrameChanged);

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }


        void KeyboardFrameChanged(object sender, UIKeyboardEventArgs args)
        {
            //args.FrameEnd;

            UIView.Animate(args.AnimationDuration, () => {
                CGRect frame = this.View.Frame;
                frame.Height -= args.FrameEnd.Height;

                this.View.Frame = frame;
            });
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            keyboardNotification.Dispose();
        }

        NSObject keyboardNotification;
    }
}

