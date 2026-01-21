using UnityEngine;

public class PossessedCollision : MonoBehaviour
{

    [SerializeField] private PlayerStateManager playerStateManager;

    public bool isPossessed = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BlueSoul"))
        {
            isPossessed = true;
            Destroy(collision.gameObject);
            
            Debug.Log($"Current player state : {playerStateManager.CurrentState}");
        }
    }
}
