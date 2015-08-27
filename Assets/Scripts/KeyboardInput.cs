using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour {

    public int PlayerNumber = 1;

    private bool jumpButtonPressed;
    public bool JumpButtonPressed {
        get { 
            return jumpButtonPressed; 
        }
    }

    private bool jumpButtonPressedThisFrame;
    public bool JumpButtonPressedThisFrame {
        get {
            return jumpButtonPressedThisFrame;
        }
    }

    private float xAxis;
    public float XAxis {
        get {
            return xAxis;
        }
    }
	
	void Update () {
        if (PlayerNumber == 1){
            if (Input.GetKey(KeyCode.Space)) {
                jumpButtonPressed = true;
            }
            else {
                jumpButtonPressed = false;
            }
            if (Input.GetKeyDown(KeyCode.Space)) {
                jumpButtonPressedThisFrame = true;
            }
            else {
                jumpButtonPressedThisFrame = false;
            }
            xAxis = 0;
            if (Input.GetKey(KeyCode.D)) {
                xAxis += 1;
            }
            if (Input.GetKey(KeyCode.A)) {
                xAxis -= 1;
            }
        }
        else if (PlayerNumber == 2) {
            if (Input.GetKey(KeyCode.UpArrow)) {
                jumpButtonPressed = true;
            }
            else {
                jumpButtonPressed = false;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow)) {
                jumpButtonPressedThisFrame = true;
            }
            else {
                jumpButtonPressedThisFrame = false;
            }
            xAxis = 0;
            if (Input.GetKey(KeyCode.RightArrow)) {
                xAxis += 1;
            }
            if (Input.GetKey(KeyCode.LeftArrow)) {
                xAxis -= 1;
            }
        }
	}
}
