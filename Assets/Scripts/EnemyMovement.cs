using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    public CharacterController motor;

    private int movingRight = 1;
    private float speed = 3f;
    private float distanceToMove = 8;
    private float distanceMoved = 0;
    private Vector3 oldPosition;

    void Update() {
        oldPosition = transform.position;
        motor.Move(new Vector3(movingRight * speed * Time.deltaTime, 0, 0));
        if (oldPosition == transform.position) {
            movingRight *= -1;
        }

    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            other.SendMessage("KillPlayer", SendMessageOptions.DontRequireReceiver);
        }
    }
}
