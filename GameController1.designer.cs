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
    [Register ("GameController1")]
    partial class GameController1
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton FinalSegue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView GameImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MapKit.MKMapView GameMap { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView GameOptions { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (FinalSegue != null) {
                FinalSegue.Dispose ();
                FinalSegue = null;
            }

            if (GameImage != null) {
                GameImage.Dispose ();
                GameImage = null;
            }

            if (GameMap != null) {
                GameMap.Dispose ();
                GameMap = null;
            }

            if (GameOptions != null) {
                GameOptions.Dispose ();
                GameOptions = null;
            }
        }
    }
}