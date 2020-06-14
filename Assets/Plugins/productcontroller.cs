using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class productcontroller : MonoBehaviour {
	
	public Text descricao, informations,searchtxt,store;
	public Image prodimg;
	public Text[] productsnames;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void SearchProduct(){
		descricao.text  = null;
		informations.text  = null;
		prodimg.sprite  = null;
		for(int i = 0; i < productsnames.Length; i++){
			if(productsnames[i].text.ToString().Contains(searchtxt.text)){
				descricao.text = productsnames[i].text;
				informations.text = productsnames[i].transform.parent.gameObject.GetComponent<buttonproduct>().informations;
				prodimg.sprite = productsnames[i].transform.parent.GetComponent<buttonproduct>().img.sprite;
			}
		
			
		}
	}
}
