using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotate : MonoBehaviour
{
    [SerializeField] float _rotattionSpeed = 30f;

    void Update()
    {
        transform.Rotate(new Vector3(0, _rotattionSpeed, 0) * Time.deltaTime);
    }
}
