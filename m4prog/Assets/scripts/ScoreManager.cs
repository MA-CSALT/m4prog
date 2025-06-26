using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int score = 0;

    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score bijgewerkt: " + score);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
