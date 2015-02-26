using System;
using UnityEngine;
using UnityEngine.CrashLog;
using System.Collections;

public class ThrowMeAnException : MonoBehaviour 
{

    void Awake()
    {
        //Replace the "1" with your project id
		//Environment.environment = "staging";
		CrashReporting.Init("ac7e0c97-ff9b-4eba-883c-c1b71a601487");

    }


    //Wait a couple of seconds and throw an Exception!


	public void Crash()
	{
		throw new Exception("Testing on Production");
	}
	

}
