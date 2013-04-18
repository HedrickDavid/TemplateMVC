using UnityEngine;
using System.Collections;

public class MainApplication : MonoBehaviour {
	
	private TestMVCController _testMVCController;
	
	// Use this for initialization
	void Start () {
		startApplication();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	private void startApplication(){
		_testMVCController = gameObject.AddComponent<TestMVCController>();	
		_testMVCController.init();
	}
}
