using UnityEngine;
using System.Collections;

public class DemoManager : MonoBehaviour {

	public GameObject cube;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Drop",0, 0.1f);
	}
	
	// Update is called once per frame
	void Drop () {
		GameObject cubeObj = (GameObject)Instantiate (cube,new Vector3(Random.Range(-20,20),30,Random.Range (-20,20)),Quaternion.identity);
		cubeObj.rigidbody.AddTorque(new Vector3(Random.Range(-100,100),Random.Range(-100,100),Random.Range(-100,100)));
		Destroy (cubeObj, 10);
	}
}
