using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{ 
    public GameObject[] myBox;

    void Start()
    {
        
    }

    void Updatet()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            for (int i = 0; i < myBox.Length; i++)
            {
                Rotate(myBox[i]);
            }
        }
    }


    void Rotate(GameObject myBox)
    {
        Vector3 pos = myBox.transform.position;

        float angle = 5;

        float x = (pos.x * Mathf.Cos(angle)) - (pos.y * Mathf.Sin(angle));
        float y = (pos.x * Mathf.Sin(angle)) + (pos.y * Mathf.Cos(angle));

        myBox.transform.position = new Vector3(x, y, pos.z);
    }


}
