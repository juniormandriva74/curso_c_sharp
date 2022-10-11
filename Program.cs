using System;

class Principal {

    static void Main() {

        // Aula 06 - Formatando a saída no console
        // Usando formatações especiais para porcentagem e valor monetário

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
            //Console.WriteLine($"N1={n1}, N2={n2}, N3={n3}");


         //Aula 05 - Operadores e operações
         /* //int num=10;
        //num=num+1;
        //num+=1;

        bool res = (5<7);

        Console.WriteLine(res); */
    }
}
