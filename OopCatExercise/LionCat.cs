using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class LionCat : Cat
    {
        public LionCat()
        {
            IsAsleep = false;
            AverageHeight = 1100;
            Setting = "wild";
        }
        public override string Eat()
        {
            return "Roar!!!!";
        }
    }
}
