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

    // Variable to count bork lengths
    private int borkLengthPlus1;

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
        int borkNumber = Random.Range(0, bork.B_bork.Length);
        audioSource.PlayOneShot(bork.B_bork[borkNumber]);

        // Mark doggo as borked
        PlayerPrefs.SetInt("BorkCount", PlayerPrefs.GetInt("BorkCount") + 1);
        Debug.Log("BorkCount: " + PlayerPrefs.GetInt("BorkCount"));
    }
}
