// // See https://aka.ms/new-console-template for more information
// Guessing game, play a quick guessing game.
Console.WriteLine("Welcome To Guessing Game");

while(true)
{

Console.WriteLine("Enter the number for the menu option");
Console.WriteLine("[1] - Play the guessing game");
Console.WriteLine("[0] - Exit");

int menu = int.Parse(Console.ReadLine());

switch (menu)
{
    case 0: return;

    case 1:




        var rand = new Random(); //Creates a rando number
        int secret = rand.Next(11); //makes the rando and saves it to secret.

        while (true){

            Console.WriteLine("Guess a number between 0 and 10");

            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("you guessed:" + input);

            if (input == secret){

                Console.WriteLine("Congrats! you guessed the secret number");
                break;
            }
            else if (input > secret){
                Console.WriteLine("You're guess is too high!");

            }
            else {
                Console.WriteLine("Your guess too low, looks like.");
            }


        }

        Console.WriteLine("Goodgame! you played well");
        break;
    
    default:
        Console.WriteLine("bad input: input not a valid option.");
        break;

}
}