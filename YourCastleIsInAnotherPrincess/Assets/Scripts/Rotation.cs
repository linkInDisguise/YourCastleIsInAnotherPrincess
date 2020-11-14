using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour
{
    void Awake()
    {

    }

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(0, 0, 500 * Time.deltaTime); //rotates 50 degrees per second around z axis
    }
}