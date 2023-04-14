using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Player player;
    public float Distance;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
      //  this.transform.position = new Vector3(0, 0, player.transform.position.z - Distance);
    }
}
