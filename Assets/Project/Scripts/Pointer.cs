using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            Raycast();
        }
    }

    private void Raycast()
    {
        Debug.Log(">>>>");

        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Debug.Log("----------- " + hit.collider.name);
            MeshRenderer renderer = hit.collider.GetComponent<MeshRenderer>();
            renderer.enabled = !renderer.enabled;
        }
    }
}