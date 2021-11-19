using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject mushroom;
    private Vector3 validDirection = Vector3.up;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vector2 direction = collision.GetContact(0).normal;
            if(direction.y == -1)  {
                this.gameObject.active = false;
                mushroom.transform.localScale -= new Vector3(0, 0, 1);
                mushroom.transform.position = new Vector3(0, -1000, 0);
            };

        }
    }
}
