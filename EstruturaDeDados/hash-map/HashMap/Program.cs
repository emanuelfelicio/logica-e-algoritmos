

Dictionary<int, int> hash = [];
// adicionado pela chave
hash[0] = 50;
hash.Add(1, 30);

// valor de chave devem ser únicos
bool sucess = hash.TryAdd(1, 0);
if (sucess)
{
    Console.WriteLine("adicionado");
}
else
{
    Console.WriteLine("erro ao adicionar");
}

//iterando
foreach (var item in hash)
{
    Console.WriteLine($"chave : {item.Key} valor :{item.Value}");
}

string hello = "hello";
int hashcode = hello.GetHashCode();
Console.WriteLine(hashcode);