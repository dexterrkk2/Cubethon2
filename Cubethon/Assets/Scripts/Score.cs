using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public GameManager gameManager;
    // Update is called once per frame
    void Update()
    {
        Data.instance.score = (player.position.z * gameManager.difficulty);
        scoreText.text = Data.instance.score.ToString("0");
    }
}
