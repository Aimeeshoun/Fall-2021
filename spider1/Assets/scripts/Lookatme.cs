using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookatme : MonoBehaviour
{

    public Transform theLookObj;

    public void Update()
    {
        transform.LookAt(theLookObj);
        var transformRotation = transform.rotation;
        transformRotation.x = 0;
        transform.rotation = transformRotation;
    }
}