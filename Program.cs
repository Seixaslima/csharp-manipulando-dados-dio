using csharp_manipulando_dados_dio.Models;

//mudando localização globalmente
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");


//Formatação de valores monetarios
decimal ValorMonetario = 1485.37M;
Console.WriteLine($"{ValorMonetario:c}");



//Aulas anteriores
// Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Seixas");

// Pessoa p2 = new Pessoa(sobrenome: "Parker", nome: "Thabata");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AddAluno(p1);
// cursoDeIngles.AddAluno(p2);
// cursoDeIngles.ListarAlunos();