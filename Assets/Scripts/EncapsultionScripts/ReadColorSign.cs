using UnityEngine;
using System.Collections;
using UnityEditor.Rendering;
using UnityEditor.Build.Content;

public class ReadColorSign : MonoBehaviour
{
    private MeshRenderer meshSign;
    public CarPublic cubeOne;
    public CarEncapsulated cubeTwo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshSign = GetComponent<MeshRenderer>();
        cubeOne = GameObject.Find("ColorCubePublic").GetComponent<CarPublic>();
        cubeTwo = GameObject.Find("ColorCubeEncapsulated").GetComponent<CarEncapsulated>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CarPublic"))
        {
            meshSign.material.color = cubeOne.rendPublic.material.color;
        }
        if (other.CompareTag("CarEncapsulated"))
        {
            meshSign.material.color = CarEncapsulated.rendEncapsulated.material.color;
        }

    }
}
