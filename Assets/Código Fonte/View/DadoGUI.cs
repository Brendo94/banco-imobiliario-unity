using UnityEngine;
using System.Collections;
using System;

public class DadoGUI : MonoBehaviour {

	string valorDado1 = "1";
	string valorDado2 = "0";

	public bool jogouDado;
	public bool mostrar_dados;
	// Use this for initialization
	void Start () {
		jogouDado = false;
		MostrarDados ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		if (mostrar_dados) {
			valorDado1 = GUI.TextField (new Rect (812, 265, 120, 20),valorDado1, 25);
			valorDado2 = GUI.TextField (new Rect (812, 295, 120, 20), valorDado2, 25);
				
		if (GUI.Button(new Rect(833, 323, 80, 30), "Jogar Dado")){
			
				EsconderDados();
				jogouDado = true;
			
			}
		}
	}
	public void MostrarDados(){
		mostrar_dados = true;
	}
	public void EsconderDados(){
		mostrar_dados = false;
	}
	public bool PlayerJogouDado(){
		return this.jogouDado;
	}
	public int ValorDados(){
		
		int vDado1 = Convert.ToInt32(valorDado1);
		int vDado2 = Convert.ToInt32(valorDado2);
		
		return vDado1 + vDado2;
		
	}
	public void MudarPlayer(){
		this.jogouDado = false;
		MostrarDados ();
	}

}
