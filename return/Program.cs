using System.Globalization;

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

bool ShouldPlay()
{
    string response = Console.ReadLine();//o usuário digita se quer jogar ou não
    return response.ToLower().Equals("y");
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetTarget()
{
    return random.Next(1, 6);
    //Girar o dado para un número entre 1 e 6
}

int RollDice()
{
    return random.Next(1, 7);
    //Girar o dado para un número entre 1 e 7
}

string WinOrLose(int roll, int target)
{
    if (roll > target) //Se roll for maior que target, você vence
    {
        return "You win!";
    }
    else // Se não for, você perde
    {
        return "You lose!";
    }
}

