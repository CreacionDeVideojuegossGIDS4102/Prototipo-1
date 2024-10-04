using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuevaPerrona : MonoBehaviour
{
    public float velocidad = 40;
    float inputY;
    float inputX;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputY = Input.GetAxis("Vertical");
        inputX = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * Time.deltaTime * 30 * inputX);
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * inputY);
    }
}
