/*
 * Full Name        : Negin Saeidi
 * Student ID       : 101261395
 * Date Modified    : October 20, 2021
 * File             : SoundManager.cs
 * Description      : This is the SoundManager script - play sounds
 * Version          : V02
 * Revision History : Changed variable names, added comments
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip click, pickup;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        click = Resources.Load<AudioClip>("click4");
        pickup = Resources.Load<AudioClip>("click2");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
	{
        switch(clip)
		{
            case "click":
                audioSrc.PlayOneShot(click);
                break;
            case "pickup":
                audioSrc.PlayOneShot(pickup);
                break;
        }
	}
}
