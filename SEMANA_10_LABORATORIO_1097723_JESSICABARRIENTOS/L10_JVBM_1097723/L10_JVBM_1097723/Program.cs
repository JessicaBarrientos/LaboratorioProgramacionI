////clase principal
//class Program
//{
//    static void Main(string[] args)
//    {
//        int numero;
//        Estudiante estudiante_1 = new Estudiante("Jessica Barrientos", 18, "Zona 8");

//        Console.WriteLine("Nombre: " + estudiante_1.nombre);
//        Console.WriteLine("Edad: " + estudiante_1.edad);
//        Console.WriteLine("Dirección: " + estudiante_1.direccion);

//        Console.ReadKey();
//    }
//}

////creación de la clase Estudiante
//public class Estudiante
//{
//    //Atributos de la clase
//    public string nombre { get; set; }
//    public int edad { get; set; }
//   public string direccion { get; set; }

//    //Constructor
//    public Estudiante(string nombre, int edad, string direccion)
//    {
//        this.nombre = nombre;
//        this.edad = edad;
//        this.direccion = "Landivar";
//    }

//}


class Program
{
    static void Main(string[] args)
    {

        Automovil auto_1 = new Automovil();

        Console.WriteLine("Modelo: " + auto_1.modelo);
        Console.WriteLine("Precio: " + auto_1.precio);
        Console.WriteLine("Marca: " + auto_1.marca);
        Console.WriteLine("Disponible: " + auto_1.disponible);
        Console.WriteLine("Tipo cambio dolar: " + auto_1.tipoCambioDolar);
        Console.WriteLine("Descuento aplicado: " + auto_1.descuentoAplicado);


        Console.ReadKey();
    }
}

//creación de la clase Estudiante
public class Automovil
{
    //Atributos de la clase
    public int modelo { get; set; }
    public double precio { get; set; }  
    public string marca { get; set; }
    public bool disponible { get; set; }    
    public double tipoCambioDolar { get; set; }
    public double descuentoAplicado { get; set; }

    //Constructor
    public Automovil()
    {
        this.modelo = 2019;
        this.precio = 10000.00;
        this.marca = "";
        this.disponible = false;
        this.tipoCambioDolar = 7.50;
        this.descuentoAplicado = 0.00;

    }

}