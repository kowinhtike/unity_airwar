using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        //delete enemy after creating 4 seconds
        Destroy(gameObject,4);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime);
        
    }
}
