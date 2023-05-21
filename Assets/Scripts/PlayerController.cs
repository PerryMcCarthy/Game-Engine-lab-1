using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float steerSpeed = 20;
    public float jumpspeed = 20;
    public float shiftMult = 2;

    private float realSpeed;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello world");
    }

    // Update is called once per frame
    void Update()
    {
        float steertValue = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float gasValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float jumpValue = Input.GetAxis("Jump") * jumpspeed * Time.deltaTime;


        Vector3 positionChange = Vector3.forward * gasValue;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            steertValue *= shiftMult;
            positionChange *= shiftMult;
        }

        transform.Translate(Vector3.up * jumpValue);
        transform.Rotate(Vector3.up, steertValue);
        transform.Translate(positionChange);

    }
}
