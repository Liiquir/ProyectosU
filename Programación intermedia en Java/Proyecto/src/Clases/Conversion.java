/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Clases;

/**
 *
 * @author josue
 */
public class Conversion {
    //atributos

    protected EquivalenciasNuevas equivalencia;

//constructor 
    public Conversion(EquivalenciasNuevas equivalencia) {
        this.equivalencia = equivalencia;
    }

//funciones
    public float CompraDolares(String monedaDestino, float montoDolares) {
        float valorMoneda = equivalencia.PrecioCompra(monedaDestino);

        return montoDolares / valorMoneda;

    }

    public float VentaDolares(String monedaOrigen, float montoRecibido) {
        float valorMoneda = equivalencia.PrecioVenta(monedaOrigen);

        return montoRecibido / valorMoneda;
    }

    public float ConversionMoneda(String monedaOrigen, String monedaDestino, float montoInicial) {
        float valorMonedaOrigen = equivalencia.PrecioCompra(monedaOrigen);
        float conversionDolar = montoInicial / valorMonedaOrigen;
        float valorMonedaDestino = equivalencia.PrecioVenta(monedaDestino);

        return valorMonedaDestino * conversionDolar;
    }

}
