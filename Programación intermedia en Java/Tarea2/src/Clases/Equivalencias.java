/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Clases;

/**
 *
 * @author josue
 *
 */
public class Equivalencias {

    //atributos de la clase
    protected String[] DescripcionMonedas;
    protected float[][] TablaConversiones;

//contructor
    public Equivalencias(String[] DescripcionMonedas, float[][] TablaConversiones) {
        this.DescripcionMonedas = DescripcionMonedas.length >= 7 && DescripcionMonedas.length <= 25 ? DescripcionMonedas : null;
        this.TablaConversiones = TablaConversiones;
    }

    //Contructor Sobrecargado
    public Equivalencias() {
        this.DescripcionMonedas = new String[]{"Dolar estadounidense", "Euros", "Colones", "Pesos Mexicanos", "Córdobas Oro", "Pesos Argentinos", "Libras Esterlinas", "Yen"};

        this.TablaConversiones = new float[][]{{1f, 1f}, {0.85f, 0.91f}, {660f, 670f}, {20f, 20.5f}, {33f, 36f}, {110f, 112.5f}, {0.70f, 0.76f}, {119f, 122.5f}};
    }

//Get and Set
    public String[] getDescripcionMonedas() {
        return DescripcionMonedas;
    }

    public void setDescripcionMonedas(String[] DescripcionMonedas) {
        this.DescripcionMonedas = DescripcionMonedas;
    }

    public float[][] getTablaConversiones() {
        return TablaConversiones;
    }

    public void setTablaConversiones(float[][] TablaConversiones) {
        this.TablaConversiones = TablaConversiones;
    }

    //Funciones
    public float PrecioCompra(String moneda_origen) {
        for (int posicion = 0; posicion < DescripcionMonedas.length; posicion++) {

            if (moneda_origen.equals(DescripcionMonedas[posicion])) {
                return TablaConversiones[posicion][0];
            }
        }
        return 0;
    }

    public float PrecioVenta(String moneda_origen) {
        for (int posicion = 0; posicion < DescripcionMonedas.length; posicion++) {
            if (moneda_origen.equals(DescripcionMonedas[posicion])) {
                return TablaConversiones[posicion][1];
            }
        }
        return 0;

    }

    public int PosicionMoneda(String moneda_origen) {
        for (int posicion = 0; posicion < DescripcionMonedas.length; posicion++) {
            if (moneda_origen.equals(DescripcionMonedas[posicion])) {
                return posicion;
            }
        }

        return -1;//La moneda no existe

    }

}
