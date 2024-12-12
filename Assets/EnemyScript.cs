using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int p = 10;
    public Animator anim;
    //private bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void attacked(int punch)
    {
        p -= punch;

        if (p <= 0)
        {
            anim.SetBool("Dead", true);
            anim.Play("Zombie Death");
            //WinPlayer();
        }
    }

    void WinPlayer()
    {
        Animator player = GameObject.Find("Player").GetComponent<Animator>();
        //player.SetTrigger("Win");
        player.SetBool("Win", true);
        player.Play("Victory");
    }
}