using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehav : MonoBehaviour
{
    public string animalSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
            Debug.Log(animalSound);
    }
}
