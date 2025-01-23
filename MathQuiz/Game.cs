using MathQuiz.Enums;
using MathQuiz.Models;
using Spectre.Console;

namespace MathQuiz;

internal class Game
{
    private Random _random = new Random();
    public void Addition()
    {
        int score = 0;
        for (int i = 0; i < 5; i++)
        {
            int num1 = _random.Next(1, 10);
            int num2 = _random.Next(1, 10);
            int answer = num1 + num2;

            var userInput = AnsiConsole.Ask<int>($"{num1} + {num2} = ");

            if(IsCorrectAnswer(answer, userInput))
            {
                score++;
            }
        }

        SaveScore(MenuItems.Addition, score);
    }

    public void Substraction()
    {
        int score = 0;
        for (int i = 0; i < 5; i++)
        {
            int num1 = _random.Next(1, 10);
            int num2 = _random.Next(1, 10);
            int answer = num1 - num2;

            var userInput = AnsiConsole.Ask<int>($"{num1} - {num2} = ");

            if (IsCorrectAnswer(answer, userInput))
            {
                score++;
            }
        }

        SaveScore(MenuItems.Substraction, score);
    }

    public void Multiplication()
    {
        int score = 0;
        for (int i = 0; i < 5; i++)
        {
            int num1 = _random.Next(1, 10);
            int num2 = _random.Next(1, 10);
            int answer = num1 * num2;

            var userInput = AnsiConsole.Ask<int>($"{num1} * {num2} = ");

            if (IsCorrectAnswer(answer, userInput))
            {
                score++;
            }
        }

        SaveScore(MenuItems.Multiplication, score);
    }

    public void Division()
    {
        int score = 0;
        for (int i = 0; i < 5; i++)
        {
            int num1;
            int num2;

            do
            {
                num1 = _random.Next(1, 100);
                num2 = _random.Next(1, 100);
            }
            while (num1 % num2 != 0);

            
            int answer = num1 / num2;

            var userInput = AnsiConsole.Ask<int>($"{num1} / {num2} = ");

            if (IsCorrectAnswer(answer, userInput))
            {
                score++;
            }
        }

        SaveScore(MenuItems.Multiplication, score);
    }

    private bool IsCorrectAnswer(int answer, int userAsnwer)
    {
        return answer == userAsnwer;
    }

    private void SaveScore(MenuItems item, int score)
    {
        Score userScore = new(item, score);
        MockDatabase.Scores.Add(userScore);

        userScore.ShowScore();
        Console.ReadKey();
    }
}
