using UnityEngine;

public class TestBlueSoul : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 20f;

    [SerializeField]
    private Rigidbody blueSoulRB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        blueSoulRB = GetComponent<Rigidbody>();

        blueSoulRB.linearVelocity = transform.TransformDirection(Vector3.forward * moveSpeed * Time.deltaTime);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
