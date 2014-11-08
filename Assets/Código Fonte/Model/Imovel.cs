using UnityEngine;
using System.Collections;


public class Imovel : ILogradouro {
	
	private int indice;
	private	int idJogadorDono;
	private int preco;
	private int taxa;

	public Imovel(int indice, int preco){
		this.indice = indice;
		this.idJogadorDono = -1;
		this.preco = preco;
		double calcTaxa =preco*0.2; 
		this.taxa = (int)calcTaxa;	}


	public bool acao(Jogador j){
	 if (idJogadorDono == -1) {
			return true;
				} else if (idJogadorDono != j.getIdJogador ()) {
			cobrarTaxa(j);
			return false;
				}
		return false;
	}

	public int getIndice(){
		return this.indice;
	}


	public void comprar(Jogador j,bool decisao){
		if (decisao) {
						this.idJogadorDono = j.getIdJogador ();
						j.cobrarValor (this.preco);
				}
		}
	public void cobrarTaxa(Jogador j){
		j.cobrarValor (taxa);
		}
	public int getPreco(){
		return this.preco;
	}


	
	}
