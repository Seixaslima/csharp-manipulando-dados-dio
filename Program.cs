using System.Globalization;
using csharp_manipulando_dados_dio.Models;
using Newtonsoft.Json;

//Serialização

List<Venda> listaVenda = [];

Venda v1 = new(1, "Material de escritorio", 10.50M,DateTime.Now);
Venda v2 = new(2, "Produtos de beleza", 17.99M,DateTime.Now);

listaVenda.Add(v1);
listaVenda.Add(v2);

string vendaSerializada = JsonConvert.SerializeObject(listaVenda, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", vendaSerializada);

Console.WriteLine(vendaSerializada);


// Descontrutor

// Pessoa p1 = new Pessoa("Jose", "Santos");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");


// //Tuplas

// LeituraArquivo arquivo = new LeituraArquivo();

// //Descarte de informação
// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//   //Console.WriteLine($"Arquivo com {numeroLinhas} linhas");
//   foreach (string linha in linhasArquivo)
//   {
//     Console.WriteLine(linha);
//   }
// }
// else
// {
//   Console.WriteLine("Não foi possivel ler o arquivo");
// }




// (int, string, string, decimal) tupla = (1, "Suco", "Maça", 5.30M);

// Console.WriteLine($"Id: {tupla.Item1} ");
// Console.WriteLine($"Produto: {tupla.Item2} ");
// Console.WriteLine($"Variação: {tupla.Item3} ");
// Console.WriteLine($"Preço: {tupla.Item4} ");

// //Tupla nomeada
// (int id, string produto, string variacao, decimal preco) tuplaNomeada = (1, "Suco", "Maça", 5.30M);
// Console.WriteLine($"Id: {tuplaNomeada.id} ");
// Console.WriteLine($"Produto: {tuplaNomeada.produto} ");
// Console.WriteLine($"Variação: {tuplaNomeada.variacao} ");
// Console.WriteLine($"Preço: {tuplaNomeada.preco} ");

// // Outras formas de criar tuplas
// ValueTuple<int, string, string, decimal> outroTipoTupla = (1, "Suco", "Maça", 5.30M);
// var variacaoDeTupla = Tuple.Create(1, "Suco", "Maça", 5.30M);


// //Execuçoes e exeçoes

// /* throw */
// try
// {
//   new ExemploExcecao().Metodo1();
// }
// catch (Exception ex)
// {
//   Console.WriteLine($"Exceção tratada: {ex.Message}");
//   Console.WriteLine($"StackTrace: {ex.StackTrace}");
// }



/*try catch

try
{

  string[] linhas = File.ReadAllLines("./Arquivos/arquivoLeitura.txt");

  foreach (string linha in linhas)
  {
    Console.WriteLine(linha);
  }
}
catch (FileNotFoundException ex)
{

  Console.WriteLine($"Ocorreu uma exceção arquivo não encontrado: {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{

  Console.WriteLine($"Ocorreu uma exceção pasta não encontrada: {ex.Message}");
}
catch (Exception ex)
{

  Console.WriteLine($"Ocorreu uma exceção Generica: {ex.Message}");
}
finally
{
  Console.WriteLine("Executando bloco finally");
} */



/* Formatando e usando DateTime

//parse de data
DateTime date = DateTime.Parse("15/01/1946 17:23:15");
// DateTime date = DateTime.Parse("32/01/1946 17:23:15");
//Gera uma exeção e para o programa
Console.WriteLine(date);

string DataString = "2024-17-01 18:00";

bool sucesso = DateTime.TryParseExact(DataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTryParse);

if (sucesso)
{
  Console.WriteLine($"Conversão com sucesso, Data: {dateTryParse}");
}
else
{
  Console.WriteLine($"A string {DataString} não é uma data valida");
}

*/


/*
//Formatando DateTime
DateTime date = DateTime.Now;

Console.WriteLine(date);
Console.WriteLine(date.ToString("dd-MM-yyyy HH-mm"));
Console.WriteLine(date.ToString("dd/MM/yyyy hh-mm"));
Console.WriteLine(date.ToString("yyyy-MM-dd hh-mm"));
Console.WriteLine(date.ToString("yy-MM-dd hh-mm"));
Console.WriteLine(date.ToShortDateString());
Console.WriteLine(date.ToShortTimeString());

*/


/*
//mudando localização globalmente
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");


//Formatação de valores monetarios
decimal ValorMonetario = 1485.37M;
Console.WriteLine("Usando a cultura especificada do programa");
Console.WriteLine($"{ValorMonetario:c}");

//Formatando de forma local 
Console.WriteLine("Mudando a cultura especificamente nesse texto");
Console.WriteLine(ValorMonetario.ToString("c", CultureInfo.CreateSpecificCulture("pt-PT")));

// outras formas de formatar
Console.WriteLine(ValorMonetario.ToString("N2"));

//porcentagem
double porcentagem = 0.365;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));
Console.WriteLine(numero.ToString("##/##/##")); */

//Aulas anteriores
// Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Seixas");

// Pessoa p2 = new Pessoa(sobrenome: "Parker", nome: "Thabata");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AddAluno(p1);
// cursoDeIngles.AddAluno(p2);
// cursoDeIngles.ListarAlunos();
