using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;

    private static Color CurrentColor;
    public MeshRenderer meshRenderer;
   
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
       
    }


    public void UpdateColor()
    {
        meshRenderer.sharedMaterial.color = CurrentColor;

           
    }
    // Update is called once per frame
    void Update()
    {
        UpdateColor();

        // playerSpeed +=2 * Time.deltaTime;

        transform.Translate(new Vector3(0, 0, playerSpeed));
        if (playerSpeed>6)
        {
            playerSpeed = 6;
        }
    }



    //  Color Getters and Setetrs........

    public static Color GetColor()
    {
        return CurrentColor;
    }

    public static void SetColor(Color color)
    {
        CurrentColor = color;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Hit")
        {
           // Debug.Log("We crossed the right one");
        }
        if (other.gameObject.tag == "Fail")
        {
            GameController.instance.GenerateLevels();
            Vector3 temp = this.transform.position;
            temp.z = 0;
            transform.position = temp;
            // StartCoroutine(PlayerDead());
            Debug.Log("Level is genearted ");
        }
    }



    //IEnumerator PlayerDead()
    //{
    //   // GameController.instance.GenerateLevels();
       
    //    //yield break;
    //}

}
