using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject debris;
    public float maxX;
    public Transform spawnPoint;
    int score = 0;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnDebris", 0.5f, 1.5f);
        InvokeRepeating("UpdateScore", 3f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnDebris()
    {
        Vector3 spawnPos = spawnPoint.position;
        spawnPos.x=Random.Range(-maxX, maxX);
        Instantiate(debris,spawnPos,Quaternion.identity);
    }

    void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
