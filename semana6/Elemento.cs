//Crear una lista enlazada con 50 números enteros, del 1 al 999 
//generados aleatoriamente. Una
//vez creada la lista, vez creada la lista, 
//se deben eliminar los nodos qu se deben eliminar 
//los nodos que estén fuera de un r e estén fuera de un rango 
//de valores leídos ango de valores leídos desde el teclado.
class Elemento
{
    public int Valor { get; set; }
    public Elemento Siguiente { get; set; } = null!;
}

class ListaEnlazada
{
    private Elemento cabeza;

    public void Agregar(int valor)
    {
        Elemento nuevo = new Elemento { Valor = valor, Siguiente = cabeza };
        cabeza = nuevo;
    }

    public void EliminarFueraDeRango(int min, int max)
    {
        // Eliminar elementos al inicio fuera de rango
        while (cabeza != null && (cabeza.Valor < min || cabeza.Valor > max))
            cabeza = cabeza.Siguiente;

        Elemento actual = cabeza;
        while (actual != null && actual.Siguiente != null)
        {
            if (actual.Siguiente.Valor < min || actual.Siguiente.Valor > max)
                actual.Siguiente = actual.Siguiente.Siguiente;
            else
                actual = actual.Siguiente;
        }
    }

    public void Mostrar()
    {
        Elemento actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Valor + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }
} 
