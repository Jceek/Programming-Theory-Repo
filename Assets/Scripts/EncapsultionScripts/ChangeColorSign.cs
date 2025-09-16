using UnityEngine;
using System.Collections;
using UnityEditor.Rendering;
using UnityEditor.Build.Content;

public class ChangeColorSign : MonoBehaviour
{
    private MeshRenderer meshSign;
    public CarFullEncapsulated carFullEncapsulated;
    public CarEncapsulated carEncapsulated;
    public CarPublic carPublic;
    public Color newSignColor;
    public float randomChannelOne, randomChannelTwo, randomChannelThree;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshSign = GetComponent<MeshRenderer>();
        carFullEncapsulated = GameObject.Find("CarFullEncapsulated").GetComponent<CarFullEncapsulated>();
        carEncapsulated = GameObject.Find("CarEncapsulated").GetComponent<CarEncapsulated>();
        carPublic = GameObject.Find("CarPublic").GetComponent<CarPublic>();
        ChangeSignColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // ENCAPSULATION example - while this is not perfect, a different approach to reading a variable is a way to provide safety.
    // we can only make certain methods readable from outside, while other methods change behaviour inside a class.
    // Here we change a color either through the meshrenderer directly, or add a layer with a method.
    // I know that an external script could still access some mesh renderer properties of the encapsulated car.
    // I don't have enough knowledge right now to protect non-number variables (with speed it was doable) - but having
    // different methods for different actions is a good compromise.
    // If we leave the SetCarcolor method empty in the original script, this would work and not change it's color.
    // like with the CarFullEncapsulated
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CarPublic"))
        {
            carPublic.rendPublic.material.color = meshSign.material.color;
        }
        if (other.CompareTag("CarEncapsulated"))
        {
            // Use the encapsulated method to set the color - with help from Unity AI
            carEncapsulated.SetCarColor(meshSign.material.color);
        }
        if (other.CompareTag("CarFullEncapsulated"))
        {
            carFullEncapsulated.SetCarColor(meshSign.material.color);
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
