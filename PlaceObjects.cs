using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObjects : MonoBehaviour
{
    public List<string> NPC;
    public List<string> obj;

    public bool show;

    private void Start()
    {
        NPC = new List<string>();
        NPC = GlobalControl.Instance.finalBand;

        obj = new List<string>();
        obj = GlobalControl.Instance.finalNPC;

        foreach (string s in NPC)
        {
            if( gameObject.name == s)
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
                show = true;
            }
        }

        foreach (string z in obj)
        {
            if(gameObject.name == z)
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
                show = true;
            }
        }

        if (!show)
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
}
