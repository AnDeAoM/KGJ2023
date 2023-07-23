using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerGrow : MonoBehaviour
{
    public Animator myAnim;
    private bool dead;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        if(collision.tag == "Rain" && !dead)
        {
            myAnim.Play("Grow");
        }
        if (collision.tag == "Lightning" && !dead)
        {
            myAnim.Play("death");
            dead = true;
        }
    }

    
}
