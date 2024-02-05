using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 direction;
    public float speed;
    public float ver;
    public float hor;

    public Transform bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        //hor = Input.GetAxisRaw("Horizontal");
        //ver = Input.GetAxisRaw("Vertical");
        direction = new Vector3(hor, ver,0);

        transform.Translate(direction * speed * Time.deltaTime);

        //for bullet
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //create bullet and set player transform position
            Instantiate(bullet,transform.position,Quaternion.identity);

        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Don't forget to enable is trigger check button and save template
        if (other.CompareTag("enemy"))
        {
            Debug.Log("Hit");
            Object.Destroy(transform.gameObject);
        }
    }
}
