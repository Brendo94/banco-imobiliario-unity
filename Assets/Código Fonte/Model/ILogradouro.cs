public interface ILogradouro {
	/// <summary>
	/// Posição da casa.
	/// </summary>
	//int indice;



	/// <summary>
	/// É executado quando o jogador para em uma casa.
	/// </summary>
	bool acao(Jogador j1);


	/// <summary>
	/// Retorna o índice (posição) do logradouro em que se encontra.
	/// </summary>
	/// <returns>O indice.</returns>
	int getIndice();

}
