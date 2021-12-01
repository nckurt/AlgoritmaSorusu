using System;

namespace GuncelAlgoritmaSorusu
{
    class Program
    {
        static void Main(string[] args)
        {            

            const string text = "nhoJ (Griffith) nodnoL saw (an) (American) ,tsilevon ,tsilanruoj (and) laicos .tsivitca ((A) reenoip (of) laicremmoc noitcif (and) naciremA ,senizagam (he) saw eno (of) (the) tsrif (American) srohtua (to) emoceb (an) lanoitanretni ytirbelec (and) nrae a egral enutrof (from) ).gnitirw";

            const string answer = "John Griffith London was an American novelist, journalist, and social activist. (A pioneer of commercial fiction and American magazines, he was one of the first American authors to become an international celebrity and earn a large fortune from writing.)";            

            if (CorrectTheText(text)==answer)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Sorry, it does not match with the correct answer.");
            }
            
            Console.ReadLine();
            
        }

        public static string CorrectTheText(string text)
        {
            string newText=null;
            string[] splited;
            splited=text.Split(" ");
            string correctedWord;                        
            for (int i=0;i<splited.Length;i++)
            {                
                if (splited[i].StartsWith('(')&& splited[i].EndsWith(')'))
                {                   
                    correctedWord=splited[i].Remove(0, 1);
                    correctedWord=correctedWord.Remove(correctedWord.Length-1, 1);
                    if (i == 0)
                    {
                        newText = correctedWord;
                    }
                    else
                    {
                        newText = string.Join(" ", newText, correctedWord);
                    }
                }
                else
                {
                    char[] charArray = splited[i].ToCharArray();
                    Array.Reverse(charArray);
                    if (i == 0)
                    {
                        newText = new string(charArray);
                    }
                    else
                    {
                        newText = string.Join(" ", newText, new string(charArray));
                    }
                }
            }
            return newText;
        }
    }
}
