using UnityEngine;

public class DataCenterConnector : MonoBehaviour {

    private float ROTATION_ANGLE = 3;
	
	void FixedUpdate () {
        transform.Rotate(0, ROTATION_ANGLE, 0);
	}
}
