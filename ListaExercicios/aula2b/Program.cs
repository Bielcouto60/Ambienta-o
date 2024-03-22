// See https://aka.ms/new-console-template for more information
//Criar um vetor 
int[] vetor = new int[100];
Random aleatorio = new Random();

//Preencher valores aleatórios no vetor
for(int i = 0; i < vetor.Length; i++){
    vetor[i] = aleatorio.Next(100);
}
//imprimir os vetores
for(int i = 0; i < vetor.Length; i++){
    Console.Write(vetor[i] + "-");
}
//Ordenar o vetor com Bubble Sort 
Array.Sort(vetor);

Console.WriteLine("\n");
//imprimit os vetores
for(int i = 0; i < vetor.Length; i++){
    Console.Write(vetor[i] + "-");
}
