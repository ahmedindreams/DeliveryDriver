using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    [SerializeField] GameObject TargetToFollow;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = TargetToFollow.transform.position+ new Vector3(0,0,-10);
        
    }
}
