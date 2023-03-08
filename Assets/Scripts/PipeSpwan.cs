using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpwan : MonoBehaviour
{
    public GameObject pipes;
    public GameObject tree;

    public float timeSpwan;
    public float startTimeSpwan;
    private float yPos;

    public float treeTimeSpwan;
    public float treeStartTimeSpwan;

    public Vector3 spwanPos;
    public Vector3 treeSpwanPos;
    void Start()
    {
        
    }

    
    void Update()
    {
        yPos = Random.Range(-2.45f, 2.15f);
        spwanPos = new Vector3(transform.position.x, yPos, transform.position.z);
        treeSpwanPos = new Vector3(transform.position.x, -2.3f, transform.position.z);
        
        if (timeSpwan <= 0)
        {
            Instantiate(pipes, spwanPos, transform.rotation);
            timeSpwan = startTimeSpwan;
        }
        else
        {
            timeSpwan -= Time.deltaTime;
            
        }

        //if (treeTimeSpwan <= 0)
        //{
            //Instantiate(tree, treeSpwanPos, transform.rotation);
            //treeTimeSpwan = treeStartTimeSpwan;
        //}
        //else
        //{
            //treeTimeSpwan -= Time.deltaTime;
        //}
        
        
    }
}
