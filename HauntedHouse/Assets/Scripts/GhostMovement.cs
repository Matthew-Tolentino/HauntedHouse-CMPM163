using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovement : MonoBehaviour
{

    Vector3[] positions = new Vector3[4];

    private bool fromNeg = false;

    public Transform target;

    void Start()
    {
        positions[0] = new Vector3(5.13f, 0.015f, -5.54f);
        positions[1] = new Vector3(-0.96f, 0.015f, -5.54f); 
        positions[2] = new Vector3(3.874f, -0.347f, 2.35f); 
        positions[3] = new Vector3(0.1f, 0.015f, -0.2f); 
    }
    void Update()
    {
        float t = Mathf.Sin(Time.time);
        if (t < 0) fromNeg = true;
        if (t > 0.93 && t < .95 && fromNeg)
        {
            fromNeg = false;
            teleport();
        }
    }

    private void teleport()
    {
        Vector3 direction = target.position - this.transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        float pick = Random.Range(0.0f, 4.0f);

        if (pick < 1)
        {
            this.transform.position = positions[0];
        }
        else if (pick < 2)
        {
            this.transform.position = positions[1];
        }
        else if (pick < 3)
        {
            this.transform.position = positions[2];
        }
        else if (pick < 4)
        {
            this.transform.position = positions[3];
        }
    }
}
