using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainUIHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI bestScoreText;
    [SerializeField] TextMeshProUGUI scoreText;

    void Start()
    {
        MainManager.Instance.onScoreUpdated += UpdateScoreUI;
        UpdateBestUI();
    }

    void UpdateBestUI()
    {
        bestScoreText.SetText($"Best Score: {PlayerManager.Instance.bestScore} ({PlayerManager.Instance.bestName})");
    } 

    void UpdateScoreUI(int score)
    { 
        scoreText.SetText($"Score: {score}");
    }
}
