using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJogador : MonoBehaviour {
	private ControladorArquivos _ctlArquivos;

	// Use this for initialization
	void Start () {
		_ctlArquivos = new ControladorArquivos ();
		//_ctlArquivos.criarDiretorio ("dados");
		//_ctlArquivos.criarArquivo ("dados/player.json",JsonUtility.ToJson(new Player("Teste",10)));

		Player _player = _ctlArquivos.lerJson<Player>("dados/player.json");
		print (_player.nome);
		print (_player.level);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
