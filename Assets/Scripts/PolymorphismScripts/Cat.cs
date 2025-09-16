using UnityEngine;
using System;
using System.Collections.Generic;
// POLYMORPHISM + inheritance : we derive from the animal class so we have access to it's methods and variables which we use and change
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
    // Method Overloading
    protected override void OnTriggerEnter(Collider other)      // POLYMORPHISM : Overloading the abstract method of colliders triggering 
    {                                                           // each other and doing an animal specific action
        if (other.CompareTag("River"))
        {
            Jump();
        }
    }
    protected override void OnTriggerExit(Collider other)
    {

    }
    // POLYMORPHISM : Method overriding
    public override void Movement()                             // Overriding the movement method and using it for an animal specific action
                                                                // We can still use the base.Movement() method
                                                                // to use the original method from the class we inherit from
    {
        transform.Translate(Vector3.forward * smallCatSpeed * Time.deltaTime);
    }

    public override void Jump()                                 // Same overriding of the jump method
    {
        animalBody.AddForce(Vector3.up * jumpForce * smallCatJump, ForceMode.Impulse);
        animalBody.AddForce(Vector3.right * jumpForce * smallCatJump, ForceMode.Impulse);
    }
}
