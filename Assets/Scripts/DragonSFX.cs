using UnityEngine;

public class DragonSFX : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource source;

    public AudioClip fireClip;
    public AudioClip tailClip;
    public AudioClip deathClip;

    void Awake()
    {
        if (!source)
            source = GetComponent<AudioSource>();
    }

    public void PlayFire()
    {
        source.PlayOneShot(fireClip);
        Debug.Log("Played fire audio");
    }

    public void PlayTail()
    {
        source.PlayOneShot(tailClip);
        Debug.Log("Played tail audio");
    }

    public void PlayDeath()
    {
        source.PlayOneShot(deathClip);
        Debug.Log("Played death audio");
    }
}