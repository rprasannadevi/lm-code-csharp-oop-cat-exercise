using System;
namespace OopCatExercise
{
	public abstract class Cat : ICat
	{
		public Boolean IsAsleep { get;  protected set; }
		public float AverageHeight { get;  protected set; }
		public string Setting { get;  protected set; }

		public abstract string Eat();

		public void GoToSleep()
		{
			IsAsleep = true;
		}

        public void WakeUp()
        {
            IsAsleep = false;
        }
    }
}
