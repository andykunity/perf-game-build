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
		CrashReporting.Init("b0f0ea8d-6282-42f1-9b8b-44998bb0c568");
    }

	public void CrashForMe()
	{
		throw new Exception("Button press exception for Igor's Build");
	}

}
