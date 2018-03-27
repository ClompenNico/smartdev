using System;
using System.Collections.Generic;
using System.Linq;

namespace NMCT.Resto.Core.Model
{
    public class Restaurant
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Cuisines { get; set; }
        public int PriceRange { get; set; }

        public string PriceRangeString
        {
            get {
                switch(PriceRange){
                    case(1):
                        return "$";
                    case (2):
                        return "$$";
                    case (3):
                        return "$$$";
                    case (4):
                        return "$$$$";
                    case (5):
                        return "$$$$$";
                }
                return "NO PRICE RANGE";
            }
        }

        public string ImageUrl { get; set; }
        public string ThumbUrl { get; set; }

        public Location Location { get; set; }

        public List<Review> Reviews { get; set; }
        public double Score {
            get { return Reviews == null ? double.NaN : Math.Round(Reviews.Average(rev => rev.Score), 1); }
        }
    }
}
