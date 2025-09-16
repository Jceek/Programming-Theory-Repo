using UnityEngine;
using System.Collections;
using UnityEditor.Rendering;
using UnityEditor.Build.Content;
using UnityEngine.UI;
using TMPro;

public class ChangeSpeedSign : MonoBehaviour
{
    public TextMeshPro speedMeter;
    public float carSpeed = -3;
    public CarFullEncapsulated carFullEncapsulated;
    public CarEncapsulated carEncapsulated;
    public CarPublic carPublic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        carPublic = GameObject.Find("CarPublic").GetComponent<CarPublic>();
        carEncapsulated = GameObject.Find("CarEncapsulated").GetComponent<CarEncapsulated>();
        carFullEncapsulated = GameObject.Find("CarFullEncapsulated").GetComponent<CarFullEncapsulated>();
        carSpeed = -3;
        speedMeter.text = carSpeed + " km/h";
    }

    // Update is called once per frame
    void Update()
    {

    }
    // ENCAPSULATION example - here the checkpoint could set the speed of all cars to a specified value.
    // Our encapsulated cars only accept positive integers - thus it won't be affected by the change.
    // the public car will be set to reverse.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CarPublic"))
        {
            carPublic.speed = carSpeed;
        }
        if (other.CompareTag("CarEncapsulated"))
        {
            carEncapsulated.speed = carSpeed;
        }
        if (other.CompareTag("CarFullEncapsulated"))
        {
            carFullEncapsulated.speed = carSpeed;
        }
    }
}
