using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{

    public AudioClip button;
    public AudioClip cardSelect;
    public AudioClip cardPlacement;
    public AudioClip death;
    public AudioClip win;

    [HideInInspector] public AudioSource aSource;
    public static SoundPlayer _instance;

    private void Start()
    {
        _instance = this;

        aSource = GetComponent<AudioSource>();

        //if (PlayerPrefs.GetInt("music", 1) == 1)
        //aSource.Play();
    }

    public void PlaySound(string name)
    {
        //if (name == "music")
        //    if (PlayerPrefs.GetInt("music", 1) == 1)
        //        aSource.Play();
        //    else
        //        aSource.Stop();


        if (PlayerPrefs.GetInt("sound", 1) == 0)
            return;

        if (name == "button")
            aSource.PlayOneShot(button);

        if (name == "death")
            aSource.PlayOneShot(death);

        if (name == "win")
            aSource.PlayOneShot(win);

        if (name == "CardSelect")
            aSource.PlayOneShot(cardSelect);

        if (name == "cardPlacement")
            aSource.PlayOneShot(cardPlacement);
    }
}
