using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomMeshTest : MonoBehaviour
{
    /*
     * 需要Material
     */


    private void Awake()
    {
        AddMesh();
    }

    private void AddMesh()
    {
        Mesh curMesh = new Mesh();
        GetComponent<MeshFilter>().mesh = curMesh;
        curMesh.name = "createTempMesh";

        Vector3[] vectices = new Vector3[3];
        vectices[0].x = 0;
        vectices[0].y = 0;
        vectices[0].z = 0;

        vectices[1].x = 1;
        vectices[1].y = 0;
        vectices[1].z = 0;

        vectices[2].x = 0;
        vectices[2].y = 1;
        vectices[2].z = 0;
        curMesh.vertices = vectices;

        int[] TriangleIndexs = new int[3];
        TriangleIndexs[0] = 0;
        TriangleIndexs[1] = 2;
        TriangleIndexs[2] = 1;
        curMesh.triangles = TriangleIndexs;

        Vector2[] uvs = new Vector2[3];
        uvs[0] = new Vector2(0, 0);
        uvs[1] = new Vector2(1.0f, 0);
        uvs[2] = new Vector2(0, 1.0f);
        curMesh.uv = uvs;

        curMesh.RecalculateNormals();//法线
    }

    //public int xSize;
    //public int ySize;

    //private void Awake()
    //{
    //    GenerateMesh();
    //}

    //private void GenerateMesh()
    //{
    //    Mesh curMesh = new Mesh();
    //    GetComponent<MeshFilter>().mesh = curMesh;
    //    curMesh.name = "Procedural Grid";

    //    Vector3[] vertices = new Vector3[(xSize + 1) * (ySize + 1)];
    //    Vector2[] uvs = new Vector2[vertices.Length];
    //    int verticeIndex = 0;
    //    for(int y = 0; y <= ySize; y++)
    //    {
    //        for(int x = 0; x <= xSize; x++)
    //        {
    //            vertices[verticeIndex] = new Vector3(x, y);
    //            uvs[verticeIndex] = new Vector2((float)x / xSize, (float)y / ySize);
    //            verticeIndex++;
    //        }
    //    }
    //    curMesh.vertices = vertices;
    //    curMesh.uv = uvs;

    //    int[] triangles = new int[xSize * ySize * 6];
    //    int triangleIndex = 0;
    //    verticeIndex = 0;
    //    for (int y = 0; y < ySize; y++)
    //    {
    //        for(int x = 0; x < xSize; x++)
    //        {
    //            triangles[triangleIndex] = verticeIndex;
    //            triangles[triangleIndex + 1] = verticeIndex + xSize + 1;
    //            triangles[triangleIndex + 2] = verticeIndex + 1;
    //            triangles[triangleIndex + 3] = verticeIndex + 1;
    //            triangles[triangleIndex + 4] = verticeIndex + xSize + 1;
    //            triangles[triangleIndex + 5] = verticeIndex + xSize + 2;

    //            triangleIndex += 6;
    //            verticeIndex++;
    //        }
    //        verticeIndex++;
    //    }
    //    curMesh.triangles = triangles;

    //    curMesh.RecalculateNormals();//法线
    //}
}
