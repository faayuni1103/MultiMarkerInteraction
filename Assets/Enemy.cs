using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void attacked()
    {
        anim.SetBool("Dead", true);
        anim.Play("Zombie Death");

        Animator player = GameObject.Find("Player").GetComponent<Animator>();
        player.SetBool("Win", true);
        player.Play("Victory");
    }
}
