using UnityEngine;

public class CollisionUnlockBlueSoul : MonoBehaviour
{
    [SerializeField] private PowerManager powerManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            powerManager.UnlockBlueSoul();
        }
    }
}
