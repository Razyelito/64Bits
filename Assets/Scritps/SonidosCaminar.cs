using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosCaminar : MonoBehaviour
{
	public AudioSource SonidosCaminarSound, SonidosCorrerSound;

	void Update()
	{
		if(Input.GetKey(KeyCode.UpArrow)){
			SonidosCaminarSound.enabled = true;
			if(Input.GetKey(KeyCode.LeftShift)){
				SonidosCaminarSound.enabled = false;
				SonidosCorrerSound.enabled = true;
			}
			else if(!Input.GetKey(KeyCode.LeftShift)){
				SonidosCorrerSound.enabled = false;
			}
		}
		else
		{
			SonidosCaminarSound.enabled = false;
			SonidosCorrerSound.enabled = false;
		}
	}

}
