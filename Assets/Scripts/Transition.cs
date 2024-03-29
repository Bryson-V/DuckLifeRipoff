using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{

    public AudioSource src;
    public AudioClip uiClick;

    // Start is called before the first frame update
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
}
