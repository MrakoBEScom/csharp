using System;

namespace projectCourse;

enum VARIANTS
{
    SCISSORS = 0,
    PAPER = 1,
    ROCK = 2,

}


class Player
{
    private string name = "Default name";

    private VARIANTS choice;


    public Player(VARIANTS choice, string name)
    {
        this.name = name;
        this.choice = choice;
    }

    public Player()
    {
        this.name = "BOT";
        Random random = new Random();
        this.choice = (VARIANTS)random.Next(3);


        
        Console.WriteLine($"Бот выбрал: {choice}");
    }


    public string whoWins(Player bot, Player player)
    {
        
        if (player.choice == VARIANTS.SCISSORS && bot.choice == VARIANTS.SCISSORS)
        {
            return "Ничья";
        }
        else if (player.choice == VARIANTS.PAPER && bot.choice == VARIANTS.PAPER)
        {
            return "Ничья";
        }
        else if (player.choice == VARIANTS.ROCK && bot.choice == VARIANTS.ROCK)
        {
            return "Ничья";
        }
        else if (player.choice == VARIANTS.SCISSORS && bot.choice == VARIANTS.PAPER)
        {
            return $"Победил: {player.name}";
        }
        else if (player.choice == VARIANTS.PAPER && bot.choice == VARIANTS.ROCK)
        {
            return $"Победил: {player.name}";
        }
        else if (player.choice == VARIANTS.ROCK && bot.choice == VARIANTS.SCISSORS)
        {
            return $"Победил: {player.name}";
        }
        else if (player.choice == VARIANTS.SCISSORS && bot.choice == VARIANTS.ROCK)
        {
            return $"Победил: {bot.name}";
        }
        else if (player.choice == VARIANTS.PAPER && bot.choice == VARIANTS.SCISSORS)
        {
            return $"Победил: {bot.name}";
        }
        else if (player.choice == VARIANTS.ROCK && bot.choice == VARIANTS.PAPER)
        {
            return $"Победил: {bot.name}";
        }
        else
        {
            return "Error!";
        }

    }
}