using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerCharacter : MonoBehaviour
{
    public MovingMark nextPos;

    public NevMashAgent pikmin;

    Transform targetingPos;
    Transform myPos;

    float speed;

    // Start is called before the first frame update
    void Start()
    {
        myPos = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        targetingPos = nextPos.transform;

        this.gameObject.transform.position = Vector3.MoveTowards(myPos.position, targetingPos.position, (speed / 60));
        

        //Vector3 currentPos = myPos.position;
        //Vector3 targetPos = targetingPos.position;

        //Vector3 distanceBtw = currentPos - targetPos;

        //if(distanceBtw.magnitude == 0)
        //{
        //    nextPos.move = false;
        //}
        
 
    }


    void pikminChosen()
    {

    }

}
