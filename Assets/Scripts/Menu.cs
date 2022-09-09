using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text nameText;
    public Text BestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        DataManager.Instance.LoadScore();
        BestScoreText.text = "Best Score: " + DataManager.Instance.Name + ": " + DataManager.Instance.Score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartNew()
    {
        DataManager.Instance.CurrentName = nameText.text;
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
