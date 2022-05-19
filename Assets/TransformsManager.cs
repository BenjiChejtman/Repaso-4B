using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformsManager : MonoBehaviour
{
    public GameObject myCube;

    //objetos de los que quiero tomar propiedades

    public GameObject rotado;
    public GameObject escalado;
    public GameObject rotadoYescalado;

    public Vector3 originalRotation;
    public Vector3 originalScale;

    public bool isRotated;
    public bool isScaled;
    // Start is called before the first frame update
    void Start()
    {
        isRotated = false;
        isScaled = false;
        originalRotation = myCube.transform.eulerAngles;
        originalScale = myCube.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) //r de rotar
        {
            if (isRotated)
            {
                myCube.transform.eulerAngles = originalRotation; //le doy la rotacion original
                isRotated = false; //aclaro que no esta rotado en el bool, declarandolo como false.
            }
            else
            {
                myCube.transform.eulerAngles = rotado.transform.eulerAngles; //le doy la rotacion de "rotado" a mi cubo, es in traspaso de propiedades, en este caso es un traspaso de rotacion.
                isRotated = true; //aclaro que esta rotado en el bool, declarandolo como true.
            }
        }
        if (Input.GetKeyDown(KeyCode.S)) //s de escalar  scale. Hacemos lo mismpo que hicimos arribsa pero en vez de para rotar, para cambiar la escala.
        {
            if (isScaled)
            {
                myCube.transform.localScale = originalScale;
                isScaled = false;
            }
            else
            {
                myCube.transform.localScale = escalado.transform.localScale;
                isScaled = true;
            }
        }
    }
}
