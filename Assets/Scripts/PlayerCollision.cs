using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
 
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; // or FindObjectOfType<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManager>().EndGame(); // Searches for a script
        }
    }

}
