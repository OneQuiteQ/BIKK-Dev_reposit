using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PayerMove1.Instance.gameObject)
        {
            PayerMove1.Instance.Lose();
        }
    }
}
