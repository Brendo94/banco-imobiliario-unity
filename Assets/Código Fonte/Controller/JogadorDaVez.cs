using System.Collections.Generic;

public class JogadorDaVez {

	int idJogadorJogadorDaVez= 0;
	List<Jogador> jogadores = new List<Jogador>();
	public JogadorDaVez(){
		jogadores.Add (new Jogador (0, 2000));
		jogadores.Add (new Jogador (1, 2000));
		}


	public Jogador getJogadorDaVez(){
		return jogadores [idJogadorJogadorDaVez];
	}
	public void proximoJogador(){
		if (idJogadorJogadorDaVez == 0)
						idJogadorJogadorDaVez = 1;
				else
						idJogadorJogadorDaVez = 0;
	}

}
