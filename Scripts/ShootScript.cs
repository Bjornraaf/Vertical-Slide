using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float fireRate = 0.1f;
    [SerializeField] private int forceMultiplier = 1000;
    [SerializeField] private Transform dirTarget;
    private bool waited = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && waited)
        {
            waited = false;
            StartCoroutine(CountDown());
        }
    }

    private void Shoot()
    {
        GameObject clone = (GameObject)Instantiate(bullet, transform.position + transform.right * 1.5f, Quaternion.identity);
        clone.GetComponent<Rigidbody2D>().AddForce((dirTarget.position - transform.position)* forceMultiplier);
        Destroy(clone, 3f);
    }

    IEnumerator CountDown()
    {
        Shoot();
        yield return new WaitForSeconds(fireRate);
        waited = true;
    }
}
