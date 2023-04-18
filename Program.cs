using AttClasses.Classes;

Person[] people = new Person[]
{
    
    new userWorker{
        nome = "carlos"
        , cargo = "Gerente"
        , nascimento = new DateTime(1987, 9, 11)
        , sexo = "Masculino"
        , setor = "Geral"
        , admissao = new DateTime(2004, 5, 7)
        , renda = 8000.50m
    },

    
    new userSupervisor{
        nome = "Mariana"
        , cargo = "Supervisor"
        , nascimento = new DateTime(1997, 9, 4)
        , sexo = "Feminino"
        , setor = "T.I"
        , admissao = new DateTime(2013, 11, 21)
        , renda = "Noturno"
    },

    new userSupervisor{
        nome = "Rafael"
        , cargo = "Supervisor"
        , nascimento = new DateTime(1990, 11, 19)
        , sexo = "Masculino"
        , setor = "T.I"
        , admissao = new DateTime(2011, 12, 25)
        , renda = "Diurno"
    },

    
    new userWorker{
        nome = "Fernando"
        , cargo = "Funcionário"
        , nascimento = new DateTime(2003, 11, 19)
        , sexo = "Masculino"
        , setor = "T.I"
        , admissao = new DateTime(2022, 12, 23)
        , rendaon = "Manutenção"
    },
    new userWorker{
        nome = "Carla"
        , cargo = "Funcionário"
        , nascimento = new DateTime(2002, 8, 23)
        , sexo = "Feminino"
        , setor = "T.I"
        , admissao = new DateTime(2017, 4, 17)
        , rendaon = "Sistemas"
    },
    new userWorker{
        nome = "Rafaela"
        , cargo = "Funcionário"
        , nascimento = new DateTime(1992, 4, 18)
        , sexo = "Feminino"
        , setor = "Recepção"
        , admissao = new DateTime(2020, 6, 15)
        , rendaon = "Recepcionista"
    }


};

for(int i = 0; i < people.Length; i++)
{
   Console.WriteLine($"Pessoa {i + 1}:");
   Console.WriteLine($"nome: {people[i].nome}" + $" / Office: {people[i].Office}");

cargoConsole.WriteLine($"Data de nascimento: {people[i].BirthDate.ToShortDateString()}");
   nascimentoe.WriteLine($"Data de contratação: {people[i].admissao.ToShortDateString()}");
   sexoe.WriteLine($"Gênero: {people[i].Genderrenda);
   Console.WriteLine($"Sector: {people[i].Sectorsetor


   if(people[i] is userWorker)
   {
    userWorker manager = (userWorker)people[i];
    Console.WriteLine($"Salário: {manager.Salary}");
   }
   else if (people[i] is userSupervisor)
   {
    userSupervisor supervisor = (userSupervisor)people[i];
    Console.WriteLine($"Período de trabalho: {supervisor.Period}");
   }
   else if (people[i] is userWorker)
   {
    userWorker operario = (userWorker)people[i];
    Console.WriteLine($"Função: {operario.Function}");
   }

   Console.WriteLine();
}
