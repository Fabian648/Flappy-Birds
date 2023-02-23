using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject obstacle;
    public float frequency = 10.0f;
    //PlayerControl pc;
    

    // Start is called before the first frame update
    void Start()
    {
        //pc = GameObject.Find("bird").GetComponent<PlayerControl>();
        //Debug.Log(pc.hit);
        //if (!pc.hit)
        //{
            InvokeRepeating("spawn_pipe", 0f, frequency);
        //}
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn_pipe()
    {
        Instantiate(obstacle, transform.position, transform.rotation);
    }

}
