using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1Grupo
{
	public class Retangulo
	{
		private double Largura = 3;

		private double Altura = 4;

		public void Area()
		{
			double area = Largura * Altura;
			Console.WriteLine("Area = {0}", area.ToString("F2"));

		}

        public void Perimetro()
		{
			double perimetro = Largura+Largura+Altura+Altura;
			Console.WriteLine("Perimetro = {0}", perimetro.ToString("F2"));

		}

        public void Diagonal()
		{
			double diagonal = Math.Pow(Largura,2) + Math.Pow(Altura,2);
			diagonal = Math.Sqrt(diagonal);
			Console.WriteLine("Diagonal = {0}", diagonal.ToString("F2"));

		}
	}
}

