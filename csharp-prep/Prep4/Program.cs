using System;

class Program
{
    static void Main(string[] args)
    {
        List <float> numbers;
        numbers = new List<float>();
        float num = -1;
        float sum = 0;
        float highestNumber = -1000;
        float leastPositiveNumber = 150;
        
        do
        {
            Console.Write("Choose a number: ");
            string yourNum = Console.ReadLine();
            num = float.Parse(yourNum);
            if (num != 0)
            {
                numbers.Add(num);
            }
        }while(num != 0);

        foreach(int number in numbers)
        {
            sum += number;
        }
        foreach (int number in numbers)
        {
            if (number > highestNumber)
            {
                highestNumber = number;
            }
        }
        foreach(float number in numbers)
        {
            if (number < leastPositiveNumber && number > 0)
            {
                leastPositiveNumber = number;
            }
        }
        float totalCount = numbers.Count;
        float averageOfNumbers = sum / totalCount;


        
        Console.WriteLine($"The sum of the numbers is {sum}");
        Console.WriteLine($"The Average of the numbers is {averageOfNumbers}");
        Console.WriteLine($"The highest number is {highestNumber}");
        Console.WriteLine($"The least positive number is {leastPositiveNumber}");
        


    }
}