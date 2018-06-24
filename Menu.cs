using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Menu : MonoBehaviour {
    public GameObject settings;

    public void StartGame()
    {
        Application.LoadLevel (1);
    }

    public void Settings() {
        settings.SetActive(!settings.activeSelf);
    }

    public void Exit()
    {
        Application.Quit();
    }

}
