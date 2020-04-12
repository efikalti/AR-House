using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class HouseController : MonoBehaviour, ITrackableEventHandler
{
    public GameObject house;
    private TrackableBehaviour mTrackableBehaviour;

    // Use this for initialization
    void Start () {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTrackableStateChanged(
                                TrackableBehaviour.Status previousStatus,
                                TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Show house when image is detected
            house.SetActive(true);
            
        }
        else
        {
            // Hide house when image is not detected
            house.GetComponent<HouseAnimController>().resetAnimations();
            house.SetActive(false);
        }
    }
}