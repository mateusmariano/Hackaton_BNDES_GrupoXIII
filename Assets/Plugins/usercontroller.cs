using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class usercontroller : MonoBehaviour {

	public static int code;
	public static bool data; 
	public GameObject datatable,warning,infopanel;
	public Toggle[] toggles;
	public Text[] dias,horarios;
	public Text[] infos;
	bool podeagendar;
	int toggleindex = -1,togglescount;
	
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
	public void Agendar(){
		for(int i = 0; i < toggles.Length; i ++){
			if(toggles[i].isOn){
				togglescount++;
				toggleindex = i;
			}
		}
		if(togglescount == 1){
			infos[0].text = dias[toggleindex].text;
			infos[1].text = horarios[toggleindex].text;
			infopanel.SetActive(true);
			togglescount = 0;

		}else{
			toggleindex = -1;
			Debug.Log("fail");
			togglescount = 0;
		}

	}
}
