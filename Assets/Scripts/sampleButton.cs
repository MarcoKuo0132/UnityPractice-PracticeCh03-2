using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleButton : MonoBehaviour
{
    private int n;
    private Rect btnRect;

    // Start is called before the first frame update
    void Start()
    {
        n = 0;
        btnRect = new Rect();

        btnRect.x = Screen.width / 3;
        btnRect.y = Screen.height * 2 / 5;
        btnRect.width = Screen.width / 3;
        btnRect.height = Screen.height / 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        if (GUI.Button(btnRect, "test"))
        {
            print(n);
            n++;
        }
    }
}
