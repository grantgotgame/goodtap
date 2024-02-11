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
        borkNumber = Random.Range(0, bork.B_bork.Length);
        audioSource.PlayOneShot(bork.B_bork[borkNumber]);

        // Mark doggo as borked
        PlayerPrefs.SetInt("BorkCount", PlayerPrefs.GetInt("BorkCount") + 1);
    }

    // Sing or whisper on button press
    public void BorkWord(string word)
    {
        // Bork a random sound
        borkNumber = Random.Range(0, bork.B_GREEN.Length);
        Debug.Log(word);
        audioSource.PlayOneShot(bork.B_GREEN[borkNumber]);
    }
}
