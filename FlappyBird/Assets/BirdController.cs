using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float jumpForce;

    private bool hasStarted;
    private float gravityScale;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gravityScale = rigid.gravityScale;
        rigid.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if(hasStarted == false)
            {
                rigid.gravityScale = gravityScale;
                hasStarted = true;
            }

            rigid.linearVelocity = Vector2.zero;
            rigid.AddForceY(jumpForce, ForceMode2D.Impulse);
        }
    }
}
