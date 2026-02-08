using UnityEngine;

public class UIButtonSFX : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clickClip;

    void Awake()
    {
        if (!source)
            source = GetComponent<AudioSource>();
    }

    public void PlayClick()
    {
        Debug.Log("Playing click audio");
        source.PlayOneShot(clickClip);
    }
}
