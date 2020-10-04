using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flute : MonoBehaviour
{
    public SpriteOutline outline;
    public AudioSource sc;
    public AudioClip clip;

    void Start()
    {
        gameObject.SetActive(false);
        if (GlobalControl.Instance.globalInventory["flute"].acquired)
        {
            gameObject.SetActive(false);
        }
        outline = GetComponent<SpriteOutline>();
        outline.OutlineColor = Color.clear;
    }

    private void OnMouseOver()
    {
        outline.OutlineColor = Color.white;

        if (Input.GetMouseButtonDown(0))
        {
            sc.PlayOneShot(clip);
            ClickManager.SetFluteStatus();
            gameObject.SetActive(false);
        }
    }

    private void OnMouseExit()
    {
        outline.OutlineColor = Color.clear;
    }
}
