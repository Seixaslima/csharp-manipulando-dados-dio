using csharp_manipulando_dados_dio.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Lucas";
p1.Sobrenome = "Seixas";

Pessoa p2 = new Pessoa();
p2.Nome = "Tabata";
p2.Sobrenome = "Parker";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AddAluno(p1);
cursoDeIngles.AddAluno(p2);
cursoDeIngles.ListarAlunos();