using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    [SerializeField]
    private float _speedRotation;
    
    void Update()
    {
        transform.Rotate(new Vector3 (0, 0, _speedRotation) * Time.deltaTime);
    }
}
