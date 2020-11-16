using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour
{
    Camera cam;
    void Start()
    {
        cam = Camera.main;
    }
    void FixedUpdate()
    {   
        float hitdist = 0.0f;
        Ray ray = cam.ScreenPointToRay (Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        if (Input.GetMouseButton(0)){
            if (Physics.Raycast (ray, out hit))
            {
            Vector3 rot = transform.eulerAngles;
            transform.LookAt(hit.point);
            transform.eulerAngles = new Vector3(rot.x, transform.eulerAngles.y, rot.z);
            }
}
}}