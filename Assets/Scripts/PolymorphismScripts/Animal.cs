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

    public virtual void Movement()
    {
        animalBody.AddForce(Vector3.right * speed * Time.deltaTime, ForceMode.Acceleration);
    }

    public virtual void Jump()
    {
        animalBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    protected abstract void OnTriggerEnter(Collider other);
    protected abstract void OnTriggerExit(Collider other);

}
