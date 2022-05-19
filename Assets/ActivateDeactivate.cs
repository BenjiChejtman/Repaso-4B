using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactivate : MonoBehaviour
{
    public GameObject myObject; //si hay myObject lo cambio por la luz por ejemplo (en unity, en el inspector), voy a poder desactivar la luz.

    // Start is called before the first frame update
    void Start()
    {
     //   myObject.SetActive(false); //desactivamos un objeto por codigo. Lo mismo que apretar la check box de arriba del gameobject en el inspector.
    }

    // Update is called once per frame
    void Update() //se ejecuta muchas veces por segundo, para fijarse si el usuario apreto tal tecla.
    {
        if (Input.GetKeyDown(KeyCode.Space))//con este if, si se presiona el espacio, desaparece el objeto es decir, se DESACTIVA EL OBJETO. //GetKey, se fija si la tecla se apreto, solto o mantuvo presionada y GetKeyDown, detecta cuando el usuario presiona o BAJA una tecla. GetKey da true todo el tiempo y GetKeyDown da true cuando se hunde o presiona una tecla.
        {
            /* if (myObject.activeInHierarchy) //si el objeto esta activado, lo desactivo con lo que se encuntra adentro del if
             {
                 myObject.SetActive(false);
             }
             else                           //con este else, si no esta activado lo activo
             {
                 myObject.SetActive(true);
             }
             */

            //setActive= activa o desactiva, al base a una condicion.
            myObject.SetActive(!myObject.activeInHierarchy); //esto es lo mismo que el if de arriba solo que se hace en una sola linea y mas facil. Activa al cubo al presionar el espacio si esta desactivado, y lo desactiva si esta activado.
        }
    }

}
