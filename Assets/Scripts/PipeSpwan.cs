using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpwan : MonoBehaviour
{
    public GameObject pipes;
    void Start()
    {
        Instantiate(pipes, transform.position, transform.rotation);
    }

    
    void Update()
    {
        
    }
}
