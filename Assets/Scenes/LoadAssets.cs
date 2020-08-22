using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LoadAssets : MonoBehaviour
{
    [SerializeField] public GameObject LoadManager;
    [SerializeField] public GameObject RedSphere;
    [SerializeField] public GameObject blueSphere;

    // Start is called before the first frame update



    
    void Start()
    {
        GameObject.Find("LoadManager");
       Instantiate(RedSphere, new Vector3(2, 0, 0), new Quaternion(0, 0, 0, 0));
       Instantiate(blueSphere, new Vector3(-2, 0, 0), new Quaternion(0, 0, 0, 0));

    }

    // Update is called once per frame
    
    void Update()
    {
        
    }
    
    
    public void redObj()
    {
     
    }


    private void blueObj()
    {

    }
}

