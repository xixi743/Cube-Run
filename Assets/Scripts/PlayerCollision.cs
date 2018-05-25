using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement; //reference to PlayerMovement script
    

    //this function run when the player hits another object
    //we get information about the collision and call it collisionInfo
    private void OnCollisionEnter(Collision collisionInfo)
    {
        //we check if the object collided with an object that has the tag "obstacle" 
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; //disables player movement
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}