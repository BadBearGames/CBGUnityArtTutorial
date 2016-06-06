using UnityEngine;
using System.Collections;

public class KillScott : MonoBehaviour 
{
	private ParticleSystem fireSystem;

	void Start () 
	{
		fireSystem = GetComponent<ParticleSystem>();
		fireSystem.Stop();
	}
	

	void Update () 
	{
		if (Input.GetMouseButtonDown(0))
		{
			if (fireSystem.isPlaying)
			{
				fireSystem.Stop();
			}
			else
			{
				fireSystem.Play();
			}
		}
	}
}
