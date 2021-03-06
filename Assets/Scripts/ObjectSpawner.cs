﻿using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform spawnPoint;
    public LayerMask targetLayers;
    public void Spawn()
    {
        Quaternion spawnRot = spawnPoint.rotation;

        Ray dirRay = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if(Physics.Raycast(dirRay, out hit, Mathf.Infinity, targetLayers))
        {
            spawnRot = Quaternion.LookRotation(hit.point - spawnPoint.position);
        }

        Instantiate(objectToSpawn, spawnPoint.position, spawnRot);
    }
}
