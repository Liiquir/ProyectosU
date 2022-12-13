package Clases;

import java.util.LinkedList;
import java.util.Queue;

/**
 *
 * @author josue
 */
public class TipoAnimal {

    private int IDTipoAnimal;
    private String descripcion;
    private Queue<Adopcion> adopciones;

    public TipoAnimal(int IDTipoAnimal, String descripcion) {
        this.IDTipoAnimal = IDTipoAnimal;
        this.descripcion = descripcion;
        this.adopciones = new LinkedList<Adopcion>();
    }

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

    public Queue<Adopcion> getAdopciones() {
        return adopciones;
    }
    public String Datos(){
        return this.IDTipoAnimal+"-"+this.descripcion;
    }
}
