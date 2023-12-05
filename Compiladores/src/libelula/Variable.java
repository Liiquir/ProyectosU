package libelula;

/**
 *
 * @author Josue
 */
public class Variable {
    //atributos
    private String nombre;
    private String tipo;
    //constructor
    public Variable(String nombre, String tipo) {
        this.nombre = nombre;
        this.tipo = tipo;
    }
    //constructor vacio
    public Variable() {
    }
    //gets y sets
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public boolean readValido(String read) {
        switch (read) {
            /*Si se encuentra una coincidencia, se evalúa una expresión booleana y se devuelve su resultado.
            Si no se encuentra ninguna coincidencia, la función devuelve false.*/
            case "Read" -> {
                return this.tipo.equals("CHAR");
            }
            case "ReadInt" -> {
                return this.tipo.equals("INTEGER");
            }
            case "ReadReal" -> {
                return this.tipo.equals("REAL");
            }
            case "Write" -> {
                return this.tipo.equals("CHAR");
            }
            case "WriteInt" -> {
                return this.tipo.equals("INTEGER");
            }
            case "WriteReal" -> {
                return this.tipo.equals("REAL");
            }
        }
        return false;
    }
}
