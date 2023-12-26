using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
  [SerializeField] Transform Player;
  [SerializeField] Vector3 Offset;
    void Awake()
    {
    Offset = transform.position - Player.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
    
    transform.position =Player.position + Offset;
    }
}
