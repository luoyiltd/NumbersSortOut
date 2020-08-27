using System;
using System.IO;
using System.Linq;
using AppKit;
using Foundation;

namespace NumbersSortOut
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void SelectFile(NSObject sender)
        {
            var openFileDialog = NSOpenPanel.OpenPanel;
            openFileDialog.CanChooseFiles = true;
            openFileDialog.CanChooseDirectories = false;
            openFileDialog.AllowedFileTypes = new string[] { "xlsx" };

            if (openFileDialog.RunModal() == 1)
            {
                var url = openFileDialog.Urls[0];

                if (url != null)
                {
                    var path = url.Path;

                    var fileName = path.Split(Path.DirectorySeparatorChar).Last();

                    FilePath.StringValue = "You selected:  " + fileName;
                }
            }
        }
    }
}