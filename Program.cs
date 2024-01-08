using ExemploExplorando.Models;
using System.Globalization;

// - - - - - LISTA DICTIONARY - - - - - - - - serve para adivionar valores com chave única 

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

Console.WriteLine(estados["MG"]); //chama um dos valores da lista

// foreach(var item in estados) {
//     Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}"); // Key e Value são LETRAS MAIUSCULAS, DEPOIS DE . É LETRA MAIUSCULA
// }

// Console.WriteLine("-----------------");

// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado"; //manipula um dictionary com colchetes usando a chave

// foreach(var item in estados) {
//     Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }


// // VERIFICANDO SE VALOR JÁ EXISTE 
// string chave = "BA";

// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave)) //verificar se a chave já existe
// {
//         Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existente. É seguuro adicionar a chave: {chave}");
// }










// // - - - - - LISTA STACK - - - - - - 
// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha){
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento ao topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach(int item in pilha) {
//     Console.WriteLine(item);
// }







// // - - - - LISTA Queue - insere um elemento no final da fila e pra remover um elemento, é sempre o primeiro da fila
// Queue<int> file = new Queue<int>(); 

// file.Enqueue(2);
// file.Enqueue(4);
// file.Enqueue(6);
// file.Enqueue(8);

// foreach(int item in file) {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {file.Dequeue()}"); //só remove o 1° da fila
// file.Enqueue(10);

// foreach(int item in file) {
//     Console.WriteLine(item);
// }








// - - - - - - - - TRATANDO EXCEÇÕES - - - - - - 

//new ExemploExcecao().Metodo1();




    //string[] linhasExemplo = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
    //Console.WriteLine("Chegou até aqui");

// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// } 
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado" + ex.Message);
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }

// finally {
//     Console.WriteLine("Chegou até aqui"); //finally vem depois dos catchs, executa um bloco de código no final da execução
// }





















// - - - - - - DATE TIME - - - - - - - - 

// string dataString = "2022-04-14 09:00";

// DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }


// Console.WriteLine(data);

//Só anotações esses de baixo
// //DateTime data = DateTime.Parse(dataString);
// //DateTime data = DateTime.Parse("17/04/2022 18:00"); //pode usar DateTime.Now para pegar a hora exata do sistema
// //Console.WriteLine(data.ToShortTimeString()); //só exibi hora

// //Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); //MM é mês e mm é minuto, HH é hora formato 24h e hh é hora formato 12 horas(fica confuso)










// - - - - - - - - - VALOR MONETARIO - - - - - - - - -

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