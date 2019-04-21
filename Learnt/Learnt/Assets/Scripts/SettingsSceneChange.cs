using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsSceneChange : MonoBehaviour
{
    public GameObject mainMenuGroup;
    public GameObject settingsGroup;
    public void SettingsClick()
    {
        // SceneManager.LoadScene("Settings");
        mainMenuGroup.SetActive(false);
        settingsGroup.SetActive(true);

    }
}
