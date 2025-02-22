//inicializando linked-list vazia
LinkedList<string> strinLinked = new LinkedList<string>();

// inicializando com elementos copiados do (IEnumerable<T>)
List<int> list = [0,2,3,4,5,6];
LinkedList<int> linked = new LinkedList<int>(list);

foreach (var item in linked)
{
    Console.WriteLine(item);
}


