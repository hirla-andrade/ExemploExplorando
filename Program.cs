using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Hirla";
p1.Sobrenome = "Andrade";

Pessoa p2 = new Pessoa();
p2.Nome = "Eduardo";
p2.Sobrenome = "Nerves Queiroz";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();


















// Pessoa p1 = new Pessoa();
// p1.Nome = "Hirla";
// p1.Sobrenome = "Andrade";
// p1.Idade = 19;
// p1.Apresentar();