using Unity.VisualScripting;
using UnityEngine;

public class TriggerCeilingFall : AnimationsAbstract
{
    public override void OnMouseDown()
    {
        if(isNearEnoughToInteract == true)
        {
            associatedSound.Play();

            PlayAnimation("isFalling");
        }
        
    }

    public override void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GreenSoul"))
        {
            isNearEnoughToInteract = true;
            Debug.Log($"Player can interact with : {gameObject.name}");
        }
    }

    public override void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("GreenSoul"))
        {
            isNearEnoughToInteract = false;
            Debug.Log($"Player can no longer interact with : {gameObject.name}");
        }
    }
}
