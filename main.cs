using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

    List<string> carros = new List<string>();
    List<double> consumo = new List<double>();
    //Carros e gastos por km
    carros.Add("Uno");
    consumo.Add(9.5);   
    carros.Add("Eco-sport");
    consumo.Add(12.7);  
    carros.Add("Porshe");
    consumo.Add(15.5);       
    carros.Add("Mercedes");
    consumo.Add(12.4);

    string carroEconomico = carros[0];
    double consumoEconomico = consumo[0];

    for(int i = 1; i < carros.Count ; i++){
     if(consumo[i] > consumoEconomico){
        carroEconomico = carros[i];
        consumoEconomico = consumo[i];
      }
    }
    //printar o menu com as informações!  
    Console.WriteLine("----------------------MENU----------------------\nCarro mais Economico: " + carroEconomico + "\nConsumo do Carro Economico: " + consumoEconomico.ToString("C"));
   
    for(int i = 0; i < carros.Count ; i++ ){
      double valorLitro = ( 1000 / consumo[i] ) * 4.89 ;
      Console.WriteLine("Carro: " + carros[i] + "\nValor: " + valorLitro.ToString("C"));     
    }
  }
}