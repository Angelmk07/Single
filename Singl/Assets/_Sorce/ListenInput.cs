using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ListenInput : MonoBehaviour
{
    private void Update()
    {
        RestartScen();
    }
    void RestartScen()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("restart");
        }
    }
}
