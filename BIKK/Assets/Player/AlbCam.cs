using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbCam : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 pos;

    private void Awake()
    {
        if (!player)
            player = FindObjectOfType<AlbMove>().transform;
    }

    private void Update()
    {
        pos = player.position;
        pos.z = -20f;
        pos.y += 3f;
        pos.x += 25f;
        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime);
    }


}