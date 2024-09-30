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

 
    Transform myPos;
    Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        myPos = this.gameObject.transform;
        pos = myPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseposition = Input.mousePosition;
        Ray worldRay = Camera.main.ScreenPointToRay(mouseposition);


        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(worldRay, out RaycastHit hitinfo))
            {
                pikmin.SetDestination(hitinfo.point);
            }
        }

    }


    void pikminChosen()
    {

    }

}
