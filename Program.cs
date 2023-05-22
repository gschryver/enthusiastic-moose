using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // As a question
    CanadaQuestion();
    EnthusiasticQuestion();
    LoveCSharpQuestion();
    SecretQuestion();
}

// refactoring for less redundancy 
void AskQuestion(string question, string yesResponse, string noResponse) // we're passing in 3 strings, question, yesResponse, and noResponse
{
    bool isTrue = MooseAsks(question); // if the answer is yes, isTrue will be true, if the answer is no, isTrue will be false
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
    AskQuestion("Is Canada real?", "Really? It seems very unlikely.", "I KNEW IT !!!");
}

void EnthusiasticQuestion()
{
    AskQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
}

void LoveCSharpQuestion() 
{ 
    AskQuestion("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
}

void SecretQuestion() {
    AskQuestion("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
}


bool MooseAsks(string question) // bool is the return type, MooseAsks is the method name, string question is the parameter. 
// MooseAsks(the string for 'question' is "Is Canada real?")
{
    Console.Write($"{question} (Y/N): "); // $ allows you to use {question} to insert the question variable into the string
    string answer = Console.ReadLine().ToLower(); // .ToLower() makes it so that the answer is not case sensitive

// Keep asking until they answer Y or N
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