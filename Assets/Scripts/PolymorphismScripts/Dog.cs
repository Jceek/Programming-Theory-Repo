using UnityEngine;

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

    // Update is called once per frame
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
    // Method overloading
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
    // Method overriding
    public override void Movement()
    {
        transform.Translate(Vector3.right * dogWalk * Time.deltaTime);
    }
}
