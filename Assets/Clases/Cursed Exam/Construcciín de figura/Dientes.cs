using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dientes : MonoBehaviour
{
    Mesh mesh;
    MeshRenderer meshRenderer;
    MeshFilter meshFilter;
    public Material material;

    Vector3[] vertex;
    int[] triangles;

    // Start is called before the first frame update
    void Start()
    {
        triangles = new int[4];


        meshFilter = gameObject.AddComponent<MeshFilter>();

        meshRenderer = gameObject.AddComponent<MeshRenderer>();

        meshRenderer.material = material;

        meshFilter.mesh = mesh;

        vertex = new[]
        {
            
            new Vector3(0,-0.25f,0), //0
            new Vector3(-0.05f,0,0.05f), //1
            new Vector3(0.05f,0,0.05f), //2
            new Vector3(0,0.25f,0), //3
            new Vector3 (0.05f,0,-0.05f), //4
            new Vector3 (-0.05f,0,-0.05f), //5
        };

        meshFilter.mesh.vertices = vertex;

        triangles = new[]
        {
            //Dientes
            2,1,0,
            2,3,1,
            4,2,0,
            3,2,4,
            5,0,1,
            1,3,5,
            4,0,5,
            4,5,3



        };

        meshFilter.mesh.triangles = triangles;
    }



}