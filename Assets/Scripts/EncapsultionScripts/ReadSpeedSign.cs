using UnityEngine;
using System.Collections;
using UnityEditor.Rendering;
using UnityEditor.Build.Content;
using UnityEngine.UI;
using TMPro;

public class ReadSpeedSign : MonoBehaviour
{
    public TextMeshPro speedMeter;
    public float carSpeed;
    public CarFullEncapsulated carFullEncapsulated;
    public CarEncapsulated carEncapsulated;
    public CarPublic carPublic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        carPublic = GameObject.Find("CarPublic").GetComponent<CarPublic>();
        carEncapsulated = GameObject.Find("CarEncapsulated").GetComponent<CarEncapsulated>();
        carFullEncapsulated = GameObject.Find("CarFullEncapsulated").GetComponent<CarFullEncapsulated>();
    }

    // Update is called once per frame
    void Update()
    {
        speedMeter.text = carSpeed + " km/h";
    }
    // ENCAPSULATION example - Here we read out the public speed value without problems. (Encapsulated Car speed
    // is inside a getter and setter)
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CarPublic"))
        {
            carSpeed = carPublic.speed;
        }
        if (other.CompareTag("CarEncapsulated"))
        {
            carSpeed = carEncapsulated.speed;
        }
        if (other.CompareTag("CarFullEncapsulated"))
        {
            carSpeed = carFullEncapsulated.speed;
        }
        return;
    }
}
