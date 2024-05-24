using csharp_manipulando_dados_dio.Models;

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


//Aulas anteriores
// Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Seixas");

// Pessoa p2 = new Pessoa(sobrenome: "Parker", nome: "Thabata");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AddAluno(p1);
// cursoDeIngles.AddAluno(p2);
// cursoDeIngles.ListarAlunos();