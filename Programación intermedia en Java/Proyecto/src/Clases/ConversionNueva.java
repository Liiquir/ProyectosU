/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Clases;

/**
 *
 * @author josue
 */
public class ConversionNueva extends Conversion {

    public ConversionNueva(EquivalenciasNuevas equivalencia) {
        super(equivalencia);
    }

    /*lo que entiendo segun el enunciado es que al precio de compra y venta osea por ejemplo al colon que tiene un valor de 670 la venta y 660 la compra se hace lo siguiente 670-660=10
    a ese 10 se le obtiene el 15% que seria 1.5 y eso se le suma al monto de los dolares comprados.
     */
 /*en el if de compra dolares coloque la condicion de que si monto de dolares comprados es igual o mayor a las cantidades que nos piden en el enuciando
       entra y hace lo que explique anteriormente y sino devuelve el valor limpio.
     */
    @Override
    public float CompraDolares(String monedaDestino, float montoDolares) {
        float valorMoneda = equivalencia.PrecioCompra(monedaDestino);
        float diferencia = equivalencia.PrecioVenta(monedaDestino) - equivalencia.PrecioCompra(monedaDestino);
        if (montoDolares / valorMoneda >= 3000) {

            if (montoDolares / valorMoneda < 6000) {

                float porcentaje = (15 * diferencia) / 100;

                return (montoDolares / valorMoneda) + porcentaje;
            }
            if (montoDolares / valorMoneda >= 6000 && montoDolares / valorMoneda < 9000) {
                float porcentaje = (25 * diferencia) / 100;

                return (montoDolares / valorMoneda) + porcentaje;
            }
            if (montoDolares / valorMoneda >= 9000) {
                float porcentaje = (35 * diferencia) / 100;

                return (montoDolares / valorMoneda) + porcentaje;
            }
        }
        return montoDolares / valorMoneda;

    }

    /*aqui se sobreescribe al metodo para poner las condiciones que nos piden en el trabajo en caso de no cumplir ninguna se devuelve el valor limpio sin impuestos.
        pero si el valor de la venta de dolares sobrepasa los 3000 entonces entra al if y ejecuta las instrucciones dependiendo de monto y lo regresa con los impuestos que
    correspondan segun cada porcentaje
     */
    @Override
    public float VentaDolares(String monedaOrigen, float montoRecibido) {
        float valorMoneda = equivalencia.PrecioVenta(monedaOrigen);
        if (montoRecibido / valorMoneda >= 3000) {
            if (montoRecibido / valorMoneda < 6000) {
                float Impuesto = 1 * (montoRecibido / valorMoneda) / 100;

                return Impuesto + (montoRecibido / valorMoneda);
            }
            if (montoRecibido / valorMoneda >= 6000 && montoRecibido / valorMoneda < 9000) {
                float Impuesto = 2 * (montoRecibido / valorMoneda) / 100;

                return Impuesto + (montoRecibido / valorMoneda);
            }
            if (montoRecibido / valorMoneda >= 9000) {
                float Impuesto = 3 * (montoRecibido / valorMoneda) / 100;

                return Impuesto + (montoRecibido / valorMoneda);
            }
        }

        return montoRecibido / valorMoneda;
    }

}
