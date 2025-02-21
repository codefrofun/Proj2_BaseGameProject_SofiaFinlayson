using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private string spawnPointName; 
    private GameManagerScript gameManagerScript;
    private GameObject player;


    public void LoadSceneToSpawnPosition(string sceneName, string spawnPoint)
    {
        spawnPointName = spawnPoint;

        SceneManager.LoadScene(sceneName);

        SceneManager.sceneLoaded += OnSceneLoaded;
    }


    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        SetPlayerToSpawn(spawnPointName);
        SceneManager.sceneLoaded -= OnSceneLoaded;
        Debug.Log("Scene loaded: " + scene.name);
    }

    //set spawn by name
    private void SetPlayerToSpawn(string spawnPointName)
    {
        GameObject spawnPoint = GameObject.Find(spawnPointName);
        player = GameObject.FindGameObjectWithTag("Player");

        if (spawnPoint != null)
        {
            Transform spawnPointTransform = spawnPoint.transform;
            player.transform.position = spawnPointTransform.position;
        }
        else
        {
            // Debug log
        }
    }
}

//UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);