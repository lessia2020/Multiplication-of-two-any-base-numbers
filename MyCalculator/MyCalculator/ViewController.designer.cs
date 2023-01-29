// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MyCalculator
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField InfoLabel { get; set; }

		[Outlet]
		AppKit.NSTextField TextInput { get; set; }

		[Action ("PushButton:")]
		partial void PushButton (AppKit.NSButton sender);

		[Action ("ResetButton:")]
		partial void ResetButton (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (InfoLabel != null) {
				InfoLabel.Dispose ();
				InfoLabel = null;
			}

			if (TextInput != null) {
				TextInput.Dispose ();
				TextInput = null;
			}
		}
	}
}
