using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{
    [SerializeField] private int SceneIndex;
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Level()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene((SceneIndex+1)%4);
    }
    public void LoadLevelIndex(int i)
    {
        SceneManager.LoadScene(i);
    }
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
