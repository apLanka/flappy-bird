using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpwan : MonoBehaviour
{
    public GameObject pipes;

    public float timeSpwan;
    public float startTimeSpwan;
    private float yPos;

    public Vector3 spwanPos;
    void Start()
    {
        
    }

    
    void Update()
    {
        yPos = Random.Range(-2.45f, 2.15f);
        spwanPos = new Vector3(transform.position.x, yPos, transform.position.z);
        
        if (timeSpwan <= 0)
        {
            Instantiate(pipes, spwanPos, transform.rotation);
            timeSpwan = startTimeSpwan;
        }
        else
        {
            timeSpwan -= Time.deltaTime;
        }
    }
}
