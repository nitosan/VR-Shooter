﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WinMRSnippets;

[RequireComponent(typeof(TrackedController))]
public class ControllerTrackListener : MonoBehaviour
{
    private TrackedController trackedController;

    // Use this for initialization
    void Start()
    {
        trackedController = GetComponent<TrackedController>();

        Debug.Assert(trackedController != null);
    }

    // Update is called once per frame
    void Update()
    {
        var state = trackedController.GetState();


        transform.localPosition = state.GripPosition;
        transform.rotation = state.GripRotation;

    }
}
