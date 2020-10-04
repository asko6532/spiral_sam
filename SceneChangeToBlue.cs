using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeToBlue : MonoBehaviour
{
    public SpriteOutline outline;

    private void Start()
    {
        outline = GetComponent<SpriteOutline>();
        outline.OutlineColor = Color.clear;
    }

    private void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(1);
        }
        outline.OutlineColor = Color.yellow;

    }

    private void OnMouseExit()
    {
        outline.OutlineColor = Color.clear;
    }
}
