using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trees : MonoBehaviour
{
    public float speed;
    
    
    void Update()
    {
        transform.Translate(Vector3.left * speed);
    }
}
