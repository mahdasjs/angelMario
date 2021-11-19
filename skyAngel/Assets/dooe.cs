using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooe : MonoBehaviour
{
    public bool flag=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E) &&flag==true)
        {
            Debug.Log("enter");

        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            flag = true;

        }
    }
}
