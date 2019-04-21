using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySceneChange : MonoBehaviour
{
    public void OnMouseClick()
    {
        Debug.Log("Clicked button");
        SceneManager.LoadScene("main");
    }
}
