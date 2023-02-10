using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioGame : MonoBehaviour
{

    public static AudioGame instance;
    public AudioClip coin;
    public AudioClip bolt;

    public AudioSource audioSource;

    private void Awake()
    {
        instance = this;
    }
    public void AuCoin()
    {
        audioSource.clip = coin;
        audioSource.Play();
    }

    public void AuBolt()
    {
        audioSource.clip = bolt;
        audioSource.Play();
    }

}
