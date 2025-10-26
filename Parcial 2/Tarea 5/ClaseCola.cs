using System;
//Ejercicio 5
//                          Jesus Alberto Rodriguez Torres 24100668

// Clase Elemento que seria el Nodo 
public class Elemento<Tipo>
{
    public Tipo Valor { get; set; }
    public Elemento<Tipo> Siguiente { get; set; }

    public Elemento(Tipo valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}
//Clase Cola/Fila con elementos para poder ver el inicio y el fin de la cola     
public class Cola<Tipo>
{
    private Elemento<Tipo> ElementoInicio;
    private Elemento<Tipo> ElementoFin;
    private int Tamaño;

    public Cola()
    {
        ElementoInicio = null;
        ElementoFin = null;
        Tamaño = 0;
    }

    public void Agregar(Tipo objAgregar)
    {
        Elemento<Tipo> NuevoElemento = new Elemento<Tipo>(objAgregar);

        if (ElementoInicio == null)
        {
            ElementoInicio = NuevoElemento;
            ElementoFin = NuevoElemento;
        }
        else
        {
            ElementoFin.Siguiente = NuevoElemento;
            ElementoFin = NuevoElemento;
        }

        Tamaño++;
    }

    public Tipo Eliminar()
    {
        if (Tamaño == 0)
            throw new Exception("Cola vacía");

        Tipo objQuitar = ElementoInicio.Valor;
        ElementoInicio = ElementoInicio.Siguiente;
        Tamaño--;

        if (Tamaño == 0)
            ElementoFin = null;

        return objQuitar;
    }

    public int Tamaño()
    {
        return Tamaño;
    }

    public Tipo VerElementoInicio()
    {
        if (ElementoInicio == null)
            throw new Exception("Cola vacía");
        return ElementoInicio.Valor;
    }

    public Tipo VerElementoFin()
    {
        if (ElementoFin == null)
            throw new Exception("Cola vacía");
        return ElementoFin.Valor;
    }
}
