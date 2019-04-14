using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class HighTemplar
    {
        private int attackP {get; set;}

        public HighTemplar(int att)
        {
            attackP = att;
        }

        //Based on operator type, you can overLoad this. Like this.
        //All the operator overloaders are static.
        public static HighTemplar operator +(HighTemplar a, HighTemplar b)
        {
            int newAtt = a.attackP + b.attackP;
            HighTemplar newHT = new HighTemplar(newAtt);
            return newHT;
        }

        public static HighTemplar operator -(HighTemplar a, HighTemplar b)
        {
            int newAtt = a.attackP - b.attackP;
            HighTemplar newHT = new HighTemplar(newAtt);
            return newHT;
        }

        public static HighTemplar operator *(HighTemplar a, HighTemplar b)
        {
            int newAtt = a.attackP * b.attackP;
            HighTemplar newHT = new HighTemplar(newAtt);
            return newHT;
        }

        //public static bool operator > (HighTemplar a, HighTemplar b)
        //{
        //    if (a.getAttack() > b.getAttack())
        //        return true;
        //    else
        //        return false;
        //}

        //Based on this, you can make a new objet using two objects with the same class.
        public int getAttack()
        {
            return attackP;
        }

    }

   

    class Day12_OP_overLoad
    {
        void copyFunc()
        {
            HighTemplar h1 = new HighTemplar(10);
            HighTemplar h2 = new HighTemplar(20);
            HighTemplar h3 = h1 + h2;
            HighTemplar h4 = h1 * h2;
            HighTemplar h5 = h2 - h1;
            Console.WriteLine(h3.getAttack());
            Console.WriteLine(h4.getAttack());
            Console.WriteLine(h5.getAttack());
        }
    }
}
