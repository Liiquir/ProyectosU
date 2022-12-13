/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package examen;

/**
 *
 * @author Josue
 */
public class Nodo {
    Object valor;
    Nodo siguiente;

    String Datos;

    public void setDatos(String Datos) {
        this.Datos = Datos;
    }

    public Nodo (Object valor){
        this.valor=valor;
        this.siguiente=null;
    }

    Nodo() {
        
    }
    
    public Object obtenerValor(){
        return valor;
    }
    
    public void enlazarSiguiente(Nodo n){
        siguiente=n;
    }
    public Nodo obtenerSiguiente(){
        return siguiente;
    }
}
