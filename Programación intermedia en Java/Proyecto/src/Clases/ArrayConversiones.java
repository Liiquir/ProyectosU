/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Clases;

import java.util.ArrayList;

/**
 *
 * @author Josue
 */
public class ArrayConversiones {
        private ArrayList<Object> a = new ArrayList<Object>();

    public ArrayConversiones() {}
        
    
  public ArrayConversiones(ArrayList<Object> a){
        this.a = a;
    }
    
    public void agregarConversion(InformeConversiones p){
        this.a.add(p);
    }
    public InformeConversiones obtenerRegistro(int i){
        return (InformeConversiones)a.get(i);
    }
    
    public int cantidadRegistro(){
        return this.a.size();
    }
    
    public int buscaCodigo(int codigo){
        for(int i = 0; i < cantidadRegistro(); i++){
            if(codigo == obtenerRegistro(i).getId())return i;
        }
        return -1;
    }
}
