using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingGame : MonoBehaviour
{
    public GameObject pipe;
    public GameObject obstacle;
    private GameObject startPipe;
    private float startOffset;
    public static FlyingGame Instance { get; private set; }
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _heightRange = 0.45f;
    private float _timer; 
    
    void Start()
    {
        //RestartGame();
        SpawnObstacle();
    }

    void Update()
    {
        if(_timer > _maxTime)
        {
            SpawnObstacle();
            _timer = 0; 
        }
        _timer += Time.deltaTime; 
    }

    public void RestartGame()
    {
        Destroy(startPipe);
        startPipe = Instantiate(pipe, new Vector2(x: startOffset, y: 0 ), Quaternion.identity); 
    }

    private void SpawnObstacle()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
        GameObject Pipe = Instantiate(pipe, spawnPos, Quaternion.identity);
        GameObject Obstacle = Instantiate(obstacle, spawnPos, Quaternion.identity);
        Destroy(Pipe, 10f); 
    }
}
