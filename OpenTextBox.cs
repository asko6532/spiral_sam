using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenTextBox : MonoBehaviour
{
    public SpriteRenderer box;
    public Text text;

    public X x;

    public GameObject yes;
    public GameObject no;

    public GameObject keyboard;
    public GameObject flute;
    public GameObject guitar;
    public GameObject clock;
    public GameObject pan;
    public GameObject hammer;
    public GameObject omni;

    public AudioSource audioSource;
    public AudioClip talking;

    private void OnEnable()
    {
        EventManager.onObjectClick += OpenBox;
        EventManager.onExitTextBox += CloseBox;
    }

    private void OnDisable()
    {
        EventManager.onObjectClick -= OpenBox;
        EventManager.onExitTextBox -= CloseBox;
    }

    private void Awake()
    {
        box = GetComponent<SpriteRenderer>();
        box.enabled = false;
        text.enabled = false;
    }

    private void OpenBox()
    {
        audioSource.PlayOneShot(talking);
        GlobalControl.Instance.dialogEnd = false;
        box.enabled = true;
        text.enabled = true;
    }

    private void CloseBox()
    {
        keyboard.SetActive(false);
        flute.SetActive(false);
        guitar.SetActive(false);
        clock.SetActive(false);
        pan.SetActive(false);
        hammer.SetActive(false);
        omni.SetActive(false);

        no.GetComponent<Text>().enabled = false;
        yes.GetComponent<Text>().enabled = false;
        no.gameObject.layer = 2;
        yes.gameObject.layer = 2;
        box.enabled = false;
        text.enabled = false;
    }
}
