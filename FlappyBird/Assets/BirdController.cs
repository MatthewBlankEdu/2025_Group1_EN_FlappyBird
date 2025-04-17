using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float jumpForce;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForceY(jumpForce, ForceMode2D.Impulse);
        }
    }
}
