

package Clases;

/**
 *
 * @author josue
 */
public class Datos {
private int IDTipoAnimal;
private String descripcion;
private String DNI;
private String nombre;
private boolean certificacionRaza;
private String domicilioAdopcion;
private float Costo;



//contructor vacio
    public Datos() {
    }
//construcctor sobrecargado
    public Datos(int IDTipoAnimal, String descripcion, String DNI, String nombre, boolean certificacionRaza, String domicilioAdopcion, float Costo) {
        this.IDTipoAnimal = IDTipoAnimal;
        this.descripcion = descripcion;
        this.DNI = DNI;
        this.nombre = nombre;
        this.certificacionRaza = certificacionRaza;
        this.domicilioAdopcion = domicilioAdopcion;
        this.Costo = Costo;
    }
//getter and setters
    public int getIDTipoAnimal() {
        return IDTipoAnimal;
    }

    public void setIDTipoAnimal(int IDTipoAnimal) {
        this.IDTipoAnimal = IDTipoAnimal;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public String getDNI() {
        return DNI;
    }

    public void setDNI(String DNI) {
        this.DNI = DNI;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public boolean isCertificacionRaza() {
        return certificacionRaza;
    }

    public void setCertificacionRaza(boolean certificacionRaza) {
        this.certificacionRaza = certificacionRaza;
    }

    public String getDomicilioAdopcion() {
        return domicilioAdopcion;
    }

    public void setDomicilioAdopcion(String domicilioAdopcion) {
        this.domicilioAdopcion = domicilioAdopcion;
    }

    public float getCosto() {
        return Costo;
    }

    public void setCosto(float Costo) {
        this.Costo = Costo;
    }
   
}
