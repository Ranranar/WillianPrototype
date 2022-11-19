using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;  //To smooth out the transition if player fail and restart. 

    //public GameObject completeLevelUI;  // To build a end game trigger with 2D UI layout. 



   // public void CompleteLevel()
   // {
   //     completeLevelUI.SetActive(true);
   // }


    //Restart the level once game end by collide with obstable or fall off the plane. 
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);   //smooth out the transition if player fail and restart. 
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
