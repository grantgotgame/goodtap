using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "audioData_", menuName = "Data/Audio Data")]
public class AudioData : ScriptableObject
{
    [SerializeField] private AudioClip[] b_bork;
    public AudioClip[] B_bork => b_bork;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
