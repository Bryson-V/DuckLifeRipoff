using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{

    public AudioSource src;
    public AudioClip uiClick;

    //Calls a method that shifts screen which user is on
    public void dropScreen()
    {
        StartCoroutine("dropppingTransition");
    }
    public void dodgeScreen(){
        StartCoroutine("dodgingTransition");
    }
    public void menuScreen()
    {
        StartCoroutine("menuTransition");
    }
    public void jumpScreen()
    {
        StartCoroutine("jumpingTransition");
    }
    //Create a noise for button clicks and changes scene
    IEnumerator menuTransition() {
        src.clip = uiClick;
        src.Play();
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Menu");
    }
    IEnumerator dodgingTransition(){
        src.clip = uiClick;
        src.Play();
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Dodging");
    }
    IEnumerator dropppingTransition() {
        src.clip = uiClick;
        src.Play();
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Dropping");
    }
    IEnumerator jumpingTransition() {
        src.clip = uiClick;
        src.Play();
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Jumping");
    }
}
