using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{

    public Transform mount;
    [SerializeField] private float fov;

    private Camera cam;
    private CameraFollow camFollow;

    public Vector3 offsetPos;
    public Vector3 offsetRotation;

    void Start ()
    {
        cam = Camera.main;
        camFollow = cam.gameObject.GetComponent<CameraFollow>();
	}
	
	void Update ()
    {
		
	}

    private void OnTriggerEnter ( Collider other )
    {
        cam.fieldOfView = fov;
        camFollow.offsetPos = offsetPos;
        camFollow.offsetRotation = offsetRotation;
    }
}
