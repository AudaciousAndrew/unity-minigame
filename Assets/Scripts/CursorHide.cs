using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHide : MonoBehaviour
{
    [SerializeField]
    bool isVisible;

    void Start()
    {
        Cursor.visible = isVisible; 
    }

}
