using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinaleTextController : MonoBehaviour
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

                _i++;

                if (_i < strings.Length )
                    text.text = strings[_i];
                
        }
        if (_i % 2 == 0)
            EventManager.RotateBack();
        else
            EventManager.Finale();
    }

    public void PopulateStrings()
    {
        strings = new string[] {
            "What a beautiful song!",
            "I grant you permission to leave the realm!",
            "Music to my ears!",
            "Spinning Spinning spiral song!",
            ""
        };
    }
}
