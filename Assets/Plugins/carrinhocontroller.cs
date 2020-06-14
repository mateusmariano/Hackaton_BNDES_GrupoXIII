using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class carrinhocontroller : MonoBehaviour {

	public List<GameObject> prodcar;
	public Text addsucess;
	public GameObject[] containers,buybuttons,sucessfeedback;
	public string storec1,storec2,storec3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void AddCar(){
		prodcar.Add(GameObject.Find("prodselected"));
		if(storec1.Length == 0){
			containers[0].transform.GetChild(1).GetComponent<Text>().text = prodcar[0].transform.GetChild(3).GetComponent<Text>().text;
			containers[0].transform.GetChild(2).GetComponent<Text>().text = prodcar[0].transform.GetChild(0).GetComponent<Text>().text;
			storec1 = (prodcar[0].transform.GetChild(3).GetComponent<Text>().text);
		}else{
			if(prodcar[prodcar.Count-1].transform.GetChild(3).GetComponent<Text>().text == storec1){
				containers[0].transform.GetChild(3).GetComponent<Text>().text = prodcar[0].transform.GetChild(0).GetComponent<Text>().text;
			}else{
				if(storec2.Length == 0){
					containers[1].SetActive(true);
					buybuttons[1].SetActive(true);
					containers[1].transform.GetChild(1).GetComponent<Text>().text = prodcar[prodcar.Count-1].transform.GetChild(3).GetComponent<Text>().text;
					containers[1].transform.GetChild(2).GetComponent<Text>().text = prodcar[prodcar.Count-1].transform.GetChild(0).GetComponent<Text>().text;
					storec2 = (prodcar[prodcar.Count-1].transform.GetChild(3).GetComponent<Text>().text);
				}else{
					if(prodcar[prodcar.Count-1].transform.GetChild(3).GetComponent<Text>().text == storec2){
						containers[1].transform.GetChild(3).GetComponent<Text>().text = prodcar[prodcar.Count-1].transform.GetChild(0).GetComponent<Text>().text;
					}else{
						if(storec3.Length == 0){
							containers[2].SetActive(true);
							buybuttons[2].SetActive(true);
							containers[2].transform.GetChild(1).GetComponent<Text>().text = prodcar[prodcar.Count-1].transform.GetChild(3).GetComponent<Text>().text;
							containers[2].transform.GetChild(2).GetComponent<Text>().text = prodcar[prodcar.Count-1].transform.GetChild(0).GetComponent<Text>().text;
							storec3 = (prodcar[prodcar.Count-1].transform.GetChild(3).GetComponent<Text>().text);
						}else{
							if(prodcar[prodcar.Count-1].transform.GetChild(3).GetComponent<Text>().text == storec3){ 
								containers[2].transform.GetChild(3).GetComponent<Text>().text = prodcar[prodcar.Count-1].transform.GetChild(0).GetComponent<Text>().text;
							}
						}
					}
				}
			}
		}
		GameObject.Find("productcontroller").GetComponent<productcontroller>().descricao.text = null;
		GameObject.Find("productcontroller").GetComponent<productcontroller>().informations.text = null;
		GameObject.Find("productcontroller").GetComponent<productcontroller>().prodimg.sprite = null;
		GameObject.Find("productcontroller").GetComponent<productcontroller>().store.text = null;
		addsucess.enabled = true;
		Invoke("Sucessfeedbacktonormal",2);
	}
	public void GenerateCode(int n){
		usercontroller.code = Random.Range(1,4);
		usercontroller.data = true;
		sucessfeedback[n].SetActive(true);
		Invoke("Sucessfeedbacktonormal",2);
	}
	void Sucessfeedbacktonormal(){
		addsucess.enabled = false;
		for(int i = 0; i < sucessfeedback.Length; i++){
			sucessfeedback[i].SetActive(false);
		}
	}

}
