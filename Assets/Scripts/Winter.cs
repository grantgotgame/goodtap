using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Winter : MonoBehaviour
{
    // Map GameObjects for UnlockIfCleared()

    [SerializeField] GameObject starDGreenYes;
    [SerializeField] GameObject starDYellowYes;
    [SerializeField] GameObject starDRedYes;
    [SerializeField] GameObject buttonE;
    [SerializeField] GameObject starEGreenYes;
    [SerializeField] GameObject starEYellowYes;
    [SerializeField] GameObject starERedYes;
    [SerializeField] GameObject buttonF;
    [SerializeField] GameObject starFGreenYes;
    [SerializeField] GameObject starFYellowYes;
    [SerializeField] GameObject starFRedYes;
    [SerializeField] GameObject buttonFour;
    [SerializeField] GameObject starFourGreenYes;
    [SerializeField] GameObject starFourYellowYes;
    [SerializeField] GameObject starFourRedYes;
    [SerializeField] GameObject buttonFive;
    [SerializeField] GameObject starFiveGreenYes;
    [SerializeField] GameObject starFiveYellowYes;
    [SerializeField] GameObject starFiveRedYes;
    [SerializeField] GameObject buttonSix;
    [SerializeField] GameObject starSixGreenYes;
    [SerializeField] GameObject starSixYellowYes;
    [SerializeField] GameObject starSixRedYes;
    [SerializeField] GameObject buttonSquirrels;
    [SerializeField] GameObject starSquirrelsGreenYes;
    [SerializeField] GameObject starSquirrelsYellowYes;
    [SerializeField] GameObject starSquirrelsRedYes;
    [SerializeField] GameObject buttonShould;
    [SerializeField] GameObject starShouldGreenYes;
    [SerializeField] GameObject starShouldYellowYes;
    [SerializeField] GameObject starShouldRedYes;
    [SerializeField] GameObject buttonAll;
    [SerializeField] GameObject starAllGreenYes;
    [SerializeField] GameObject starAllYellowYes;
    [SerializeField] GameObject starAllRedYes;
    [SerializeField] GameObject buttonSuck;
    [SerializeField] GameObject starSuckGreenYes;
    [SerializeField] GameObject starSuckYellowYes;
    [SerializeField] GameObject starSuckRedYes;
    [SerializeField] GameObject buttonSome;
    [SerializeField] GameObject starSomeGreenYes;
    [SerializeField] GameObject starSomeYellowYes;
    [SerializeField] GameObject starSomeRedYes;
    [SerializeField] GameObject buttonNuts;
    [SerializeField] GameObject starNutsGreenYes;
    [SerializeField] GameObject starNutsYellowYes;
    [SerializeField] GameObject starNutsRedYes;
    [SerializeField] GameObject newLevelText;

    // Variables for UnlockLetterIfCleared
    [SerializeField] GameObject letterWinter;
    private bool letterWinterYes;

    // Start is called before the first frame update
    void Start()
    {
        // If levels and stars are cleared, set GameObjects active
        UnlockIfCleared("DStarGreen", starDGreenYes);
        UnlockIfCleared("DStarYellow", starDYellowYes);
        UnlockIfCleared("DStarRed", starDRedYes);
        //UnlockIfCleared("D", buttonE);
        UnlockIfCleared("EStarGreen", starEGreenYes);
        UnlockIfCleared("EStarYellow", starEYellowYes);
        UnlockIfCleared("EStarRed", starERedYes);
        UnlockIfCleared("E", buttonF);
        UnlockIfCleared("FStarGreen", starFGreenYes);
        UnlockIfCleared("FStarYellow", starFYellowYes);
        UnlockIfCleared("FStarRed", starFRedYes);
        UnlockIfCleared("F", buttonFour);
        UnlockIfCleared("FourStarGreen", starFourGreenYes);
        UnlockIfCleared("FourStarYellow", starFourYellowYes);
        UnlockIfCleared("FourStarRed", starFourRedYes);
        UnlockIfCleared("Four", buttonFive);
        UnlockIfCleared("FiveStarGreen", starFiveGreenYes);
        UnlockIfCleared("FiveStarYellow", starFiveYellowYes);
        UnlockIfCleared("FiveStarRed", starFiveRedYes);
        UnlockIfCleared("Five", buttonSix);
        UnlockIfCleared("SixStarGreen", starSixGreenYes);
        UnlockIfCleared("SixStarYellow", starSixYellowYes);
        UnlockIfCleared("SixStarRed", starSixRedYes);
        UnlockIfCleared("Six", buttonSquirrels);
        UnlockIfCleared("SquirrelsStarGreen", starSquirrelsGreenYes);
        UnlockIfCleared("SquirrelsStarYellow", starSquirrelsYellowYes);
        UnlockIfCleared("SquirrelsStarRed", starSquirrelsRedYes);
        UnlockIfCleared("Squirrels", buttonShould);
        UnlockIfCleared("ShouldStarGreen", starShouldGreenYes);
        UnlockIfCleared("ShouldStarYellow", starShouldYellowYes);
        UnlockIfCleared("ShouldStarRed", starShouldRedYes);
        UnlockIfCleared("Should", buttonAll);
        UnlockIfCleared("AllStarGreen", starAllGreenYes);
        UnlockIfCleared("AllStarYellow", starAllYellowYes);
        UnlockIfCleared("AllStarRed", starAllRedYes);
        UnlockIfCleared("All", buttonSuck);
        UnlockIfCleared("SuckStarGreen", starSuckGreenYes);
        UnlockIfCleared("SuckStarYellow", starSuckYellowYes);
        UnlockIfCleared("SuckStarRed", starSuckRedYes);
        UnlockIfCleared("Suck", buttonSome);
        UnlockIfCleared("SomeStarGreen", starSomeGreenYes);
        UnlockIfCleared("SomeStarYellow", starSomeYellowYes);
        UnlockIfCleared("SomeStarRed", starSomeRedYes);
        UnlockIfCleared("Some", buttonNuts);
        UnlockIfCleared("NutsStarGreen", starNutsGreenYes);
        UnlockIfCleared("NutsStarYellow", starNutsYellowYes);
        UnlockIfCleared("NutsStarRed", starNutsRedYes);
        UnlockIfCleared("D", newLevelText);

        // If all stars are cleared, unlock Letter
        UnlockLetterIfCleared();
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

    // If all stars are cleared, unlock Letter
    private void UnlockLetterIfCleared()
    {
        // If letter has been cleared, set it active
        letterWinterYes = (PlayerPrefs.GetInt("WinterLetter") != 0);
        if (letterWinterYes)
        { letterWinter.SetActive(true); }

        // If letter not clear, check if all stars collected
        else if (
            PlayerPrefs.GetInt("DStarGreen") != 0 &&
            PlayerPrefs.GetInt("DStarYellow") != 0 &&
            PlayerPrefs.GetInt("DStarRed") != 0 &&
            PlayerPrefs.GetInt("EStarGreen") != 0 &&
            PlayerPrefs.GetInt("EStarYellow") != 0 &&
            PlayerPrefs.GetInt("EStarRed") != 0 &&
            PlayerPrefs.GetInt("FStarGreen") != 0 &&
            PlayerPrefs.GetInt("FStarYellow") != 0 &&
            PlayerPrefs.GetInt("FStarRed") != 0 &&
            PlayerPrefs.GetInt("FourStarGreen") != 0 &&
            PlayerPrefs.GetInt("FourStarYellow") != 0 &&
            PlayerPrefs.GetInt("FourStarRed") != 0 &&
            PlayerPrefs.GetInt("FiveStarGreen") != 0 &&
            PlayerPrefs.GetInt("FiveStarYellow") != 0 &&
            PlayerPrefs.GetInt("FiveStarRed") != 0 &&
            PlayerPrefs.GetInt("SixStarGreen") != 0 &&
            PlayerPrefs.GetInt("SixStarYellow") != 0 &&
            PlayerPrefs.GetInt("SixStarRed") != 0 &&
            PlayerPrefs.GetInt("SquirrelsStarGreen") != 0 &&
            PlayerPrefs.GetInt("SquirrelsStarYellow") != 0 &&
            PlayerPrefs.GetInt("SquirrelsStarRed") != 0 &&
            PlayerPrefs.GetInt("ShouldStarGreen") != 0 &&
            PlayerPrefs.GetInt("ShouldStarYellow") != 0 &&
            PlayerPrefs.GetInt("ShouldStarRed") != 0 &&
            PlayerPrefs.GetInt("AllStarGreen") != 0 &&
            PlayerPrefs.GetInt("AllStarYellow") != 0 &&
            PlayerPrefs.GetInt("AllStarRed") != 0 &&
            PlayerPrefs.GetInt("SuckStarGreen") != 0 &&
            PlayerPrefs.GetInt("SuckStarYellow") != 0 &&
            PlayerPrefs.GetInt("SuckStarRed") != 0 &&
            PlayerPrefs.GetInt("SomeStarGreen") != 0 &&
            PlayerPrefs.GetInt("SomeStarYellow") != 0 &&
            PlayerPrefs.GetInt("SomeStarRed") != 0 &&
            PlayerPrefs.GetInt("NutsStarGreen") != 0 &&
            PlayerPrefs.GetInt("NutsStarYellow") != 0 &&
            PlayerPrefs.GetInt("NutsStarRed") != 0
        )
        // If all stars, unlock Letter
        {
            PlayerPrefs.SetInt("WinterLetter", 1);
            letterWinter.SetActive(true);
        }
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
