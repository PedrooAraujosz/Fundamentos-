using Fundamentos;

internal class Program
{
    private static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        aluno1.None = "Pedro Araújo";
        aluno1.RM = "4448TI";
        aluno1.Email = "mxpedro.araujo11@gmail.com";
        aluno1.Nascimento = new DateOnly(2007, 09, 27);


        Aluno aluno2 = new Aluno();
        aluno2.None = "Erick Penazzi";
        aluno2.RM = "4364TI";
        aluno2.Email = "Djerickdev@gmail.com";
        aluno2.Nascimento = new DateOnly(2007, 07, 17);

        Aluno aluno3 = new Aluno();
        aluno3.None = "Thiago Vanucci";
        aluno3.RM = "4413TI";
        aluno3.Email = "Thiago.dev24@gmail.com";
        aluno3.Nascimento = new DateOnly(2007, 12, 07);

        Console.WriteLine("aluno1");
        Console.WriteLine("Nome " + aluno1.None);
        Console.WriteLine("RM " + aluno1.RM);
        Console.WriteLine(aluno1.Email);
        Console.WriteLine("Email: " + aluno1.Email);
        Console.WriteLine("Nascimento " + aluno1.Nascimento);
        Console.WriteLine("===================================");

        Console.WriteLine("aluno2");
        Console.WriteLine("Nome " + aluno1.None);
        Console.WriteLine("RM " + aluno1.RM);
        Console.WriteLine(aluno1.Email);
        Console.WriteLine("Email: " + aluno1.Email);
        Console.WriteLine("Nascimento " + aluno1.Nascimento);
        Console.WriteLine("===================================");


        Console.WriteLine("aluno3");
        Console.WriteLine("Nome " + aluno1.None);
        Console.WriteLine("RM " + aluno1.RM);
        Console.WriteLine(aluno1.Email);
        Console.WriteLine("Email: " + aluno1.Email);
        Console.WriteLine("Nascimento " + aluno1.Nascimento);
        Console.WriteLine("===================================");


        Produto p1 = new Produto();
        p1.Nome = "Coca-Cola 2 Litros";
        p1.Preco = 12.99;
        p1.Estoque = 96;

        //Chamar o metodo QuantidadeEstoque
        p1.QuantidadeEstoque();
        p1.Estoque = 86;
        p1.QuantidadeEstoque();



        Console.WriteLine("===================================");
        Console.WriteLine();

        //instanciar um objeto do tipo Carro
        Carro carro1 = new Carro();
        carro1.Marca = "Ferrari";
        carro1.Modelo = "488";
        carro1.Velocidade = 80;

        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();

        Console.WriteLine("===================================");
        Console.WriteLine();

        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "Pedro";
        pessoa1.Idade = 19;

        pessoa1.Envelhecer(5);
        pessoa1.Envelhecer(2);



        Console.WriteLine("===================================");
        Console.WriteLine();

        Funcionario func1 = new Funcionario();
        func1.Nome = "wilian";
        func1.Idade = 22;
        func1.Cargo = "aprendiz";
        func1.Salario = 1400.00;
        func1.ApresentarSe();



        Console.WriteLine("===================================");
        Console.WriteLine();


        Animal animal1 = new Animal()


        animal1.Especie = "cachorro";

        animal1.emitirsom();


        Console.WriteLine("O animal " + animal1.Especie + "emitiu um som.");


        Gato gato1 = new Gato();
        gato1.Nome = "frajola";
        Console.WriteLine(gato1.Nome + " faz:");
        gato1.emitirsom();

        Console.WriteLine("===================================");
        Console.WriteLine();

        Porco porco1 = new Porco();
        porco1.Nome = "pig boy";
        Console.WriteLine(porco1.Nome + " faz:");
        porco1.emitirsom();

        Console.WriteLine("===================================");
        Console.WriteLine();


        Galinha galinha1 = new Galinha();
        galinha1.Nome = "pit";
        Console.WriteLine(galinha1.Nome + " faz:");
        galinha1.emitirsom();


    }
}