// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Calculator.iOS
{
    [Register ("MyViewController")]
    partial class MyViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonNewCalculation { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField leftInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton minusButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton plusButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel result { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField rightInput { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonNewCalculation != null) {
                buttonNewCalculation.Dispose ();
                buttonNewCalculation = null;
            }

            if (leftInput != null) {
                leftInput.Dispose ();
                leftInput = null;
            }

            if (minusButton != null) {
                minusButton.Dispose ();
                minusButton = null;
            }

            if (plusButton != null) {
                plusButton.Dispose ();
                plusButton = null;
            }

            if (result != null) {
                result.Dispose ();
                result = null;
            }

            if (rightInput != null) {
                rightInput.Dispose ();
                rightInput = null;
            }
        }
    }
}