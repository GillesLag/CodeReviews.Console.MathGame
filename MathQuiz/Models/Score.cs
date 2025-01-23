using MathQuiz.Enums;
using Spectre.Console;
using System;
namespace MathQuiz.Models;

internal class Score
{
    private DateTime date = DateTime.Now;
    private int totalScore;
    private int maxScore = 5;
    private MenuItems gameMode;

    public Score(MenuItems gameMode, int totalScore)
    {
        this.gameMode = gameMode;
        this.totalScore = totalScore;
    }

    public void ShowScore()
    {
        AnsiConsole.MarkupLine($"[yellow]Gamemode[/] = {Enum.GetName(MenuItems.Addition)}");
        AnsiConsole.MarkupLine($"[yellow]Date[/] = {date.ToString("dd/MM/yyyy")}");
        AnsiConsole.MarkupLine($"[yellow]Score[/] = {totalScore}/{maxScore}");
    }
}
