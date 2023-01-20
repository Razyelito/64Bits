using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosCaminar : MonoBehaviour
{
	public AudioSource SonidosCaminarSound;

	void Update()
	{
		if(Input.GetKey(KeyCode.UpArrow)){
			SonidosCaminarSound.enabled = true;
		}
		else
		{
			SonidosCaminarSound.enabled = false;
		}
	}

}
