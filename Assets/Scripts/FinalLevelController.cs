using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalLevelController : MonoBehaviour
{
    public Dialog dialog;
    public AudioClip sadBossDeath;
    public AudioClip bossScreech;
    public AudioClip song2;
    // Start is called before the first frame update
    void Start()
    {
        Player.Instance.currentLevel = "FinalLevel";
        FindObjectOfType<DialogManager>().StartDialog(this.dialog);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.Instance.transform.position.y < -5f)
            Player.Instance.hp = 0;

        CreditsManager.gameFinished = Hippity.HippityIsDead;

        if (Hippity.HippityIsDead) 
        {
            StartCoroutine(AfterBossFight());
        }
    }

    IEnumerator AfterBossFight() 
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = bossScreech;
        audio.Play();
        yield return new WaitForSeconds(10f);
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Credits");
    }

}
