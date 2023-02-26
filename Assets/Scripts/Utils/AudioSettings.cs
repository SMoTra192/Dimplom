using System;
using System.Collections;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup Master;
    [SerializeField] private Slider _BGslider,effectsSlider;
    [SerializeField] private Toggle _toggle;
    [SerializeField] private TextMeshProUGUI text;
    

    private void Start()
    {
        _toggle.isOn = PlayerPrefs.GetInt("VolumeEnabled") == 1;
        _BGslider.value = PlayerPrefs.GetFloat("BackGround");
        effectsSlider.value = PlayerPrefs.GetFloat("Effects");
    }


    public void ToggleAudio(bool enabled)
    {
        if (enabled)
        {
                     text.text = "ON";
                     Master.audioMixer.SetFloat("Master", 0);
        }
        else 
        {
            text.text = "OFF";
            Master.audioMixer.SetFloat("Master", -80);
            
        }
        PlayerPrefs.SetInt("VolumeEnabled", enabled ? 1 : 0);
    }

    public void ChangeBGVolume(float volume)
    {
        Master.audioMixer.SetFloat("BackGround", math.lerp(-80, 0, volume));
        PlayerPrefs.SetFloat("BackGround", volume);
    }

    public void ChangeEffectsVolume(float volume)
    {
        Master.audioMixer.SetFloat("EffectsVolume", math.lerp(-80, 0, volume));
        PlayerPrefs.SetFloat("Effects", volume);
    }
    
    
}
