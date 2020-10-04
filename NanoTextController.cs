using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NanoTextController : MonoBehaviour
{
    public int dialogOption;
    public Text text;
    public int i;
    public string[] strings;

    // instantiate
    public GameObject yes;
    public GameObject no;

    void Start()
    {
        yes.SetActive(false);
        no.SetActive(false);
        GlobalControl.Instance.dialogEnd = false;
        PopulateStrings();
        text.text = strings[i];
    }

    void Update()
    {
        if (GlobalControl.Instance.nanoHelp == true)
        {
            text.text = strings[8];
            GlobalControl.Instance.dialogEnd = true;
        }
        else if (GlobalControl.Instance.globalInventory["mic"].acquired)
        {
            if (i == 3)
            {
                yes.SetActive(true);
                no.SetActive(true);
            }
            else if ( i < 4 )
            {
                text.text = strings[i + 5];
            }
        }

        else
        {
            if (i < 5)
                text.text = strings[i];
            if (i > 4)
                GlobalControl.Instance.dialogEnd = true;
        }

    }

    public void PopulateStrings()
    {
        // 9 total
        // split at 4 index, 5 length
            strings = new string[] {
                "Ah, you must be the newest dream criminal",
                "I'm guessing you're trying to get out of here so you can commit more dream crimes.",
                "Well before you ask, no I can't help you make a song for Spiral Sam.",
                "I lost my microphone so I can't sing.",
                "Now leave me alone, I've got things to do.",
                "Oh, you found a microphone!",
                "Well if you still need help making the spiral song I can help you.",
                "Would you like my help?",
                "I'll meet you in Sam's room when you're ready to play the song."
            };
 
    }
}
