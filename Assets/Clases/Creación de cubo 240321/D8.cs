using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D8 : MonoBehaviour
{
    public Material material;

    Mesh mesh;
    MeshRenderer meshRenderer;
    MeshFilter meshFilter;
    Vector3[] vertex;



    int[] triangles;

    List<int> triangles_2;
    // Start is called before the first frame update
    void Start()
    {
        meshFilter = gameObject.AddComponent<MeshFilter>();

        meshRenderer = gameObject.AddComponent<MeshRenderer>();

        meshRenderer.material = material;

        meshFilter.mesh = mesh;

        vertex = new[]
        {
            // D20
            new Vector3(1,0,0), //a-0
            new Vector3(2,0,0), //b-1
            new Vector3(0.5f,0,0.87f), //D-2
            new Vector3(1.5f,0.58f,-0.65f), //E-3
            new Vector3(2.31f,0.93f,-0.18f), //F-4
            new Vector3(0.69f,0.58f,0.76f), //G-5
            new Vector3(0.69f,0.93f,-0.18f), //H-6
            new Vector3(2.31f,0.93f,-0.18f), //I-7
            new Vector3(1.5f,0.58f,0.76f), //J-8
            new Vector3(1.5f,1.51f,-0.29f), //K-9
            new Vector3(2,1.51f,0.58f), //L-10
            new Vector3(1,1.51f,0.58f), //M-11

        };

        /*vertex = new Vector3[3];
        vertex[0] = new Vector3(0, 0, 0);
        vertex[1] = new Vector3(0, 1, 0);
        vertex[2] = new Vector3(1, 0, 0);*/

        meshFilter.mesh.vertices = vertex;

        triangles = new[]
        {
            // D20
            0,1,2,  // T_1
            2,3,0, // T_2
            0,2,3 // T_3

            
            
            
        };

        meshFilter.mesh.triangles = triangles;

        /*
        triangle = new int[4];

        triangles_2 = new List<int>();

        triangle[0] = 1;

        triangles_2[0] = 1;

        triangles_2 
        */
    }


}
