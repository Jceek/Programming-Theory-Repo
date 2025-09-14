using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class EncapsulatedCar : MonoBehaviour
{
    [SerializeField] private float speed = 2.0f;
    protected static Renderer rendEncapsulated { get;  set; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rendEncapsulated = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColor();
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void ChangeColor()
    {
        rendEncapsulated.material.SetColor("_Color", Color.blue);
    }
}
