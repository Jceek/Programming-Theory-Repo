using UnityEngine;
using System.Collections;
using UnityEditor.Rendering;

public class TrackSignColor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<>().material.color = Color.green;
    }
}
