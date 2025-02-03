using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManangare : MonoBehaviour
{
    [Header("................Audio Sorce ...................")]
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource SFXSource;

    [Header("................Audio Clip ....................")]
    public AudioClip background;
    public AudioClip victory;
    public AudioClip shieldTake;
    public AudioClip jumpTake;
    public AudioClip colillisionTake;

    [Header("................Audio Sliders .................")]
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;

    //AudioManangare audioManangare;

    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadMusicVolume();
        }
        else
        {
            SetMusicVolume();
        }
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadSFXVolume();
        }
        else
        {
            SetSFXVolume();
        }
        audioSource.clip = background;
        audioSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

 
    public void PlayMusic() //Co tutaj, nie gra?
    {
        audioSource.Play();
        //if(audioSource.Stop)
        {
           // AudioSorce.Stop(audioSorce.Play);
        }
    }

    public void StopMusic()
    {
       audioSource.Stop();
    }

    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        audioMixer.SetFloat("Music", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("musicVolume", volume);
    }

    public void LoadMusicVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        SetMusicVolume();
    }

    public void SetSFXVolume()
    {
        float volume = sfxSlider.value;
        audioMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("sfxVolume", volume);
    }

    public void LoadSFXVolume()
    {
        sfxSlider.value = PlayerPrefs.GetFloat("sfxVolume");
        SetMusicVolume();
    }

}
