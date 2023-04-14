using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixCylinder : MonoBehaviour
{
    private GameObject helix;
    void Start()
    {
        helix = GameObject.Find("helix");
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0, 0, helix.gameObject.transform.eulerAngles.z%25);
    }
}
