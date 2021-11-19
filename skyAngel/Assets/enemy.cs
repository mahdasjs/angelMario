using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject mushroom;
    private int leftPoint = 10;
    private int rightPoint = 18;
    private int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == 1)
        {
            mushroom.transform.Translate (Vector3.right*2*Time.deltaTime);
            direction = 1;
        }
        if (mushroom.transform.position.x > rightPoint)
        {
            direction = 2;
        }
        if (direction == 2)
        {
            mushroom.transform.Translate(Vector3.right * -2 * Time.deltaTime);
            direction = 2;
        }
        if (mushroom.transform.position.x < leftPoint)
        {
            direction = 1;
        }
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
            }
            else if (direction.x == 1 || direction.x == -1)
            {
                Debug.Log("stop");
            };

        }
    }
}
