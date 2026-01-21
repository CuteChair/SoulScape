using UnityEngine;

public class TriggerCeilingOpen : MonoBehaviour
{
    [SerializeField] private Animator animatorCeiling;
    [SerializeField] private Animator animatorWall;

    [SerializeField] private CollisionUnlockBlueSoul blueSoul;

    private bool isInteracteble = false;

    private void Start()
    {
        animatorCeiling = GameObject.FindGameObjectWithTag("CeilingHang").GetComponent<Animator>();
        animatorWall = GameObject.FindGameObjectWithTag("WallOpen").GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        if (animatorCeiling != null && isInteracteble == true && animatorWall != null)
        {
            animatorCeiling.SetTrigger("isHanging");
            animatorWall.SetTrigger("isDown");
            blueSoul.enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GreenSoul"))
        {
            isInteracteble = true;

            Debug.Log("GreenSoul is close enough to interact");
        }
    }
}
