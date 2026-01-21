using UnityEngine;

public class GreenSoulMovements : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;



    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 mouvements = new Vector3(x, 0, z);

        Vector3 vertMoves = new Vector3(0, 1, 0);

        transform.Translate(mouvements * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(vertMoves * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(vertMoves * -speed * Time.deltaTime);
        }
    }
}
