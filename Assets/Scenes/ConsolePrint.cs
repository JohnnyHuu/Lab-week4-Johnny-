using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    // Start is called before the first frame update
    int result = 0;
    public GameObject RedSphere;
    public GameObject blueSphere;
    public GameObject GameObject;
    // Start is called before the first frame update
    public void Start()
    {
        Update();
       


    }


    //
    public void Update()
    {
        
        for (int i = 0; i < 133; i++)
        {
            int result;
            result = i;
           
                Debug.Log("RedSphere :" + result);
            Debug.Log("blueSphere :" + result);



        }



    }
}