using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroTextController : MonoBehaviour
{
    public string[] strings;
    public Text text;
    private int _i = 0;

    // Start is called before the first frame update
    void Start()
    {
        PopulateStrings();
        text = GetComponent<Text>();
        text.text = strings[_i];
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if ( _i < 10 )
            {
                _i++;

                if ( _i < 10 )
                    text.text = strings[_i];
            }
        }

        if (_i > 9 )
        {
            EventManager.SlideSnail();
        }
        
            
    }

    public void PopulateStrings()
    {
        strings = new string[] {
            "Well look who it is...",
            "The dream criminal who thought they would never get caught...",
            "... Oh who am I?",
            "My name is Spiral Sam.",
            "I have watched you commit many dream crimes, but your crime spree is coming to an end.",
            "I am sending you to the Spiral Realm as punishment.",
            "I will let you leave when I feel like you have atoned for your crimes.",
            "If you can play me a beautiful song, a song so beautiful that I am compelled to do the spiral dance...",
            "I will consider letting you leave.",
            "Best of luck!"
        };
    }

}
