using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetterLevelSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { LoadLevelSelect(); }
    }

    // Load LevelSelect scene on button press
    public void LoadLevelSelect()
    {
        // Load Level select
        SceneManager.LoadScene("LevelSelect");
    }
}
