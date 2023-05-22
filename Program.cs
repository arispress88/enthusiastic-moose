// See https://aka.ms/new-console-template for more information
using System;

Main();

    void Main()
    {
        Console.WriteLine("Welcome to the Enthusiastic Moose Simulator");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine();

        //Let the moose speak!
        MooseSays("H I, I'M  E N T H U S I A S T I C !");
        MooseSays("I really am enthusiastic");

        //As a question
        CanadaQuestion();
        EnthusiasticQuestion();
        LoveCSharpQuestion();
        SecretQuestion();

        //Refactored code for less redundancy
        void AskQuestion(string question, string yesResponse, string noResponse) //Total of 3 strings passing through this function
        {
            bool isTrue = MooseAsks(question); //If the answer is yes, isTrue will always be true. If no, isTrue will be false
            if (isTrue)
            {
                MooseSays(yesResponse);
            }
            else
            {
                MooseSays(noResponse);
            }
        }
        void CanadaQuestion()
        {
            AskQuestion("Is Canada real?", "Really? It seems unlikely.", "I KNEW IT !!!");
        }

        void EnthusiasticQuestion()
        {
            AskQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
        }

        void LoveCSharpQuestion()
        {
           AskQuestion("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
        }

        void SecretQuestion()
        {
            AskQuestion("Do you want to know a secret?", "ME TOO!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
        }
    }




void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
        ");
    }

  static bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): "); //$ allows you to use {question} to insert the question variable into the string
    string answer = Console.ReadLine().ToLower(); //using .ToLower() allows the use of lower case answers

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}
