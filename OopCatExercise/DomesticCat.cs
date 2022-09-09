using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class DomesticCat : Cat
    {
        public DomesticCat()
        {
            IsAsleep = false;
            AverageHeight = 23;
            Setting = "domestic";
        }
        
        public override string Eat()
        {
            return "Purrrrrrr";
        }
    }
}
