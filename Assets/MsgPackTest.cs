using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using MsgPack;
using MsgPack.Serialization;

public class MsgPackTest : MonoBehaviour {
	
	public class SampleClass {
		public string str;
	}
	
	public class FailClass {
		public string str;
		public int number;
	}
	
	// Use this for initialization
	void Start () {
		
		Debug.Log ("Sample Class");
		var s = SerializationContext.Default.GetSerializer<SampleClass> ();
		
		Debug.Log ("Fail Class");
		var s2 = SerializationContext.Default.GetSerializer<FailClass> ();
		
		Debug.Log ("Start() End");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
