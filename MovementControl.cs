using UnityEngine;

public class MovementControl : MonoBehaviour {

    private float rotationSpeed = 10;
    private float speed = 10;

    void turningControls()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }

    }

    void elevationControls()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * Time.deltaTime * speed;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.up * Time.deltaTime * speed;
        }
    }

    private void mainControls()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= transform.forward * Time.deltaTime * speed;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        
    }


    private void FixedUpdate()
    {
        mainControls();
        turningControls();
        elevationControls();
    }

}