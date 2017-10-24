using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraPos : MonoBehaviour
{

    private Camera cam;

    public Vector3 position;
    public Vector3 rotation;

    [SerializeField] private bool smooth;
    [SerializeField] private float smoothSpeed;

    private bool canChange;

    void Start ()
    {
        cam = Camera.main.GetComponent<Camera>();
    }

    private void OnEnable ()
    {
        canChange = false;
    }

    void LateUpdate ()
    {
        if(canChange)
        {
            if (smooth)
            {
                cam.transform.position = Vector3.Lerp(cam.transform.position, position, smoothSpeed);
                cam.transform.rotation = Quaternion.Euler(Vector3.Lerp(cam.transform.rotation.eulerAngles, rotation, smoothSpeed));
            }

            else
            {
                cam.transform.position = position;
                cam.transform.rotation = Quaternion.Euler(rotation);
            }

            if(cam.transform.position == position && cam.transform.rotation == Quaternion.Euler(rotation))
            {
                this.gameObject.SetActive(false);
            }
        }
	}

    private void OnTriggerEnter ( Collider other )
    {
        canChange = true;
    }
}
