package libelula;

import java.io.BufferedWriter;
import java.io.IOException;

/**
 *
 * @author Josue
 */
public class ValidacionesModule {

    public static void ValidacionesModule(String args, String identificador, String tokens[], String leerArchivo, BufferedWriter bw) throws IOException {
        try {
            identificador = tokens[1];
            AnalizadorLexico.encontrarPalabra(args, bw, "MODULE");
            AnalizadorLexico.ValidarIdentificadores(identificador, bw, "Identificador");
            AnalizadorLexico.noEsPalabraReservada(identificador, bw);
        } catch (Exception e) {
        }

    }

}
