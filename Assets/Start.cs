using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("demo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
