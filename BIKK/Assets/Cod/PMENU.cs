using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMENU : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    private Vector3 dir;
    private SpriteRenderer sprite;

    private void Start()
    {
        dir = transform.up;
    }

    private void Update()
    {
        Move();
    }


    private void Move()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position + transform.up * 0.1f + transform.up * dir.y * 0.1f, 0.1f);

        if (colliders.Length > 0) dir *= -1;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, Time.deltaTime * speed);
    }
}
