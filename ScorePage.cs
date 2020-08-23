using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using Xamarin.Essentials;


namespace WhereInTheFuckingWorld
{
    public partial class ScorePage : UIViewController
    {
        public List<Round> rounds;
        public List<Option> choices;
        public List<Option> answers;
        public double score=0;

        public ScorePage (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            for(int i= 0;i < choices.Count; i++)
            {
                score+= Location.CalculateDistance(choices[i].location , answers[i].location, DistanceUnits.Miles);

            }

            Score.Text = score + " Miles off";
            Answers.Source = new TableSource(answers,ScoreMap);

            ScoreMap.MapType = MapKit.MKMapType.Satellite;//Hybrid;
            ScoreMap.ZoomEnabled = true;
            ScoreMap.ScrollEnabled = true;
            ScoreMap.Delegate = new MapActions(Answers);
            foreach (Option curOpt in answers)
            {
                ScoreMap.AddAnnotations(new MapKit.MKPointAnnotation() { Title = curOpt.title, Coordinate = new CoreLocation.CLLocationCoordinate2D(curOpt.location.Latitude, curOpt.location.Longitude) });

                //pin annotaition code, need to override function
                //NSObject temp2 = new NSObject();
                //temp2.Equals(curOpt);
                //NSCoder temp = new NSCoder();
                //temp.Encode(0 , curOpt.title);
                //GameMap.AddAnnotations(new MapKit.MKPinAnnotationView(temp); //{Title=curOpt.title, Coordinate= new CoreLocation.CLLocationCoordinate2D(curOpt.location.Latitude, curOpt.location.Longitude) });

            }
            ScoreMap.SetRegion(new MapKit.MKCoordinateRegion(new CoreLocation.CLLocationCoordinate2D(0, 0), new MapKit.MKCoordinateSpan(180, 360)), true);


        }

        
        //score += 

    }

}