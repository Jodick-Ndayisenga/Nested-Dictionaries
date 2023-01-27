using System;
using System.Collections.Generic;

Dictionary<int, Dictionary<string, string>>myData= new Dictionary<int, Dictionary<string, string>>();

int i=1;
double total =0;
while (i<11)
{
    Console.WriteLine();
    Console.Write(" What is your first name: ");
    string firstName = Console.ReadLine();

    Console.Write(" What is your number: ");
    string number = Console.ReadLine();

    Console.Write(" What is the cost: ");
    string cost = Console.ReadLine();
    total+= double.Parse(cost);

    var firstPerson = new Dictionary<string, string>()
    {
        {"name", firstName },
        {"number",number },
        {"cost",cost},
    };
    myData.Add(i, firstPerson);
    Console.WriteLine(" ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" NAME\t\t");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("NUMBER\t\t");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("COST");
    Console.ResetColor();
    //Console.WriteLine(" NAME\t\tNUMBER\t\tCOST");
    Console.WriteLine("-----------------------------------------");
    foreach (int person in myData.Keys)
    {
        Dictionary<string, string> personData = myData[person];
        Console.ForegroundColor= ConsoleColor.Red;
        Console.Write($" {personData["name"]}\t\t");
        Console.ForegroundColor= ConsoleColor.Green;
        Console.Write($"{personData["number"]}\t\t");
        Console.ForegroundColor= ConsoleColor.Blue;
        Console.WriteLine($"Ksh.{personData["cost"]}");
        Console.ResetColor();
        //Console.WriteLine($" {personData["name"]}\t\t{personData["number"]}\t\tKsh.{personData["cost"]}");
    }
    Console.WriteLine("-----------------------------------------");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(" TOTAL\t\t\t\t");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Ksh.{total}");
    Console.ResetColor();
    i++;
}