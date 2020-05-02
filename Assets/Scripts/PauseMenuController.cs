using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenu;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    }

    public void Resume()
    {
        //Debug.Log("Resume called");
        pauseMenu.SetActive(false);
        Player.Instance.Inactive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void Pause()
    {
        //Debug.Log("Pause called");
        pauseMenu.SetActive(true);
        Player.Instance.Inactive(false);
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void MainMenuPressed()
    {
        //Debug.Log("MainMenu called");
        Player.Instance.currentLevel = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
        Player.Instance.Inactive(false);
        //Player.Instance.transform.position = new Vector3(6f, -3.86f, 0f);
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
