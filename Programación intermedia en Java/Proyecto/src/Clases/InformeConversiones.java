/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Clases;

/**
 *
 * @author Josue
 */
public class InformeConversiones {
    //atributos
    protected int id;
    protected String monedaOrigen;
    protected float montoRecibido;
    protected String monedaDestino;
    protected float montoARecibir;
    protected float DolaresComprados;
    protected float DolaresVendidos;

    public InformeConversiones(int id, String monedaOrigen, float montoRecibido, String monedaDestino, float montoARecibir, float DolaresComprados, float DolaresVendidos) {
        this.id = id;
        this.monedaOrigen = monedaOrigen;
        this.montoRecibido = montoRecibido;
        this.monedaDestino = monedaDestino;
        this.montoARecibir = montoARecibir;
        this.DolaresComprados = DolaresComprados;
        this.DolaresVendidos = DolaresVendidos;
    }

    public InformeConversiones() {
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getMonedaOrigen() {
        return monedaOrigen;
    }

    public void setMonedaOrigen(String monedaOrigen) {
        this.monedaOrigen = monedaOrigen;
    }

    public float getMontoRecibido() {
        return montoRecibido;
    }

    public void setMontoRecibido(float montoRecibido) {
        this.montoRecibido = montoRecibido;
    }

    public String getMonedaDestino() {
        return monedaDestino;
    }

    public void setMonedaDestino(String monedaDestino) {
        this.monedaDestino = monedaDestino;
    }

    public float getMontoARecibir() {
        return montoARecibir;
    }

    public void setMontoARecibir(float montoARecibir) {
        this.montoARecibir = montoARecibir;
    }

    public float getDolaresComprados() {
        return DolaresComprados;
    }

    public void setDolaresComprados(float DolaresComprados) {
        this.DolaresComprados = DolaresComprados;
    }

    public float getDolaresVendidos() {
        return DolaresVendidos;
    }

    public void setDolaresVendidos(float DolaresVendidos) {
        this.DolaresVendidos = DolaresVendidos;
    }
            
    
}
