using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class PlayerCharacter : MonoBehaviour
{
    public MovingMark nextPos;
    public NavMeshAgent pikmin;

    public Renderer myRender;

    Color selected;
    Color deselected;
 
    public Transform myPos;
    Vector2 pos;


    public bool activePikmin;

    // Start is called before the first frame update
    void Start()
    {
        myPos = this.gameObject.transform;
        pos = myPos.position;
        activePikmin = false;

        pikmin = GetComponent<NavMeshAgent>();

        deselected = myRender.material.color;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mouseposition = Input.mousePosition;
            Ray worldRay = Camera.main.ScreenPointToRay(mouseposition);

            if (Physics.Raycast(worldRay, out RaycastHit hitinfo))
            {
                myRender.material.color = selected;
                activePikmin = true;
            }

            if (activePikmin)
            {
                if (Physics.Raycast(worldRay, out RaycastHit hitInfo))
                {
                    pikmin.SetDestination(hitInfo.point);
                }
            } 
        }
        else if (Input.GetMouseButtonDown(1)) {

            myRender.material.color = deselected;
            activePikmin = false;

        }

    }

}
