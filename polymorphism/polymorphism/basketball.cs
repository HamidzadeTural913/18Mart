using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    internal class Basketball : Sport
    {
        public byte Squarearea;
        public string Confrance;

        public Basketball(string uniform, string gender, byte time,byte squarearea,string confrance):base(uniform,gender,time)
        {
            Squarearea = squarearea;
            Confrance = confrance;  

        }

        public override void nutrilition()
        {
            Console.WriteLine("steak");
        }

        public override void run()
        {
            Console.WriteLine("4km");
        }
        public void LetInfo()
        {

            Console.WriteLine($"Uniform: {Uniform}| Gender: {Gender}| Time: {Time}| Squarearea: {Squarearea}| Confrance {Confrance}");

        }

        //public override void Reffere()
        //{
        //    Console.WriteLine("There is a reffere in Basketball");
        //}
    }
}
