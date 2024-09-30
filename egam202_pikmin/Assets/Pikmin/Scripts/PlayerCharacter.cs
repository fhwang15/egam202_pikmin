using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public MovingMark nextPos;

    Transform targetingPos;
    Transform myPos;

    float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        myPos = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        targetingPos = nextPos.transform;

        this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, targetingPos.transform.position, (speed/60));
        
    }
}
