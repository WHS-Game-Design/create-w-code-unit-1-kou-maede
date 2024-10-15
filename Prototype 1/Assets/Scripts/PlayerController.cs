using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Don't make variables up here.

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 input;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputZ = Input.GetAxis("Vertical");
        float inputX = Input.GetAxis("Horizontal");
        Debug.Log(inputZ);

        transform.Translate(Vector3.forward * Time.deltaTime * inputZ * speed * 2);
        transform.Rotate(Vector3.up * Time.deltaTime * inputX * inputZ * speed * 10);
    }
}
