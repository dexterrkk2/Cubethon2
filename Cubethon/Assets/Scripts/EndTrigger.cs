using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    GameManager gameManager;
    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
