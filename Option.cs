using System;
using Xamarin.Essentials;
using System.Collections.Generic;

namespace WhereInTheFuckingWorld
{
    public class Option
    {

        public string title;// { get; set; }
        public Location location;// { get; set; }

        public Option()
        {
        }


        public static List<Option> RandomizeOptionList(List<Option> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Option value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }
    }
}
