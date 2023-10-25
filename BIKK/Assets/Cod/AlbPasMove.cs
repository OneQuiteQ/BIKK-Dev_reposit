using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AlbPasMove : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    private int lives = 5;
    [SerializeField] private int health = 5;
    [SerializeField] private float jumpForce = 15f;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    public static AlbPasMove Instance { get; set; }

    private void Awake()
    {
        lives = 5;
        health = lives;
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }


    private void Update()
    {
        Run();
        if (Input.GetButtonDown("Jump"))
            Jump();

    }


    private void Run()
    {
        transform.Translate(Vector3.right * speed);
    }

    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    public void Lose()
    {
        lives -= 5;
        Debug.Log(health);
        if (lives == 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(2);
        }

    }

}
