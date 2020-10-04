using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip bass;

    public AudioClip clock;
    public AudioClip pan;
    public AudioClip keyboard;
    public AudioClip omni;
    public AudioClip mic;
    public AudioClip guitar;
    public AudioClip flute;
    public AudioClip hammer;

    public Dictionary<string,string> band;

    private void Start()
    {
        band = new Dictionary<string, string>();
        band = GlobalControl.Instance.finalInventory;

        if (band.ContainsKey("clock"))
            audioSource.PlayOneShot(clock);
        if (band.ContainsKey("pan"))
            audioSource.PlayOneShot(pan);
        if (band.ContainsKey("keyboard"))
            audioSource.PlayOneShot(keyboard);
        if (band.ContainsKey("omni"))
            audioSource.PlayOneShot(omni);
        if (band.ContainsKey("mic"))
            audioSource.PlayOneShot(mic);
        if (band.ContainsKey("guitar"))
            audioSource.PlayOneShot(guitar);
        if (band.ContainsKey("flute"))
            audioSource.PlayOneShot(flute);
        if (band.ContainsKey("hammer"))
            audioSource.PlayOneShot(hammer);

        audioSource.PlayOneShot(bass);


    }

}
