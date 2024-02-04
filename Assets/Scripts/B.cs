using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class B : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip good;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Do something on button press
    public void Button()
    {
        //Play a sound
        audioSource.PlayOneShot(good);
        
        // Mark level as complete
        PlayerPrefs.SetInt("B", 1);

        StartCoroutine(WaitLoad());
    }

    // Wait, then load Level Select
    IEnumerator WaitLoad()
    {
        //Wait 1 second
        yield return new WaitForSeconds(1);
        
        // Load level select
        SceneManager.LoadScene("LevelSelect");
    }
}
