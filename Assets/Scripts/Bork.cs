using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bork : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip bork;
    [SerializeField] private AudioClip[] borks;

    // Start is called before the first frame update
    void Start()
    {
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
        int borkNumber = Random.Range(0, borks.Length);
        Debug.Log("borkNumber: " + borkNumber);
        audioSource.PlayOneShot(borks[borkNumber]);

        // Mark doggo as borked
        //PlayerPrefs.SetInt("BorkCount", 1);

    }
}
