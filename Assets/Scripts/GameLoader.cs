using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // If level Be is complete, load Winter. Else, load LevelSelect
        bool levelBeCleared = (PlayerPrefs.GetInt("Be") != 0);
        if (levelBeCleared)
        { SceneManager.LoadScene("Winter"); }
        else { SceneManager.LoadScene("LevelSelect"); }
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

    // If levelCleared has been cleared, unlock objectToUnlock 
    private void UnlockIfCleared(string levelCleared, GameObject objectToUnlock)
    {
        // Check if level has been cleared
        bool clear = (PlayerPrefs.GetInt(levelCleared) != 0);

        //Unlock objectToUnlock if level has been cleared
        if (clear)
        { objectToUnlock.SetActive(true); }
    }

    // If do not pressed, destroy all progress and reload
    public void DoNotPress()
    {
        // Destroy all progress
        PlayerPrefs.DeleteAll();

        // Load Level Select
        SceneManager.LoadScene("LevelSelect");
    }
}
