using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PayerMove.Instance.gameObject)
        {
            PayerMove.Instance.Lose();
        }
    }
}
