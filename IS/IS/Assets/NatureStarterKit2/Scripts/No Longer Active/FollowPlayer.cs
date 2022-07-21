using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowPlayer : MonoBehaviour
{
    //public Transform player;

    //void Update()
    //{
    //   transform.position = player.transform.position + new Vector3(0, 1, -56);
    //}

    public Vector3 camOffset = new Vector3(0f, 1.2f, -56.4f);
    private Transform target;

    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    void LateUpdate()
    {
        transform.position = target.TransformPoint(camOffset);
        
    }

}
