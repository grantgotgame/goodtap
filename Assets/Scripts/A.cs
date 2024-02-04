using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class A : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Load LevelSelect scene on button press
    public void LoadLevelSelect()
    {
        // Mark level as complete
        PlayerPrefs.SetInt("A", 1);

        // Load Level select
        SceneManager.LoadScene("LevelSelect");
    }
}
