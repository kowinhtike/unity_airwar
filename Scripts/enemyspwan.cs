using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspwan : MonoBehaviour
{
    public Transform enemy;
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(new Vector3(0,20,0));
        InvokeRepeating("spawn", .5f, 1.5f);
        //CancelInvoke();
    }

    void spawn()
    {
        Vector3 spawnPos = new Vector3 (Random.Range(-8,8), 0, 0);
        //set transform ,vector and rotation 
        Instantiate(enemy,spawnPos,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
