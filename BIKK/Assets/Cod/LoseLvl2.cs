using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseLvl2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == AlbMove.Instance.gameObject)
        {
            AlbMove.Instance.Lose();
        }
    }
}