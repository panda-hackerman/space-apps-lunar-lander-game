using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject CreditsPanel;

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OpenCredits()
    {
        CreditsPanel.SetActive(true);
    }

    public void CloseCredits()
    {
        CreditsPanel.SetActive(false);
    }
}
