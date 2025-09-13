using UnityEngine;
using System;
using System.Collections.Generic;
using System.Collections;

public abstract class Animal : MonoBehaviour
{
    public Rigidbody animalBody;
    public float speed = 24f;
    public float jumpForce = 115.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animalBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    // Method Overriding
    public virtual void Movement()      // setting method to virtual -> it can later be overridden to be modified
    {
        animalBody.AddForce(Vector3.right * speed * Time.deltaTime, ForceMode.Acceleration);
    }

    public virtual void Jump()          // setting method to virtual -> it can later be overridden to be modified
    {
        animalBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
    // Method Overloading 
    protected abstract void OnTriggerEnter(Collider other);     // Setting a method to an abstract state - not defining any action - children inheriting from
    protected abstract void OnTriggerExit(Collider other);      // this class will need to use that method - and each one will use it in a specific manner


}
