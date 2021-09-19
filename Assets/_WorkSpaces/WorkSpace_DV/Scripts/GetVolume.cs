using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GetVolume : MonoBehaviour
{
    public AudioMixer mixer;

    // Start is called before the first frame update
    void Start()
    {
        float sliderValue = PlayerPrefs.GetFloat("MusicVolume",  0.75f);
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
