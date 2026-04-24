using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{
    [SerializeField] public int SceneIndex;
    public void Menu()
    {
        StartCoroutine(LoadWithDelay(0));
    }

    public void Level()
    {
        StartCoroutine(LoadWithDelay(1));
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadWithDelay((SceneIndex + 1) % 4));
    }

    public void LoadLevelIndex(int i)
    {
        StartCoroutine(LoadWithDelay(i));
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    private IEnumerator LoadWithDelay(int sceneIndex)
    {
        yield return new WaitForSecondsRealtime(0.7f); // works even if game is paused
        SceneManager.LoadScene(sceneIndex);
    }
}
