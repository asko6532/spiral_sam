using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X : MonoBehaviour
{

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            EventManager.CloseTextWindow();
        }
    }

}
