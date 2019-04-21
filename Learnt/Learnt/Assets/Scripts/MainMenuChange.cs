using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuChange : MonoBehaviour
{
    public GameObject mainMenuGroup;
    public GameObject settingsGroup;
    public void SettingsClick()
    {
        settingsGroup.SetActive(false);
        mainMenuGroup.SetActive(true);
    }
}
