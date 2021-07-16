using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carBehav : MonoBehaviour
{

    public string marca = "Peugeot";
    public string modelo = "208";
    public Color color = Color.blue;
    public int cv = 150;


    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(new Vector3(5, 8));
        //Te encuentra todos los objetos de pantalla con ese tag
         GameObject[] enemigos = GameObject.FindGameObjectsWithTag("Enemy");
         Debug.Log("Hay "+ enemigos.Length + " enemigos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Arrancar()
    {
        Debug.Log("Brrrrr");
    }

}
