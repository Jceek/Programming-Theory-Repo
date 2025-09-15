using UnityEngine;
using System.Collections;
using UnityEditor.Rendering;
using UnityEditor.Build.Content;

public class ReadColorSign : MonoBehaviour
{
    private MeshRenderer meshSign;
    public CarPublic carPublic;
    public CarEncapsulated carEncapsulated;
    public CarFullEncapsulated carFullEncapsulated;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshSign = GetComponent<MeshRenderer>();
        carPublic = GameObject.Find("CarPublic").GetComponent<CarPublic>();
        carEncapsulated = GameObject.Find("CarEncapsulated").GetComponent<CarEncapsulated>();
        carFullEncapsulated = GameObject.Find("CarFullEncapsulated").GetComponent<CarFullEncapsulated>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ENCAPSULATION example - while this is not perfect, a different approach to reading a variable is a way to provide safety.
    // we can only make certain methods readable from outside, while other methods change behaviour inside a class.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CarPublic"))
        {
            meshSign.material.color = carPublic.rendPublic.material.color;
        }

        if (other.CompareTag("CarEncapsulated"))
        {
            meshSign.material.color = carEncapsulated.GetCarColor();
        }

        if (other.CompareTag("CarFullEncapsulated"))
        {
            meshSign.material.color = carFullEncapsulated.GetCarColor();
        }

    }
}
