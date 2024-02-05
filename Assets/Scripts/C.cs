using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class C : MonoBehaviour
{
    // Map audio
    private AudioSource audioSource;
    [SerializeField] AudioClip sing_GOOD;
    [SerializeField] AudioClip sing_TAP;

    // Map button containers
    [SerializeField] GameObject container_GOOD;
    [SerializeField] GameObject container_TAP;

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
    public void ButtonGOOD()
    {
        // Sing GOOD
        audioSource.PlayOneShot(sing_GOOD);

        // Wait 1 second, disable GOOD, enable TAP
        StartCoroutine(I_GOOD());
    }

    IEnumerator I_GOOD()
    {
        // Wait 1 second
        yield return new WaitForSeconds(1);

        // Disable GOOD
        container_GOOD.SetActive(false);

        // Enable TAP
        container_TAP.SetActive(true);
    }

    // Sing TAP and load Level Select
    public void ButtonTAP()
    {
        // Sing TAP
        audioSource.PlayOneShot(sing_TAP);

        StartCoroutine(WaitLoad());
    }

    // Wait, then load Level Select
    IEnumerator WaitLoad()
    {
        // Mark level as complete
        PlayerPrefs.SetInt("C", 1);

        //Wait 1 second
        yield return new WaitForSeconds(1);

        // Load level select
        SceneManager.LoadScene("LevelSelect");
    }
}
