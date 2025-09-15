using UnityEngine;
using System.Collections;
using UnityEditor.Rendering;
using UnityEditor.Build.Content;

public class ChangeColorSign : MonoBehaviour
{
    private MeshRenderer meshSign;
    public CarEncapsulated carEncapsulated;
    public CarPublic carPublic;
    public Color newSignColor;
    public float randomChannelOne, randomChannelTwo, randomChannelThree;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshSign = GetComponent<MeshRenderer>();
        carEncapsulated = GameObject.Find("ColorCubeEncapsulated").GetComponent<CarEncapsulated>();
        carPublic = GameObject.Find("ColorCubePublic").GetComponent<CarPublic>();
        ChangeSignColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CarPublic"))
        {
            carPublic.rendPublic.material.color = meshSign.material.color;
        }
        if (other.CompareTag("CarEncapsulated"))
        {
            CarEncapsulated.rendEncapsulated.material.color = meshSign.material.color;
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
