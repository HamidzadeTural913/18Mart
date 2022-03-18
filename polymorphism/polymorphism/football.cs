using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    internal class Football:Sport
    {
        public string Club;
        public string Sponsor;

        public Football(string uniform, string gender, byte time,string club, string sponsor):base(uniform,gender,time)
        {
            Club = club;
            Sponsor = sponsor;
        }

        public override void nutrilition()
        {
            Console.WriteLine("spagetti");
        }

        public override void run()
        {
            Console.WriteLine("18 km");
        }

        public void SetInfo()
        {

            Console.WriteLine($"Uniform: {Uniform}| Gender: {Gender}| Time: {Time}| Club: {Club}| Sponsor: {Sponsor}");

        }

        //public override void Reffere()
        //{
        //    Console.WriteLine("There is a reffere in Football");
        //}
    }
}
