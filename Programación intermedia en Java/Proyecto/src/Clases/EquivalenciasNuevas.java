/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Clases;

import java.text.ParseException;

/**
 *
 * @author josue
 */
public class EquivalenciasNuevas extends Equivalencias {
//constructor con el super de la clase que hereda

    public EquivalenciasNuevas(String[] DescripcionMonedas, float[][] TablaConversiones) {
        super(DescripcionMonedas, TablaConversiones);
    }

    public boolean AgregarNuevaEquivalencia(String DescripcionMoneda, float MontoCompra, float MontoVenta) {
        //el if valida que la moneda no exista para poder agregarla
        if (!ExisteMoneda(DescripcionMoneda)) {

            int nuevoTam = this.DescripcionMonedas.length;
//como en la primera tarea hice el vector y la matriz estatica entonces copie las matrices a una nueva matriz y arreglo para que esta vez sea dinamica y podamos agregar datos
            String[] NuevaDescripcionMonedas = new String[nuevoTam + 1];
            float[][] NuevaTablaConversiones = new float[nuevoTam + 1][2];
            for (int i = 0; i < nuevoTam; i++) {
                NuevaDescripcionMonedas[i] = this.DescripcionMonedas[i];
                NuevaTablaConversiones[i][0] = this.TablaConversiones[i][0];
                NuevaTablaConversiones[i][1] = this.TablaConversiones[i][1];
            }
            NuevaDescripcionMonedas[nuevoTam] = DescripcionMoneda;
            NuevaTablaConversiones[nuevoTam][0] = MontoCompra;
            NuevaTablaConversiones[nuevoTam][1] = MontoVenta;

            this.DescripcionMonedas = NuevaDescripcionMonedas;
            this.TablaConversiones = NuevaTablaConversiones;

            return true;
        } else {
            return false;
        }

    }

    public boolean ActualizarValoresEquivalencias(String DescripcionMoneda, float ActualizarMontoCompra, float ActualizarMontoVenta) {
        //aqui se obtiene el nombre de la moneda para buscar la posicion y poder actualizar los valores de compra y venta, si la moneda no existe se devuelve un falso
        int posicionMoneda = this.PosicionMoneda(DescripcionMoneda);
        if (posicionMoneda == -1) {
            return false;
        } else {
            this.TablaConversiones[posicionMoneda][0] = ActualizarMontoCompra;
            this.TablaConversiones[posicionMoneda][1] = ActualizarMontoVenta;
            return true;
        }
    }
//metodo para verificar si la moneda a agregar o actualizar existe

    private boolean ExisteMoneda(String Moneda) {
        for (int i = 0; i < this.DescripcionMonedas.length; i++) {
            if (DescripcionMonedas[i].equals(Moneda)) {
                return true;
            }

        }
        return false;
    }
}
