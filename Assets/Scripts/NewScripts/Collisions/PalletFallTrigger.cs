using UnityEngine;

public class PalletFallTrigger : MonoBehaviour
{

    [SerializeField] private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GameObject.FindGameObjectWithTag("PalletFall").GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision with : " + gameObject.name);
        if (other.CompareTag("Player"))
        {
            if (animator != null)
            {
                animator.SetTrigger("isFalling");
            }
            else
            {
                Debug.LogWarning("The animator is null");
            }
        }
        
    }
}
