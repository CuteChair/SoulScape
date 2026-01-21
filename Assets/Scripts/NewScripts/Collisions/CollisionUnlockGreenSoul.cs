using UnityEngine;

public class CollisionUnlockGreenSoul : MonoBehaviour
{
    [SerializeField] private PowerManager powerManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            powerManager.UnlockGreenSoul();
        }
    }
}
