using UnityEngine;
using System.Collections;
using UnityEditor.Rendering;
using UnityEditor.Build.Content;

public class ChangeColorSign : MonoBehaviour
{
    private MeshRenderer meshSign;
    public ColorCubeTest cubeChange;
    public EncapsulatedCar carEncapsulated;
    public PublicCar carPublic;
    public Color newSignColor;
    public float randomChannelOne, randomChannelTwo, randomChannelThree;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshSign = GetComponent<MeshRenderer>();
        cubeChange = GameObject.Find("ColorCube").GetComponent<ColorCubeTest>();
        carEncapsulated = GameObject.Find("Encapsulator").GetComponent<EncapsulatedCar>();
        carPublic = GameObject.Find("Publicator").GetComponent<PublicCar>();
        ChangeSignColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            cubeChange.rendPublic.material.color = meshSign.material.color;
        }
        if (other.CompareTag("EncapsulatedCar"))
        {
            carEncapsulated.rendEncapsulated.material.color = meshSign.material.color;
        }
        if (other.CompareTag("PublicCar"))
        {
            carPublic.rendPublic.material.color = meshSign.material.color;
        }

    }
    public void ChangeSignColor()
    {
        randomChannelOne = Random.Range(0f, 1f);
        randomChannelTwo = Random.Range(0f, 1f);
        randomChannelThree = Random.Range(0f, 1f);

        newSignColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);
        meshSign.material.color = newSignColor;
        return;
    }
}
