using UnityEngine;
using System.Collections;

public class AnimateScott : MonoBehaviour 
{
	Animator animator;

	void Start () 
	{
		animator = GetComponent<Animator>();
	}
	

	void Update () 
	{
		if (Input.GetMouseButtonDown(0))
		{
			animator.SetBool("running", !animator.GetBool("running"));
		}
	}
}
