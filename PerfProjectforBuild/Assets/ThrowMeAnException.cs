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
	
    void Start ()
    {
        StartCoroutine(Boom());
    }

    //Wait a couple of seconds and throw an Exception!
    IEnumerator Boom()
    {
        yield return new WaitForSeconds(2);
        First();
    }
	
	
	private void First()
	{
	    Second();
	}
	
	private void Second()
	{
	    Third();
	}
	
	private void Third()
	{
	    Fourth();
	}
	
	private void Fourth()
	{
		Debug.Log("I'm in crash now");
	    throw new Exception("Boom ios 2");
	}
	

}
