using System.Runtime.CompilerServices;
using UnityEngine;

public class CarFullEncapsulated : MonoBehaviour
{
    // ENCAPSULATION application : setting certain variables private + a successful application of a getter + setter combo.
    // the speed value can be read by our checkpoints but can only be set in a certain way (only positive speed)
    // this way our car can keep driving
    private Color newCarColor;
    private float m_speed = 1.9f;
    public float speed
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
                m_speed = value;
            }
        }
    }

    private MeshRenderer rendEncapsulated;
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
    // ENCAPSULATION METHODS : private changecolor methods for random
    // a public setcolor method - we could leave it empty
    // + at the end a method just to read out a variable without the ability to set it.
    private void ChangeCarColor()
    {
        randomChannelOne = Random.Range(0f, 1f);
        randomChannelTwo = Random.Range(0f, 1f);
        randomChannelThree = Random.Range(0f, 1f);

        newCarColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);
        rendEncapsulated.material.color = newCarColor;
        return;
    }
    // We don't play around here. No color change through this method !
    public void SetCarColor(Color color)
    {

    }
    // A simple GetCarColor method to just read out the car color, but not be able to change it through this method
    // with the help from Unity AI - this is part of Encapsulation and the AI helped my understanding of the matter a lot
    public Color GetCarColor()
    {
        return rendEncapsulated.material.color;
    }

}
