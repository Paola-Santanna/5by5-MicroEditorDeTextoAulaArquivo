//Aula 14 - Tratamento de Arquivos

using Microsoft.Win32.SafeHandles;

string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Dados\\";
/*
 * Na linha acima está o modelo de endereço do arquivo, mas que vai ser possível de rodar em computadores diferentes.
 * 
 * O @ demonstra que o que está estrito tem caractere especial; aqui será escrito o caminho do arquivo
 */

string file = "arquivo.txt"; //nome e extensão do arquvo

if (!Directory.Exists(path))
    Directory.CreateDirectory(path);

if (File.Exists (path+file))
{
    StreamReader sr = new StreamReader(path+file);
    string s = sr.ReadToEnd();
    Console.Clear();
    Console.WriteLine(s);
    sr.Close();

    s += "\n";
    s += Console.ReadLine();

    StreamWriter sw = new(path + file);
    sw.WriteLine(s);
    sw.Close();

    Console.Clear();
    Console.WriteLine("Conteúdo do arquivo:");
    StreamReader sr2 = new(path + file);
    Console.WriteLine(sr2.ReadToEnd());
    sr2.Close();

    File.ReadLines(path + file).Skip(2).Take(1).First();
    File.ReadLines(path + file).ElementAt(2);
}

/**
if(!Directory.Exists(path+file)) //Vai verificar se o diretório existe ou não. Se não existir, ele pula para o próximo diretório. Se existir, pula para as próximas linhas de código
    Directory.CreateDirectory(path);

StreamWriter sw = new(path + file); //Tem que passar como parâmetro o caminho e o nome do arquivo

Console.WriteLine("Informe seu nome:");
string s = Console.ReadLine();

Console.WriteLine("Informe seu email: ");
s = Console.ReadLine();

sw.WriteLine(s);
sw.Close();

StreamReader sr = new(path + file);

Console.Clear();
Console.WriteLine(sr.ReadToEnd());

/*
 * ReadLine() - retorna o que foi digitado, mas só 1 coisa
 * ReadToEnd() - retorna e imprime tudo que está no arquivo
 */

//sr.Close();