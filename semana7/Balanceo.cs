// Implemente un programa que determine si los paréntesis, llaves 
//y corchetes en una expresión matemática están correctamente balanceados.
//Ejemplo:
//Entrada: {7 + (8 * 5) - [(9 - 7) + (4 + 1)]}
//Salida esperada: Fórmula balanceada.

public class Balanceo
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese una expresión matemática:");
        string? expresion = Console.ReadLine();
        if (string.IsNullOrEmpty(expresion))
        {
            Console.WriteLine("No se ingreso ninguna expresión.");
            return;
        }

        if (EstaBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula no balanceada.");
    }

    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();
        foreach (char c in expresion)
        {
            if (c == '{' || c == '(' || c == '[')
                pila.Push(c);
            else if (c == '}' || c == ')' || c == ']')
            {
                if (pila.Count == 0) return false;
                char ultimo = pila.Pop();
                if ((c == '}' && ultimo != '{') ||
                    (c == ')' && ultimo != '(') ||
                    (c == ']' && ultimo != '['))
                    return false;
            }
        }
        return pila.Count == 0;
    }
}