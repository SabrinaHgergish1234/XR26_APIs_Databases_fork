using UnityEngine;
using Databases;

public class TestGameData: MonoBehaviour
{
    void Start()
    {
        GameDataManager.Instance.AddHighScore("Oliwer", 100, "Level1");
        GameDataManager.Instance.AddHighScore("Amanda", 160, "Level1");
        GameDataManager.Instance.AddHighScore("Sabrina", 290, "Level2");

        //top score general//
        var topScores = GameDataManager.Instance.GetTopHighScores(5);
        foreach (var score in topScores)
        {
            Debug.Log($"[TOP] {score.PlayerName} - {score.Score} ({score.LevelName})");
        }
        

        // top score level1//
        var level1Scores = GameDataManager.Instance.GetHighScoresForLevel("Level1", 3);
        foreach (var score in level1Scores)
        {
            Debug.Log($"[LEVEL1] {score.PlayerName} - {score.Score}");
        }
    }
}
