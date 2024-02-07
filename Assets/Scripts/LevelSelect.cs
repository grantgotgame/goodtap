using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    // Map GameObjects for UnlockIfCleared()
    [SerializeField] GameObject buttonB;
    [SerializeField] GameObject buttonC;
    [SerializeField] GameObject buttonOne;
    [SerializeField] GameObject buttonTwo;
    [SerializeField] GameObject stars4;
    [SerializeField] GameObject buttonThree;
    [SerializeField] GameObject starThreeYes;
    [SerializeField] GameObject newLevelText;

    // Start is called before the first frame update
    void Start()
    {
        // If levels are cleared, set GameObjects active
        UnlockIfCleared("A", buttonB);
        UnlockIfCleared("B", buttonC);
        UnlockIfCleared("C", buttonOne);
        UnlockIfCleared("One", buttonTwo);
        UnlockIfCleared("Two", stars4);
        UnlockIfCleared("Two", buttonThree);
        UnlockIfCleared("Three", starThreeYes);
        UnlockIfCleared("Three", newLevelText);
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
}
