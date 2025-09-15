using UnityEngine;
using System.Collections;
using UnityEditor.Rendering;
using UnityEditor.Build.Content;

public class TrackSignColor : MonoBehaviour
{
    private ColorCubeTest cubeChange;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubeChange = GameObject.Find("ColorCube").GetComponent<ColorCubeTest>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        cubeChange.ChangeCarColor();
        cubeChange.Jump();
    }
}
