using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLevels : MonoBehaviour
{
    public Vector3 mouseReference;
    public Vector3 mouseOffset;
    public Vector3 rotation;
    public bool isRotating;
    void Start()
    {
        
    }



    private void Update()
    {
        
        if (isRotating)
        {
            mouseOffset = Input.mousePosition  -mouseReference;
            //Debug.Log("mouseOffset>>"+mouseOffset);
            //Debug.Log("Input.mousePosition>>"+ Input.mousePosition);
            // rotation.y = -(mouseOffset.x + mouseOffset.y);
            transform.Rotate(new Vector3(0, -mouseOffset.y,0));

            mouseReference = Input.mousePosition;
        }
    }
    void OnMouseDown()
    {
        mouseReference = Input.mousePosition;
        isRotating = true;
    }
    void OnMouseUp()
    {
        isRotating = false;
    }

}
