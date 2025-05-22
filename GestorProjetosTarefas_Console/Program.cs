using GestorProjetosTarefas.Shared.Models;
using GestorProjetosTarefas.Shared.Data;
using GestorProjetosTarefas.Shared.Data.BD;

internal class Program
{
    public static Dictionary<string, Empregado> EmpregadoList = new();
    private static void Main(string[] args)
    {
        using var context = new GestorProjetosTarefasContext();
        var EmpregadoDAL = new DAL<Empregado>(context);

        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Você chegou no Gestor de Projetos e Tarefas!\n");
            Console.WriteLine("Digite 1 para registrar um empregado");
            Console.WriteLine("Digite 2 para registrar a tarefa de um empregado");
            Console.WriteLine("Digite 3 para mostrar todos os empregados");
            Console.WriteLine("Digite 4 para mostrar as tarefas de um empregado");
            Console.WriteLine("Digite -1 para sair\n");
            Console.WriteLine("Informe sua opção:");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    RegistrarEmpregado();
                    break;
                case 2:
                    RegistrarTarefa();
                    break;
                case 3:
                    ObterEmpregados();
                    break;
                case 4:
                    ObterTarefas();
                    break;
                case -1:
                    Console.Clear();
                    Console.WriteLine("Até mais!");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            //Thread.Sleep(2000);
            //Console.Clear();
        }

        void RegistrarEmpregado()
        {
            Console.Clear();
            Console.WriteLine("Registro de Empregados\n");
            Console.Write("Digite o nome do empregado que deseja registrar: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a matricula do empregado que deseja registrar: ");
            string matricula = Console.ReadLine();
            Empregado empregado = new(nome, matricula);
            //EmpregadoList.Add(matricula, empregado);
            EmpregadoDAL.Create(empregado);
            Console.WriteLine($"O empregado {nome} foi registrado com sucesso!");
            Console.ReadKey();
        }

        void ObterEmpregados()
        {
            Console.Clear();
            Console.WriteLine("Lista de empregados:\n");
            foreach (var empregado in EmpregadoDAL.Read())
            {
                Console.WriteLine(empregado);
            }
            Console.ReadKey();
        }

        void ObterTarefas()
        {
            Console.Clear();
            Console.WriteLine("Exibir detalhes do empregado\n");
            Console.Write("Digite o empregado cujas tarefas deseja consultar: ");
            string matricula = Console.ReadLine();
            var targetEmpregado = EmpregadoDAL.ReadBy(x => x.Matricula.Equals(matricula));

            if (targetEmpregado is not null)
            {
                targetEmpregado.showTarefas();
            }
            else Console.WriteLine($"\nO empregado de matrícula {matricula} não foi encontrado");
            Console.ReadKey();
        }

        void RegistrarTarefa()
        {
            Console.Clear();
            Console.WriteLine("registro de tarefas\n");
            Console.WriteLine("digite o matrícula do empregado cuja categoria deseja registrar: ");
            string matricula = Console.ReadLine();
            var targetEmpregado = EmpregadoDAL.ReadBy(x=>x.Matricula.Equals(matricula));

            if (targetEmpregado is not null)
            {
                Console.WriteLine($"informe o nome da tarefa do empregado {targetEmpregado.Nome}: ");
                string nome = Console.ReadLine();
                Console.WriteLine($"informe a descrição da tarefa {nome}: ");
                string descricao = Console.ReadLine();
                Console.WriteLine($"informe a duração da tarefa {nome} em dias : ");
                int duracaodias = int.Parse(Console.ReadLine());
                //equipment equipment = equipmentlist[equipmentname];
                targetEmpregado.adicionarTarefas(new Tarefa(nome, descricao, duracaodias));
                EmpregadoDAL.Update(targetEmpregado);
                Console.WriteLine($"a tarefa {nome} do {targetEmpregado.Nome} foi registrada com sucesso!");
            }
            else Console.WriteLine($"\no empregado de matrícula {matricula} não foi encontrado");
            Console.ReadKey();
        }

    }




}