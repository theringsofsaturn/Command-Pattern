﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //left click
        //cast a ray
        //detect a cube
        //assign a random color
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if(Physics.Raycast(rayOrigin, out hitInfo))
            {
                if(hitInfo.collider.tag == "Cube")
                {
                    hitInfo.collider.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
                }
            }
        }
    }
}
