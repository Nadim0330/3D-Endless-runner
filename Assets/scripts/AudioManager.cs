using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioClip hit;
    public static AudioSource auds;
    void Start()
    {
        hit = Resources.Load<AudioClip>("Resources/hitSound");
        auds = GetComponent<AudioSource>();
    }


    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "hit":
                auds.Play();
                break;

        }
    }

}
