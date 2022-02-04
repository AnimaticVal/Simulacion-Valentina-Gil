using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTest : MonoBehaviour
{
   
    float escalar = 4;

    [SerializeField] MyVector a= new MyVector(2,2);
    [SerializeField] MyVector b = new MyVector(-1, 3);
    [SerializeField] [Range(0, 1)] private float tamaño;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        a.Draw(Color.red);
        b.Draw(Color.green);
        b.Resta(a).Draw(Color.blue);
        b.Resta(a).Draw(a, Color.white);

        a.Lerp(b, tamaño).Draw(Color.white);

    }
}
