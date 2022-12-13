
package Clases;

/**
 * @author Josue
 */
public class Pais {
    //Atributos
    String nombrePais;
    float puntosPais;

    public Pais(String nombrePais, float puntosPais) {
        this.nombrePais = nombrePais;
        this.puntosPais = puntosPais;
    }

    public String getNombrePais() {
        return nombrePais;
    }

    public void setNombrePais(String nombrePais) {
        this.nombrePais = nombrePais;
    }

    public float getPuntosPais() {
        return puntosPais;
    }

    public void setPuntosPais(float puntosPais) {
        this.puntosPais = puntosPais;
    }
    public void AumentarPuntos(float puntosExtra){
        this.puntosPais+=puntosExtra;
    }
}
