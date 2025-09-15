using System.Runtime.CompilerServices;
using UnityEngine;

public class CarEncapsulated : MonoBehaviour
{
    
    public static Color newCarColor {  get; private set; } 
    private int m_speed = 2;
    public int speed
    {
        get { return m_speed; }
        set
        {
            if (value < 0)
            {
                Debug.LogError("You can't set a negative speed for the Encapsulated Car!");
            }
            else
            {
                m_speed = value; // original setter now in if/else statement
            }
        }
    }

    public static MeshRenderer rendEncapsulated {  get; private set; }
    public float jumpForce = 150.0f;
    private Rigidbody cubeRb;
    public float randomChannelOne, randomChannelTwo, randomChannelThree;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubeRb = GetComponent<Rigidbody>();
        rendEncapsulated = GetComponent<MeshRenderer>();
        ChangeCarColor();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * m_speed * Time.deltaTime);
    }
    private void ChangeCarColor()
{
        randomChannelOne = Random.Range(0f, 1f);
        randomChannelTwo = Random.Range(0f, 1f);
        randomChannelThree = Random.Range(0f, 1f);

        newCarColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);
        rendEncapsulated.material.color = newCarColor;
        return;
    }
}
