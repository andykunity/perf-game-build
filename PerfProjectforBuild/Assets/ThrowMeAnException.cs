using System;
using UnityEngine;
using UnityEngine.CrashLog;
using System.Collections;

public class ThrowMeAnException : MonoBehaviour 
{

    void Awake()
    {
        //Replace the "1" with your project id
		Environment.environment = "staging";
		CrashReporting.Init("0d40f105-a012-4c55-92e0-6f0c9b119a0e");

    }


    //Wait a couple of seconds and throw an Exception!


	public void Crash()
	{
		throw new Exception("This is our final RC for releasing on 2/26");
	}
	

}
