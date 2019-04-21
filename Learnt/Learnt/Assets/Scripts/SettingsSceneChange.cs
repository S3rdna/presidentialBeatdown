using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsSceneChange : MonoBehaviour
{
    public void SettingsClick()
    {
        SceneManager.LoadScene("Settings");
    }
}
