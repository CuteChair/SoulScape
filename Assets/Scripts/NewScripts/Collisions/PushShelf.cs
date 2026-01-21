using UnityEngine;

public class PushShelf : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private bool isPushable = false;

    private void Start()
    {
        animator = GetComponent<Animator>();    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPushable = true;
        }
    }

    private void OnMouseDown()
    {
        if (isPushable == true)
        {
            animator.SetTrigger("isFalling");
        }
    }
}
