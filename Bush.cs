using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour
{
    public SpriteOutline outline;
    public bool clicked = false;

    public GameObject mic;

    void Start()
    {
        outline = GetComponent<SpriteOutline>();
        outline.OutlineColor = Color.clear;
    }

    private void OnMouseOver()
    {
        if (!clicked)
            outline.OutlineColor = Color.white;
        else
            gameObject.SetActive(false);

        if (Input.GetMouseButtonDown(0))
        {
            clicked = true;
            if (!GlobalControl.Instance.globalInventory["mic"].acquired)
                mic.SetActive(true);

        }
    }

    private void OnMouseExit()
    {
        outline.OutlineColor = Color.clear;
    }
}
