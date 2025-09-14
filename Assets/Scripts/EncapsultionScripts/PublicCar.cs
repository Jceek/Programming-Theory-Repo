using UnityEngine;

public class PublicCar : MonoBehaviour
{
    public float speed = 2.0f;
    public MeshRenderer rendPublic;
    public Color newCarColor;
    public float randomChannelOne, randomChannelTwo, randomChannelThree;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rendPublic = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeCarColor();
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void ChangeCarColor()
    {
        randomChannelOne = Random.Range(0f, 1f);
        randomChannelTwo = Random.Range(0f, 1f);
        randomChannelThree = Random.Range(0f, 1f);

        newCarColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);
        rendPublic.material.SetColor("_Color", newCarColor);
    }
}
