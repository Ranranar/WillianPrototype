using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;   //A reference to our PlayerMovement script

    //This function runs when we hit another object.
    //We got information about the collistion and call it "collisionInfo"

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {

        //We check if the object we collided with has a tag called "Obstacle"
        if (collisionInfo.gameObject.tag == "Obstacle") 
        {
            //Debug.Log("I hit Obstacle");
           movement.enabled = false; //Disable the player movement. 
           FindObjectOfType<GameManager>().EndGame();
        }
    }

}
