using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPolarExp : MonoBehaviour
{
    [SerializeField] 
    private float gradoangulo;
    [SerializeField] 
    private float velocidadangular;
    private float r = 1;

    void Update()
    {
        gradoangulo -= velocidadangular * Time.deltaTime;
        Polar2Cartesian(gradoangulo, r).Draw(Color.blue);
    }

    MyVector Polar2Cartesian(float angle, float rad)
    {
        float x = Mathf.Cos(gradoangulo * Mathf.Deg2Rad);
        float y = Mathf.Sin(gradoangulo * Mathf.Deg2Rad);
        MyVector unitdir = new MyVector(x * r, y * r);
        return unitdir;
    }
}
