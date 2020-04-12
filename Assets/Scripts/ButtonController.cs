using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {
    
    private HouseAnimController houseController;

    // Use this for initialization
    void Start () {
        houseController = FindObjectOfType<HouseAnimController>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayAnimation()
    {
        houseController.PlayAnimation();
    }

    public void PauseAnimation()
    {
        houseController.PauseAnimation();
    }
    
    public void NextAnimation()
    {
        houseController.NextAnimation();
    }
}
