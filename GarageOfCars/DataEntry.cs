/*******************************************************************************
*  APPLICATION :    DataEntry.cs
*  PURPOSE     :    Takes user input for the car and the owner
*  AUTHOR      :    Kedar Kanel 
*  Date        :   12 Feb 2014
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class DataEntry
    {
        private int numData;

        public int inputEntryDetail() {
            int inNo;
            Console.Write("How many data do you want to enter? ");
            inNo = Convert.ToInt16(Console.ReadLine());
            numData = inNo;
            return inNo;        
        }
        public Car[] InputCarDetail() {            
            int count = 0;
            string nameOfCar;
            string model;
            string type;
            int year;
            double engine;     
            
            Car[] cars = new Car[numData];
            
            for(count = 0; count< numData; count++) {
                Console.Write("Enter the name of the car : ");
                nameOfCar = Console.ReadLine();
                Console.Write("Enter the model of the car : ");
                model = Console.ReadLine();
                Console.Write("Enter the type of the car : ");
                type = Console.ReadLine();
                Console.Write("Enter the year of the car : ");
                year = Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter the engine of the car(2.0 format) : ");
                engine = Convert.ToDouble(Console.ReadLine());

                cars[count] = new Car(nameOfCar, model, type, year, engine);                
            }
            return cars;
        }
        public Owner[] InputOwnerDetail()
        {                   
            string ownerName;
            string ownerAddress;
            ulong ownerPhone;
        
            Owner[] owners = new Owner[numData];

            for(int count = 0; count< numData; count++)
            {
                Console.Write("Enter the name of the owner : ");
                ownerName = Console.ReadLine();
                Console.Write("Enter the address of the owner : ");
                ownerAddress = Console.ReadLine();
                Console.Write("Enter the phone of the owner : ");
                ownerPhone = Convert.ToUInt64(Console.ReadLine());
             
                owners[count] = new Owner(ownerName, ownerAddress, ownerPhone);                
            }
            return owners;
        }
    }
}
