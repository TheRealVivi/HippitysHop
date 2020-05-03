using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalLevelController : MonoBehaviour
{
    public Text bossHp;
    public Dialog dialog;
    public Dialog dyingDialog;
    public AudioClip sadBossDeath;
    public AudioClip bossMusic;
    Hippity hippity;
    bool beginningTriggered;
    bool endingTriggered;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        hippity = FindObjectOfType<Hippity>();
        beginningTriggered = false;
        endingTriggered = false;
        Player.Instance.currentLevel = "FinalLevel";
        //Speak(this.dialog);
        audio = GetComponent<AudioSource>();
        audio.clip = bossMusic;
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!beginningTriggered) 
        {
            beginningTriggered = true;
            Speak(this.dialog);
        }
        if (Player.Instance.transform.position.y < -5f)
            Player.Instance.TakeDamage(100);

        bossHp.text = hippity.hp.ToString() + "/300";
        CreditsManager.gameFinished = Hippity.HippityIsDead;

        if (Hippity.HippityIsDead && !endingTriggered) 
        {
            endingTriggered = true;
            StartCoroutine(AfterBossFight());
        }
    }

    IEnumerator AfterBossFight() 
    {
        Speak(this.dyingDialog);
        yield return new WaitForSeconds(10f);
        //AudioSource audio = GetComponent<AudioSource>();
        audio.clip = sadBossDeath;
        audio.Play();
        yield return new WaitForSeconds(10f);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene("Credits");
    }

    public void Speak(Dialog dialog)
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }

}
