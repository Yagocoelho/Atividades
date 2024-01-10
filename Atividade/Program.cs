
#region soma 2 numeros

Console.WriteLine("Somar dois numeros");
Console.WriteLine("Digite o primeiro numero: ");
var numero1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
var numero2 = Convert.ToInt16(Console.ReadLine()); ;
var result = numero1 + numero2;
Console.WriteLine("O resultado é: " + result);

#endregion

#region media de 4 valores
Console.WriteLine("Soma de media de 4 valores");
Console.WriteLine("Digite o primeiro valor: ");
var vl1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Digite o segundo valor: ");
var vl2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Digite o terceiro valor: ");
var vl3 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Digite o quarto valor: ");
var vl4 = Convert.ToInt16(Console.ReadLine());
var result = (vl1 + vl2 + vl3 + vl4) / 4;
Console.WriteLine("resultado da media é: " + result);
#endregion

#region concatenar de nomes
Console.WriteLine("Concatenar nome");
Console.WriteLine("Digite o primeiro nome: ");
var nome1 = (Console.ReadLine());
Console.WriteLine("Digite o nome meio: ");
var nome2 = (Console.ReadLine());
Console.WriteLine("Digite o ultimo nome: ");
var nome3 = (Console.ReadLine());
var result = nome1 + " " + nome2 + " " + nome3;
Console.WriteLine("O resultado é: " + result);
#endregion

#region forma de baskara

    Console.WriteLine("Calculo de Forma de baskara");
    Console.WriteLine("Digite o valor de a: ");
    var a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite ovalor de b: ");
    var b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o valor de c: ");
    var c = Convert.ToDouble(Console.ReadLine());


    var delta = (b * b) - (4 * a * c);
    var r1 = ((-b) + (Math.Sqrt(delta))) / (2 * a);
    var r2 = ((-b) - (Math.Sqrt(delta))) / (2 * a);
    Console.WriteLine("o valor de delta è: " + delta);

    Console.WriteLine("resposta 1: " + r1);
    Console.WriteLine("resposta 2: " + r2);

#endregion

#region ler dois numeros diferentes e mostrar o maior
Console.WriteLine("Leitor de numero maior");

Console.WriteLine("Digite o primeiro Valor");
var valor1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite o segundo Valor");
var valor2 = Convert.ToInt16(Console.ReadLine());

if (valor1 != valor2)
{
    if (valor1 > valor2)
    {
        Console.WriteLine("o maior numero é: " + valor1);
    }
    else { Console.WriteLine("o maior numero é: " + valor2); }
}
else { Console.WriteLine("numeros iguais!"); }

#endregion

#region ler valores diferentes e colocar em ordem crescente
Console.WriteLine("Numeros em ordem crescente");

Console.WriteLine("Digite o primeiro Valor");
var valor1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite o segundo Valor");
var valor2 = Convert.ToInt16(Console.ReadLine());

if (valor1 != valor2)
{
    if (valor1 > valor2)
    {
        Console.WriteLine("a ordem crescente é:" + valor2 + " " + valor1);
    }
    else { Console.WriteLine("a ordem crescente é: " + valor1 + " " + valor2); }
}
else { Console.WriteLine("numeros iguais!"); }
#endregion

#region leitor de maior que 10
Console.WriteLine("leitor de 10");

Console.WriteLine("digite o numero!");
var numero = Convert.ToInt16(Console.ReadLine());
if (numero > 10) { Console.WriteLine("É MAIOR QUE 10"); }
if (numero < 10) { Console.WriteLine("É MENOR QUE 10"); }
if (numero == 10) { Console.WriteLine("Número iguail á 10"); }
#endregion

#region IMC

Console.WriteLine("Calculador de IMC");
Console.WriteLine("Digite seu Peso em kg");
var peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite sua Altura");
var altura = Convert.ToDouble(Console.ReadLine());

var resultado = peso / (altura * altura);

if (resultado < 18.5) { Console.WriteLine("Peso "+resultado +" Abaixo do peso"); }
if (resultado > 25.6 && resultado < 24.9) { Console.WriteLine("Peso " + resultado + " peso ideal(Parabens)"); }
if (resultado > 25.6 && resultado < 29.9) { Console.WriteLine("Peso " + resultado + " Levemente acima do peso)");}
if (resultado > 30.0 && resultado < 34.9) { Console.WriteLine("Peso " + resultado + " obesidade grau 1"); }
if (resultado > 35.0 && resultado < 39.9) { Console.WriteLine("Peso  " + resultado + " obesidade grau 2(SEVERA)"); }
if (resultado >= 40.0) { Console.WriteLine("Peso  " + resultado + " obesidade grau 3(MÓRBIDA)"); }
#endregion