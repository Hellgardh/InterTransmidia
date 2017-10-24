using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatPretas : MonoBehaviour
{

    public GameObject plats;
    public Vector3 posIni;
    public Vector3 posEnd;
    public float platSpeed;

    private void OnTriggerStay ( Collider other )
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                plats.transform.position = Vector3.MoveTowards(plats.transform.position, posEnd, platSpeed * Time.deltaTime);
            }

            else
            {
                plats.transform.position = Vector3.MoveTowards(plats.transform.position, posIni, platSpeed * Time.deltaTime);
            }
        }
    }

    private void OnTriggerExit ( Collider other )
    {
        if(other.gameObject.CompareTag("Player"))
        {
            plats.transform.position = Vector3.MoveTowards(plats.transform.position, posIni, platSpeed * Time.deltaTime);
        }
    }
}
