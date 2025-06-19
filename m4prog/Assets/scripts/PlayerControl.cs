using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 500f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Speler klaar!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce);
            Debug.Log("Springen!");
        }
    }
}
