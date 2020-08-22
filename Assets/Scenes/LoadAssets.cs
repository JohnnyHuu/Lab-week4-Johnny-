using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoadAssets : MonoBehaviour
{

    // Start is called before the first frame update

    public GameObject RedSphere;
    public GameObject blueSphere;

    [SerializeField]
    void Start()
    {
        Instantiate(RedSphere, new Vector3(2, 0, 0), new Quaternion(0, 0, 0, 0));
        Instantiate(blueSphere, new Vector3(-2, 0, 0), new Quaternion(0, 0, 0, 0));
    }

    // Update is called once per frame
    
    void Update()
    {
        
    }

    [SerializeField]
    public void redObj()
    {
    
    }

    [SerializeField]
    private void blueObj()
    {
   
    }
}

