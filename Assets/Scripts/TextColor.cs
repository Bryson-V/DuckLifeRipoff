using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextColor : MonoBehaviour
{
 
    public TMP_Text text;
    public float waitTimer=0.15f;
 
    void Start()
    {
        StartCoroutine("colorChange");
    }
 
IEnumerator colorChange()
{
    while(true){
        yield return new WaitForSeconds(waitTimer);
        Color rand=new Color(Random.value,Random.value,Random.value);
        text.color = rand;
    }
}
//change the transparency, as an example
}
