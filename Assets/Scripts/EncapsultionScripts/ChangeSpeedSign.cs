using UnityEngine;
using System.Collections;
using UnityEditor.Rendering;
using UnityEditor.Build.Content;
using UnityEngine.UI;
using TMPro;

public class ChangeSpeedSign : MonoBehaviour
{
    public TextMeshPro speedMeter;
    public int carSpeed = -3;
    public CarEncapsulated carEncapsulated;
    public CarPublic carPublic;
    private int carMinSpeed = 1;
    private int carMaxSpeed = 15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        carPublic = GameObject.Find("ColorCubePublic").GetComponent<CarPublic>();
        carEncapsulated = GameObject.Find("ColorCubeEncapsulated").GetComponent<CarEncapsulated>();
        carSpeed = -3;
    }

    // Update is called once per frame
    void Update()
    {
        speedMeter.text = carSpeed + " km/h";
    }
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
    }
}
