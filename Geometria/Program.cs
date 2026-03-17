using Geometria;

Formageometrica forma = new Formageometrica();

forma.cor = "Azul";
forma.visualizarCor(forma.cor);

Circulo objcirculo = new Circulo();
Console.WriteLine("Qual a cor do círculo?");
objcirculo.cor = Console.ReadLine();
Console.WriteLine("Qual o raio do círculo?");
objcirculo.raio = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("O círculo é da cor: " + objcirculo.cor);
objcirculo.calcularArea(objcirculo.raio);

Retangulo objretangulo = new Retangulo();
Console.WriteLine("Qual a cor do Retângulo?");
objretangulo.cor = Console.ReadLine();
Console.WriteLine("Qual o Altura do Retângulo??");
objretangulo.altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Qual a Base?");
objretangulo.B = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("O retangulo é da cor: " + objretangulo.cor);
objretangulo.calcularArea(objretangulo.altura, objretangulo.B);

Triangulo objtriangulo = new Triangulo();
Console.WriteLine("Qual a cor do Triangulo?");
objtriangulo.cor = Console.ReadLine();
Console.WriteLine("Qual o Altura do Triangulo?");
objtriangulo.altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Qual a Base do Triangulo ?");
objtriangulo.B = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("O triangulo é da cor: " + objtriangulo.cor);
objtriangulo.calcularArea(objtriangulo.altura, objtriangulo.B);


