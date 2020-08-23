using System;
using Foundation;
using UIKit;
using System.Collections.Generic;
using Xamarin.Essentials;

namespace WhereInTheFuckingWorld
{
    public class TableSource : UITableViewSource
    {
        List<Option> options;
        Option selected;
        MapKit.MKMapView mapView;

        public TableSource(List<Option> items, MapKit.MKMapView map)
        {
            options = items;
            mapView = map;

        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return options.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell("TableCell");
            Option item = options[indexPath.Row];

            //if there are no cells to reuse, create a new one
            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, "TableCell");
            }

            cell.TextLabel.Text = item.title;
            //cell.DetailTextLabel.Text = item.title;

            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
                selected = options[indexPath.Row];

            CoreLocation.CLLocationCoordinate2D selectedLoc = new CoreLocation.CLLocationCoordinate2D(selected.location.Latitude, selected.location.Longitude);
            mapView.SetRegion(new MapKit.MKCoordinateRegion(selectedLoc, new MapKit.MKCoordinateSpan(30, 30)), true);

            foreach (var annotation in mapView.Annotations)
            {
                if (selected.location.Latitude == annotation.Coordinate.Latitude && selected.location.Longitude == annotation.Coordinate.Longitude)
                {
                    mapView.SelectAnnotation(annotation, true);

                }

            }


            //NSSet annotations= mapView.GetAnnotations(new MapKit.MKMapRect(new MapKit.MKMapPoint(selectedLoc.Latitude,selectedLoc.Longitude), new MapKit.MKMapSize(10,10)));

            

            
        }


        public Option GetItem()
        {
            return selected;
        }

        /*
        public NSIndexPath FindRow(string title)
        {
            int i;
            for (i = 0; i < options.Count; i++)
            {
                if (options[i].title == title)
                    break;

            }

            return new NSIndexPath(new IntPtr(i));
        }
        */

    }


    //https://docs.microsoft.com/en-us/xamarin/ios/user-interface/controls/tables/populating-a-table-with-data
    //https://docs.microsoft.com/en-us/xamarin/ios/user-interface/controls/tables/creating-tables-in-a-storyboard

}