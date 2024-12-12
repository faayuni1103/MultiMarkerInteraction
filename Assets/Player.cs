using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        
        if(collider.tag == "Enemy")
        {
            for (int i = 0; i < 20; i++)
                player.Play("Idle");
            collider.gameObject.GetComponent<Enemy>().attacked();
        }
    }
}
