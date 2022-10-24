using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==  Arrays. ==");
            Console.WriteLine();


            //0 Pistol

            //1 Shotgun

            //2 Spreader

            //3 Laser

            //4 Rocket Launcher


            //current weapon
            //string weapon = "Pistol";
            int weapon = 0; // o..4


            //ammo
            int Pistolammo = 6;
            int shotGunAmmo = 2;
            int spreaderAmmo = 50;
            int lazerAmmo = 25;
            int rocketLauncherAmmo = 10;
            //etc...

            int[] ammo;
            ammo = new int[5];
            ammo[0] = 6;
            ammo[1] = 2;
            ammo[2] = 50;
            ammo[3] = 25;
            ammo[4] = 10;


            //Show current weapon (WITHOUT HARD CODING!!!)

            Console.WriteLine(ammo[weapon]);


            weapon = 3; //Changing weapon


            Console.WriteLine(ammo[weapon]);




            Console.ReadKey(true);
        }


        static void Fire()
        {

        }
    }
}
