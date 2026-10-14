using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;

    public GameObject propeller;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        transform.Rotate(Vector3.right * turnSpeed * verticalInput * Time.deltaTime);

        if (propeller !=null)
        {
            propeller.transform.Rotate(Vector3.forward * 1000 * Time.deltaTime, Space.Self);
        }
    }
}
