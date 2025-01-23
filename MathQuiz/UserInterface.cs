using MathQuiz.Enums;
using Spectre.Console;

namespace MathQuiz;

internal class UserInterface
{
    private Game game = new Game();
    internal void ShowMenu()
    {
        var name = AnsiConsole.Ask<string>("Welcome to the mathquiz, What's your name: ");
        Console.Clear();

        while (true)
        {
            Console.Clear();

            var choice = AnsiConsole.Prompt(
               new SelectionPrompt<MenuItems>()
               .Title($"Hello {name}! Choose an option!")
               .AddChoices(Enum.GetValues<MenuItems>()));

            Console.Clear();

            switch (choice)
            {
                case MenuItems.Addition:
                    game.Addition();
                    break;

                case MenuItems.Substraction:
                    game.Substraction();
                    break;

                case MenuItems.Multiplication:
                    game.Multiplication();
                    break;

                case MenuItems.Division:
                    game.Division();
                    break;

                case MenuItems.ShowScores:
                    foreach (var score in MockDatabase.Scores)
                    {
                        score.ShowScore();
                        Console.WriteLine();
                    }

                    Console.ReadKey();
                    break;

                case MenuItems.Quit:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
