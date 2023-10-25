using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreackBlock : MonoBehaviour
{
    [SerializeField] private int lives = 2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PayerMove.Instance.gameObject)
        {
            lives--;
        }
        if (lives < 1)
            Destroy(this.gameObject);
    }
}
