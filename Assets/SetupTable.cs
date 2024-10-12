using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Meta.XR.MRUtilityKit;

public class SetupTable : MonoBehaviour
{
    MRUKAnchor closestAnchor;
    public LabelFilter tableLabelFilter;  // Changed type and default value
    public float distance = 0.0f;
    // Find the nearest table and set the position and rotation of this object to match the table
    void Start()
    {
        // Get the current room
        MRUKRoom room = MRUK.Instance.GetCurrentRoom();

        Vector3 closestPosition;
        distance = room.TryGetClosestSurfacePosition(transform.position, out closestPosition, out closestAnchor, tableLabelFilter);
        
        if (distance > 0)
        {
            // Set the position of the object to match the closest surface (table)
            transform.position = closestPosition;

            // Optionally, set the rotation to align with the closest surface's normal or custom logic
            transform.rotation = Quaternion.LookRotation(Vector3.up);
        }
        else
        {
            Debug.LogWarning("No closest surface (table) found in the scene.");
        }
    }

    // Update is called once per frame (currently not used)
    void Update()
    {
    }
}
