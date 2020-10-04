using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHover : MonoBehaviour
{
    public SpriteOutline outline;

    void Start()
    {
        outline = GetComponent<SpriteOutline>();
        outline.OutlineColor = Color.clear;
    }

    private void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {   
            if (gameObject.name == "nano")
            {
                ClickManager.NanoFirstInteraction();
            }
            

            EventManager.OpenTextWindow();
        }
        outline.OutlineColor = Color.white;
        
    }

    private void OnMouseExit()
    {
        outline.OutlineColor = Color.clear;
    }

}
