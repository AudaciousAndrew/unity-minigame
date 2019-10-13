using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelWithButton : MonoBehaviour
{

    [SerializeField]
    KeyCode KeyRestart;

    void Update()
    {
        if (Input.GetKey(KeyRestart))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);   
    }
}
