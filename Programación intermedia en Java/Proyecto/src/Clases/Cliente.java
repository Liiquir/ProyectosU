/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Clases;



/**
 *
 * @author Josue
 */
public class Cliente {

    
    //atributos
    public int IDCliente;
    public String Nombre;
    public String Apellidos;
    public String Nacionalidad;
    public int Edad;

    public Cliente(int IDCliente, String Nombre, String Apellidos, String Nacionalidad, int Edad) {
        this.IDCliente = IDCliente;
        this.Nombre = Nombre;
        this.Apellidos = Apellidos;
        this.Nacionalidad = Nacionalidad;
        this.Edad = Edad;
    }

    public int getIDCliente() {
        return IDCliente;
    }

    public void setIDCliente(int IDCliente) {
        this.IDCliente = IDCliente;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String Nombre) {
        this.Nombre = Nombre;
    }

    public String getApellidos() {
        return Apellidos;
    }

    public void setApellidos(String Apellidos) {
        this.Apellidos = Apellidos;
    }

    public String getNacionalidad() {
        return Nacionalidad;
    }

    public void setNacionalidad(String Nacionalidad) {
        this.Nacionalidad = Nacionalidad;
    }

    public int getEdad() {
        return Edad;
    }

    public void setEdad(int Edad) {
        this.Edad = Edad;
    }

    public Cliente() {

    }
    
    
    
    
    
    
    
    
       
    
    
}


