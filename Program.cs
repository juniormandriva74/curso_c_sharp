using System;

class Principal {

    enum DiasSemana{Domingo,Segunda,Terca,Quarta,Quinta,Sexta,Sabado}; //Referente a aula 10
    static void Main() {

        // Aula 10 - Enumeradores (enum)

        DiasSemana ds = DiasSemana.Domingo;
        Console.WriteLine(ds);

        DiasSemana ds2 = (DiasSemana)3;
        Console.WriteLine(ds2);

        // Aula 09 - Operações de Bitwise
        // Para a esquerda dobra o valor, 
        // para a direita reduz o valor a metade
        /*

        int num=10;
        num=num>>1;

        Console.WriteLine(num);
        */

        // Aula 08 - Lendo valores do teclado
        /*

        int v1, v2, soma;
        //string nome;

        Console.WriteLine("Digite o primeiro número: ");
        v1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        v2 = Convert.ToInt32(Console.ReadLine());

        soma = v1+v2;

        Console.WriteLine($"A soma de {v1} mais {v2} é igual a {soma}");
        */

        // Aula 07 - Constantes
        /*

        const string canal="cfbcursos";
        const double pi=3.1416;

        Console.WriteLine($"Canal: {canal}");
        Console.WriteLine($"Constante PI: {pi}");
        */

        // Aula 06 - Formatando a saída no console
        // Usando formatações especiais para porcentagem e valor monetário
        /*

        double valorCompra=105.50;
        double valorVenda;
        double lucro=0.1;
        string produto="memoria ram";

        valorVenda=valorCompra+(valorCompra*lucro);

        Console.WriteLine("Produto........:{0,15}",produto);
        Console.WriteLine("Val. Compra....:{0,15:c}",valorCompra);
        Console.WriteLine("Lucro..........:{0,15:p}",lucro);
        Console.WriteLine("Val. Venda.....:{0,15:c}",valorVenda);

            //int n1, n2, n3;

            //n1=10; n2=20; n3=30;

            //Console.WriteLine("N1=" +n1+ " N2=" +n2+ " N3=" +n3);
            //Console.WriteLine("N1={0}, N2={1}, N3={2}",n1,n2,n3);
            //Console.WriteLine($"N1={n1}, N2={n2}, N3={n3}"); */


         //Aula 05 - Operadores e operações
         /* //int num=10;
        //num=num+1;
        //num+=1;

        bool res = (5<7);

        Console.WriteLine(res); */
    }
}
