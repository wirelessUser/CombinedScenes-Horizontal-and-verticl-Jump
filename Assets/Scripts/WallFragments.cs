using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallFragments : MonoBehaviour
{
    public MeshRenderer meshRender;


    private void Awake()
    {
        meshRender = GetComponent<MeshRenderer>();
    }
    void Start()
    {
       


        if (this.gameObject.tag=="Hit")
        {
            meshRender.material.color = GameController.instance.hitColor;
        }
        else
        {
            meshRender.material.color = GameController.instance.FailColor;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
