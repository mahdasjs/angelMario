﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene("level1");

        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            flag = true;

        }
    }
    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
        player.coinNum = 0;
    }
}
