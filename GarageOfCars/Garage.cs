/*******************************************************************************
*  APPLICATION :    Garage.cs
*  PURPOSE     :    Creates Garage, with cars and owners 
*  AUTHOR      :    Kedar Kanel 
*  Date        :   12 Feb 2014
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class Garage
    {
        public void DisplayResult() {
            DataEntry enterData = new DataEntry();
            int totalEntry = enterData.inputEntryDetail();              

            Car[] allCars = enterData.InputCarDetail();
            Owner[] allOwners = enterData.InputOwnerDetail();

            for (int i = 0; i<totalEntry; i++) {
                Console.Write(Environment.NewLine + "The detail of the Owners and their car Present in the Garage are : ");
                Console.Write(Environment.NewLine + "Owner " + totalEntry + " detail : ");
                Console.Write(Environment.NewLine + "Name : " +  allOwners[i].getName() );
                Console.Write(Environment.NewLine + "Address : " + allOwners[i].getAddress());
                Console.Write(Environment.NewLine + "Phone : " + allOwners[i].getPhone() + Environment.NewLine);
                Console.Write(Environment.NewLine + "His/her Car detail : ");
                Console.Write(Environment.NewLine + "Brand : " +  allCars[i].getCarName());
                Console.Write(Environment.NewLine + "Model : " + allCars[i].getCarModel());
                Console.Write(Environment.NewLine + "Type : " + allCars[i].getCarType());
                Console.Write(Environment.NewLine + "Year : " + allCars[i].getCarYear());
                Console.Write(Environment.NewLine + "Engine : " +allCars[i].getCarEngine());
            }
           // Console.Write(Environment.NewLine + allCars[1].getCarName());          
        
        }
    }
}
