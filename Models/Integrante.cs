namespace TP1.Models;

public class Integrante
{
    public int dni;
    public string nombre;
    public DateTime fechaNacimiento;
    public string foto;
    public List<string> familiares;
    public List<string> intereses;
    public Integrante(int dni, string nombre, DateTime fechaNacimiento, string foto)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.fechaNacimiento = fechaNacimiento;
        this.foto = foto;
        this.familiares = new List<string>();
        this.intereses = new List<string>();
    }
}