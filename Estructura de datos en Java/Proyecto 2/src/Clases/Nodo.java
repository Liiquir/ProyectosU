package Clases;

/**
 *
 * @author Josue
 */
public class Nodo {
    protected String dato;
    protected Nodo izq,der;

    public Nodo(String dato) {
        this.dato = dato;
        this.izq = izq;
        this.der = der;
    }

    public String getDato() {
        return dato;
    }

    public void setDato(String dato) {
        this.dato = dato;
    }

    public Nodo getIzq() {
        return izq;
    }

    public void setIzq(Nodo izq) {
        this.izq = izq;
    }

    public Nodo getDer() {
        return der;
    }

    public void setDer(Nodo der) {
        this.der = der;
    }
 
}
