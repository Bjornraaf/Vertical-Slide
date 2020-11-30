using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurveBullet : MonoBehaviour
{
    float count = 0.0f;
    [SerializeField] private Vector3 point0;
    [SerializeField] private Vector3 point1;
    [SerializeField] private Vector3 point2;
    [SerializeField] private float arch = 20.0f;
    [SerializeField] private float speed = 1.0f;
    private void Start()
    {
        CalculatePoints();
        Destroy(this.gameObject, 3f);
        Debug.Log(point0);
        Debug.Log(point1);
        Debug.Log(point2);
    }
    private void Update()
    {
        if (count < speed)
        {
            count += Time.deltaTime;

            Vector3 m1 = Vector3.Lerp(point0, point1, count);
            Vector3 m2 = Vector3.Lerp(point1, point2, count);
            transform.position = Vector3.Lerp(m1, m2, count);
        }
    }

    private void CalculatePoints()
    {
        point1 = point0 + (point2 - point0) / 2 + Vector3.up * arch;
    }

    public void SetPoints(Vector3 point00, Vector3 point01, Vector3 point02)
    {
        point0 = point00;
        point1 = point01;
        point2 = point02;
    }
}
