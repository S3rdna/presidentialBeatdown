using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitSceneChange : MonoBehaviour
{
    public void CloseGame()
    {
        Debug.Log("Quit the game");
        Application.Quit();
    }
}
