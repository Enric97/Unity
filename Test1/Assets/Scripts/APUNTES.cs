using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APUNTES : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int CosasVarias()
    {
        //Otra posible manera de iniciar arrays
        string[] booba = new string[] { "CACAO", "Menta", "Fresita", "Simba" };


        //Te encuentra todos los objetos de pantalla con ese tag
        GameObject[] enemigos = GameObject.FindGameObjectsWithTag("Enemy");


        //Cosas de listas
        List<string> lista = new List<string>();
        lista.Add("hombre");
        lista.Add("muercielago");
        lista.Clear();

        //Insertar en la posicion 3
        lista.Insert(3, "bobobo");
        string[] enemigosLista = lista.ToArray();

        //Para sacar a uno en concreto
        string a = lista[3];


        //Esto nos permite tener un tipo de lista que nos guarda diferente tipos de variables
        ArrayList ArrayLista = new ArrayList();
        ArrayLista.Add("");
        ArrayLista.Add(3);
        ArrayLista.Add(true);
        //Este ultimo es para buscar objetos con ese mismo nombre
        ArrayLista.Add(GameObject.Find("Rabbit"));


        //Esto es un map tipo arraylist, donde metes lo que quieres. 
        //El primero es la key y el segundo el valor
        Hashtable personalInfo = new Hashtable();
        personalInfo.Add(0, "userLevel");
        personalInfo.Add("userlevel", 1);

        //Manera molona
        Dictionary<string, double> accounts = new Dictionary<string, double>();
        accounts.Add("hello", 1.2);
        //No existe el .get aqui
        double d = accounts["hello"];

        //Foreach
        foreach(string enemigo in enemigosLista)
        {
            Debug.Log(enemigo);
        }


        return 0;
    }
}
