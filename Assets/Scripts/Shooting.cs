using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Camera mainCam;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectsWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
