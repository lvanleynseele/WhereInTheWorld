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
    [Register ("ScorePage")]
    partial class ScorePage
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView Answers { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Score { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MapKit.MKMapView ScoreMap { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Answers != null) {
                Answers.Dispose ();
                Answers = null;
            }

            if (Score != null) {
                Score.Dispose ();
                Score = null;
            }

            if (ScoreMap != null) {
                ScoreMap.Dispose ();
                ScoreMap = null;
            }
        }
    }
}