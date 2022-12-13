package Clases;

import javax.swing.JPanel;

/**
 *
 * @author Josue
 */
public class SimuladorArbol {

    Arbol miArbol = new Arbol();

    public SimuladorArbol() {
    }

    public boolean insertar(String dato) {
        return (this.miArbol.agregar(dato));
    }

    public String borrar(String dato) {
        String x = this.miArbol.borrar(dato);
        if (x == null) {
            
        }
        return (x.toString());
    }

    public JPanel getDibujo() {
        return this.miArbol.getdibujo();
    }
}
