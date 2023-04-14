using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixRing : MonoBehaviour
{
    private bool ableToMove = true;

    private float angle;
    private float lastAngle, lastTouchX;
    public Camera myCam;
    void Start()
    {
       
        ableToMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        GetMouseX();
        if (ableToMove&& TouchMouse.isPressing)
        {
            float mouseX = GetMouseX();
            lastAngle = lastTouchX - mouseX;
            angle += lastAngle * 360 * 1.7f;
            lastTouchX = mouseX;
        }
        else if (lastAngle!=0)
        {
            lastAngle -= lastAngle * 5 * Time.deltaTime;
            angle += lastAngle * 360 * 1.7f;
        }

        transform.eulerAngles = new Vector3(0, 0, angle);
    }



    public float GetMouseX()
    {
      // 
      
        float mousePosOfX = Input.mousePosition.x;
        float mousePosOfX2 = Input.mousePosition.x / Screen.width;
     
        float mousePosOfY = Input.mousePosition.y;
        float mousePosOfY2 = Input.mousePosition.y / Screen.height;
       
        return mousePosOfX;
    }


}
