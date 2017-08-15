using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ControladorArquivos {
	private string _caminho;

	public ControladorArquivos(){
		this._caminho = Application.dataPath;
	}

	public bool validarDiretorio(string nome){
		return Directory.Exists (this._caminho+"/"+nome);
	}

	public bool validarArquivo(string nome){
		return File.Exists (this._caminho+"/"+nome);
	}

	public void criarDiretorio(string nome){
		if (this.validarDiretorio (nome)) {
			Debug.Log("Esse diretorio ja existe.");
		} else {
			Directory.CreateDirectory(this._caminho+"/"+nome);
		}
	}

	public void criarArquivo(string nome, string conteudo){
		if (this.validarArquivo (nome)) {
			Debug.Log("Esse arquivo ja existe");
		} else {
			var arquivo = File.CreateText(this._caminho+"/"+nome);
			arquivo.WriteLine(conteudo);
			arquivo.Close();
		}
	}
}
