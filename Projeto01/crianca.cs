using System;

class Crianca {
  private int id;
  private string nome;
  private string sexo;
  private DateTime nasc;
  private int idResponsavel;
  public Crianca (int id, string nome, string sexo, DateTime nasc, int idResponsavel) {
    this.id = id;
    this.nome = nome;
    this.sexo = sexo;
    this.nasc = nasc;
    this.idResponsavel = idEspecie;
  }
  public void SetId(int id) {
    this.id = id;
  }

  public void SetNome(string nome){
    this.nome = nome;
  }
  
  public void SetSexo(string sexo){
    this.sexo = sexo;
  }

  public void SetNasc(DateTime nasc){
    this.nasc = nasc;
  }

  public void SetIdEspecie(int idEspecie) {
    this.idEspecie = idEspecie;
  }

  public int GetId() {
    return id;
    
  }
  public string GetNome() {
    return nome;
  }

  public string GetSexo() {
    return sexo;
  }

  public DateTime GetNasc() {
    return nasc;
  }

  public int GetIdEspecie() {
    return idEspecie;
    
  }


  public override string ToString() {
    return $"{id} - {nome} - {responsavel} - {nasc:dd/MM/yyyy}";
  }
}