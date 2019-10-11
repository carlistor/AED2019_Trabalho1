using System;
using System.Collections.Generic;
namespace project{
public class Desaparecidos{
private string _nome;
private int _idade;
private int _corDePele;
private int _sexo;
private int _corteDeCabelo;
private int _barba;
private double _peso;
private int _perfilFisico;
private double _altura;

   public string Nome 
   {
      get => _nome;
      set => _nome = value;
   }

   public int Idade
   {
      get => _idade;
      set => _idade = value; 
   }

   public int CorDePele
   {
     get => _corDePele;
     set => _corDePele = value;
   }
   public int Sexo
   {
     get => _sexo;
     set => _sexo = value;
   }
   public int CorteDeCabelo
   {
     get => _corteDeCabelo;
     set => _corteDeCabelo = value;
   }
   public int Barba
   {
     get => _barba;
     set => _barba = value;
   }
   public double Peso
   {
     get =>_peso;
     set =>_peso = value;
   }
   public int PerfilFisico
   {
     get => _perfilFisico;
     set => _perfilFisico=value;
   }
   public double Altura
   {
     get => _altura;
     set => _altura = value;
   }
  }
}