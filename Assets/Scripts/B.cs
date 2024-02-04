using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class B : MonoBehaviour
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
        SceneManager.LoadScene("LevelSelect");
    }
}
