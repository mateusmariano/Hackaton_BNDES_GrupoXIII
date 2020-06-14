using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttonproduct : MonoBehaviour {

	public Text descricaotxt;
	public string informations,store;
	public Image img;
	public GameObject addcarrinho;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ProductSelected(){
		GameObject.Find("productcontroller").GetComponent<productcontroller>().descricao.text = descricaotxt.text;
		GameObject.Find("productcontroller").GetComponent<productcontroller>().informations.text = informations;
		GameObject.Find("productcontroller").GetComponent<productcontroller>().store.text = store;
		GameObject.Find("productcontroller").GetComponent<productcontroller>().prodimg.sprite = img.sprite;
		addcarrinho.SetActive(true);
	}
}
