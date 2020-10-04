using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiral : MonoBehaviour
{
    public SpriteOutline outline;
    public bool startSpin;

    public GameObject flute;

    void Start()
    {
        outline = GetComponent<SpriteOutline>();
        outline.OutlineColor = Color.clear;
    }

    private void Update()
    {
        if (startSpin)
            transform.Rotate(Vector3.forward * 50.0f * Time.deltaTime);
    }

    private void OnMouseOver()
    {
        if (!startSpin)
            outline.OutlineColor = Color.white;
        else
            gameObject.layer = 2;

        if (Input.GetMouseButtonDown(0))
        {
            startSpin = true;
            if ( !GlobalControl.Instance.globalInventory["flute"].acquired )
                flute.SetActive(true);

        }
    }

    private void OnMouseExit()
    {
        outline.OutlineColor = Color.clear;
    }


}
