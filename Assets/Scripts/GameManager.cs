using UnityEngine;
using UnityEngine.SceneManagement; // Use when changing to new scene or reloading current scene

//Reponsable for changing states in our game
// Start/Stop a game, restart a game
// Display UI on the screen for a score counter
// Display gameover screen
// Transition to main menu/level selector

public class GameManager : MonoBehaviour
{

    bool gameEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if(gameEnded == false)
        {
            gameEnded = true;
            Invoke("Restart", restartDelay); // (Name of function, delay before calling it)
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
