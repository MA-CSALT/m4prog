using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float speed = 5f;
    [SerializeField] private ScoreManager scoreManScript;
    void Start()
    {

        if (scoreManScript == null)
        {
            Debug.LogError("ScoreManager niet ingesteld!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * speed *Time.deltaTime;
        Vector3 move = new Vector3(moveX, 0f, 0f);
        transform.Translate(move);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Coin")
        {
            scoreManScript.AddScore(10); 

            Debug.Log("Munt gepakt!");

            Destroy(other.gameObject);
        }
    }
    }
