using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject wallPiece;
    public GameObject wall1, wall2;
    public float rotationZ;
    private float rotationZMax = 180;
    private float rotationZMin = -180;
    GameObject wallf;
    void Start()
    {
        wallPiece = Resources.Load("Wall") as GameObject;
        SpawnFragment();
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void SpawnFragment()
    {


        wall1 = new GameObject();
        wall2 = new GameObject();

        wall1.name = "Wall1";
        wall2.name = "Wall2";

        wall2.gameObject.tag = "Fail";
        wall1.transform.SetParent(this.transform);
        wall2.transform.SetParent(this.transform);
        wall2.gameObject.AddComponent<BoxCollider>().size = new Vector3(18.72f, 42.16f, 0.25f);
        wall2.GetComponent<BoxCollider>().center = new Vector3(10.01f, 0, this.transform.position.z );
        wall2.GetComponent<BoxCollider>().isTrigger = true;

        for (int i = 0; i < 100; i++)
        {
            //if (wallf.transform.rotation <= Quaternion.Euler(0, 0, -180))// why we canncot apply less thasn or greate sign with quaternions


            wallf = Instantiate(wallPiece, transform.position, Quaternion.Euler(0, 0, rotationZ));
            rotationZ += 3.6f;
           
            if (rotationZ <= rotationZMax)// why we canncot apply less thasn or greate sign with quaternions
            {
                wallf.transform.SetParent(wall1.transform);
                wallf.gameObject.tag = "Hit";

            }
            else if (rotationZ >= rotationZMin)
            {
                wallf.transform.SetParent(wall2.transform);
                // wallf.gameObject.tag = "Wall";

            }
           
        }


    }
}
