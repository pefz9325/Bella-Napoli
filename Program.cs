Console.WriteLine("Bienvenidos a la pizeria Bella Napoli");
Console.WriteLine("==========Lea el menu=========\n");
Console.WriteLine("\nTodas nuestras pizzas incluyen de base: salsa de tomate y mozzarella\n");

Console.WriteLine("==============Elija una opcion============\n");
Console.WriteLine("========== Opcion 1: vegetariana =======");
Console.WriteLine("========== Opcion 2: no vegetariana =======");
Console.WriteLine("===========Porfavor ingrese un numero========");

string tipoPizza;
int opcionU;
opcionU = Convert.ToInt32(Console.ReadLine());

switch (opcionU)
{
    case 1:
    tipoPizza = "vegetariana";
    List<string> ingVeg = new List<string>();
    ingVeg.Add("Pimiento");
    ingVeg.Add("Tofu");

    Console.WriteLine("Los ingredientes son");
    for (int i = 0; i < ingVeg.Count; i++)    
    {
        Console.WriteLine(ingVeg[i]);    
    }

    Console.WriteLine("Elija el ingrediente que quiera agregar a su pizza (1, 2)\n");
    Console.WriteLine("Solo se permite un ingrediente");

    int eleccionU;
    eleccionU = Convert.ToInt32(Console.ReadLine());

    while (eleccionU < 1 || eleccionU > 2)
    {
        Console.WriteLine("Elija una opcion valida (del 1 al 2) que corresponde a los ingredientes");
        eleccionU = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("===== RESUMEN DEL PEDIDO =====");
    Console.WriteLine($"Tipo de pizza {tipoPizza}");
    Console.WriteLine($"Ingredientes Salsa de tomate, mozzarella y {ingVeg[eleccionU-1]}");
    break;

    case 2:
    tipoPizza = "no vegetariana";
    List<string> ingNoVeg = new List<string>();
    ingNoVeg.Add("Peperoni");
    ingNoVeg.Add("Jamon");
    ingNoVeg.Add("Salmon");

    Console.WriteLine("Los ingredientes son");
    for (int i = 0; i < ingNoVeg.Count; i++)    
    {
        Console.WriteLine(ingNoVeg[i]);    
    }

    Console.WriteLine("Elija el ingrediente que quiera agregar a su pizza (1, 2, 3)\n");
    Console.WriteLine("Solo se permite un ingrediente");

    int eleccionU2;
    eleccionU2 = Convert.ToInt32(Console.ReadLine());

    while (eleccionU2 < 1 || eleccionU2 > 3)
    {
        Console.WriteLine("Elija una opcion valida (del 1 al 3) que corresponde a los ingredientes");
        eleccionU2 = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("===== RESUMEN DEL PEDIDO =====");
    Console.WriteLine($"Tipo de pizza {tipoPizza}");
    Console.WriteLine($"Ingredientes Salsa de tomate, mozzarella y {ingNoVeg[eleccionU2-1]}");
    break;

    default:
    Console.WriteLine("Opcion no contemplada");
    break;
}