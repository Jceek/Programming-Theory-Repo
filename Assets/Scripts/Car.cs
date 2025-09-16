using UnityEngine;

public class Car : MonoBehaviour

{
    public float speed = 7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();          // ABSTRACTION method , reusable
    }
    public void MoveForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}

