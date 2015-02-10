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
		CrashReporting.Init("ee0b870f-4028-4ff5-8922-9fa2b1ee7b73");
    }

	public void CrashForMe()
	{
		throw new Exception("Button press exception");
	}

}
