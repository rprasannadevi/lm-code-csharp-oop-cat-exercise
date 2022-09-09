using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public  class CheetahCat :Cat
    {
        public CheetahCat()
        {
            IsAsleep = false;
            AverageHeight = 1000;
            Setting = "wild";
        }

        public override string Eat()
        {
            return "Zzzzzzz";
        }
    }
}
