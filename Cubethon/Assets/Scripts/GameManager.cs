using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public bool offStartMenu;
    public float restarDelay;
    public GameObject completeLevelUi;
    public List<GameObject> Obstacle;
    public float spawnTime;
    public float startSpawnTime;
    public float incrementAdjuster;
    public int difficulty;
    public Transform spawnPoint;
    private void Start()
    {
        startSpawnTime = spawnTime;
        difficulty = Data.instance.difficulty;
    }
    public void CompleteLevel()
    {
        completeLevelUi.SetActive(true);
        Debug.Log("Level won");
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            CompleteLevel();
        }
    }
    private void Update()
    {
        if (spawnTime<0) 
        {
            spawnObstacles();
        }
        spawnTime -= Time.deltaTime;
    }
    public void spawnObstacles()
    {
        int random = Random.Range(0, Obstacle.Count);
        Instantiate(Obstacle[random],spawnPoint);
        spawnTime = startSpawnTime -(spawnPoint.position.z/(incrementAdjuster/difficulty));
        if (spawnTime < .15)
        {
            spawnTime = .15f;
        }
        spawnPoint.DetachChildren();
    }
}
