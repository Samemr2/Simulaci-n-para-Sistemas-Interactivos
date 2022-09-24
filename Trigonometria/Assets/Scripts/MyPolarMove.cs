using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPolarMove : MonoBehaviour
{
    [SerializeField] 
    MyVector PolarPunto;
    [SerializeField] 
    float VelocidadAngular;
    [SerializeField] 
    float Velocidadr;
    [SerializeField] 
    float Aceleracionr;
 
    void Update()
    {
        PolarPunto.x += Time.deltaTime * Velocidadr;
        PolarPunto.y += Time.deltaTime * VelocidadAngular;
        MyVector cartesianPoint = Polar2Cartesian(PolarPunto);
        cartesianPoint.Draw(Color.cyan);
        transform.position = cartesianPoint;
        CheckBounds();
    }
    MyVector Polar2Cartesian(MyVector polar)
    {
        float x = Mathf.Cos(polar.y * Mathf.Deg2Rad) * polar.x; 
        float y = Mathf.Sin(polar.y * Mathf.Deg2Rad) * polar.x;
        MyVector unitdir = new MyVector(x, y);
        return unitdir;
    }
    void CheckBounds()
    {
        if (Mathf.Abs(PolarPunto.x) >= 5)
        {
            PolarPunto.x = Mathf.Sign(PolarPunto.x) * 5;
            if (Mathf.Abs(Aceleracionr) > 0)
            {
                Aceleracionr = -Aceleracionr; 
                Velocidadr *= -1;
            }
            else 
            {
                Velocidadr = -Velocidadr; 
            }

        }

    }
}
