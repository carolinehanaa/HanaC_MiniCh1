/*10-18-2022
Caroline Hana
Mini Challenge #1 "What is your name?"
This is console project that the users input and print their name
*/

Console.Clear();

string? playAgain = "yes";
while (playAgain == "yes")
{
    string? myName;

    Console.WriteLine("Hello, what is your name?");
    myName = Console.ReadLine();

    Console.WriteLine($"Hello {myName}");

    string? answer = "";
    while (answer != "yes" && answer != "no")
    {
        Console.WriteLine("Would you like to enter another name? (yes or no)");
        answer = Console.ReadLine();
        answer = answer.ToLower();
             if(answer == "yes")
             {
                playAgain = answer;
             }
             else if (answer == "no")
             {
                playAgain = answer;
             }
             else
             {
                Console.WriteLine("Invalid Answer");
             }

    }







}