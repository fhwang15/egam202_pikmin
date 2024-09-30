using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClick : MonoBehaviour
{
    public Camera myCamera;

    public Transform markHandle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Vector2 mouseposition = Input.mousePosition;
        //Ray worldRay = myCamera.ScreenPointToRay(mouseposition); // can go from the


        //if (Physics.Raycast(worldRay, out RaycastHit hitInfo))
        //{
        //    ClickObject clickable = hitInfo.transform.GetComponent<ClickObject>();
        //    if (clickable != null)
        //    {
        //        clickable.Hover();
        //    }

        //}

        //if (Input.GetMouseButtonDown(0))
        //{
        //    if (Physics.Raycast(worldRay, out RaycastHit hitinfo))
        //    {
        //        markHandle.position = hitinfo.point;
        //    }
        //}


        //Debug.DrawRay(worldRay.origin, worldRay.direction);

    }
}
