using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject Cube;

    private Vector3 offset;


    void Start()
    {
        offset = transform.position - Cube.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Cube.transform.position + offset;
    }
}