using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset; // Vector3 holds 3 floats, good for x, y ,z positioning
    
    // Update is called once per frame
    void Update() {

        transform.position = player.position + offset; // Lowercase t refers to this object (Main camera in this scenario)

    }
}
