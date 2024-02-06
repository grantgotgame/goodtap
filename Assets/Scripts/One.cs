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
        - Play audio
        - Wait 1 second
        - Deactivate button
        - Increment step counter
        - Set next button container active
    */

    public void Buttons()
    {
        // Loop through the array of button sets
        //for (int = 0; i < buttonSets.Length; int++)
        {
            StartCoroutine(IButtons());
        }
    }

    IEnumerator IButtons()
    {
        {
            // Play audio
            audioSource.PlayOneShot(audioClips[0]);

            // Wait 1 second
            yield return new WaitForSeconds(1);

            // Deactivate button
            buttons[0].interactable = false;

            // Increment step counter
            stepCounter++;

            // Set next button container active
            buttonContainers[0].SetActive(true);
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
