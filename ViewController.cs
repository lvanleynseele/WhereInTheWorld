using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using Xamarin.Essentials;

namespace WhereInTheFuckingWorld
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        { 
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {

            base.PrepareForSegue(segue, sender);

            if (segue.Identifier == "PlaySegue")
            {
                var gameController1 = segue.DestinationViewController as GameController1;

                if (gameController1 != null)
                {
                    Round temp1 = new Round
                    {
                        image = "Hanoi.png",
                        correct = new Option { title = "Hanoi, Vietnam", location = new Location(21.0278, 105.8342) },
                        fake1 = new Option { title = "Darjeeling, India", location = new Location(27.0410, 88.2663) },
                        fake2 = new Option { title = "Gunagzhou, China", location = new Location(23.1291, 113.2644) },
                        fake3 = new Option { title = "Cusco, Peru", location = new Location(-13.5320, -71.9675) }
                    };

                    Round temp2 = new Round
                    {
                        image = "MatterhornPeak.png",
                        correct = new Option { title = "Matterhorn, Switzerland", location = new Location(45.9766, 7.6585) },
                        fake1 = new Option { title = "Denali, Alaska", location = new Location(63.0692, -151.0070) },
                        fake2 = new Option { title = "Everest, Nepal", location = new Location(27.9881, 86.9250) },
                        fake3 = new Option { title = "Kilimanjaro, Tanzania", location = new Location(-3.0674, 37.3556) }
                    };


                    Round temp3 = new Round
                    {
                        image = "Ilulissat.png",
                        correct = new Option { title = "Victoria Falls, Zambia", location = new Location(-17.9243, 25.8572) },
                        fake1 = new Option { title = "Niagra Falls, New York", location = new Location(43.0962, -79.0377) },
                        fake2 = new Option { title = "Angel Falls, Venezuela", location = new Location(5.9701, -62.5362) },
                        fake3 = new Option { title = "Iguazu Falls, Argentina", location = new Location(-25.6953, -54.4367) }
                    };



                    gameController1.Rounds = new List<Round> { temp3, temp2, temp1, temp2, temp3 };
                    gameController1.choices = new List<Option>();
                    gameController1.answers = new List<Option>();
                    gameController1.currenRound = 0;

                }
            }
          
        }
    }
}