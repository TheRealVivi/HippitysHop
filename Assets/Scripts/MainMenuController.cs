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
        if (Player.Instance != null)
        {
            Player.Instance.NewGame();
        }

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        CreditsManager.gameFinished = false;
        SceneManager.LoadScene("HubScene");
    }

    public void PlayPressed()
    {
        //Debug.Log("Play called");
        Door door = gameObject.AddComponent<Door>() as Door;
        if (Player.Instance.hp <= 0) 
        {
            Player.Instance.hp = 100;
            door.goingToIndex = Player.Instance.currentLevelInt;
            Collider collider = Player.Instance.GetComponent<Collider>();
            door.Open(collider, door.scenes[door.goingToIndex], Door.Coordinates.cooridnates[door.goingToIndex]);
        }
        else
            SceneManager.LoadScene(door.scenes[Player.Instance.currentLevelInt]);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
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
