using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbPasLose : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == AlbPasMove.Instance.gameObject)
        {
            AlbPasMove.Instance.Lose();
        }
    }
}
