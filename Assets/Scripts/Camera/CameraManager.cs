using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    float moveSpeed = 50f;
    float rotateDir = 0f;
    float rotateSpeed = 100f;

    int edgeScrollSize = 20;
    // Update is called once per frame
    void Update()
    {

    Vector3 moveDir = new Vector3(0,0,0);

    if(Input.GetKey(KeyCode.W)) moveDir.z = +1f;
    if(Input.GetKey(KeyCode.S)) moveDir.z = -1f;
    if(Input.GetKey(KeyCode.A)) moveDir.x = -1f;
    if(Input.GetKey(KeyCode.D)) moveDir.x = +1f;


    
    transform.position += moveDir * moveSpeed * Time.deltaTime;
    

    }
}
