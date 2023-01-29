using System;

using AppKit;
using Foundation;

namespace MyCalculator
{
	public partial class ViewController : NSViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

		int step = 0;
		int num1;
		int num2;

        partial void PushButton(NSButton sender)
        {
			if (step == 0)
			{
				num1 = Convert.ToInt16(TextInput.StringValue);
				TextInput.StringValue = "";
				step++;
				SetText("Enter the next number.");
			} else if (step == 1)
			{
                num1 = Convert.ToInt16(TextInput.StringValue);
                TextInput.StringValue = "";
                step = 0;
				SetText("The answer is: " + Convert.ToString(num1 * num2));
            }
        }
        partial void ResetButton(NSButton sender)
        {
			step = 0;
			SetText("Set the first number");
        }

		private void SetText(String text)
		{
			InfoLabel.StringValue = text;
		}
    }
}
