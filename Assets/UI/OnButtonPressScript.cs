using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnButtonPressScript : MonoBehaviour
{
    public GameObject instructions;
    public AudioSource buttonSound;
    //public Scene scene;

    void Start()
    {
        instructions.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) //Tab toggles instructions
            instructions.gameObject.SetActive(!instructions.gameObject.activeSelf);

        // need to pause game here
            
    }

    public void OnButtonPressPlay() //play game
    {
        SceneManager.LoadScene("prototype");
        buttonSound.Play();
    }

    public void OnButtonPressQuit() //quit game
    {
        Application.Quit();
    }

    public void OnButtonPressMenu()
    {
        SceneManager.LoadScene("menu");
        buttonSound.Play();
    }

    public void OnButtonPressResume()
    {
        instructions.gameObject.SetActive(!instructions.gameObject.activeSelf);
        buttonSound.Play();
    }

    /*
    public void ResetScene() //play game
    {
        SceneManager.LoadScene("Level_One");
    }

    public void ButtonSound() //play game
    {
        buttonSound.Play();
    }*/
}
