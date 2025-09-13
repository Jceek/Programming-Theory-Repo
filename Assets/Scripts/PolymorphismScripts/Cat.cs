using UnityEngine;
using System;
using System.Collections.Generic;

public class Cat : Animal
{
    private float smallCatJump = 0.66f;
    private float smallCatSpeed = 1.6f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animalBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    protected override void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("River"))
        {
            Jump();
        }
    }
    protected override void OnTriggerExit(Collider other)
    {

    }

    public override void Movement()
    {
        transform.Translate(Vector3.forward * smallCatSpeed * Time.deltaTime);
    }

    public override void Jump()
    {
        animalBody.AddForce(Vector3.up * jumpForce * smallCatJump, ForceMode.Impulse);
        animalBody.AddForce(Vector3.right * jumpForce * smallCatJump, ForceMode.Impulse);
    }
}
