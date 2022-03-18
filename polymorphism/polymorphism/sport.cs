using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    abstract class Sport
    {
        public string Uniform;
        public string Gender;
        public byte Time;
        public Sport(string uniform,string gender,byte time)
        {
            Uniform = uniform;
            Gender = gender;    
            Time = time;    

        }
        public abstract void run();

        public abstract void nutrilition();

        //public virtual void Reffere()
        //{
        //    Console.WriteLine("There is a reffere in every sport");
        //}

        
    }
}
   