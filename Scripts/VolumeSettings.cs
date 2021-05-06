using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSettings : MonoBehaviour
{
    public AudioMixer audioMixer;
    
    public void SetVolume(float masterVolume)
    {
        Debug.Log(masterVolume);
        audioMixer.SetFloat("masterVolume", masterVolume);
    }
}
