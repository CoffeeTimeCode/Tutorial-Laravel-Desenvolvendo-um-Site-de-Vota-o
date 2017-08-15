using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJogador : MonoBehaviour {
	private ControladorArquivos _ctlArquivos;

	// Use this for initialization
	void Start () {
		_ctlArquivos = new ControladorArquivos ();
		_ctlArquivos.criarDiretorio ("dados");
		_ctlArquivos.criarArquivo ("dados/player.json","Teste");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
