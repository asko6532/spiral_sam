using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcquireObject : MonoBehaviour
{
    // depricated

    public SpriteOutline outline;

    private void OnEnable()
    {
        EventManager.onClickPlant += ChangeLayer;
    }

    private void OnDisable()
    {
        EventManager.onClickPlant -= ChangeLayer;
    }

    void Start()
    {
        Debug.Log(gameObject.name);
        if (gameObject.name == "keyboard")
        {
            if (GlobalControl.Instance.globalInventory["keyboard"].acquired)
            {
                gameObject.SetActive(false);
            }
        }

        if (gameObject.name == "flute")
        {
            if (GlobalControl.Instance.globalInventory["flute"].acquired)
            {
                gameObject.SetActive(false);
            }
        }
        
        outline = GetComponent<SpriteOutline>();
        outline.OutlineColor = Color.clear;
    }

    void ChangeLayer()
    {
        gameObject.layer = 0;
    }

    private void OnMouseOver()
    {
        outline.OutlineColor = Color.white;

        if (Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);
        }
    }

    private void OnMouseExit()
    {
        outline.OutlineColor = Color.clear;
    }
}
