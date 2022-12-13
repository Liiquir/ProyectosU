
package Clases;

import java.util.LinkedList;
import javax.swing.JPanel;

/**
 *
 * @author Josue
 */
public class Arbol {

    private Nodo raiz;
    int num_nodos;
    int alt;

    public Arbol() {
        raiz = null;
    }

    public boolean agregar(String dato) {
        Nodo nuevo = new Nodo(dato);
        agregaNodo(dato);
        return true;
    }
    //Borrar el que sea
    public String borrar(String x) {
        if (!this.buscar(x)) {
            return null;
        }

        Nodo z = borrar(this.raiz, x);
        this.setRaiz(z);
        return x;

    }

    private Nodo borrar(Nodo r, String x) {
        if (r == null) {
            return null;//<--Dato no encontrado		
        }
        int compara = ((Comparable) r.getDato()).compareTo(x);
        if (compara > 0) {
            r.setIzq(borrar(r.getIzq(), x));
        } else if (compara < 0) {
            r.setDer(borrar(r.getDer(), x));
        } else {
            
            if (r.getIzq() != null && r.getDer() != null) {
                Nodo cambiar = buscarMin(r.getDer());
                String aux = cambiar.getDato();
                cambiar.setDato(r.getDato());
                r.setDato(aux);
                r.setDer(borrar(r.getDer(), x));
                
            } else {
                r = (r.getIzq() != null) ? r.getIzq() : r.getDer();
                
            }
        }
        return r;
    }
 
    //buscar min
    private Nodo buscarMin(Nodo r) {
        for (; r.getIzq() != null; r = r.getIzq());
        return (r);
    }
    //buscar
    public boolean buscar(String x) {
        return (buscar(this.raiz,x));


    }

    private boolean buscar(Nodo r, String x) {
        if (r == null) {
            return (false);
        }
        int compara = ((Comparable) r.getDato()).compareTo(x);
        if (compara > 0) {
            return (buscar(r.getIzq(), x));
        } else if (compara < 0) {
            return (buscar(r.getDer(), x));
        } else {
            return (true);
        }
    }

    
    public void agregaNodo(String nom) {
        Nodo nuevo = new Nodo(nom);
        if (raiz == null) {
            raiz = nuevo;
        } else {
            Nodo auxiliar = raiz;
            Nodo padre;
            if (nom.compareTo(auxiliar.dato) == 0) {
                
                }
            else{while (true) {
                padre = auxiliar;
                
                 if (nom.compareTo(auxiliar.dato) <= 0) {
                    auxiliar = auxiliar.izq;
                    if (auxiliar == null) {
                        padre.izq = nuevo;
                        return;
                    }
                } else {
                    auxiliar = auxiliar.der;
                    if (auxiliar == null) {
                        padre.der = nuevo;
                        return;
                    }
                }
            }}
        }
    }

    public Nodo getRaiz() {
        return raiz;
    }

    public void setRaiz(Nodo raiz) {
        this.raiz = raiz;
    }

    public JPanel getdibujo() {
        return new GraficoArbol(this);
    }
}
