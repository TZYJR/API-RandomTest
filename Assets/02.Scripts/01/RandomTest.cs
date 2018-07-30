using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTest : MonoBehaviour
{
    public GameObject Cube_a;

    private void Update()
    {
        Instantiate(Cube_a, Random.onUnitSphere * 4.0f, Quaternion.identity);
    }

}
