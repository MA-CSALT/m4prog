using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl2 : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField]private GameObject coinPrefab;
    // Start is called before the first frame update
    void Start()
    {
        float randVal = Random.Range(-10, 10);
        Instantiate(coinPrefab, new Vector3(randVal, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * input * speed * Time.deltaTime);
    }
}
