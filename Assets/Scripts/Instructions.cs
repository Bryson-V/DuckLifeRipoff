using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Instructions : MonoBehaviour
{
    private int Gamenumber=1;
    public TMP_Text Title, rules;
    public GameObject Panel;
    public Sprite[] images;
    public Image spriteImage1;

    public void Appear()
    {
        Panel.SetActive(true);
    }

    public void Left()
    {
        Gamenumber--;
        if(Gamenumber==0)
            Gamenumber=3;
        SetInstructionImage(Gamenumber);
    }

    public void Right()
    {
        Gamenumber++;
        if(Gamenumber==4)
            Gamenumber=1;
        SetInstructionImage(Gamenumber);
    }

    public void SetInstructionImage(int index) {
        if (Gamenumber == 1) {
            spriteImage1.sprite = images[0];
        } else if (Gamenumber == 2) {
            spriteImage1.sprite = images[1];
        } else if (Gamenumber == 3) {
            spriteImage1.sprite = images[2];
        } else {
            Debug.Log("ur ***** code dusent wurk");
        }
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Panel.SetActive(false);
        }
    }

    void FixedUpdate(){
        if(Gamenumber==1)
        {
            Title.text="Game 1 - Dropping";
            rules.text="Move Left/Right using\nA/D or Arrow Keys\nDrop through gaps between platforms";
        }
        else if(Gamenumber==2)
        {
            Title.text="Game 2 - Dodging";
            rules.text="Move Left/Right using\nA/D or Arrow Keys\nAvoid falling objects indicated by warning triangles";
        }
        else if(Gamenumber==3)
        {
            Title.text="Game 3 - Jumping";
            rules.text="\nPress 1/2/3/4 to jump over obstacles\nUse left mouse button to fall to floor quickly";
        }
    }
}
