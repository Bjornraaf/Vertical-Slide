using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private int fireRate = 4;
    protected GameObject lastestSpawnedBullet;

    private void Start()
    {
        StartCoroutine(Countdown());
    }

    private IEnumerator Countdown()
    {
        while (true)
        {
            yield return new WaitForSeconds(fireRate);
            Shoot();
        }
    }

    virtual protected void Shoot()
    {
        lastestSpawnedBullet = Instantiate(prefab, this.transform);
    }
}
