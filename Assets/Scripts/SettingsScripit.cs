using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsScript : MonoBehaviour
{
    public FloatVariable MasterVolume;
    public FloatVariable MusicVolume;
    public FloatVariable SfxVolume;

    // Start is called before the first frame update

    [Header("--------Mixer-----------")]
    [SerializeField] AudioMixer MusicMixer;
    [Header("--------Master-----------")]
    [SerializeField] Slider MasterVolumeSlider;
    [SerializeField] Toggle MasterMuteToggle;
    [Header("--------Music------------")]
    [SerializeField] Slider MusicVolumeSlider;
    [SerializeField] Toggle MusicMuteToggle;
    [Header("--------Sfx--------------")]
    [SerializeField] Slider SfxVolumeSlider;
    [SerializeField] Toggle SxfMuteToggle;
    
   


    private void Start()
    {
        MasterVolumeSlider.value = (MasterVolume.Value == 0 || !MasterVolume.enabled) ?  0.0001f : MasterVolume.Value;
        MusicVolumeSlider.value = (MusicVolume.Value == 0 || !MusicVolume.enabled) ? 0.0001f :MusicVolume.Value;
        SfxVolumeSlider.value = (SfxVolume.Value == 0 || !SfxVolume.enabled) ? 0.0001f : SfxVolume.Value;
    }
    // Volume setters 
    /// <summary>
    /// Sets the Master Volume
    /// </summary>
    /// <param name="MasterVol"> The float value of the slider</param>
    public void MasterSet(float MasterVol)
    {
        MasterVolume.Value = MasterVol;
        MasterVolume.OldValue = MasterVolume.enabled ? MasterVol : MasterVolume.OldValue;
        MusicMixer.SetFloat("MasterVolume.", Mathf.Log10(MasterVol) * 20);
    }
    /// <summary>
    /// Sets the Music Volume
    /// </summary>
    /// <param name="MusicVol">The float value of the slider</param>
    public void MusicSet(float MusicVol)
    {
       MusicVolume.Value = MusicVol;
       MusicVolume.OldValue = MusicVolume.enabled ? MusicVol : MusicVolume.OldValue ;
        MusicMixer.SetFloat("MusicVolume", Mathf.Log10(MusicVol) * 20);
    }
    /// <summary>
    /// Sets the Sxf Volume
    /// </summary>
    /// <param name="SfxVol">The float value of the slider</param>
    public void SxfSet(float SfxVol)
    {
        SfxVolume.Value = SfxVol;
        SfxVolume.OldValue = SfxVolume.enabled ?  SfxVol : SfxVolume.OldValue;
        MusicMixer.SetFloat("SfxVolume", Mathf.Log10(SfxVol) * 20);
    }
    // Mutes 

  /// <summary>
  /// Mutes/Unmutes the master volume 
  /// </summary>
  /// <param name="Mute"></param>
    public void MuteMaster(bool Mute)
    {
        Debug.Log($"MAster Mute {Mute}");
        MasterVolume.enabled = Mute ? false : true;
        MasterVolumeSlider.enabled = Mute ? false : true;
        MasterVolumeSlider.value = MasterVolume.enabled ? MasterVolume.OldValue : 0.0001f; 

    }
    /// <summary>
    /// Mutes/Unmutes the Music volume 
    /// </summary>
    /// <param name="Mute"></param>
    public void MuteMusic(bool Mute)
    {
        MusicVolume.enabled = Mute ? false : true;
        MusicVolumeSlider.enabled = Mute ? false : true;
        MusicVolumeSlider.value = MusicVolume.enabled ? MusicVolume.OldValue : 0.0001f;
    }
    /// <summary>
    /// Mutes/Unmutes the Sfx volume 
    /// </summary>
    /// <param name="Mute"> </param>
    public void MuteSxf(bool Mute)
    {
        SfxVolume.enabled = Mute ? false : true;
        SfxVolumeSlider.enabled = Mute ? false : true;
        SfxVolumeSlider.value = SfxVolume.enabled ? SfxVolume.OldValue : 0.0001f;
    }
} 