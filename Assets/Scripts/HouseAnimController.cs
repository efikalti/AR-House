using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseAnimController : MonoBehaviour {

    // Animators
    public Animator floorAnimator;
    public Animator columnAnimator;
    public Animator wallsAnimator;
    public Animator topFloorAnimator;
    public Animator topHouseFloorAnimator;
    public Animator topHouseAnimator;
    public Animator railingsAnimator;
    public Animator topRoofAnimator;
    public Animator topWindowsAnimator;
    public Animator roofColumnAnimator;
    public Animator lowerRoofAnimator;

    //Buttons
    public Button playButton;
    public Button pauseButton;
    public Button nextButton;

    private Animator houseAnimator;
    private bool autoPlay;
    private int animationTurn;

    // Use this for initialization
    void Start () {
        houseAnimator = GetComponent<Animator>();
        animationTurn = 0;
        nextButton.interactable = false;
        pauseButton.interactable = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayAnimation()
    {
        // Start Animation
        autoPlay = true;
        UpdateButtons();
        playAnimation();
    }

    public void PauseAnimation()
    {
        // Start Animation
        autoPlay = false;
        UpdateButtons();
    }

    public void NextAnimation()
    {
        // Start Animation
        playAnimation();
    }

    private void UpdateButtons()
    {
        playButton.interactable = !autoPlay;
        pauseButton.interactable = autoPlay;
        nextButton.interactable = !autoPlay;
    }

    public void animationFinished(string componentName)
    {
        if (autoPlay)
        {
            animationTurn++;
            switch (componentName)
            {
                case "Floor":
                    // Floor animation is finished, start animation for Columns
                    columnAnimator.SetBool("showColumns", true);
                    break;
                case "Columns":
                    // Columns animation is finished, start animation for Walls
                    wallsAnimator.SetBool("showWalls", true);
                    break;
                case "Walls":
                    // Walls animation is finished, start animation for Top Floor
                    topFloorAnimator.SetBool("showTopFloor", true);
                    break;
                case "Top Floor":
                    // Top Floor animation is finished, start animation for Top House Floor
                    topHouseFloorAnimator.SetBool("showTopHouseFloor", true);
                    break;
                case "Top House Floor":
                    // Top House Floor animation is finished, start animation for Top House
                    topHouseAnimator.SetBool("showHouse", true);
                    break;
                case "Top House":
                    // Top House animation is finished, start animation for Railings
                    railingsAnimator.SetBool("showRailings", true);
                    break;
                case "Railings":
                    // Railings animation is finished, start animation for Top Roof
                    topRoofAnimator.SetBool("showTopRoof", true);
                    break;
                case "Top Roof":
                    // Top Roof animation is finished, start animation for Top Windows
                    topWindowsAnimator.SetBool("showWindows", true);
                    break;
                case "Top Windows":
                    //  Top Windows animation is finished, start animation for Roof Columns
                    roofColumnAnimator.SetBool("showRoofColumns", true);
                    break;
                case "Roof Columns":
                    //  Roof Columns animation is finished, start animation for Lower Roof
                    lowerRoofAnimator.SetBool("showLowerRoof", true);
                    break;
                case "Lower Roof":
                    //  Lower Roof animation is finished, start animation for House Items
                    houseAnimator.SetBool("showItems", true);
                    animationTurn = 0;
                    break;
                default:
                    break;
            }
        }
    }

    public void playAnimation()
    {
        animationTurn++;

        switch (animationTurn)
        {
            case 1:
                // Start Floor animation
                floorAnimator.SetBool("showFloor", true);
                break;
            case 2:
                // Floor animation is finished, start animation for Columns
                columnAnimator.SetBool("showColumns", true);
                break;
            case 3:
                // Columns animation is finished, start animation for Walls
                wallsAnimator.SetBool("showWalls", true);
                break;
            case 4:
                // Walls animation is finished, start animation for Top Floor
                topFloorAnimator.SetBool("showTopFloor", true);
                break;
            case 5:
                // Top Floor animation is finished, start animation for Top House Floor
                topHouseFloorAnimator.SetBool("showTopHouseFloor", true);
                break;
            case 6:
                // Top House Floor animation is finished, start animation for Top House
                topHouseAnimator.SetBool("showHouse", true);
                break;
            case 7:
                // Top House animation is finished, start animation for Railings
                railingsAnimator.SetBool("showRailings", true);
                break;
            case 8:
                // Railings animation is finished, start animation for Top Roof
                topRoofAnimator.SetBool("showTopRoof", true);
                break;
            case 9:
                // Top Roof animation is finished, start animation for Top Windows
                topWindowsAnimator.SetBool("showWindows", true);
                break;
            case 10:
                //  Top Windows animation is finished, start animation for Roof Columns
                roofColumnAnimator.SetBool("showRoofColumns", true);
                break;
            case 11:
                //  Roof Columns animation is finished, start animation for Lower Roof
                lowerRoofAnimator.SetBool("showLowerRoof", true);
                break;
            case 12:
                //  Lower Roof animation is finished, start animation for House Items
                houseAnimator.SetBool("showItems", true);
                break;
            default:
                break;
        }


    }

    public void resetAnimations()
    {
        UpdateButtons();
        animationTurn = 0;
        nextButton.interactable = false;
        pauseButton.interactable = false;
        playButton.interactable = true;
    }

}
