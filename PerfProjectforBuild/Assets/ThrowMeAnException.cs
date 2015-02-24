using System;
using UnityEngine;
using UnityEngine.CrashLog;
using System.Collections;

public class ThrowMeAnException : MonoBehaviour 
{

    void Awake()
    {
        //Replace the "1" with your project id
		CrashReporting.Init("f7e93b31-6583-4f27-a4f2-ac3d80428c34");

    }


    //Wait a couple of seconds and throw an Exception!


	public void Crash()
	{
		throw new Exception("Pressed the button, this is the new one on ios");
	}
	

}
