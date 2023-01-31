using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public spPlayer movement;
    bool gameEnd = false;
    public GameObject levelcompeleted;
    public void EndGame()
    {
        if (!gameEnd)
        {
            gameEnd = true;
            Debug.Log("Game Over!");
            //Restart();
            Invoke("Restart", 1);
        }
        
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameCompleted()
    {
        levelcompeleted.SetActive(true);
        Debug.Log("you win this level");
        movement.enabled = false;
    }
}
