using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MortarFlower : SpawnBullet
{
    [SerializeField] private Transform point0;
    [SerializeField] private Transform point1;
    [SerializeField] private Transform point2;

    protected override void Shoot()
    {
        base.Shoot();
        lastestSpawnedBullet.GetComponent<CurveBullet>().SetPoints(point0.position, point1.position, point2.position);
    }
}
