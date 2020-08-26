using System;
using Grimtol.Controllers;

namespace Grimtol
{
    class Program
    {
        static void Main(string[] args)
        {
            new GameController();
            System.Console.WriteLine("Thanks for playing! Press any key to exit...");
            Console.ReadKey();





            // DMoney dmoney = new DMoney();
            // Person temporary = (Person)dmoney;
            // IDeveloper dev = (IDeveloper)dmoney;
        }
    }



    // public class Person
    // {
    //     public string Name { get; private set; }
    // }

    interface IDeveloper
    {
        // public bool Plumber { get; private set; }
        // public bool Framer { get; private set; }
        bool Developer { get; }
        void WriteCode();
        // public bool counterfeiter { get; private set; }
        // public bool Counterfitter { get; private set; }
    }
    // interface IMechanic
    // {

    //     bool Mechanic { get; set; }
    // }

    // public class DMoney : Person, IDeveloper, IMechanic
    // {
    //     public bool Developer { get; private set; } = true;
    //     public bool Mechanic { get; set; } = true;
    // }




    // public abstract class Actor
    // {
    //     public int X { get; private set; }
    //     public int Y { get; private set; }
    //     public virtual void Move(int x, int y)
    //     {
    //         X = x;
    //         Y = y;
    //     }
    // }

    // public class NonPlayerCHaracter : IVendor
    // {

    // }

    // public class Enemy : Actor
    // {
    //     public void Attack()
    //     {

    //     }
    // }

    // public class Goblin : Enemy, ISchedulable
    // {
    //     public int Time { get; set; }
    // }

    // interface ISchedulable
    // {
    //     int Time { get; set; }
    // }






}







