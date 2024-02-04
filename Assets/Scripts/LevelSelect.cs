using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public GameObject buttonB;

    // Start is called before the first frame update
    void Start()
    {
        // Set button B active if level A is cleared
        bool clearA = (PlayerPrefs.GetInt("A") != 0);
        if (clearA)
        {
            buttonB.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Load selected level on button press
    public void LoadLevel()
    {
        string selectedLevel = EventSystem.current.currentSelectedGameObject.name;
        SceneManager.LoadScene(selectedLevel);
    }
}
