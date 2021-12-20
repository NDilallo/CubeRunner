using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;
    
    void OnTriggerEnter() // OnCollisionEnter wont work if marked as trigger
    {
        gameManager.CompleteLevel();
    }

}
