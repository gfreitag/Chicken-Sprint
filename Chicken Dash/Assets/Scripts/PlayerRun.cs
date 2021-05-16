using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRun : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 7.0f;
    public float acc = .10f;
    private float distanceMoved ;
    private float startPos;
    private float currPos;
    void Start()
    {
        startPos = transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        speed += Time.deltaTime*acc;
        transform.Translate(Time.deltaTime*speed, 0,0);

        /*
        currPos = transform.position.x - startPos;
        Debug.Log("current: " + currPos);

        if (currPos == 1000f) 
        {
            Debug.Log("CHANGING SPEED");
            speed = speed + 0.5f;
            startPos = transform.position.x;
        }
        transform.Translate(Time.deltaTime*speed, 0,0);

        */

    }


   /* private void OnTriggerEnter(Collider obstacle)
    {
        if (obstacle.tag == "obstacle") 
        {
            Debug.Log("ouch!");

        }
    }
    */


}
