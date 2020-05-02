using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Button continueButton;
    private void Start()
    {
        if (Player.Instance == null)
            continueButton.interactable = false;
        else
            continueButton.interactable = true;
    }

    public void CreditsPressed() 
    {
        SceneManager.LoadScene("Credits");
    }

    public void NewGamePressed() 
    {
        SceneManager.LoadScene("HubScene");
        if (Player.Instance != null)
        {
            Player.Instance.NewGame();
        }
        Player.Instance.currentLevel = "HubScene";
        Cursor.lockState = CursorLockMode.Locked;

        CreditsManager.gameFinished = false;
    }

    public void PlayPressed()
    {
        //Debug.Log("Play called");
        SceneManager.LoadScene(Player.Instance.currentLevel);
        Cursor.lockState = CursorLockMode.Locked;
        //if (Player.Instance != null)
        //{
        //    Door door = gameObject.AddComponent<Door>() as Door;
        //    //Door door = new Door();
        //    Player.Instance.transform.position = new Vector3(-5.82f, -2.92f, 0f);
        //    Player.Instance.NewGame();
        //    Player.Instance.Inactive(true);
        //    CreditsManager.gameFinished = false;
        //}
    }

    public void QuitPressed()
    {
        //Debug.Log("Quit called");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif

    }

}
