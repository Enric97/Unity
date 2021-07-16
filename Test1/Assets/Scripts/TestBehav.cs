using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBehav : MonoBehaviour
{

    public string playerName = "Anna Bodal";
    
    [SerializeField]
    private int playerScore = 34;

    [SerializeField]
    private int maxScore =44;

    [SerializeField]
    private int playerAge = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(playerScore + maxScore);
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            birthDate();
    }

    void birthDate()
    {
        playerAge++;
        Debug.Log(playerAge);
    }
}
