using Micro_editor_de_texto___Arquivo;

List<Product> products = new();

string path = @"C:\Users\Paola\Documents\Aulas\Projetos_C#\Micro editor de texto - Arquivo\Micro editor de texto - Arquivo\bin\Debug\net6.0";
string file = "products.txt";

Console.WriteLine(">>>> CADASTRO DE PRODUTOS <<<<");

#region createProduct
Product CreateProduct()
{
    Console.WriteLine("Informe um id:");
    int id = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe a descrição do produto: ");
    string description = Console.ReadLine();

    Console.WriteLine("Informe o preço do produto:");
    double price = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a quantidade disponível:");
    int quantity = int.Parse(Console.ReadLine());

    return new Product (id, description, price, quantity);
}
#endregion

#region showAll
/*
 * Na função com void, não tem retorno.
 * O "retorno" está no Console.WriteLine();
 */
void ShowAll(List<Product> receivedlist)
{
    foreach (var product in receivedlist)
    {
        Console.WriteLine(product.ToString());
    }
}
#endregion

void SaveFile(List<Product> list, string pathFile, string fileCreated)
{
    if (!Directory.Exists(pathFile)) //Se o meu diretório não existe no meu caminho...
    {
        // ...tem que criar
        Directory.CreateDirectory(pathFile);
    }
    if (!File.Exists(pathFile + fileCreated))
    {
        File.Create(pathFile + fileCreated);
    }

    StreamWriter sw = new(pathFile + fileCreated);

    foreach (var item in list)
    {
        sw.WriteLine(item.ToString());
    }
}

List<Product> LoadFile(string p, string f) //
{
    if (CheckIfExits(p, f))
    {
        StreamReader sr = new(p + f);
        List<Product> listProducts = new();

        foreach (var linha in File.ReadAllLines(path + file))
        {
            Console.Write(linha);
        }
    }
}

//Execução do Programa
products.Add(CreateProduct());

Console.WriteLine();
products.Add (CreateProduct());

Console.WriteLine();
ShowAll(products);

Console.WriteLine();
SaveFile(products, path, file);
