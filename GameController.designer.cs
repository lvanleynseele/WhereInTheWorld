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

namespace WhereInTheFuckingWorld
{
    [Register ("GameController")]
    partial class GameController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView GameImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MapKit.MKMapView GameMap { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (GameImage != null) {
                GameImage.Dispose ();
                GameImage = null;
            }

            if (GameMap != null) {
                GameMap.Dispose ();
                GameMap = null;
            }
        }
    }
}