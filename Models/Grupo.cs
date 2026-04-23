namespace TP1.Models;

public class Grupo
{
    public Dictionary<int, Integrante> integrantes;
    public Grupo()
    {
        this.integrantes = new Dictionary<int, Integrante>();
    }
    public void cargaDatosManual()
    {
        integrantes.Add(12345678, new Integrante(12345678, "Juan Perez", new DateTime(2005, 7, 15), "12345678.png"));
        integrantes[12345678].familiares.Add("Padre: Pablo Perez");
        integrantes[12345678].familiares.Add("Madre: Laura García");
        integrantes[12345678].familiares.Add("Hermana: Ana Perez");
        integrantes[12345678].intereses.Add("Jugar al fútbol");
        integrantes[12345678].intereses.Add("Ver películas");
        integrantes.Add(87654321, new Integrante(87654321, "Maria Gomez", new DateTime(2006, 5, 8), "87654321.jpg"));
        integrantes[87654321].familiares.Add("Madre: Ana Castro");
        integrantes[87654321].familiares.Add("Padre: Carlos Gomez");
        integrantes[87654321].familiares.Add("Hermano: Luis Gomez");
        integrantes[87654321].intereses.Add("Leer libros");
        integrantes[87654321].intereses.Add("Tocar la guitarra");
    }
    public Integrante getIntegrante(int dni)
    {
        if (integrantes.ContainsKey(dni))
        {
            return integrantes[dni];
        }
        else
        {
            return null;
        }
    }
    public Dictionary<int, Integrante> DevolverIntegrantes()
    {
        return integrantes;
    }
}