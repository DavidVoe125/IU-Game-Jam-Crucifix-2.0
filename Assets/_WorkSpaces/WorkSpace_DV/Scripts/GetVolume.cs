using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    private float volume;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        volume = PlayerPrefs.GetFloat("MusicVolume", 0.75f);

        mixer.SetFloat("MusicVol", Mathf.Log10(volume) * 20);
    }
}
