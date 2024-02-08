using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Three : MonoBehaviour
{
    // Map audio
    private AudioSource audioSource;
    [SerializeField] AudioClip[] audioGreen;
    [SerializeField] AudioClip[] audioYellow;

    // Map buttons and their containers
    [SerializeField] GameObject[] buttonsGreen;
    [SerializeField] GameObject[] buttonsYellow;

    // Counter to track which button is next
    private int stepCounterGreen = 0;
    private int stepCounterYellow = 0;

    // String to track script name for CompleteLevel function
    private string scriptName;

    // Start is called before the first frame update
    void Start()
    {
        // Map audio source
        audioSource = GetComponent<AudioSource>();

        // Map script name
        scriptName = this.GetType().Name;
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

    public void ButtonsGreen()
    {
        StartCoroutine(IButtonsGreen());
    }

    IEnumerator IButtonsGreen()
    {
        {
            // Deactivate button
            buttonsGreen[stepCounterGreen].GetComponent<Button>().interactable = false;

            // Play audio
            audioSource.PlayOneShot(audioGreen[stepCounterGreen]);

            // Wait 1 second
            yield return new WaitForSeconds(0.5f);

            // Increment step counter
            stepCounterGreen++;

            // Set next button active
            if (stepCounterGreen < buttonsGreen.Length)
            { buttonsGreen[stepCounterGreen].SetActive(true); }

            // If no more buttons, complete level
            else
            {
                // Award green star
                PlayerPrefs.SetInt(scriptName + "StarGreen", 1);

                CompleteLevel();
            }
        }
    }

    public void ButtonsYellow()
    {
        StartCoroutine(IButtonsYellow());
    }

    IEnumerator IButtonsYellow()
    {
        {
            // Deactivate button
            buttonsYellow[stepCounterYellow].GetComponent<Button>().interactable = false;

            // Play audio
            audioSource.PlayOneShot(audioYellow[stepCounterYellow]);

            // Wait 1 second
            yield return new WaitForSeconds(0.5f);

            // Increment step counter
            stepCounterYellow++;

            // Set next button active
            if (stepCounterYellow < buttonsYellow.Length)
            { buttonsYellow[stepCounterYellow].SetActive(true); }

            // If no more buttons, complete level
            else { CompleteLevel(); }
        }
    }

    // Mark level complete and load Level Select
    public void CompleteLevel()
    {
        // Mark level as complete
        PlayerPrefs.SetInt(scriptName, 1);
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
