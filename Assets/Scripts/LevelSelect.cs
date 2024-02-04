using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    // Map buttons
    public GameObject buttonB;
    public GameObject buttonC;

    // Start is called before the first frame update
    void Start()
    {
        // Set button B active if level A is cleared
        UnlockIfCleared("A", buttonB);
        // bool clearA = (PlayerPrefs.GetInt("A") != 0);
        // if (clearA)
        // { buttonB.SetActive(true); }

        // Set button C active if level B is cleared
        UnlockIfCleared("B", buttonC);
        // bool clearB = (PlayerPrefs.GetInt("B") != 0);
        // if (clearB)
        // { buttonC.SetActive(true); }
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

    // If levelCleared has been cleared, unlock buttonToUnlock 
    private void UnlockIfCleared(string levelCleared, GameObject buttonToUnlock)
    {
        // Check if level has been cleared
        bool clear = (PlayerPrefs.GetInt(levelCleared) != 0);

        //Unlock button if level has been cleared
        if (clear)
        { buttonToUnlock.SetActive(true); }
    }
}
