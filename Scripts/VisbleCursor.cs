using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisbleCursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Cursor.visible) 
        {
            Cursor.visible = false;
        }
    }
}
