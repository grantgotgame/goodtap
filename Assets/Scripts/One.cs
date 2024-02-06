using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class One : MonoBehaviour
{
    // Map audio
    private AudioSource audioSource;
    [SerializeField] AudioClip[] audioClips;

    // Map buttons and their containers
    [SerializeField] Button[] buttons;
    [SerializeField] GameObject[] buttonSets;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
        For each button:
        - Play audio
        - Wait 1 second
        - Deactivate button
        - Set next button container active
    */
    public void Buttons()
    {
        // Sing GOOD
        //audioSource.PlayOneShot(sing_GOOD);

        // Wait 1 second, disable GOOD, enable TAP
        StartCoroutine(IButtons());
    }

    IEnumerator IButtons()
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
