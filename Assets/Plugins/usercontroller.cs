using UnityEngine;
using System.Collections;

public class usercontroller : MonoBehaviour {

	public static int code;
	public static bool data; 
	public GameObject datatable,warning;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(data){
			datatable.SetActive(true);
			warning.SetActive(false);
		}else{
			warning.SetActive(true);
			datatable.SetActive(false);
			
		}
	}
	void UserDashboard(){

	}
}
