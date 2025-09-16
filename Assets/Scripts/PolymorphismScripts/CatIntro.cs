using UnityEngine;
using System;
using System.Collections.Generic;
// POLYMORPHISM + inheritance : for our intro cat we derive from the cat class which derives from the animal class 
public class CatIntro : Cat
{
    public bool isActivated = false;
    private bool isDelayed = false;
    private float firstDelay = 3.5f;
    private float secondDelay = 4.5f;
    private float fatCat = 1.5f;


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animalBody = GetComponent<Rigidbody>();
        Invoke("ActivateMethod", firstDelay);
        Invoke("Jump", secondDelay);
        Invoke("RotateBody", secondDelay);
        Invoke("Jump", secondDelay + 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (isActivated)
        {
            Movement();
        }

    }
    private void ActivateMethod()
    {
        isActivated = true;
    }

    private void RotateBody()
    {
        animalBody.rotation = Quaternion.Euler(0f, 45f, 0f);
    }
    // POLYMORPHISM : Method overriding
    public override void Movement()
    {
        animalBody.AddForce(Vector3.forward * speed * fatCat, ForceMode.Acceleration);
    }
    public override void Jump()
    {
        animalBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
