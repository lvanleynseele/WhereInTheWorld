using System;
using System.Collections.Generic;
using UIKit;

namespace WhereInTheFuckingWorld
{

    //https://docs.microsoft.com/en-us/xamarin/ios/user-interface/controls/ios-maps/
    

    public class MapActions : MapKit.MKMapViewDelegate
    {

        MapKit.MKPointAnnotation selected { get; set; }//= new MapKit.MKPointAnnotation();
        public TableSource tableSource;

        public UITableView tableView;

        public MapActions(UITableView view)
        {
            tableView = view;
            tableSource = tableView.Source as TableSource;
        }


        public override void DidSelectAnnotationView(MapKit.MKMapView mapView, MapKit.MKAnnotationView view)
        {
            
            selected = view.Annotation as MapKit.MKPointAnnotation;

            if (selected!=null) {
                mapView.SetRegion(new MapKit.MKCoordinateRegion(new CoreLocation.CLLocationCoordinate2D(selected.Coordinate.Latitude, selected.Coordinate.Longitude), new MapKit.MKCoordinateSpan(30, 30)), true);

                foreach (var cell in tableView.VisibleCells)
                {
                    if (selected.Title == cell.TextLabel.Text)
                    {
                        //tableView.SelectRow(tablerow,true,0 );
                        cell.Selected = true;
                        
                        //cell.Accesory
                    }
                    else
                    {
                        cell.Selected = false;
                    }
                }
            }

            //Foundation.NSIndexPath tablerow = new Foundation.NSIndexPath();
            //tablerow=
            //tableSource.FindRow(selected.Title);
            //tableView.SelectRow(tablerow,true,0 );
            
            //UITableViewDataSource.SectionIndex
        }



        public MapKit.MKPointAnnotation GetSelection()
        {

            return selected;
        }

    }

        
}
