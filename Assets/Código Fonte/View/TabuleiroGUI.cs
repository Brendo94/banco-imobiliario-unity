using UnityEngine;
using System.Collections.Generic;

public class TabuleiroGUI : MonoBehaviour {
		
	public GameObject playerVermelho;//nome do player
	public GameObject playerAzul;

	public GameObject casaPlayerVermelo;
	public GameObject casaPlayerAzul;

	private GameObject casaComprada;

	private List<Vector3> posicoes = new List<Vector3>();


	void Start () {
		float x = -4.033f;
		float y = -3.75f;
		float z = 0f;

		//////////////////////////////////////////////////
		/// preenchenco as posicoes...
		/// 
		for(int i =0;i<9;i++){
			
			posicoes.Add (new Vector3 (x, y, z));
			x += 0.79f;
		}
		
		y+=0.79f;
		for (int i=0; i<9; i++) {
			posicoes.Add(new Vector3(x,y,z));
			y+=0.79f;
		}
		x -=0.79f;
		
		for (int i=0; i<9; i++) {
			posicoes.Add(new Vector3(x,y,z));
			x-=0.79f;
		}
		y-=0.79f;
		for (int i=0; i<9; i++) {
			posicoes.Add(new Vector3(x,y,z));
			y-=0.79f;
		}
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	
	public void percorerTabuleiro(int idJogadorDaVez, int posicaoJogador){
				if (idJogadorDaVez == 0) {
						playerVermelho.transform.position = posicoes [posicaoJogador];
				} else
			if (idJogadorDaVez == 1) {
						playerAzul.transform.position = posicoes [posicaoJogador];
				}
		}
		public void comprarLogradouro(int idJogadorDaVez, int posicaoJogadorC){
			if (idJogadorDaVez == 0) {
			casaComprada = GameObject.Instantiate(casaPlayerVermelo) as GameObject;
			casaComprada.transform.position = posicoes[posicaoJogadorC];
			casaComprada.transform.parent = transform;
				}
		else if (idJogadorDaVez == 1) {
			casaComprada = GameObject.Instantiate(casaPlayerAzul) as GameObject;
			casaComprada.transform.position = posicoes[posicaoJogadorC];
			casaComprada.transform.parent = transform;
		}
			
		}
	
	}




