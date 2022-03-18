using System;

namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sport sport = new Sport();
            //sport.Reffere();

            //Basketball basketball = new Basketball();
            //basketball.Reffere();

            //Football football = new Football();
            //football.Reffere();
            Football football = new Football("Nike", "Male", 90, "Real Madrid", "Fly Emirates");
            football.SetInfo();
            football.nutrilition();
            football.run();

            Basketball basketball = new Basketball("Puma", "Male", 80, 20, "East Confrance");
            basketball.LetInfo();
            basketball.nutrilition();
            basketball.run();
        }



    }

}
