//Jacob Abel
//Temperature Conversion (From Fahrenheit to Celcius and Kelvin)
//Last edited 9/10/19
using System;

class MainClass {

  public static void Main (string[] args) 
  {

//This line is my declared variables and strings that the program will be told to recognize
    double fahrenheit, kelvin, celcius;
    string fahrenheitString;

//I created a prompt to inform the user what to do and made a command to have the program take in a value entered in by the user
    Console.WriteLine("Insert a temperature in Fahrenheit.");
    fahrenheitString = Console.ReadLine();
    fahrenheit = double.Parse(fahrenheitString);

//These are the two conversion equations used which will convert the Fahrenheit number inserted into their specific units.
    celcius = (fahrenheit - 32) * 5/9 ;
    kelvin = celcius + 273.15;
    
//This last line informs the user what the numbers spat out means.
    Console.WriteLine("The temperature in Celcius is " + celcius);Console.WriteLine("The temperature in Kelvin is " + kelvin);
  }
} 