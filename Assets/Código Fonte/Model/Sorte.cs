

public class Sorte : ILogradouro {


	private int indice;
	private int testeSortes;

	public Sorte(int indice,int testeSortes){
		this.indice = indice;
		this.testeSortes = testeSortes;
	}

	// Criar uma coleção para o atributo OpçõesDeSorte...

	
	public bool acao(Jogador j){
		if (testeSortes == 1) {
						j.setPosicao (j.getPosicao () + 2);
						return false;		
				} else if (testeSortes == 2) {
						j.setPosicao (j.getPosicao () - 2);
						return false;	
				} else if (testeSortes == 3) {
			j.cobrarValor(200);
			return false;
		}if (testeSortes == 4) {
			j.setSaldo(j.getSaldo() +200 );
		}
		return false;	
	}
	
	
	public int getIndice(){
		return this.indice;
	}


	// Devemos criar uma classe para a cartaSorte com 2 atributos...
	private void modificaSaldo(){

	}


	// Devemos criar uma classe para a cartaSorte com 2 atributos...
	private void modificaPosicao(){

	}


	// Devemos sortear pelo indice da coleções e executar os métodos de acordo com o contexto...
	public void sorteia(){

		this.modificaSaldo();

		this.modificaPosicao();
	}
}
