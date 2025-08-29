using UnityEngine;

public class Animal : MonoBehaviour
{
    public Rigidbody animalBody;
    public float speed = 2f;
    public float speedForce = 2.5f;
    public float jumpForce = 115.0f;
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
    public void Movement()
    {
        animalBody.AddForce(Vector3.forward * speed * speedForce, ForceMode.Acceleration);
    }
    public void Jump()
    {
        animalBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
