using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Hero Information
            String  HeroName = "00x";
            Double HeroHeight = 100.5;
            int HeroAge = 400;
            String HeroSuperPower = "Xfire";

            // The Villain Information
            String VillainName = "F00";
            Double  VillainHeight = 800.5;
            int VillainAge = 800;
            String VillainSuperPower = "Fire";

            int ageDifferenve = VillainAge - HeroAge ; //The Age Difference 

            //The Hero Information printing 

            Console.WriteLine("The Hero Information : ");
            Console.WriteLine("The HeroName : " + HeroName);
            Console.WriteLine("The HeroHeight : " + HeroHeight);
            Console.WriteLine("The HeroAge  : " + HeroAge);
            Console.WriteLine("The HeroSuperPower : " + HeroSuperPower);
            Console.WriteLine(" ");

            //The Villain Information printing 

            Console.WriteLine("The Villain Information : ");
            Console.WriteLine("The VillainName : " + VillainName);
            Console.WriteLine("The VillainHeight : " + VillainHeight);
            Console.WriteLine("The VillainAge  : " + VillainAge);
            Console.WriteLine("The VillainSuperPower : " + VillainSuperPower);
            Console.WriteLine(" ");

            // The differene between the Ages 
            Console.WriteLine("The Difference Between The Ages  : " + ageDifferenve);
            Console.WriteLine(" ");

            // The Bounse 
            HeroHeight = HeroHeight + 5;
            VillainSuperPower = "None";

            Console.WriteLine("Printing the Updated information  " );

            //The Hero Updated Information printing 

            Console.WriteLine("The Hero Information : ");
            Console.WriteLine("The HeroName : " + HeroName);
            Console.WriteLine("The HeroHeight : " + HeroHeight);
            Console.WriteLine("The HeroAge  : " + HeroAge);
            Console.WriteLine("The HeroSuperPower : " + HeroSuperPower);
            Console.WriteLine(" ");

            //The Villain  Updated Information printing 

            Console.WriteLine("The Villain Information : ");
            Console.WriteLine("The VillainName : " + VillainName);
            Console.WriteLine("The VillainHeight : " + VillainHeight);
            Console.WriteLine("The VillainAge  : " + VillainAge);
            Console.WriteLine("The VillainSuperPower : " + VillainSuperPower);
            Console.WriteLine(" ");




        }
    }
}
