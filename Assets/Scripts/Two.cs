using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Two : MonoBehaviour
{
    // Map audio
    private AudioSource audioSource;
    [SerializeField] AudioClip[] audioClips;

    // Map buttons and their containers
    [SerializeField] Button[] buttons;
    [SerializeField] GameObject[] buttonContainers;

    // Counter to track which button is next
    private int stepCounter = 0;

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
        - Deactivate button
        - Play audio
        - Wait
        - Increment step counter
        - Set next button container active
    */

    public void Buttons()
    {
        StartCoroutine(IButtons());
    }

    IEnumerator IButtons()
    {
        {
            // Deactivate button
            buttons[stepCounter].interactable = false;

            // Play audio
            audioSource.PlayOneShot(audioClips[stepCounter]);

            // Wait 1 second
            yield return new WaitForSeconds(0.5f);

            // Increment step counter
            stepCounter++;

            // Set next button container active
            if (stepCounter < buttonContainers.Length)
            { buttonContainers[stepCounter].SetActive(true); }

            // If no more buttons, complete level
            else { CompleteLevel(); }
        }
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
