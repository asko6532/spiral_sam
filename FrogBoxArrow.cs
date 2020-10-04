using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogBoxArrow : MonoBehaviour
{
    public SpriteRenderer arrow;
    public GameObject go;

    private void OnEnable()
    {
        EventManager.onObjectClick += ShowArrow;
        EventManager.onExitTextBox += HideArrow;
    }

    private void OnDisable()
    {
        EventManager.onObjectClick -= ShowArrow;
        EventManager.onExitTextBox -= HideArrow;
    }

    private void Awake()
    {
        arrow = GetComponent<SpriteRenderer>();
        arrow.enabled = false;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TextController textScript = go.GetComponent<TextController>();
            textScript.i++;

            if (GlobalControl.Instance.dialogEnd)
                EventManager.CloseTextWindow();

        }
    }

    private void ShowArrow()
    {
        arrow.enabled = true;
        gameObject.layer = 0;
    }

    private void HideArrow()
    {
        arrow.enabled = false;
        gameObject.layer = 2;
    }
}
