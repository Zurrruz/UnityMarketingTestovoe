using System.Collections;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField]
    int _howManyCoins;
    [SerializeField]
    ParticleSystem _particleSystem;
    [SerializeField]
    GameObject _coin;
    
    public delegate void AddCoin();
    public static event AddCoin addCoin;
    

    private void OnTriggerEnter(Collider coll)
    {
        if(coll.CompareTag("Player"))
        {
            _particleSystem.Play();
            StartCoroutine(DestroyCoin());
            _coin.SetActive(false);
            CountCoinController.OnPlayerCoinsChanged(_howManyCoins);
        }
    }

    IEnumerator DestroyCoin()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
