using csharp_manipulando_dados_dio.Models;
// Formatando e usando DateTime

DateTime date = DateTime.Now;

Console.WriteLine(date);
Console.WriteLine(date.ToString("dd-MM-yyyy HH-mm"));
Console.WriteLine(date.ToString("dd/MM/yyyy hh-mm"));
Console.WriteLine(date.ToString("yyyy-MM-dd hh-mm"));
Console.WriteLine(date.ToString("yy-MM-dd hh-mm"));
Console.WriteLine(date.ToShortDateString());
Console.WriteLine(date.ToShortTimeString());




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