using System;

namespace POO_Polimorfismo_Sobrecarga.Classes
{
    public class Funcionario
    {
        private string Name {get; set;}

        public string[] lista = {"Paulo", "Regis", "Denis", "Luana" };

            public void Mostrar(){
                foreach (var item in lista)
                {
                    Console.WriteLine(item);
                }
            }

            public void Mostrar(int indice){

                Console.WriteLine(lista[indice]);
            }

            public void Mostrar(string busca){

                foreach (var item in lista)
                {
                    if (item == busca)
                    {
                        Console.WriteLine("Resultado da Busca: " +item);
                    }
                }
            }
        }

    }
