using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerSceneChange_Prefab : MonoBehaviour
{
    [SerializeField] private string sceneName;
    [SerializeField] private string spawnPointName;

    private GameManagerScript gameManagerScript;
    private void Awake()
    {
        gameManagerScript = FindAnyObjectByType<GameManagerScript>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            gameManagerScript.levelManager.LoadSceneToSpawnPosition(sceneName, spawnPointName);
        }
    }/*
    if (!string.IsNullOrEmpty(sceneName) && !string.IsNullOrEmpty(spawnPointName))
            {
                Debug.Log("Player entered trigger. Changing scene to: " + sceneName + " and spawn point: " + spawnPointName);

                if (gameManagerScript != null)
                {
                    gameManagerScript.levelManager.LoadSceneToSpawnPosition(sceneName, spawnPointName);
                }
                else
{
    Debug.LogError("Game Manager instance is not found!");
} 
            }*/
}
