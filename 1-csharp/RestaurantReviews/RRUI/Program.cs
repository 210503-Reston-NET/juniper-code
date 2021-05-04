using System;
using RRModels;
using System.Collections.Generic;

namespace RRUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant goodTaste = new Restaurant("Good Taste", "Baguio City", "Benguet");
            goodTaste.Reviews = new List<Review> {
                new Review {
                    Rating = 5,
                    Description = "A M A Z I N G"
                },
                new Review {
                    Rating = 5,
                    Description = "Good food for cheap"
                }
            };

            Console.WriteLine(goodTaste.ToString());
            foreach (Review review in goodTaste.Reviews)
            {
                Console.WriteLine(review.ToString());
            }
        }
    }
}
