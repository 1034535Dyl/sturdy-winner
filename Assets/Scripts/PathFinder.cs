using System;
using UnityEngine;
using UnityEngine.AI;

public class PathFinder : MonoBehaviour
{
    public Transform targetTransform;
    public NavMeshPath Path;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Path = new NavMeshPath();
    }

    // Update is called once per frame
    void Update()
    {
        if (targetTransform == null)
        {
            return;
        }

        if (Path == null)
        {
            Path = new NavMeshPath();
        }

        NavMesh.CalculatePath(transform.position, targetTransform.position, NavMesh.AllAreas, Path);
    }

    private void OnDrawGizmos()
    {
        if (Path == null || Path.corners == null || Path.corners.Length == 0)
        {
            return;
        }

        Vector3 lastPos = Vector3.zero;
        for (var index = 0; index < Path.corners.Length; index++)
        {
            var pathCorner = Path.corners[index];

            if (index != 0)
            {
                Gizmos.DrawLine(lastPos, pathCorner);
            }
            lastPos = pathCorner;
        }
    }
}
