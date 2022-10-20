using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public float RotationSpeed = 35f;

    void Update()
    {
        transform.Rotate(new Vector3(0, RotationSpeed, 0) * Time.deltaTime); //вращение объектов
    }
}
