using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // DONE--Create a class Animal
            // DONE--give this class 4 members that all Animals have in common


            // DONE--Create a class Bird
            // DONE--give this class 4 members that are specific to Bird
            // DONE--Set this class to inherit from your Animal Class

            // DONE--Create a class Reptile
            // DONE--give this class 4 members that are specific to Reptile
            // DONE--Set this class to inherit from your Animal Class

            /*DONE--Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values */
             

            var falcon = new Bird();
            
            falcon.Age = 12;
            falcon.NumberOfEars = 2;
            falcon.NumberOfEyes = 2;
            falcon.NumberOfLegs = 2; 
            falcon.LongOrShortBeak = "short"; 
            falcon.NumberOfFeathers = 1200000;
            falcon.Color = "brown"; 
            falcon.NumberOfWings = 2;
            Console.WriteLine("AGE  EARS  EYES  LEGS  COLOR  BEAK SIZE  FEATHER COUNT  WINGS");
            Console.WriteLine("---  ----  ----  ----  -----  ---------  -------------  -----");
            Console.WriteLine("");
            Console.WriteLine($"{falcon.Age}   {falcon.NumberOfEars}     {falcon.NumberOfEyes}     {falcon.NumberOfLegs}     {falcon.Color}  {falcon.LongOrShortBeak}      {falcon.NumberOfFeathers}        {falcon.NumberOfWings}");

            /*DONE--Create an object of your Reptile class
                *  give values to your members using the object of your Reptile class
                *  
                * Creatively display the class member values 
                */

            var cobra = new Reptile();

            cobra.Age = 19;
            cobra.NumberOfEars = 2;
            cobra.NumberOfEyes = 2;
            cobra.NumberOfLegs = 0;
            cobra.Color = "black";
            cobra.LengthInFeet = 12;
            cobra.IsPoisonous = true;
            cobra.BiterOrConstrictor = "Biter";
            Console.WriteLine("AGE  EARS  EYES  LEGS  COLOR  LENGTH  POISONOUS?  TYPE");
            Console.WriteLine("---  ----  ----  ----  -----  ------  ----------  ----");
            Console.WriteLine("");
            Console.WriteLine($"{ cobra.Age}   {cobra.NumberOfEars}     {cobra.NumberOfEyes}     {cobra.NumberOfLegs}     {cobra.Color}  {cobra.LengthInFeet}FT.   {cobra.IsPoisonous}        {cobra.BiterOrConstrictor}");
            

        }
    }
}
