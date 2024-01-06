using ExemploExplorando.Models;
using System.Globalization;

string dataString = "2022-04-14 09:00";

DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}

//DateTime data = DateTime.Parse(dataString);
//DateTime data = DateTime.Parse("17/04/2022 18:00"); //pode usar DateTime.Now para pegar a hora exata do sistema

Console.WriteLine(data);
//Console.WriteLine(data.ToShortTimeString()); //só exibi hora

//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); //MM é mês e mm é minuto, HH é hora formato 24h e hh é hora formato 12 horas(fica confuso)












// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.4M;
// Console.WriteLine(valorMonetario.ToString("C1")); // esse C é a quant de casas decimais nos numeros da moeda C2, C3. C4
// //Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); //alterando a localização/idioma da cultura

// double porcentagem = .3421; //porcentagem
// Console.WriteLine(porcentagem.ToString("p"));

// int numero = 123456; //data
// Console.WriteLine(numero.ToString("##-##-##")); //organização dos dígitos







// string numero1 = "10";
// string numero2 = "20";
// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);





// Pessoa p1 = new Pessoa(nome: "Hirla", sobrenome: "Andrade");
// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();







// Pessoa p1 = new Pessoa();
// p1.Nome = "Hirla";
// p1.Sobrenome = "Andrade";
// p1.Idade = 19;
// p1.Apresentar();