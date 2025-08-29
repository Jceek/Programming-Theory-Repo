using UnityEngine;

public class Cat : Animal
{
    public bool isActivated = false;
    private bool isDelayed = false;
    private float firstDelay = 3.5f;
    private float secondDelay = 4.5f;

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
}
