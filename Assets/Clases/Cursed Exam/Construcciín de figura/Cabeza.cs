using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabeza : MonoBehaviour
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
            // Cube 1A0
            new Vector3(0,0,0), //0
            new Vector3(-1.5f,4,1.5f), //1
            new Vector3(1.5f,4,1.5f), //2
            new Vector3(0,12,0), //3
            new Vector3 (1.5f,4,-1.5f), //4
            new Vector3 (-1.5f,4,-1.5f), //5
        };

        meshFilter.mesh.vertices = vertex;

        triangles = new[]
        {
            //Cabeza
            2,1,0,
            3,1,2,
            4,2,0,
            3,2,4,
            5,0,1,
            1,3,5,

        };

        meshFilter.mesh.triangles = triangles;
    }

    

}
