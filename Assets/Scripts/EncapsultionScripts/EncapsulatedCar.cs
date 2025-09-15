using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class EncapsulatedCar : MonoBehaviour
{
    [SerializeField] private float speed = 2.0f;
    public MeshRenderer rendEncapsulated;
    private Rigidbody carRb;
    public Color newCarColor;
    public float randomChannelOne, randomChannelTwo, randomChannelThree;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rendEncapsulated = GetComponent<MeshRenderer>();
        carRb = GetComponent<Rigidbody>();
        ChangeCarColor();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void ChangeCarColor()
    {
        randomChannelOne = Random.Range(0f, 1f);
        randomChannelTwo = Random.Range(0f, 1f);
        randomChannelThree = Random.Range(0f, 1f);

        newCarColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);
        rendEncapsulated.material.color = newCarColor;
        return;
    }
}
