using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoLevel3 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == AlbMove.Instance.gameObject)
        {
            SceneManager.LoadScene(5);
        }
    }
}