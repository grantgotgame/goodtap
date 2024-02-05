using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class One : MonoBehaviour
{
    // Map audio
    private AudioSource audioSource;
    [SerializeField] AudioClip[] audioClips;

    // Map button containers
    [SerializeField] GameObject[] buttonSet1;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Sing GOOD and load next button
    public void ButtonSet1()
    {
        // Sing GOOD
        //audioSource.PlayOneShot(sing_GOOD);

        // Wait 1 second, disable GOOD, enable TAP
        StartCoroutine(BS1());
    }

    IEnumerator BS1()
    {
        // Wait 1 second
        yield return new WaitForSeconds(1);

        // Disable GOOD
        //container_GOOD.SetActive(false);

        // Enable TAP
        //container_TAP.SetActive(true);
    }

    // Sing TAP and load Level Select
    public void CompleteLevel()
    {
        // Mark level as complete
        PlayerPrefs.SetInt("One", 1);

        StartCoroutine(WaitQuit());
    }

    // Wait, then load Level Select
    IEnumerator WaitQuit()
    {
        //Wait 1 second
        yield return new WaitForSeconds(1);

        // Load level select
        SceneManager.LoadScene("LevelSelect");
    }
}
