Using System;


class Program
{
   static void Main()
   {
       Console.Write("Enter weight: ");
       double weight = Convert.ToDouble(Console.ReadLine());


       Console.Write("Enter number of motors: ");
       int numberOfMotors = Convert.ToInt32(Console.ReadLine());


       if (weight / numberOfMotors > 5.6)
       {
           Console.WriteLine("ja");
       }
       else
       {
           Console.WriteLine("nej");
       }
   }
}
