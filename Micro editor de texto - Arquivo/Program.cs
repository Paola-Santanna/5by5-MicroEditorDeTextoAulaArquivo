//Aula 14 - Tratamento de Arquivos

string path = @"C:\Dados\"; //O @ demonstra que o que está estrito tem/é um caractere especial; aqui será escrito o caminho do arquivo
string file = "arquivo.txt"; //nome e extensão do arquvo

StreamWriter sw = new(); //Tem que passar como parâmetro o caminho e o nome do arquivo