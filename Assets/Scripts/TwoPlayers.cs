using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TwoPlayers : MonoBehaviour
{
    [SerializeField]
    string strTag;
    [SerializeField]
    string strTag2;
    [SerializeField]
    string strSceneName;
    
    private void OnCollisionEnter(Collision collision)
    {   
        if(collision.collider.tag == strTag)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if(collision.collider.tag == strTag2)
            SceneManager.LoadScene(strSceneName); 
    }

}
