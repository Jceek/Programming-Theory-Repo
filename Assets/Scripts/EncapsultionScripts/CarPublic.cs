using UnityEngine;
// ENCAPSULATION : everything in this script is open for access
public class CarPublic : MonoBehaviour
{
    public Color newCarColor;
    public float speed = 2.1f;
    public MeshRenderer rendPublic;
    public Rigidbody cubeRb;
    public float randomChannelOne, randomChannelTwo, randomChannelThree;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubeRb = GetComponent<Rigidbody>();
        rendPublic = GetComponent<MeshRenderer>();
        ChangeCarColor();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void ChangeCarColor()
    {
        randomChannelOne = Random.Range(0f, 1f);
        randomChannelTwo = Random.Range(0f, 1f);
        randomChannelThree = Random.Range(0f, 1f);

        newCarColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);
        rendPublic.material.color = newCarColor;
        return;
    }
}
