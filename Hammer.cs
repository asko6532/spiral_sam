using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    public SpriteOutline outline;
    public AudioSource sc;
    public AudioClip clip;

    void Start()
    {
        if (GlobalControl.Instance.globalInventory["hammer"].acquired)
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
            ClickManager.SetHammerStatus();
            gameObject.SetActive(false);
        }
    }

    private void OnMouseExit()
    {
        outline.OutlineColor = Color.clear;
    }
}
