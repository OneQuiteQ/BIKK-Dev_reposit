using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoLevel2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PayerMove.Instance.gameObject)
        {
            SceneManager.LoadScene(3);
        }
    }
}