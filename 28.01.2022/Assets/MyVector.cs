using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MyVector
{
    public float x;
    public float y;
    public MyVector(float a, float b)
    {
        x = a;
        y = b;

    }

    public MyVector Suma(MyVector vector)
    {
        return new MyVector(x + vector.x, y + vector.y);
    }

    public static MyVector operator +(MyVector a, MyVector b)
    {
        return new MyVector(a.x + b.x, a.y + b.y);
    }

    public MyVector Resta(MyVector vector)
    {
        return new MyVector(x - vector.x, y - vector.y);
    }

    public static MyVector operator - (MyVector a, MyVector b)
    {
        return new MyVector(a.x - b.x, a.y - b.y);
    }

    public override string ToString()
    {
        return ("(" + x + "," + y + ")");
    }

    public void Draw(MyVector inicio, Color color)
    {

        Debug.DrawLine(new Vector3(inicio.x, inicio.y), new Vector3(x + inicio.x, y + inicio.y), color);
    }

    public void Draw(Color color)
    {

        Debug.DrawLine(Vector3.zero, new Vector3(x, y), color);
    }

    public MyVector Multiplicar(float escalar) {

        return new MyVector(x = x * escalar, y = y * escalar);

    }

    public static MyVector operator * (MyVector a, MyVector b)
    {
        return new MyVector(a.x * b.x, a.y * b.y);
    }

    public MyVector Lerp(MyVector vector, float tamaño) {

        return Suma(vector.Resta(this).Multiplicar(tamaño));
    }

    public float Magnitud()
    {
         return Mathf.Sqrt(( Mathf.Pow(x, 2)) + (Mathf.Pow(y, 2)));
    }

    public MyVector Normalizar() 
    {
        return new MyVector(x / Magnitud(), y / Magnitud());
     
    }
}