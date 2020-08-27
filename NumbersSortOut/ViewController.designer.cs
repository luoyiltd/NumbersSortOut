// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NumbersSortOut
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField FilePath { get; set; }

		[Action ("SelectFile:")]
		partial void SelectFile (Foundation.NSObject sender);

		[Action ("SortByName:")]
		partial void SortByName (Foundation.NSObject sender);

		[Action ("SortByProduct:")]
		partial void SortByProduct (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (FilePath != null) {
				FilePath.Dispose ();
				FilePath = null;
			}
		}
	}
}
