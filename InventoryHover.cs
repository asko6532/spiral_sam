using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryHover : MonoBehaviour
{
    public SpriteOutline outline;
    public Text text;

    public GameObject inventoryBox;
    public GameObject keyboard;
    public GameObject flute;
    public GameObject mic;
    public GameObject guitar;
    public GameObject clock;
    public GameObject pan;
    public GameObject hammer;
    public GameObject omni;

    private bool isInventoryOpen;

    void Start()
    {
        outline = GetComponent<SpriteOutline>();
        outline.OutlineColor = Color.clear;
        text.enabled = false;
        isInventoryOpen = false;
        inventoryBox.SetActive(false);

    }

    private void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if ( !isInventoryOpen)
            {
                inventoryBox.SetActive(true);

                if (GlobalControl.Instance.globalInventory["keyboard"].acquired)
                    keyboard.SetActive(true);
                else
                    keyboard.SetActive(false);

                if (GlobalControl.Instance.globalInventory["flute"].acquired)
                    flute.SetActive(true);
                else
                    flute.SetActive(false);

                if (GlobalControl.Instance.globalInventory["mic"].acquired)
                    mic.SetActive(true);
                else
                    mic.SetActive(false);

                if (GlobalControl.Instance.globalInventory["guitar"].acquired)
                    guitar.SetActive(true);
                else
                    guitar.SetActive(false);

                if (GlobalControl.Instance.globalInventory["clock"].acquired)
                    clock.SetActive(true);
                else
                    clock.SetActive(false);

                if (GlobalControl.Instance.globalInventory["pan"].acquired)
                    pan.SetActive(true);
                else
                    pan.SetActive(false);

                if (GlobalControl.Instance.globalInventory["hammer"].acquired)
                    hammer.SetActive(true);
                else
                    hammer.SetActive(false);

                if (GlobalControl.Instance.globalInventory["omni"].acquired)
                    omni.SetActive(true);
                else
                    omni.SetActive(false);

                isInventoryOpen = true;
            }
            else
            {
                CloseInventory();
                isInventoryOpen = false;
            }
        }
        outline.OutlineColor = Color.black;
        text.enabled = true;
    }

    private void OnMouseExit()
    {
        outline.OutlineColor = Color.clear;
        text.enabled = false;
    }

    private void CloseInventory()
    {
        inventoryBox.SetActive(false);
    }
}
