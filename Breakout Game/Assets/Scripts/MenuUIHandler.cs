using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI bestScoreText;
    [SerializeField] TMP_InputField nameField; 

    void Start()
    {
        UpdateBestUI();
    }

    void UpdateBestUI()
    {
        bestScoreText.SetText($"Best Score: {PlayerManager.Instance.bestScore} ({PlayerManager.Instance.bestName})");
        nameField.text = PlayerManager.Instance.bestName;
    } 

    // debug method
    public void SaveCurrentData()
    {
        PlayerManager.Instance.SaveBestData();
    }

    // debug method
    public void LoadCurrentData()
    {
        PlayerManager.Instance.LoadBestData();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}
