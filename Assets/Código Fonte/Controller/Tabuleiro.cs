using System.Collections.Generic;

public class Tabuleiro{

	private List<ILogradouro> listaLogradouroTabuleiro = new List<ILogradouro>();
	ILogradouro casaDaVez;

	public Tabuleiro(){
		GerarTabuleiro ();
		}

	public void GerarTabuleiro(){
		criarLogradouros();
	}

	private void criarLogradouros(){
		Imovel casa0 = new Imovel (0, 400);
		Imovel casa1 = new Imovel(1,100);
		Imovel casa2 = new Imovel (2, 350);
		Sorte casa3 = new Sorte(3,4);
		Empresa casa4 = new Empresa (4, 150);
		Imovel casa5 = new Imovel(5,180);
		Imovel casa6 = new Imovel(6,200);
		Imovel casa7 = new Imovel (7, 180);
		Empresa casa8 = new Empresa(8,100);
		Imovel casa9 = new Imovel (9, 220);
		Sorte casa10 = new Sorte (10,2);
		Imovel casa11 = new Imovel(11,220);
		Empresa casa12 = new Empresa (12,200);
		Imovel casa13 = new Imovel(13,240);
		Imovel casa14 = new Imovel(14,60);
		Imovel casa15 = new Imovel(15,60);
		Sorte casa16 = new Sorte (16,3);
		Imovel casa17 = new Imovel(17,100);
		Imovel casa18 = new Imovel(18,260);
		Imovel casa19 = new Imovel(19,280);
		Sorte casa20 = new Sorte (20,4);
		Imovel casa21 = new Imovel(21,300);
		Empresa casa22 = new Empresa (22,200);
		Imovel casa23 = new Imovel(23,300);
		Imovel casa24 = new Imovel(24,320);
		Empresa casa25 = new Empresa (25,200);
		Imovel casa26 = new Imovel(26,260);
		Imovel casa27 = new Imovel(27,140);
		Imovel casa28 = new Imovel(28,140);
		Imovel casa29 = new Imovel (29,160);
		Imovel casa30 = new Imovel(30,100);
		Empresa casa31 = new Empresa (31,50);
		Imovel casa32 = new Imovel(32,120);
		Sorte casa33 = new Sorte(33,1);
		Empresa casa34 = new Empresa (34, 150);
		Sorte casa35 = new Sorte (35,3);
		
		listaLogradouroTabuleiro.Add (casa0);
		listaLogradouroTabuleiro.Add (casa1);
		listaLogradouroTabuleiro.Add (casa2);
		listaLogradouroTabuleiro.Add (casa3);
		listaLogradouroTabuleiro.Add (casa4);
		listaLogradouroTabuleiro.Add (casa5);
		listaLogradouroTabuleiro.Add (casa6);
		listaLogradouroTabuleiro.Add (casa7);
		listaLogradouroTabuleiro.Add (casa8);
		listaLogradouroTabuleiro.Add (casa9);
		listaLogradouroTabuleiro.Add (casa10);
		listaLogradouroTabuleiro.Add (casa11);
		listaLogradouroTabuleiro.Add (casa12);
		listaLogradouroTabuleiro.Add (casa13);
		listaLogradouroTabuleiro.Add (casa14);
		listaLogradouroTabuleiro.Add (casa15);
		listaLogradouroTabuleiro.Add (casa16);
		listaLogradouroTabuleiro.Add (casa17);
		listaLogradouroTabuleiro.Add (casa18);
		listaLogradouroTabuleiro.Add (casa19);
		listaLogradouroTabuleiro.Add (casa20);
		listaLogradouroTabuleiro.Add (casa21);
		listaLogradouroTabuleiro.Add (casa22);
		listaLogradouroTabuleiro.Add (casa23);
		listaLogradouroTabuleiro.Add (casa24);
		listaLogradouroTabuleiro.Add (casa25);
		listaLogradouroTabuleiro.Add (casa26);
		listaLogradouroTabuleiro.Add (casa27);
		listaLogradouroTabuleiro.Add (casa28);
		listaLogradouroTabuleiro.Add (casa29);
		listaLogradouroTabuleiro.Add (casa30);
		listaLogradouroTabuleiro.Add (casa31);
		listaLogradouroTabuleiro.Add (casa32);
		listaLogradouroTabuleiro.Add (casa33);
		listaLogradouroTabuleiro.Add (casa34);
		listaLogradouroTabuleiro.Add (casa35);
	}



	public void percorrerTabuleiro (Jogador jogadorDaVez,int valorDados){
		if (jogadorDaVez.getPosicao () + valorDados > 35) {
			jogadorDaVez.setPosicao(jogadorDaVez.getPosicao()+valorDados -36);
			jogadorDaVez.setSaldo(jogadorDaVez.getSaldo()+200);
				}else
		jogadorDaVez.setPosicao (jogadorDaVez.getPosicao () + valorDados);

		setCasaDaVez (listaLogradouroTabuleiro [jogadorDaVez.getPosicao ()]);
	}
	public void AcaoDaPadrada(Jogador jogadorDaVez){
		listaLogradouroTabuleiro [jogadorDaVez.getPosicao ()].acao (jogadorDaVez);
	
	}

	public void setCasaDaVez(ILogradouro casaDaVez){
		this.casaDaVez = casaDaVez;
	}
	public ILogradouro getCasaDaVez(){
		return this.casaDaVez;
	}
	

}
