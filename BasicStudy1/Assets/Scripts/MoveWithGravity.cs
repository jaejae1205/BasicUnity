using UnityEngine;

public class MoveWithGravity : MonoBehaviour
{

    public Rigidbody rb;

    public float jumpForce = 5.0f;

    void Start()
    {

    }


    void Update()
    {
        //space 키를 누르면 점프

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }
}
