using UnityEngine;
using System;
using System.Collections.Generic;
// POLYMORPHISM + inheritance : we derive from the animal class so we have access to it's methods and variables which we use and change
public class Dog : Animal
{
    private float dogWalk = 0.9f;
    private float dogRotateForce = 20.0f;
    public bool inRiver = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animalBody = GetComponent<Rigidbody>();
    }
    // POLYMORPHISM : Equally using our overriden methods as well as base version from the animal class.
    void Update()
    {
        Movement();
        if (inRiver)
        {
            base.Movement();
            transform.Rotate(-Vector3.right * speed * dogRotateForce * Time.deltaTime, Space.Self);
        }
        else
        {
            Movement();
        }
    }
    // POLYMORPHISM : Method overloading
    protected override void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("River"))
        {
            inRiver = true;
        }
    }
    protected override void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("River"))
        {
            inRiver = false;
        }
    }
    // POLYMORPHISM : Method overriding
    public override void Movement()
    {
        transform.Translate(Vector3.right * dogWalk * Time.deltaTime);
    }
}
