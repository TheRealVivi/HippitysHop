using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public void ContinuePressed() 
    {
        Player.Instance.hp = 100;
        Door door = gameObject.AddComponent<Door>() as Door;
        door.goingToIndex = Player.Instance.currentLevelInt;
        Collider collider = Player.Instance.GetComponent<Collider>();
        door.Open(collider, door.scenes[door.goingToIndex], Door.Coordinates.cooridnates[door.goingToIndex]);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void MainMenuPressed() 
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
        Player.Instance.Inactive(false);
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
