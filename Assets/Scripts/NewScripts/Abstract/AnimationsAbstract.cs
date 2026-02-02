using Unity.VisualScripting;
using UnityEngine;

public abstract class AnimationsAbstract : MonoBehaviour
{
    [SerializeField] private Animator animator;

    [SerializeField] protected AudioSource associatedSound;

    protected bool isNearEnoughToInteract;

    private void Start()
    {
        isNearEnoughToInteract = false;
    }

    public abstract void OnMouseDown();


    public abstract void OnTriggerEnter(Collider other);


    public abstract void OnTriggerExit(Collider other);
    

    protected void PlayAnimation(string animationName)
    {
        if (animator != null)
        {
            animator.SetTrigger(animationName);
        }
        else
        {
            Debug.LogError("AnimationsAbstrct : Animator is null ");
        }
    }
}
