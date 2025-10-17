Queue<string> test = new(30);

//adicionando elementos
test.Enqueue("one");
test.Enqueue("two");
test.Enqueue("three");
// capacidade da fila
Console.WriteLine(test.Capacity);
//quantidade de elemetnos na fila
Console.WriteLine(test.Count);
// acessando primeiro valor 
Console.WriteLine(test.Peek());
// removendo primeiro elemento
test.Dequeue();
// removendo espaços vazios na fila
test.TrimExcess();
