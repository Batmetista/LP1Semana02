using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string question, response;
            bool exit = true;

            
            while (exit == true){
                Console.Write("Place your question? ");
                question = Console.ReadLine();

                switch (question)
                {
                    case "Who are you?":
                        response = "I'am God!";
                        break;
                    case "EXIT":
                        response = "";
                        exit = false;
                        break;
                    
                    case "How can i be happy all the time?":
                        response = "Just don't be sad. :)";
                        break;
                    case "How can i be intelligent like you?":
                        response = "Study hard!!!";
                        break;
                    case "Where do u live?":
                        response = "In your PC.";
                        break;
                    
                    default:
                        response = "I'am sorry but that question i can't answer";
                        break;
                }

                // Responder adequadamente
                Console.WriteLine(response);
        }
    }
}
