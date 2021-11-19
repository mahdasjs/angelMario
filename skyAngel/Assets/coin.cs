using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public GameObject coins;
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
            this.gameObject.active = false;
            coins.active = false;
            player.coinNum += 1;
            Debug.Log(player.coinNum);
        }
    }
}
