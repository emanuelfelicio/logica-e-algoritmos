PriorityQueue<string, int> priority = new();

priority.Enqueue("abacaxi", 1);
priority.Enqueue("arroz", 3);
priority.Enqueue("abacaxii", 3);
priority.Enqueue("feijao",3);
priority.Enqueue("feijao preto", 3);
priority.Enqueue("feijao verde", 3);


while (priority.Count > 0)
{
    var item = priority.Dequeue();
    Console.WriteLine(item);
}