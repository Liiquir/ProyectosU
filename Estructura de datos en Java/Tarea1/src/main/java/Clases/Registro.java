

package Clases;

public class Registro {

    private int IDJornada;
    private int IDPartido;
    private String fechaPartido;
    private String nombreEquipoA;
    private int carrerasEquipoA;
    private String nombreEquipoB;
    private int carrerasEquipoB;
    private boolean extraInnings;

    //Contructor Vacio
    public Registro() {
    }

    

//Contructor Sobrecargado
    public Registro(int IDJornada, int IDPartido, String fechaPartido, String nombreEquipoA, int CarrasEquipoA, String nombreEquipoB, int CarrasEquipoB, boolean extraInnings) {
        this.IDJornada = IDJornada;
        this.IDPartido = IDPartido-1;
        this.fechaPartido = fechaPartido;
        this.nombreEquipoA = nombreEquipoA;
        this.carrerasEquipoA = CarrasEquipoA;
        this.nombreEquipoB = nombreEquipoB;
        this.carrerasEquipoB = CarrasEquipoB;
        this.extraInnings= extraInnings;
    }
//get and set

    public boolean isExtraInnings() {
        return extraInnings;
    }

    public void setExtraInnings(boolean extraInnings) {
        this.extraInnings = extraInnings;
    }

    public int getIDJornada() {
        return IDJornada;
    }

    public void setIDJornada(int IDJornada) {
        this.IDJornada = IDJornada;
    }

    public int getIDPartido() {
        return IDPartido;
    }

    public void setIDPartido(int IDPartido) {
        this.IDPartido = IDPartido;
    }

    public String getFechaPartido() {
        return fechaPartido;
    }

    public void setFechaPartido(String fechaPartido) {
        this.fechaPartido = fechaPartido;
    }

    public String getNombreEquipoA() {
        return nombreEquipoA;
    }

    public void setNombreEquipoA(String nombreEquipoA) {
        this.nombreEquipoA = nombreEquipoA;
    }

    public int getCarrerasEquipoA() {
        return carrerasEquipoA;
    }

    public void setCarrerasEquipoA(int carrerasEquipoA) {
        this.carrerasEquipoA = carrerasEquipoA;
    }

    public String getNombreEquipoB() {
        return nombreEquipoB;
    }

    public void setNombreEquipoB(String nombreEquipoB) {
        this.nombreEquipoB = nombreEquipoB;
    }

    public int getCarrerasEquipoB() {
        return carrerasEquipoB;
    }

    public void setCarrerasEquipoB(int carrerasEquipoB) {
        this.carrerasEquipoB = carrerasEquipoB;
    }
    
}
