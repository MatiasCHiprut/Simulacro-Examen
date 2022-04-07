//2.Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
//Comunicar si la suma de los mismos supera o no el monto de dinero disponible.
//Luego indicar cuánto dinero sobra o falta.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    public float prod1;
    public float prod2;
    public float prod3;
    public float monto;
    // Start is called before the first frame update
    void Start()
    {
        float total = prod1 + prod2 + prod3;
        float resto = monto - total;
        float falta = total - monto;
        if (total <= monto)
        {
            Debug.Log("La suma no supera el monto de dinero disponible. El dinero que le sobra es $"+resto);
        }
        else if (total > monto)
        {
            Debug.Log("La suma supera el monto de dinero disponible. El dinero que le falta es $"+falta);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
