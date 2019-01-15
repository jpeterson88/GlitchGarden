using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : Singleton
{
    [SerializeField] int timeToWait = 4;
    int currentSceneIndex;

    void Awake()
    {
        SetupSingleton();
    }

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(LoadNextScene());
        }
    }

    IEnumerator LoadNextScene()
    {
        currentSceneIndex++;
        yield return new WaitForSeconds(timeToWait);
        Debug.Log("Loading scene " + currentSceneIndex.ToString());
        SceneManager.LoadScene(currentSceneIndex);
    }
}
