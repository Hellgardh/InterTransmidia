using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaPulo : MonoBehaviour
{

    public GameObject targetPlatform;
    public Vector3 targetPlatPos;
    private Vector3 targetPlatIni;

    public Vector3 currentPlatPos;
    private Vector3 currentPlatIni;

    public float targetPlatSpeed;
    public float currentPlatSpeed;

    [SerializeField]
    private bool onPlat;

    private void Start ()
    {
        targetPlatIni = targetPlatform.transform.position;
        currentPlatIni = transform.position;
        onPlat = false;
    }

    private void Update ()
    {
        if(onPlat)
        {
            targetPlatform.transform.position = Vector3.MoveTowards(targetPlatform.transform.position, targetPlatPos, targetPlatSpeed);
            transform.position = Vector3.MoveTowards(transform.position, currentPlatPos, currentPlatSpeed);
        }

        else
        {
            targetPlatform.transform.position = Vector3.MoveTowards(targetPlatform.transform.position, targetPlatIni, targetPlatSpeed);
            transform.position = Vector3.MoveTowards(transform.position, currentPlatIni, currentPlatSpeed);
        }
    }

    private void OnCollisionEnter ( Collision other )
    {
        if(other.gameObject.CompareTag("Player"))
        {
            onPlat = true;
            Debug.Log("Colidiu");
        }

        Debug.Log("Occoreu colisão");
    }

    private void OnCollisionExit ( Collision other )
    {
        if(other.gameObject.CompareTag("Player"))
        {
            onPlat = false;
            Debug.Log("Saiu");
        }
    }

}
