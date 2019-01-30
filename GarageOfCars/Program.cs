/*******************************************************************************
*  APPLICATION :    Program.cs
*  PURPOSE     :    Creates Car Garage with cars, its details and its owners
*  AUTHOR      :    Kedar Kanel 
*  Date        :   12 Feb 2014
******************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Garage g1 = new Garage();
            g1.DisplayResult();

            Console.Read();
        }
    }
}
