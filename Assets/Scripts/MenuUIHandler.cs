using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;
using TMPro;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI bestScore;

    public void Start()
    {
        bestScore.text = "Best Score: \n" + UserManager.Instance.bestPlayerName + ": " + UserManager.Instance.bestScore;
    }
    public void StartNew()
    {
        UserManager.Instance.SetPlayerName();
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}