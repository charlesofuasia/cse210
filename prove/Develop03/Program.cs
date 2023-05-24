using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        Reference myRef = new Reference("Enos", "1", "2");

        ScriptureSelector text = new ScriptureSelector("scripture.txt");
        string textVerse = text.GetText();
       
        Scripture scripture  = new Scripture(myRef, textVerse);

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