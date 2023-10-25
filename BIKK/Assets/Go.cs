using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Go : MonoBehaviour
{
    public Button [] Play;

    private void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
    }

    public void Select(int numberInBuild)
    {
        SceneManager.LoadScene(numberInBuild);
    }
}