using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VikingScript : MonoBehaviour
{
    public Vector3 MovingDirection;

    MeshRenderer mr;
    float movingSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();



    }

    // Update is called once per frame
    void Update()
    {
        mr.material.color = new Color((int)Time.time % 2 * 1.0f , 1.0f , 1.0f);

        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.back;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.right;
        }

    }
}
