using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public int i = 0;
    public string[] frogStrings;
    public string[] mantisStrings;
    public string[] otterStrings;

    public GameObject fluteGo;
    public GameObject clockGo;
    public GameObject hammerGo;
    public GameObject panGo;
    public GameObject omniGo;
    public GameObject guitarGo;
    public GameObject keyboardGo;

    public Text text;

    public GameObject go;
    public string currentGo;

    public AudioSource audioSource;
    public AudioClip talking;

    private void Start()
    {
        currentGo = go.name;

        SetFrogStrings();
        SetMantisStrings();
        SetOtterStrings();

        if (currentGo == "frog")
        {
            text.text = frogStrings[i];
        }

        if (currentGo == "mantis")
        {
            text.text = mantisStrings[i];
        }

        if (currentGo == "otter")
        {
            text.text = otterStrings[i];
        }
    }

    private void Update()
    {
        // frog dialog
        if (currentGo == "frog")
        {
            if (GlobalControl.Instance.frogHelp == true)
            {
                text.text = frogStrings[7];
                GlobalControl.Instance.dialogEnd = true;
            }
            else if (GlobalControl.Instance.globalInventory["pan"].acquired || GlobalControl.Instance.globalInventory["clock"].acquired || GlobalControl.Instance.globalInventory["hammer"].acquired)
            {
                if (i == 2)
                {
                    if (GlobalControl.Instance.globalInventory["pan"].acquired)
                        panGo.SetActive(true);
                    if (GlobalControl.Instance.globalInventory["clock"].acquired)
                        clockGo.SetActive(true);
                    if (GlobalControl.Instance.globalInventory["hammer"].acquired)
                        hammerGo.SetActive(true);
                }
                else if (i < 3)
                {
                    text.text = frogStrings[i + 5];
                }
            }

            else
            {
                if (i < 4)
                {
                    text.text = frogStrings[i];
                    GlobalControl.Instance.dialogEnd = false;
                }
                if (i == 4)
                {
                    text.text = frogStrings[i];
                }
                if (i > 4)
                    GlobalControl.Instance.dialogEnd = true;
            }
        }

        // mantis dialog
        if (currentGo == "mantis")
        {
            if (GlobalControl.Instance.mantisHelp == true)
            {
                text.text = mantisStrings[7];
                GlobalControl.Instance.dialogEnd = true;
            }
            else if (GlobalControl.Instance.globalInventory["keyboard"].acquired || GlobalControl.Instance.globalInventory["omni"].acquired)
            {
                if (i == 2)
                {
                    if (GlobalControl.Instance.globalInventory["keyboard"].acquired)
                        keyboardGo.SetActive(true);
                    if (GlobalControl.Instance.globalInventory["omni"].acquired)
                        omniGo.SetActive(true);
                }
                else if (i < 3)
                {
                    text.text = mantisStrings[i + 5];
                }
            }

            else
            {
                if (i < 4)
                {
                    text.text = mantisStrings[i];
                    GlobalControl.Instance.dialogEnd = false;
                }
                if (i == 4)
                {
                    text.text = mantisStrings[i];
                }
                if (i > 4)
                    GlobalControl.Instance.dialogEnd = true;
            }
        }

        if (currentGo == "otter")
        {
            if (GlobalControl.Instance.otterHelp == true)
            {
                text.text = otterStrings[5];
                GlobalControl.Instance.dialogEnd = true;
            }
            else if (GlobalControl.Instance.globalInventory["flute"].acquired || GlobalControl.Instance.globalInventory["guitar"].acquired)
            {
                if (i == 2)
                {
                    if (GlobalControl.Instance.globalInventory["flute"].acquired)
                        fluteGo.SetActive(true);
                    if (GlobalControl.Instance.globalInventory["guitar"].acquired)
                        guitarGo.SetActive(true);
                }
                else if (i < 3)
                {
                    text.text = otterStrings[i + 3];
                }
            }

            else
            {
                if (i < 2)
                {
                    text.text = otterStrings[i];
                    GlobalControl.Instance.dialogEnd = false;
                }
                if (i == 2)
                {
                    text.text = otterStrings[i];
                }
                if (i > 2)
                    GlobalControl.Instance.dialogEnd = true;
            }
        }
    }



    public void SetFrogStrings()
    {
        // 8 total
        // split at 4 index, 5 length
        frogStrings = new string[]
        {
            "Huh? Is someone there?",
            "Oh hello, sorry. I can't see anything in here. I don't even know where I am.",
            "We can leave this place if we play a song for Spiral Sam you say?",
            "Hmm... if you brought me something to bang on I could make a beat.",
            "Let me know if you find anything. I'm scared and want to leave.",
            "Hey you brought something to for me to bang on!",
            "Pick which of these items I'll use as an instrument.",
            "I'll meet you in Sam's room in a bit and we can jam. I'm pretty sure it's north of here? I forget."
        };
    }

    public void SetMantisStrings()
    {
        // 8 total
        // split at 4 index, 5 length
        mantisStrings = new string[]
        {
            "...",
            "Oh were you talking to me? I was lost in thought. Thinking about spirals is all I do anymore.",
            "You need to make a song for Spiral Sam so you can leave this place? Oh.",
            "Well I quite like it here... and don't understand the rush to leave... but I do like playing music.",
            "Fine, I'll help you play a song for Sam. Find me a keyboard or synth or something.",
            "... ... Hm ... Oh hi.",
            "Pick what instrument you want me to play.",
            "I'll meet you in Sam's room when you're ready to play."
        };

    }

    public void SetOtterStrings()
    {
        otterStrings = new string[]
        {
            "Hey dude... so I'm trying to escape this spiral prison and Sam told me I need to play him a song.",
            "He said that to you too? Awesome let's work together.",
            "Could you find me an instrument to play? Preferably something with strings... or holes... thanks!",
            "You brought and instrument for me to play? Great.",
            "Pick which instrument you think I should play.",
            "I'll be in Sam's room, meet me there when you're ready to play."
        };
    }
}
