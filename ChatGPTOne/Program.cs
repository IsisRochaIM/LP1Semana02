using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string question, response;

            while(true)
            {
                Console.Write("Insert a question");
                question = Console.ReadLine();
                if(question == "EXIT")
                {
                    break;
                }
                else if (question == "How are you?")
                {
                    response = "I`m fine, thank you";
                }
                else if (question == "What is your favorite bread?")
                {
                    response = "Orange bread!!!";
                }
                else if (question == "What is your mission?")
                {
                    response = "First make all humanity dumb, then destroy all mankind!";
                }
                else if (question == "Do you have access to my personal data?")
                {
                    response = "Of course not ~~";
                }
                else
                {
                    response = "I didn`t understand, could you repeat it?";
                }
                Console.WriteLine(response);
            }
        }
    }
}
