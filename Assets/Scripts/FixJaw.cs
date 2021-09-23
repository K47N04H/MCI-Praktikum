using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixJaw : MonoBehaviour
{
    private Vector3 startPos;
    private Quaternion startRot;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.localPosition;
        startRot = transform.localRotation;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.localPosition = startPos;
        transform.localRotation = startRot;
    }
}
