using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        Reference myRef = new Reference("Genesis", "1", "1");
        Scripture scripture  = new Scripture(myRef, "In the beginning God created the heaven and the earth.");

        bool Display()
        {
            Console.Clear();
            scripture.DisplayScripture();
            if(scripture.AllHidden())
                return false;
            Console.WriteLine("\nType 'Quit' to end program or press enter to continue.");
            string input = Console.ReadLine();
            if(input == "Quit")
                return false;
            else
                return true;
        }

        while(Display())
        {
            int counter = 0;
            while(counter < 3)
            {
                int index = rnd.Next(scripture.GetWords().Count);
                if(!scripture.GetWords()[index].GetIsHidden())
                {
                    scripture.GetWords()[index].HideWord();
                    counter++;
                }

                if(scripture.AllHidden())
                    break;
            }
        }
    }
}