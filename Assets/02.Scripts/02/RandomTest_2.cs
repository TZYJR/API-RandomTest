using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTest_2 : MonoBehaviour
{
    Color[] colorArray;
    public GameObject Cube;

    void Statr()
    {
        //colorArray = new Color[3];
        //colorArray[0] = Color.black;
        //colorArray[1] = Color.red;
        //colorArray[2] = Color.gray;
    }

    void Update()
    {
        colorArray = new Color[3];
        colorArray[0] = Color.black;
        colorArray[1] = Color.red;
        colorArray[2] = Color.green;

        //Vector3 random = Random.insideUnitSphere * 10;
        //Instantiate(Cube, random, Quaternion.identity);
        //Instantiate(Cube, Random.insideUnitSphere * 30f, Quaternion.identity);

        //Instantiate(Cube, Random.onUnitSphere * 3f, Quaternion.identity);

        Vector3 v3 = Random.onUnitSphere * 10;
        GameObject currentCube = Instantiate(Cube, v3, Quaternion.identity) as GameObject;
        currentCube.GetComponent<Renderer>().material.color = colorArray[Random.Range(0, 3)];

    }

}
