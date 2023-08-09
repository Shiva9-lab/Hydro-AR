using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class ARPlacement : MonoBehaviour
{
    ARRaycastManager arRaycastManager;
    GameObject ObjToInstantiate;
    GameObject SpawnedObject;
    Vector2 touchPosition;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();


    private void Awake()
    {
        arRaycastManager = GetComponent<ARRaycastManager>();
    }

    bool GetTouchPosition(out Vector2 touchPosition)
    {
        if(Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }

        touchPosition = default;
        return false;
    }

    void Update()
    {
        if(!GetTouchPosition(out Vector2 touchPosition))
        {
            return;
        }

        if(arRaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
        {
            var hitPose = hits[0].pose;
            
            if(SpawnedObject == null)
            {
                SpawnedObject = Instantiate(ObjToInstantiate, hitPose.position, hitPose.rotation);
            }
           

        }

    }
}
