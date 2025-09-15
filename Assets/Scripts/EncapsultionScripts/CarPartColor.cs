using UnityEngine;

public class CarPartColor : MonoBehaviour
{
    private MeshRenderer carPartColor;
    public EncapsulatedCar carEncapsulated;
    public PublicCar carPublic;
    public Color partColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        carPartColor = GetComponent<MeshRenderer>();
        carEncapsulated = GameObject.Find("Encapsulator").GetComponent<EncapsulatedCar>();
        carPublic = GameObject.Find("Publicator").GetComponent<PublicCar>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EncapsulatedCar"))
        {
            carPartColor.material.color = carEncapsulated.rendEncapsulated.material.color;
        }
        if (other.CompareTag("PublicCar"))
        {
            carPartColor.material.color = carPublic.rendPublic.material.color;
        }
    }
}
