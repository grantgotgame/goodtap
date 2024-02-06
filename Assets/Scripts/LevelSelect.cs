using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    // Map buttons
    [SerializeField] GameObject buttonB;
    [SerializeField] GameObject buttonC;
    [SerializeField] GameObject buttonOne;

    // Start is called before the first frame update
    void Start()
    {
        // Set buttons active if levels are cleared
        UnlockIfCleared("A", buttonB);
        UnlockIfCleared("B", buttonC);
        UnlockIfCleared("C", buttonOne);
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
