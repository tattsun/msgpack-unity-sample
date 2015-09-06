using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using MsgPack;
using MsgPack.Serialization;

public class MsgPackTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Dictionary<string, string> dict = new Dictionary<string, string>();
		dict.Add ("foo", "bar");
		dict.Add ("hoge", "hoge");

		var s = SerializationContext.Default.GetSerializer<Dictionary<string, string>> ();
		var packed = s.PackSingleObject (dict);
		
		var unpacked = s.UnpackSingleObject (packed);

		foreach (var kv in unpacked) {
			Debug.Log (kv.Key + ":" + kv.Value);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
