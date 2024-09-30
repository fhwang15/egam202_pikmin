using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObject : MonoBehaviour
{
    public Renderer myRend;

    Color originalColor;
    public Color highlight;

    bool ishighlighted;


    private void Start()
    {
        originalColor = myRend.material.color;
    }


    public void Hover()
    {
        myRend.material.color = highlight;
        ishighlighted = true;
    }

    // Update is called once per frame
    private void Update()
    {
        if (ishighlighted)
        {
            ishighlighted = false;
            myRend.material.color = originalColor;
        }
    }
}
