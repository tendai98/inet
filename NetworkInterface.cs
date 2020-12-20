using UnityEngine;

public class NetworkInterface : MonoBehaviour {
    
    private float ROTATION_ANGLE = 3;
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(0, ROTATION_ANGLE, 0);
    }
}
