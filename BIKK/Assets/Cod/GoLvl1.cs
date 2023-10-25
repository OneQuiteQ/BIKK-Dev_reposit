using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoLvl1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == AlbPasMove.Instance.gameObject)
        {
            SceneManager.LoadScene(1);
        }
    }
}