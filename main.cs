//Jacob Abel
//This program takes in hourly wages, worked hours in a week, and overtime, and outputs the yearly salary after taxes.
//Last edited 9/17/19
using System;

class MainClass {
  public static void Main (string[] args) 
  {
    double wage, hours, overtime, yearwage, withover, taxes, final;
    string wageString, hoursString, nameString, overtimeString;

    Console.WriteLine("Insert your name.");
      nameString = Console.ReadLine();
      
    Console.WriteLine("Insert your current wages.");
      wageString = Console.ReadLine();
      wage = double.Parse(wageString);

    Console.WriteLine("How many hours do you work a week?");
     hoursString = Console.ReadLine();
     hours = double.Parse(hoursString);

    Console.WriteLine("Insert overtime you've worked this year.");
     overtimeString = Console.ReadLine();
     overtime = double.Parse(overtimeString);

       yearwage = (wage * hours) * 4 * 12;
      
       withover = (overtime * wage) * 1.5;

        taxes = (yearwage + withover) * .12;

       final = (yearwage + withover) - taxes;

       Console.WriteLine(nameString + ", your salary after taxes is " + final);
  }
}