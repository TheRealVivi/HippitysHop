using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HippityAllyAnimator : MonoBehaviour
{
    public Animator animator;
    public bool fourOrbs;
    public bool tenOrbs;

    private void Start()
    {
        fourOrbs = false;
        tenOrbs = false;
    }
    private void Update()
    {
        fourOrbs = Player.Instance.orbsInPossession >= 4;
        tenOrbs = Player.Instance.orbsInPossession >= 10;
        animator.SetBool("fourOrbs", fourOrbs);
        animator.SetBool("tenOrbs", tenOrbs);
    }

}
