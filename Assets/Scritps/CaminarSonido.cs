using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminarSonido : MonoBehaviour
{
	public AudioSource SonidosCaminar;

	void update()
	{
		if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S)){
			SonidosCaminar.enabled = true;
		}
		else
		{
			SonidosCaminar.enabled = false;
		}
	}

}
