using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBox : MonoBehaviour
{
    public GameObject daddy;

    private void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);
            daddy.SetActive(false);
        }
    }
}
