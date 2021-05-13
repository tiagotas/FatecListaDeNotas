using System;
using System.Collections.Generic;
using System.Text;

namespace ListaDeNotas
{
    public class Aluno
    {
        public int Ra { set; get; }
        public string Nome { set; get; }
        public double Trabalho { set; get; }
        public double Exercicios { set; get; }
        public double Prova { set; get; }
        public double Media 
        { 
            get => (Trabalho+Prova+Exercicios)/3; 
        }
    }
}
