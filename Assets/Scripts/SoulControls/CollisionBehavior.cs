using UnityEngine;

public class CollisionBehavior : MonoBehaviour
{
    [SerializeField]
    private Collider soulCollider;
    [SerializeField]
    private Collider playerCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private void Awake()
    {
        //playerCollider = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider>();
        soulCollider = GetComponent<Collider>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Physics.IgnoreCollision(soulCollider, playerCollider);
    }
}
