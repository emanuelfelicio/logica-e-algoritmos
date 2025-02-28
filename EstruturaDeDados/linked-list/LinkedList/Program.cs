LinkedList<string> list = new LinkedList<string>();



list.AddFirst("Hello");
list.AddLast("World");
list.AddLast("test");
list.Remove("test");

// adicionando depois de um nó especificado
LinkedListNode<string>? node = list.Find("World");
if (node != null)
{
    list.AddAfter(node, "Guys");
}




//printando LinkedList
foreach (var item in list)
{
    Console.WriteLine(item);
}

List<int> liist = [4, 1, 2, 3, 4];
liist.Remove(liist[0]);
foreach (var item in liist)
{
    Console.WriteLine(item);
}

