using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;

    public TextMeshProUGUI scoringSystem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoringSystem.text = score.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "pikmin")
        {
            Debug.Log("Why");
            score++;
            Destroy(collision.gameObject);
        }

    }
    


}
