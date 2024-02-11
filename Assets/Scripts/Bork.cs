using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bork : MonoBehaviour
{
    // Map audio
    private AudioSource audioSource;

    // Create arrays for audio clips
    [SerializeField] private AudioData bork;

    // Counter for Bork functions
    private int borkNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Map audio source
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Bork on button press
    public void BorkBork()
    {
        //Play a random bork sound
        borkNumber = Random.Range(0, bork.B_Bork.Length);
        audioSource.PlayOneShot(bork.B_Bork[borkNumber]);

        // Mark doggo as borked
        PlayerPrefs.SetInt("BorkCount", PlayerPrefs.GetInt("BorkCount") + 1);
    }

    // Sing or whisper on button press
    public void BorkWord(string word)
    {

        // Map bork library - bork random sound

        if (word == "EASY")
        {
            borkNumber = Random.Range(0, bork.B_EASY.Length);
            audioSource.PlayOneShot(bork.B_EASY[borkNumber]);
        }

        if (word == "GREEN")
        {
            borkNumber = Random.Range(0, bork.B_GREEN.Length);
            audioSource.PlayOneShot(bork.B_GREEN[borkNumber]);
        }

        if (word == "IS")
        {
            borkNumber = Random.Range(0, bork.B_IS.Length);
            audioSource.PlayOneShot(bork.B_IS[borkNumber]);
        }

        if (word == "RED")
        {
            borkNumber = Random.Range(0, bork.B_RED.Length);
            audioSource.PlayOneShot(bork.B_RED[borkNumber]);
        }

        if (word == "THIS")
        {
            borkNumber = Random.Range(0, bork.B_THIS.Length);
            audioSource.PlayOneShot(bork.B_THIS[borkNumber]);
        }

        if (word == "TIME")
        {
            borkNumber = Random.Range(0, bork.B_TIME.Length);
            audioSource.PlayOneShot(bork.B_TIME[borkNumber]);
        }
    }
}
