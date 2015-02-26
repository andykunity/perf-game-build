using UnityEngine;
using System;
using System.Collections;
using System.Reflection;

public class Environment  
{

	private static FieldInfo m_Environment;
	
	static Environment()
	{
		Type logRunner = Type.GetType("UnityEngine.CrashLog.ConfigService, UnityEngine.CrashLog");
		m_Environment = logRunner.GetField("s_Environment", BindingFlags.NonPublic | BindingFlags.Static);
	}
	public static string environment
	{
		get
		{
			return (string)m_Environment.GetValue(null);
		}

		set
		{
			m_Environment.SetValue(null, value);
		}
	}
}
