using UnityEngine;
using System;
using System.Collections.Generic;
// POLYMORPHISM + inheritance : we derive from the animal class so we have access to it's methods and variables which we use and change
public class Fox : Animal
{
    public bool inRiver = false;
    private float spawnStart = 3.5f;
    private float spawnDelay = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animalBody = GetComponent<Rigidbody>();
        InvokeRepeating("Jump", spawnStart, spawnDelay);
    }
    // Update is called once per frame
    void Update()
    {
        Movement();

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
            CancelInvoke("Jump");
            inRiver = false;
        }
    }
    // POLYMORPHISM : Method overriding
    public override void Movement()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
    public override void Jump()
    {
        animalBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
