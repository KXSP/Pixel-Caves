using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Transform Player;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void LateUpdate()
    {
        Vector3 temp = transform.position;
        temp.x = Player.position.x;
     asdasd   temp.y = Player.position.y;

        transform.position = temp;
   asd }
}
asdaasdada