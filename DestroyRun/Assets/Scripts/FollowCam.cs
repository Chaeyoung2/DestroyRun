using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform target;
    private Transform tr;

    public float CameraZ = -5;
    public float CameraSpeed;

    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        Vector3 targetPos = target.position;
        targetPos.y += 15;
        tr.position = Vector3.Lerp(tr.position, targetPos, Time.deltaTime * CameraSpeed);
    }
}
