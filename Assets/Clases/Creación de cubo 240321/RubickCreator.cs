﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubickCreator : MonoBehaviour
{
    [SerializeField] GameObject myCube;

    [SerializeField] GameObject[] allCubes;


    void Star ()
    {
         for (int z = 0; z < 3; z++)
        {
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Debug.Log ("Se crean las tres lineas");
                    Instantiate(myCube);
                    myCube.transform.position = new Vector3(x,y,z);
                }
            }
        }
        FindObjects();
    }
    
    void FindObjects()
    {
        allCubes = GameObject.FindGameObjectsWithTag("MyCube");
        for(int i = 0; i < allCubes.Length; i++)
        {

        }

    }

}