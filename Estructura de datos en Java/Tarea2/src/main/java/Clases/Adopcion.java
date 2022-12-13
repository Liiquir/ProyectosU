package Clases;

/**
 *
 * @author josue
 */
public class Adopcion {

    
    private String DNI;
    private String nombre;
    private boolean certificacionRaza;
    private String domicilioAdopcion;
    private float costo;

    public Adopcion(String DNI, String nombre, boolean certificacionRaza, String domicilioAdopcion, float costo) {
      
        this.DNI = DNI;
        this.nombre = nombre;
        this.certificacionRaza = certificacionRaza;
        this.domicilioAdopcion = domicilioAdopcion;
        this.costo = costo;
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
        return costo;
    }

    public void setCosto(float costo) {
        this.costo = costo;
    }
    public String Datos(){
        return "DNI:"+DNI+" nombre: "+nombre+" Certificación de raza: "+(certificacionRaza ? "Sí" : "No")+" Domicilio: "+domicilioAdopcion+" Costo: "+costo;
    }
}
