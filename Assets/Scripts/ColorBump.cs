using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBump : MonoBehaviour
{
    public Material mat;
    void Awake()
    {
        mat = GetComponent<MeshRenderer>().material ;
       // transform.parent = null;
    }

    // Update is called once per frame
    void Start()
       
    {
        transform.parent = null;
        mat.color = GameController.instance.colors[Random.Range(0, GameController.instance.colors.Length)];
    }


    public Color GetColor()
    {
        return this.mat.color;
    }
}
