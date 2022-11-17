using System;

namespace ejerc_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DIAS=5;
            const int SEMANA=4;
            
            int[ , ] arregloTemp = new int[SEMANA, DIAS];

        
            float  temperaturaMinima =arregloTemp[0 , 0], temperaturaMaxima=arregloTemp[0 , 0];
            int diaMax=arregloTemp[0 , 0], diaMin=300;
            

            

            Console.WriteLine(". . . REGISTRO DE TEMPERATURA . . . ");

            // registra las temperaturas ingresadas por el usuario
           for(int i=0; i<SEMANA; i++){

                for(int j=0; j< DIAS; j++ ){

                    Console.WriteLine("Ingrese temperatura, dia: {0} Semana: {1}", j+1 , i+1);
                    arregloTemp[i,j]=Convert.ToInt32(Console.ReadLine());

                }
            }
            

            for(int i=0; i< SEMANA; i++){
                for(int j=0; j< DIAS; j++){
                    if(diaMax < arregloTemp[i , j]){
                        diaMax=arregloTemp[i , j];
                    }
                    if(diaMin > arregloTemp[i , j]){
                        diaMin=arregloTemp[i , j];
                    }

                }

                Console.Clear();
                Console.WriteLine("LA TEMPERATURA MAXIMA FUE: " + diaMax);
                Console.WriteLine("LA TEMPERATURA MINIMA FUE: " + diaMin);


            }


           }

           
        }
}

