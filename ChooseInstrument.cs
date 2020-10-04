using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseInstrument : MonoBehaviour
{
    public TextController textController;
    public SpriteOutline outline;

    private void Start()
    {
        outline = GetComponent<SpriteOutline>();
        outline.OutlineColor = Color.clear;
    }

    private void OnMouseOver()
    {
        outline.OutlineColor = Color.white;
        if (Input.GetMouseButtonDown(0))
        {
            //frog
            if (gameObject.name == "clock_option")
            {
                GlobalControl.Instance.AddBandmate("clock");
                GlobalControl.Instance.AddNPC("frog");
                GlobalControl.Instance.frogHelp = true;
            }
            if (gameObject.name == "hammer_option")
            {
                GlobalControl.Instance.AddBandmate("hammer");
                GlobalControl.Instance.AddNPC("frog");
                GlobalControl.Instance.frogHelp = true;
            }
            if (gameObject.name == "pan_option")
            {
                GlobalControl.Instance.AddBandmate("pan");
                GlobalControl.Instance.AddNPC("frog");
                GlobalControl.Instance.frogHelp = true;
            }

            //mantis
            if (gameObject.name == "keyboard_option")
            {
                GlobalControl.Instance.AddBandmate("keyboard");
                GlobalControl.Instance.AddNPC("mantis");
                GlobalControl.Instance.mantisHelp = true;
            }
            if (gameObject.name == "omni_option")
            {
                GlobalControl.Instance.AddBandmate("omni");
                GlobalControl.Instance.AddNPC("mantis");
                GlobalControl.Instance.mantisHelp = true;
            }

            //otter
            if (gameObject.name == "flute_option")
            {
                GlobalControl.Instance.AddBandmate("flute");
                GlobalControl.Instance.AddNPC("otter");
                GlobalControl.Instance.otterHelp = true;
            }
            if (gameObject.name == "guitar_option")
            {
                GlobalControl.Instance.AddBandmate("guitar");
                GlobalControl.Instance.AddNPC("otter");
                GlobalControl.Instance.otterHelp = true;
            }

            textController.i++;
            gameObject.SetActive(false);
            EventManager.CloseTextWindow();
        }
    }

    private void OnMouseExit()
    {
        outline.OutlineColor = Color.clear;
    }
}
