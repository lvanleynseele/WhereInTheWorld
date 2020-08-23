using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using Xamarin.Essentials;
//using Xamarin.Forms.Maps;

namespace WhereInTheFuckingWorld
{
    public partial class GameController : UIViewController
    {
        public int currenRound;
        public List<Round> Rounds;
        public List<Option> choices;
        public List<Option> answers;
        public Dictionary<string, Option> options = new Dictionary<string, Option>() { };


        public GameController (IntPtr handle) : base (handle)
        {
           
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Round current = Rounds[currenRound];
            answers.Add(current.correct);
            
            options.Add(current.correct.title,current.correct);
            options.Add(current.fake1.title, current.fake1);
            options.Add(current.fake2.title, current.fake2);
            options.Add(current.fake3.title, current.fake3);


            //handle image for round
            //add scaling stuff ??
            GameImage.Image = UIImage.FromFile(current.image);


            //handle map stuff
            GameMap.MapType = MapKit.MKMapType.Satellite;//Hybrid;
            GameMap.ZoomEnabled = true;
            GameMap.ScrollEnabled = true;
            //GameMap.Delegate = new MapActions();

            double avglat = 0;
            double avglon = 0;
            foreach (KeyValuePair<string,Option> curOpt in options)
            {
                avglat += curOpt.Value.location.Latitude;
                avglon += curOpt.Value.location.Longitude;
                GameMap.AddAnnotations(new MapKit.MKPointAnnotation() { Title = curOpt.Key, Coordinate = new CoreLocation.CLLocationCoordinate2D(curOpt.Value.location.Latitude, curOpt.Value.location.Longitude) });

                //pin annotaition code, need to override function
                //NSObject temp2 = new NSObject();
                //temp2.Equals(curOpt);
                //NSCoder temp = new NSCoder();
                //temp.Encode(0 , curOpt.title);
                //GameMap.AddAnnotations(new MapKit.MKPinAnnotationView(temp); //{Title=curOpt.title, Coordinate= new CoreLocation.CLLocationCoordinate2D(curOpt.location.Latitude, curOpt.location.Longitude) });
       
            }


            GameMap.SetRegion(new MapKit.MKCoordinateRegion( new CoreLocation.CLLocationCoordinate2D(avglat/4, avglon/4), new MapKit.MKCoordinateSpan(180, 360)),true);
            

        }



        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            if (segue.Identifier == "HomeSegue")
            {

            }
            else
            {
                var source = GameMap.Delegate as MapActions;
                MapKit.MKPointAnnotation selection = source.GetSelection();
                if (selection != null)
                {
                    choices.Add(options[selection.Title]);
                }


                

                if (segue.Identifier == "FinalSegue")
                {
                    var scorepage = segue.DestinationViewController as ScorePage;
                    if (scorepage != null)
                    {
                        scorepage.choices = choices;
                        scorepage.answers = answers;
                    }
                }
                else
                {
                    var gamecontroller = segue.DestinationViewController as GameController;
                    if (gamecontroller != null)
                    {
                        //choices.Add(item);
                        //gamecontroller.choices = choices;
                        gamecontroller.Rounds = Rounds;
                        gamecontroller.currenRound = currenRound + 1;
                        gamecontroller.answers = answers;
                        gamecontroller.choices = choices;
                    }


                }

            }

                

        }

    }
  
}

    




