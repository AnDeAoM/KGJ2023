using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerDestroy : MonoBehaviour
{
    public Animator myAnim;
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
        if(collision.tag == "Rain")
        {
            Debug.Log("Hello");
            myAnim.Play("Grow");
        }
        if (collision.tag == "Lightning")
        {
            Destroy(this.gameObject);
        }
    }

    
}
