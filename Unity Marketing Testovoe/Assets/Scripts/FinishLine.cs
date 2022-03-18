using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField]
    private GameObject _restartMenu;
    void Start()
    {
        _restartMenu.SetActive(false);
    }

    void OnTriggerEnter(Collider coll)
    {
        if(coll.CompareTag("Player"))
        _restartMenu.SetActive(true);
    }
}
