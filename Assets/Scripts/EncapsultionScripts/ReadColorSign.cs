using UnityEngine;
using System.Collections;
using UnityEditor.Rendering;
using UnityEditor.Build.Content;

public class ReadColorSign : MonoBehaviour
{
    private MeshRenderer meshSign;
    public ColorCubeTest cubeChange;
    public EncapsulatedCar carEncapsulated;
    public PublicCar carPublic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshSign = GetComponent<MeshRenderer>();
        cubeChange = GameObject.Find("ColorCube").GetComponent<ColorCubeTest>();
        carEncapsulated = GameObject.Find("Encapsulator").GetComponent<EncapsulatedCar>();
        carPublic = GameObject.Find("Publicator").GetComponent<PublicCar>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            meshSign.material.color = cubeChange.rendPublic.material.color;
        }
        if (other.CompareTag("EncapsulatedCar"))
        {
            meshSign.material.color = carEncapsulated.rendEncapsulated.material.color;
        }
        if (other.CompareTag("PublicCar"))
        {
            meshSign.material.color = carPublic.rendPublic.material.color;
        }

    }
}
