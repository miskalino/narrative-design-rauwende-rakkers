using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float YOffset = 2f;
    public Transform person;
    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(person.position.x,person.position.y + YOffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
    }
}
