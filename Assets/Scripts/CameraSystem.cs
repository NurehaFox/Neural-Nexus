using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    

    Vector3 moveDir = new Vector3(0,0,0);
    if(Input.GetKey(KeyCode.W)) moveDir.z = +1f;
    }
}
