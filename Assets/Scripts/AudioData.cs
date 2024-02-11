using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "audioData_", menuName = "Data/Audio Data")]
public class AudioData : ScriptableObject
{
    // Map audio data words
    [SerializeField] private AudioClip[] b_bork;
    public AudioClip[] B_bork => b_bork;
    [SerializeField] private AudioClip[] b_IS;
    public AudioClip[] B_IS => b_IS;
    [SerializeField] private AudioClip[] b_GREEN;
    public AudioClip[] B_GREEN => b_GREEN;
    [SerializeField] private AudioClip[] b_EASY;
    public AudioClip[] B_EASY => b_EASY;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
