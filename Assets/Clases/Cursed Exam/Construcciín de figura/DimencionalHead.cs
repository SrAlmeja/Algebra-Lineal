using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimencionalHead : MonoBehaviour
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
            new Vector3(0,0.5f,0), //0
            new Vector3(-1.45f,4,1.45f), //1
            new Vector3(1.45f,4,1.45f), //2
            new Vector3(0,11.95f,0), //3
            new Vector3 (1.45f,4,-1.45f), //4
            new Vector3 (-1.45f,4,-1.45f), //5
        };

        meshFilter.mesh.vertices = vertex;

        triangles = new[]
        {
            //Cabeza
            0,1,2,
            2,1,3,
            0,2,4,
            4,2,3,
            1,0,5,
            5,3,1,

        };

        meshFilter.mesh.triangles = triangles;
    }
}