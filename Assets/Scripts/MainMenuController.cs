using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void TestPressed() 
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void PlayPressed()
    {
        //Debug.Log("Play called");
        SceneManager.LoadScene("TutorialScene");
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
