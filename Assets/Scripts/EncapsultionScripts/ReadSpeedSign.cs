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
    public CarEncapsulated carEncapsulated;
    public CarPublic carPublic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        carPublic = GameObject.Find("ColorCubePublic").GetComponent<CarPublic>();
        carEncapsulated = GameObject.Find("ColorCubeEncapsulated").GetComponent<CarEncapsulated>();
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
            carSpeed = carPublic.speed;
        }
        if (other.CompareTag("CarEncapsulated"))
        {
            carSpeed = carEncapsulated.speed;
        }
        return;
    }
}
