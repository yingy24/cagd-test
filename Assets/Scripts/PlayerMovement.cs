using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    /*
     * TO DO:
     * Movement
     *      Should use the CharacterController which is already attached to this GameObject
     *      Be able to move left and right
     *      Collide with/be stopped by walls
     *      Not move too quickly or slowly
     *          Remember that movement happens every frame
     * Jumping/Falling
     *      Fall to the ground, and not through it
     *      Able to jump
     *      Can reach platforms to the right, but not the one on the left
     *      Only able to jump while standing on the ground
     * Input
     *      Ideally, use the KeyboardInput script which is already attached to this GameObject
     *      A & D for left and right movement
     *      Space for jumping
     * Moving Platform
     *      When standing on the platform, the character should stay on it/move relative to the moving platform
     *      When not standing on the platform, revert to normal behavior
     * Enemy
     *      If the character touches the enemy, he should "die"
     *      
     * 
     * 
     * 
     * Variables you might want:
     *      References to the CharacterController and Keyboard input classes
     *      Speed values for moving, falling, and jumping
     *      A value to keep track of the player's movement speed and direction
     *      You will probably need to use the Update function as well as create functions for moving platforms and enemies
     */
	
	//Jumping


	private int movingRight = 1;
	private int movingLeft = -1;
	private int jumping = 1;
	private float speed = 2f;
	public float fallSpeed = 8.0f;

	void Start() 
	{
	
	}
	
	void Update(){
		
		//transform.Translate (Vector3.down * fallSpeed * Time.deltaTime, Space.World);
		
		if ((Input.GetKey (KeyCode.D))) {
			transform.Translate (new Vector3 (Time.deltaTime * speed * movingRight, 0, 0));
		}
		else if ((Input.GetKey (KeyCode.A))) {
			transform.Translate (new Vector3 (Time.deltaTime * speed * movingLeft, 0, 0));
		}
		else if ((Input.GetKey (KeyCode.Space))) {
			transform.Translate (new Vector3 (0, Time.deltaTime * speed * jumping, 0));
		}

		/*
		void OnCollisionEnter(Collision collision)
		{
			Debug.Log("Hit Something!");
		}
		void OnCollisionStay(Collision collision)
		{
			Debug.Log("Hit Something!");
		}
		void OnCollisionExit(Collision collision)
		{
			Debug.Log("Hit Something!");
		}
*/
		
	}
}