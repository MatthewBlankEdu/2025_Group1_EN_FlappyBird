using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public TextMeshProUGUI pointsField;
    public Rigidbody2D rigid;
    public float jumpForce;

    public static bool hasStarted;
    public static bool gameOver;
    
    private float gravityScale;
    private int points;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hasStarted = false;
        gameOver = false;
        
        gravityScale = rigid.gravityScale;
        rigid.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver == true)
            return;
        
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

    private void OnCollisionEnter2D(Collision2D other)
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Points"))
        {
            points++;
            pointsField.text = points.ToString();
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("FlappyBird");
    }
}
