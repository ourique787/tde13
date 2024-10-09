Empresa empresa = new Empresa();
Funcionario f1 = new Funcionario("Wellington", 20);
Gerente gerente = new Gerente("Lucas", 22, 5000.0);
Estagiario estagiario = new Estagiario("Edmo", 30);

empresa.AdicionarFuncionario(f1);
empresa.AdicionarFuncionario(gerente);
empresa.AdicionarFuncionario(estagiario);

empresa.ListarFuncionario();
