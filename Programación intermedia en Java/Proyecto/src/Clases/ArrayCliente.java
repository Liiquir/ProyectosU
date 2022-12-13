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
//este codigo fue obtenido del los ejemplos que dio el profesor Wilfrido Castilla
public class ArrayCliente {
    
    private ArrayList<Object> a = new ArrayList<Object>();

    public ArrayCliente() {}
        
    
  public ArrayCliente(ArrayList<Object> a){
        this.a = a;
    }
    //metodo para agregar objetos a la array
    public void agregarRegistro(Cliente p){
        this.a.add(p);
    }
    //metodo para editar objetos en la array
    public void modificarRegistro(int i, Cliente p){
        this.a.set(i, p);
    }
    //metodo para eliminar objetos de la array
    public void eliminarRegistro(int i){
        this.a.remove(i);
    }
    //metodo de tipo cliente para obtener el objeto
    public Cliente obtenerRegistro(int i){
        return (Cliente)a.get(i);
    }
    //metodo para obtener el tamaño de la array
    public int cantidadRegistro(){
        return this.a.size();
    }
    //metodo para buscar el id del cliente dentro de la array y devolverlo
    public int buscaCodigo(int codigo){
        for(int i = 0; i < cantidadRegistro(); i++){
            if(codigo == obtenerRegistro(i).getIDCliente())return i;
        }
        return -1;
    }
}
