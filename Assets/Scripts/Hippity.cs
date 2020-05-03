using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Hippity : Enemy
{
    public AudioClip bossDyingSound;
    public static bool HippityIsDead;
    //bool soundPlaying;
    // Start is called before the first frame update
    void Start()
    {
        HippityIsDead = false;
        //soundPlaying = false;
        agent = GetComponent<NavMeshAgent>();
    }


    public void TakeDamage(int damage)
    {
        hp -= damage;

        HippityIsDead = hp <= 0;

        if (HippityIsDead)
            StartCoroutine(Dying());
    }

    IEnumerator Dying() 
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = bossDyingSound;
        audio.Play();
        agent.enabled = false;
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }
}
