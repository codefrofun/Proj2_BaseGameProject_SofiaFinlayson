
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameStateManager gameManager;
    public UIManager uiManager;
    private static GameManagerScript Instance;

    public LevelManager levelManager;
    public PlayerMovement player; // May delete


    private void Awake()
    {
        #region Singelton Pattern

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        #endregion
    }
}