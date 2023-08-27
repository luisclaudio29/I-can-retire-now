using System;

class Program
{
    public static void Main(string[] args)
    {
        string contributionManTime = "20";
        string contributionWomanTime = "15";

        string manRetirementAge = "65";
        string womanRetirementAge = "62";

        Console.Write("You are Man or Woman? ");
        string gender = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("How much contribution time do you have? ");
        double contributionTime = Convert.ToDouble(Console.ReadLine());

        int retirementAge = 0;

        if (gender == "man")
        {
            retirementAge = 65;
        }
        else if (gender == "woman")
        {
            retirementAge = 62;
        }

        if (age >= retirementAge)
        {
            Console.WriteLine("You can now retire");
        }
        else
        {
            int timeLeft = retirementAge - age;
            Console.WriteLine($"Missing {timeLeft} years for you to retire");
        }
    }
}


