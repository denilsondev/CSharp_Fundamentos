﻿using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Console.WriteLine("Boas vindas ao ByteBank Administração!\n");

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

Funcionario andre = new Funcionario();
andre.Nome = "André";
andre.CPF = "546.879.157-20";
andre.Salario = 2000;

gerenciador.Registrar(andre);

Diretor maria = new Diretor();
maria.Nome = "Maria";
maria.CPF = "454.658.148-3";
maria.Salario = 5000;

gerenciador.Registrar(maria);

Console.WriteLine(andre.Nome);
Console.WriteLine(andre.GetBonificacao());

Console.WriteLine(maria.Nome);
Console.WriteLine(maria.GetBonificacao());

Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());