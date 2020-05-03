using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsManager : MonoBehaviour
{
    public static bool gameFinished = false;
    public void MainMenuPressed()
    {
        if (gameFinished)
        {
            Player.Instance.inventory[0] = false;
            Destroy(GameObject.Find("FirstPersonPlayer"));
        }
        SceneManager.LoadScene("MainMenu");
    }
}
