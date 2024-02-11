using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "audioData_", menuName = "Data/Audio Data")]
public class AudioData : ScriptableObject
{
    // Map audio data words
    [SerializeField] private AudioClip[] b_Bork;
    public AudioClip[] B_Bork => b_Bork;
    [SerializeField] private AudioClip[] b_EASY;
    public AudioClip[] B_EASY => b_EASY;
    [SerializeField] private AudioClip[] b_easy;
    public AudioClip[] B_easy => b_easy;
    [SerializeField] private AudioClip[] b_GREEN;
    public AudioClip[] B_GREEN => b_GREEN;
    [SerializeField] private AudioClip[] b_IS;
    public AudioClip[] B_IS => b_IS;
    [SerializeField] private AudioClip[] b_is;
    public AudioClip[] B_is => b_is;
    [SerializeField] private AudioClip[] b_RED;
    public AudioClip[] B_RED => b_RED;
    [SerializeField] private AudioClip[] b_THIS;
    public AudioClip[] B_THIS => b_THIS;
    [SerializeField] private AudioClip[] b_this;
    public AudioClip[] B_this => b_this;
    [SerializeField] private AudioClip[] b_TIME;
    public AudioClip[] B_TIME => b_TIME;
    [SerializeField] private AudioClip[] b_time;
    public AudioClip[] B_time => b_time;
    [SerializeField] private AudioClip[] b_yellow;
    public AudioClip[] B_yellow => b_yellow;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
