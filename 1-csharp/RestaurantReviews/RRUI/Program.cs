using System;
using RRModels;
using System.Collections.Generic;

namespace RRUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting aparent type to an instance of a subtype is called covariance
            MenuFactory.GetMenu("main").Start();
        }
    }
}
