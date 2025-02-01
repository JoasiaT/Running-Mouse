using UnityEngine;

public class AudioManangare : MonoBehaviour
{
    [Header("................Audio Sorce ...................")]
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource SFXSource;
    [Header("................Audio Clip ...................")]
    public AudioClip background;
    public AudioClip victory;
    public AudioClip shieldTake;
    public AudioClip jumpTake;
    public AudioClip colillisionTake;
    //AudioManangare audioManangare;

    private void Start()
    {
        audioSource.clip = background;
        audioSource.Play();
    }
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

}
