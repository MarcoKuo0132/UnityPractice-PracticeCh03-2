using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleLabel : MonoBehaviour
{
    private Rect labelRect;
    // Start is called before the first frame update
    void Start()
    {
        labelRect = new Rect();

        labelRect.x = Screen.width / 3;
        labelRect.y = Screen.height * 2 / 5;
        labelRect.width = Screen.width / 3;
        labelRect.height = Screen.height / 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        GUI.Label(labelRect, "Hello world");
    }
}
