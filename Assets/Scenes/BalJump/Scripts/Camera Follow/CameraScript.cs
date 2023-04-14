using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private GameObject target;

    public float distance=7.6f;
    public float height=2.5f;
    public float damping=1.1f;
    public float rotationalDamping = 0f;
    public bool smoothRotation=true;
    public bool followBehind = true;

    private void Awake()
    {
        target = GameObject.FindWithTag("Player");
    }
  

    // Update is called once per frame
    void Update()
    {
        Vector3 WantedPosition;
        WantedPosition = new Vector3(target.gameObject.transform.position.x - 0.5f, target.gameObject.transform.position.x + 2f, target.gameObject.transform.position.x - 1f);
        if (followBehind)
        {
            // WantedPosition = target.gameObject.transform.TransformPoint(0, height, -distance);

        }
        else
        {
            Debug.Log("Inside Follow beghind");
            WantedPosition = target.gameObject.transform.TransformPoint(0, height, distance);
        }

        transform.position = Vector3.Lerp(transform.position, WantedPosition, Time.deltaTime);



        //if (smoothRotation)
        //{
        //    Quaternion wantedRotation = Quaternion.LookRotation(target.transform.position - transform.position, target.transform.up);
        //   transform.rotation = Quaternion.Slerp(transform.rotation , wantedRotation, Time.deltaTime);
        //}
        //else
        //{
        //    transform.LookAt(target.transform.position, target.transform.position);
        //}
    }// End Update
}
