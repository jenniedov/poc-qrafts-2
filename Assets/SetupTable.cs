using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Meta.XR.MRUtilityKit;

public class SetupTable : MonoBehaviour
{
    MRUKAnchor closestAnchor;
    public LabelFilter tableLabelFilter;
    public float distance = 0.0f;

    public bool isSetup = false;

    // Find the nearest table and set the position and rotation of this object to match the table
    void Start()
    {
        if (MRUK.Instance == null)
        {
            Debug.LogError("MRUK.Instance is null. Make sure MRUK is properly initialized.");
            return;
        }
    }

    // Update is called once per frame (currently not used)
    void Update()
    {
        if (!isSetup)
        {
            FindTable();
        }
    }

    void FindTable()
    {
        if (MRUK.Instance == null)
        {
            Debug.LogError("MRUK.Instance is null. Make sure MRUK is properly initialized.");
            return;
        }

        MRUKRoom room = MRUK.Instance.GetCurrentRoom();
        if (room == null)
        {
            Debug.Log("Current room is null. Make sure you're in a valid MRUK environment.");
            return;
        }

        Vector3 closestPosition;
        try
        {
            distance = room.TryGetClosestSurfacePosition(transform.position, out closestPosition, out closestAnchor, tableLabelFilter);
        }
        catch (Exception e)
        {
            Debug.LogError($"Error calling TryGetClosestSurfacePosition: {e.Message}");
            return;
        }
        
        if (distance > 0)
        {
            // Set the position of the object to match the closest surface (table)
            transform.position = closestPosition;

            // Optionally, set the rotation to align with the closest surface's normal or custom logic
            transform.rotation = Quaternion.LookRotation(Vector3.up);
            isSetup = true;
            Debug.Log("Table found and setup.");
        }
        else
        {
            Debug.LogWarning("No closest surface (table) found in the scene.");
        }
    }
}
