using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeFinale : MonoBehaviour
{

    private void Start()
    {

    }

    private void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(5);
        }


    }


}
