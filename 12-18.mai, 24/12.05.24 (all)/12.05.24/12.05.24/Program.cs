
/*
 * 1. RotateText
2. Change word
1 -> En funksjon som tar en tekst som parameter og som returnerer teksten snudd i motsatt rekkefølge. For eksempel skal 'Terje' bli til 'ejreT.
2 -> En funksjon som bytter ut alle 'e' med 'a' i tekst du sender inn*/

class Program
{
    static void Main()
    {

        string word1 = "Malin";
        string word2 = "Emilie";

        Console.WriteLine("Press 1 for RotateWord()");
        Console.WriteLine("Press 2 for ChangeWord()");

        string answer = Console.ReadLine();

        if(answer == "1")
        { 
            Console.WriteLine($"the result is: {RotateWord(word1)}");
        }else if (answer == "2")
        {
            Console.WriteLine($"the result is: {ChangeWord(word2)}");
        }
        else
        {
            Console.WriteLine("Please answer only 1 or 2");
            Main();
        }
    }

    public static string RotateWord(string text)
    {
        char[] letters = text.ToCharArray();
        Array.Reverse(letters);
        return new string(letters);     }

    public static string ChangeWord(string text)
    {
        char[] chars = text.ToCharArray();
        for(int i = 0; i<chars.Length; i++)
        {
            if (char.ToLower(chars[i]) == 'e')
            {
                chars[i] = 'a';
            }
        }
        return new string(chars);
    }

}