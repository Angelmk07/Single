using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class AudioOlayerSingleton : MonoBehaviour
{
    public static AudioOlayerSingleton Instance { get; private set; }
    [SerializeField]
    private AudioClip audio;
    private AudioSource _audioSource;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        Destroy(gameObject);
    }
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.clip = audio;
        _audioSource.playOnAwake = true;
    }
}
