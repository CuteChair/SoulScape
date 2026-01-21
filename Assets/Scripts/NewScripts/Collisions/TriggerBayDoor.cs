using UnityEngine;

public class TriggerBayDoor : AnimationsAbstract
{
    public override void OnMouseDown()
    {
        if (isNearEnoughToInteract == true)
        {
            PlayAnimation("isOpened");
        }
    }

    public override void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isNearEnoughToInteract = true;
            Debug.Log($"Player is near enough to interact with : {gameObject.name}");
        }
    }

    public override void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isNearEnoughToInteract = true;
            Debug.Log($"Player is no longer close enough to interact with : {gameObject.name}");
        }
    }
}
