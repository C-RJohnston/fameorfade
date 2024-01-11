using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mouseOver : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Scenes/Game");
    }
}
