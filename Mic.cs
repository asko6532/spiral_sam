using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mic : MonoBehaviour
{
    public SpriteOutline outline;
    public AudioSource sc;
    public AudioClip clip;

    void Start()
    {
        gameObject.SetActive(false);
        if (GlobalControl.Instance.globalInventory["mic"].acquired)
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
            ClickManager.SetMicStatus();
            GlobalControl.Instance.nanoDialog = 1;
            gameObject.SetActive(false);
        }
    }

    private void OnMouseExit()
    {
        outline.OutlineColor = Color.clear;
    }
}
