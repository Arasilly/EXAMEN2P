using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CannonController : MonoBehaviour
{

    public float rotationSpeed = 1;

    public float BlastPower = 5;

    public GameObject Bala;

    public Transform PuntoDeDisparo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        float HorizontalRotation = Input.GetAxis("Horizontal");
        float VerticalRotation = Input.GetAxis("Vertical");

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, HorizontalRotation * rotationSpeed, VerticalRotation * rotationSpeed));


        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject CreatedBala = Instantiate(Bala, PuntoDeDisparo.position, PuntoDeDisparo.rotation);
            CreatedBala.GetComponent<Rigidbody>().linearVelocity = PuntoDeDisparo.up * BlastPower;
        }
    }
}
