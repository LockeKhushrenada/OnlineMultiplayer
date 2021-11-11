using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CameraFollow : MonoBehaviour
{
	public Transform target;
	public float smoothing = 5f;
	public GameObject[] players;

	private Vector3 offset;

	void Update()
	{
	}

	void FixedUpdate()
	{
		players = GameObject.FindGameObjectsWithTag("Player");
		if(players.Length >= 1)
        {
			if(target == null)
			{
				target = FindObjectOfType<PlayerHealth>().transform;
				offset = transform.position - target.position;
				//Vector3 targetCamPos = target.position + offset;
				//transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
			}
			Vector3 targetCamPos = target.position + offset;
			transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
		}
		
		
	}
}
