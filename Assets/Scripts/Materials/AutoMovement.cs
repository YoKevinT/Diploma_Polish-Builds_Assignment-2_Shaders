using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovement : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 newPosition;

    [SerializeField] private int speed = 3;
    [SerializeField] private int maxDistance = 1;

    void Start()
    {
        startPosition = transform.position;
        newPosition = transform.position;
    }

    void Update()
    {
        // X
        newPosition.z = startPosition.z + (maxDistance * Mathf.Sin(Time.time * speed));
        transform.position = newPosition;
    }
}