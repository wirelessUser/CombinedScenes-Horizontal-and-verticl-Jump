using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Color[] colors;

    public Color hitColor, FailColor;
    public GameObject[] wall2;
    public GameObject finishLine;
     int wallSpawnCount=12;
    public int z;
    public bool colorBump;
    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
        GenerateColor();
        Spawner();
        GenerateLevels();


    }
   public void GenerateLevels()
    {
        wallSpawnCount = 12;
        z = 5;
        DeleteWalls();
        colorBump = false;
        Spawner();
    }

    void DeleteWalls()
    {
        wall2 = GameObject.FindGameObjectsWithTag("Fail");

        if (wall2.Length>1)
        {
            for (int i = 0; i < wall2.Length; i++)
            {

                Destroy(wall2[i].transform.parent.gameObject);
            }

            Destroy(GameObject.FindWithTag("ColorBump"));
        }
       
    }
    public void GenerateColor()
    {
        hitColor = colors[ Random.Range(0, colors.Length)];
        FailColor = colors[Random.Range(0, colors.Length)];

        do
        {
            FailColor= colors[Random.Range(0, colors.Length)];
        } while (hitColor==FailColor);

        Player.SetColor( hitColor);
    }

    public void Spawner()
    {
        for (int i = 0; i < wallSpawnCount; i++)
        {
            GameObject walls=null;
            float rand = Random.value;
            if (rand >= 0f && !colorBump)
            {
                Debug.Log("random.value==" + rand);
                colorBump = true;
                 walls = Instantiate(Resources.Load("ColorBump") as GameObject, transform.position, Quaternion.identity);
            }
            else
            {
                walls = Instantiate(Resources.Load("WallGen") as GameObject, transform.position, Quaternion.identity);
            }
           
            Transform parent = GameObject.Find("Helix").GetComponent<Transform>();
            walls.transform.SetParent(parent);
            walls.transform.localPosition = new Vector3(0, 0, z);
            float randomRotation = Random.Range(0, 360);
            walls.transform.localRotation = Quaternion.EulerAngles(new Vector3(0, 0, randomRotation));
           
            z += 25;

            if (i==wallSpawnCount-1)
            {
                Debug.Log(" finish line palce called");
                finishLine.transform.localPosition = new Vector3(0, 0.03f, z);
            }
        }
    }

}
