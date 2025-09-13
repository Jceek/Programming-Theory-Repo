using UnityEngine;

public class FlowingRiver : MonoBehaviour
{
    private Vector3 startPos;
    private float riverSpeed = 5.0f;
    private float repeatLength;
    public GameObject riverPrefab;
    private float offSet = -0.5f;
    private float scaleFactor = 4.0f; // have to use the scale of the transform to appropriately get the size,
                                      // otherwise it takes the base box collider y size
                                      // for the length of the object which is warped due to scale

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        repeatLength = GetComponent<BoxCollider>().size.y * scaleFactor;
    }

    // Update is called once per frame
    void Update()
    {
        Flow();
        if (transform.position.z < startPos.z - repeatLength - offSet)
        {
            repeatLength += repeatLength;
            Instantiate(riverPrefab, startPos, riverPrefab.transform.rotation);
        }
    }
    public void Flow()
    {
        transform.Translate(-Vector3.up * riverSpeed * Time.deltaTime);
    }
}
