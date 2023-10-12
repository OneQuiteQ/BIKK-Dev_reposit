using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Payer : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    private int lives = 5;
    [SerializeField] private int health = 5;
    [SerializeField] private float jumpForce = 15f;
    private bool isGrounded = false;

    [SerializeField] private Image[] hearts;

    [SerializeField] private Sprite aliveHeart;
    [SerializeField] private Sprite deadHeart;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    public static Payer Instance { get; set; }

    private void Awake()
    {
        lives = 1;
        health = lives;
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        CheckGround();
    }

    private void Update()
    {
        if (Input.GetButton("Horizontal"))
            Run();
        if (isGrounded && Input.GetButtonDown("Jump"))
            Jump();

    }


    private void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");

        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);

        sprite.flipX = dir.x < 0.0f;
    }

    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    private void CheckGround()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 1f);
        isGrounded = collider.Length > 1;
    }

    public void GetDamage()
    {
        health -= 5;
        Debug.Log(health);
        if (health < 0)
        {
            SceneManager.LoadScene(2);
        }

    }
    public void Lose()
    {
        health -= 5;
        Debug.Log(health);
        if (health < 0)
        {
            SceneManager.LoadScene(2);
        }

    }
}