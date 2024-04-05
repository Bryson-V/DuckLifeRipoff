using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text taco;
    public static float value = 0f;

    public TMP_Text PlatformsText;
    public static int platformsPassed;

    // Start is called before the first frame update
    void Start()
    {
        //Sets two scores to 0 at start of each scene.  Starts IEnumerator for increasing score constantly
        value=0;
        platformsPassed=0;
        taco.text="Hello World";
        StartCoroutine("countdown");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator countdown() {
        while(true) {
            //Increases score by 1 every .01 seconds.  Changes the amount of platforms passed to current value, changed in other scripts.
            yield return new WaitForSeconds(0.01f);
            value += 1f;
            taco.text = value.ToString();
            PlatformsText.text = platformsPassed.ToString();
        }
    }
}
