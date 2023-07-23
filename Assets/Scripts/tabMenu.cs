using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabMenu : MonoBehaviour
{
    public GameObject instructions;
    public GameObject c;
    public float time = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //instructions.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) //Tab toggles instructions
        {
            instructions.gameObject.SetActive(!instructions.gameObject.activeSelf);
            c.gameObject.SetActive(!c.gameObject.activeSelf);
            //c.SetActive(false);
            //paused = true;
            Time.timeScale = 0;
        }

    }
}
