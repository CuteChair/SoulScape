using UnityEngine;

public class OpenDoorTrigger : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;
    private bool isDoorOpen;

    private void Start()
    {
        doorAnimator = GameObject.FindGameObjectWithTag("Door").GetComponentInChildren<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isDoorOpen = true;

            doorAnimator.SetBool("isOpened", isDoorOpen);
        }
    }

}
