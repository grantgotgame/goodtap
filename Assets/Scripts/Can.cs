using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Can : MonoBehaviour
{
    // Map audio
    private AudioSource audioSource;

    // Map buttons and their containers
    [SerializeField] GameObject[] buttonsGreen;
    [SerializeField] GameObject[] buttonsYellow;
    [SerializeField] GameObject[] buttonsRed;

    // Counter to track which button is next
    private int stepCounterGreen = 0;
    private int stepCounterYellow = 0;
    private int stepCounterRed = 0;
    private int stepCounterMain = 0;

    // String to track script name for CompleteLevel function
    private string scriptName;

    // Variables for Bork() script
    private Bork bork;
    private TMP_Text m_TextComponent;
    private Transform m_Transform;
    private string buttonText;


    // Start is called before the first frame update
    void Start()
    {
        // Map audio source
        audioSource = GetComponent<AudioSource>();

        // Map script name
        scriptName = this.GetType().Name;

        // Find Bork script
        bork = GameObject.Find("buttons").GetComponent<Bork>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
        For each button:
        - Play audio
        - Deactivate button
        - Wait
        - Increment step counter
        - Set next button container active
    */

    public void ButtonsGreen()
    {
        // Play audio
        buttonText = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<TMP_Text>().text;
        bork.BorkWord(buttonText);

        // Deactivate buttons
        buttonsGreen[stepCounterMain].GetComponent<Button>().interactable = false;
        buttonsRed[stepCounterMain].GetComponent<Button>().interactable = false;

        StartCoroutine(IButtonsGreen());
    }

    IEnumerator IButtonsGreen()
    {
        {// Wait 1 second
            yield return new WaitForSeconds(0.5f);

            // Increment step counter
            stepCounterGreen++;
            stepCounterMain++;

            // Set next buttons active
            if (stepCounterMain < buttonsGreen.Length)
            {
                buttonsGreen[stepCounterMain].SetActive(true);
                buttonsGreen[stepCounterMain].GetComponent<Button>().interactable = true;
                buttonsYellow[stepCounterMain].SetActive(true);
                buttonsYellow[stepCounterMain].GetComponent<Button>().interactable = true;
                buttonsRed[stepCounterMain].SetActive(true);
                buttonsRed[stepCounterMain].GetComponent<Button>().interactable = true;
            }

            // If no more buttons, complete level
            else
            {
                // If conditions are met, award green star
                if (stepCounterGreen == stepCounterMain)
                {
                    PlayerPrefs.SetInt(scriptName + "StarGreen", 1);
                }

                CompleteLevel();
            }
        }
    }

    public void ButtonsYellow()
    {
        stepCounterYellow++;
        
        // Play audio
        buttonText = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<TMP_Text>().text;
        bork.BorkWord(buttonText);

        StartCoroutine(IButtonsYellow());
    }

    IEnumerator IButtonsYellow()
    {
        {
            // Deactivate buttons
            buttonsYellow[stepCounterMain].GetComponent<Button>().interactable = false;
            buttonsGreen[stepCounterMain].GetComponent<Button>().interactable = false;
            buttonsRed[stepCounterMain].GetComponent<Button>().interactable = false;

            // Wait 1 second
            yield return new WaitForSeconds(0.5f);

            // Increment step counter
            stepCounterMain++;

            // Set next buttons active
            if (stepCounterMain < buttonsYellow.Length)
            {
                buttonsGreen[stepCounterMain].SetActive(true);
                buttonsRed[stepCounterMain].SetActive(true);
            }

            // If no more buttons, complete level
            else
            {
                // Award yellow star if victory conditions are met
                if (stepCounterYellow == stepCounterMain)
                { PlayerPrefs.SetInt(scriptName + "StarYellow", 1); }

                CompleteLevel();
            }
        }
    }

    public void ButtonsRed()
    {
        // Play audio
        buttonText = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<TMP_Text>().text;
        bork.BorkWord(buttonText);

        StartCoroutine(IButtonsRed());
    }

    IEnumerator IButtonsRed()
    {
        {
            // Deactivate buttons
            buttonsRed[stepCounterMain].GetComponent<Button>().interactable = false;
            buttonsGreen[stepCounterMain].GetComponent<Button>().interactable = false;

            // Wait 1 second
            yield return new WaitForSeconds(0.25f);

            // Increment step counter
            stepCounterRed++;
            stepCounterMain++;

            // Set next button active
            if (stepCounterMain < buttonsRed.Length)
            {
                buttonsRed[stepCounterMain].SetActive(true);
                buttonsRed[stepCounterMain].GetComponent<Button>().interactable = true;
                buttonsYellow[stepCounterMain].SetActive(true);
                buttonsYellow[stepCounterMain].GetComponent<Button>().interactable = true;
                buttonsGreen[stepCounterMain].SetActive(true);
                buttonsGreen[stepCounterMain].GetComponent<Button>().interactable = true;
            }

            // If no more buttons, complete level
            else
            {
                // If conditions are met, award red star
                if (stepCounterRed == stepCounterMain)
                {
                    PlayerPrefs.SetInt(scriptName + "StarRed", 1);
                }

                CompleteLevel();
            }
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
        yield return new WaitForSeconds(2);

        // Load level select
        SceneManager.LoadScene("LevelSelect");
    }
}
