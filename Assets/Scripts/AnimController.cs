using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour {

    private HouseAnimController houseController;
    private Animator animator;

	// Use this for initialization
	void Start () {
        houseController = GetComponentInParent<HouseAnimController>();
        animator = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void signalFinishedAnimation()
    {
        houseController.animationFinished(transform.name);
    }
}
