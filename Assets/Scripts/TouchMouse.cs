using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchMouse : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
   

    public  static bool isPressing = false;

    public static bool  Pressing()
    {

      
        if (isPressing)
        {
            Debug.Log(" Mosue is down");
        }
       else  if (!isPressing)
        {
            Debug.Log(" Mosue is Up");
        }

        return isPressing;
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressing = true;
     
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressing = false;
     

    }
   
}// end class...........
