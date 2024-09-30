using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class MovingMark : MonoBehaviour
{
    public Camera myCamera;
    Transform myPosition;

    public bool move;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().enabled = false;
        myPosition = gameObject.transform;
        move = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseposition = Input.mousePosition;
        Ray worldRay = myCamera.ScreenPointToRay(mouseposition);


        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Renderer>().enabled = true;

            if (Physics.Raycast(worldRay, out RaycastHit hitinfo))
            {
                myPosition.position = hitinfo.point;
            }
        }

        Debug.DrawRay(worldRay.origin, worldRay.direction);
    }

}
