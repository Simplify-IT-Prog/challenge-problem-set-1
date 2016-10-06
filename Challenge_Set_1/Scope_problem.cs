/**
The below code is the beginning of a game, but already suffers a potential vulnerability that allows savvy players to append code to our program and modify their score. 

Refactor the code to protect from this.
**/

using System;
public class Score
{
    private int score = 0;
    public void increaseScore()
    {
        this.score++;
    }
    public void decreaseScore()
    {
        this.score--;
    }
    public void setScore(int score)
    {
        this.score = 9000;
    }
    public void showScore()
    {
        Console.WriteLine ("{0}", score);
    }
}

public class SomeEvilProgram
{
    public static void Main()
    {
        Score objScore = new Score();
        objScore.setScore (9000);
        objScore.showScore();
        objScore.increaseScore();
        objScore.showScore();
        objScore.decreaseScore();
        objScore.showScore();
    }
}


