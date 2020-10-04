using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    public SpriteOutline outline;
    public AudioSource sc;
    public AudioClip clip;

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
        if (GlobalControl.Instance.globalInventory["keyboard"].acquired)
        {
            gameObject.SetActive(false);
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
            sc.PlayOneShot(clip);
            ClickManager.SetKeyboardStatus();
            gameObject.SetActive(false);
        }
    }

    private void OnMouseExit()
    {
        outline.OutlineColor = Color.clear;
    }
}
