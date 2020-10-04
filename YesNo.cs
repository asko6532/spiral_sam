using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesNo : MonoBehaviour
{
    public NanoTextController nanoText;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (gameObject.name == "Yes")
            {
                GlobalControl.Instance.AddBandmate("mic");
                GlobalControl.Instance.AddNPC("nano");
                GlobalControl.Instance.nanoHelp = true;
            }
            else
                GlobalControl.Instance.nanoHelp = false;

            nanoText.i++;
            EventManager.CloseTextWindow();
        }
    }
}
