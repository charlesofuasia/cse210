using System;

/*
For creativity, I added the following improvements:
1. In the reflection activity, I added a loop for the code that randomly picks a question 
   such that a question once picked cannot be picked again in the same round of the activity.
    This removes monotony and helps make the activity more exciting.
2. I added functions in the ListingActivity and Program classes that correctly chooses singular 
   or plural nouns depending on the number of items counted. if item counted is greater than 1, the function 
   appends "s" to the noun.
3. After exiting the program, the list of activity and the number of times each activity is carried
   out are displayed on the console.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Wellcome to the Mindfullness App");
        Thread.Sleep(2000);
        Console.WriteLine();
        string option = "";

        int bCount = 0;
        int lCount = 0;
        int rCount = 0;

           while(option != "4")
           {
             option = ChooseOption();
            switch(option){
            case "1":
            BreathingActivity breathing = new BreathingActivity();
            breathing.RunBreathingActivity();
            bCount++;
            break;

            case "2":
            ListingActivity listing = new ListingActivity();
            listing.RunListingActivity();
            lCount++;
            break;

            case "3":
            ReflectionActivity reflection = new ReflectionActivity();
            reflection.RunReflectionActivity();
            rCount++;
            break;

           
            case "4":
            break;

        };
         }
        Console.WriteLine();
        Console.WriteLine($"You have completed:\n{bCount} round{AddS(bCount)} of breathing activity\n{lCount} round{AddS(lCount)} of listing activity\n{rCount} round{AddS(rCount)} of reflection activity.\n\tWell Done!");
             
        static string ChooseOption()
        {
            /*
              A function to display the options and prompts user to choose one of the options
              Parameters: none
              Returns string: option
            */
            Console.Clear();
            Console.WriteLine("Choose one option from this list:");
            Console.WriteLine("1. Breathing.\n2. Listing.\n3. Reflection.\n4. Exit");
            string option = Console.ReadLine();
            return option;
        }

        static string AddS(int count){
            /*
             A function to append "s" to a word if the word represents a plural item.
            */
            if(count > 1)
            {
                return "s";
            }
            else
            {
                return "";
            }
        }
    }
}