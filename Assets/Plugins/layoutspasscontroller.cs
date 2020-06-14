using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class layoutspasscontroller : MonoBehaviour {
	public CanvasGroup[] layouts;
	public int layoutinuse;
	bool desactive;
	public Animator configanim;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void ChangeLayout(int n){
		layoutinuse = n;
		layouts[0].gameObject.GetComponent<Animator>().enabled = false;
		layoutinuse = n;
		for(int i = 0; i < layouts.Length; i ++){
			if(i != n){
				layouts[i].alpha = 0;
				layouts[i].blocksRaycasts = false;
				layouts[i].interactable = false;
				layouts[i].GetComponent<Animator>().enabled = false;

			}
		}
		layouts[n].alpha = 1;
		layouts[n].blocksRaycasts = true;
		layouts[n].interactable = true;
		layouts[n].GetComponent<Animator>().enabled = true;
		
	}
	public void Config(int n){
		if(n == 1){
			configanim.SetBool("showconfig",true);
			if(layoutinuse == 2){
				layouts[2].alpha = 0.05f;
				layouts[2].interactable = false;
			}else{
				layouts[4].alpha = 0.05f;
				layouts[4].interactable = false;
			}
			layouts[2].GetComponent<Animator>().enabled = false;
			layouts[4].GetComponent<Animator>().enabled = false;
			layouts[3].GetComponent<Animator>().enabled = true;
			layouts[3].interactable = true;
			layouts[3].blocksRaycasts = true;
			
		}
		else{
			configanim.SetBool("showconfig",false);
			if(layoutinuse == 2){
				layouts[2].alpha = 1f;
				layouts[2].interactable = true;
			}else{
				layouts[4].alpha = 1f;
				layouts[4].interactable = true;
			}
			layouts[3].interactable = false;
			layouts[3].blocksRaycasts = false;
		}
	}


}
