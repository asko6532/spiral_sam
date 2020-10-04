using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Snail : MonoBehaviour
{

    private void OnEnable()
    {
        EventManager.onIntroComplete += SlideSnail;
        EventManager.onStartSong += DanceSnail;
        EventManager.onChangeDir += DanceBackward;
    }

    private void OnDisable()
    {
        EventManager.onIntroComplete -= SlideSnail;
        EventManager.onStartSong -= DanceSnail;
        EventManager.onChangeDir -= DanceBackward;
    }


    public void SlideSnail()
    {
        transform.Translate(Vector2.right * 4.0f * Time.deltaTime);
    }

    public void DanceSnail()
    {
        transform.Rotate(Vector3.forward * 70.0f * Time.deltaTime);
    }

    public void DanceBackward()
    {
        transform.Rotate(Vector3.back * 70.0f * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        GlobalControl.Instance.introComplete = true;
        SceneManager.LoadScene(1);
    }


}
