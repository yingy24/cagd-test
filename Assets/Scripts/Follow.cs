using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

    public Transform playerTransform;

	void Update () {
        transform.position = new Vector3(playerTransform.position.x, transform.position.y, transform.position.z);
	}
}
