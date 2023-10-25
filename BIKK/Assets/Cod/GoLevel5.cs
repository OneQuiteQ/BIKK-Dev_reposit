using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoLevel5 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == PayerMove1.Instance.gameObject)
        {
            SceneManager.LoadScene(7);
        }
    }
}