using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("DangSon/AudioManager")]
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance
    {
        get => instance;
    }
    private static AudioManager instance;
    /// <summary>
    public AudioSource musicSource;
    public AudioSource sfxSource;
    /// </summary>
    private void Awake()
    {
        if (instance != null)
        {
            DestroyImmediate(gameObject);   
            return;
        }
        instance = this;
       // DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.loop = true;
        musicSource.Play();
    }
    public void PlaySfx(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
}
