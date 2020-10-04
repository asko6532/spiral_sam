using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpArrowClick : MonoBehaviour
{
    public SpriteOutline outline;
    public GameObject baby;

    private void Start()
    {
        outline = GetComponent<SpriteOutline>();
        outline.OutlineColor = Color.clear;
    }

    private void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {
            baby.SetActive(true);
        }
        outline.OutlineColor = Color.yellow;

    }

    private void OnMouseExit()
    {
        outline.OutlineColor = Color.clear;
    }
}
