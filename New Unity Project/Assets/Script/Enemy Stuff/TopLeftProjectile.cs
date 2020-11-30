using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopLeftProjectile : MonoBehaviour
{
    [SerializeField] private float speed = 0.05f;
    void Start()
    {
        Destroy(gameObject, 8f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(-speed, speed, 0);
    }
}
