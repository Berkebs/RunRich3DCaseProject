using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public static GameSceneManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void ChangeScene(int SceneNumber) 
    {
        SceneManager.LoadScene(SceneNumber);
    }
    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    public void ChangeScene()
    {
        ChangeScene(SceneManager.GetActiveScene().buildIndex);
    }
}
