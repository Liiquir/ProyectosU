/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package libelula;

import java.io.BufferedWriter;
import java.io.IOException;

/**
 *
 * @author Josue
 */
public class ValidacionesVariables {

    public static boolean ValidarReal(String linea, BufferedWriter bw) throws IOException {
        if (linea.matches(".*:.*REAL.*;")) {//se valida el formato con un regex
            AnalizadorLexico.validarVariables(linea, bw);
            return true;
        } else {
            bw.write("        ERROR 030:La línea no cumple con el formato deseado");
            bw.newLine();
            return false;
        }

    }

    public static boolean ValidarInteger(String linea, BufferedWriter bw) throws IOException {
        if (linea.matches(".*:.*INTEGER.*;")) {//se valida el formato con un regex
            AnalizadorLexico.validarVariables(linea, bw);
            return true;
        } else {
            bw.write("        ERROR 030:La línea no cumple con el formato deseado");
            bw.newLine();
            return false;
        }

    }

    public static boolean ValidarChar(String linea, BufferedWriter bw) throws IOException {
        if (linea.matches(".*:.*CHAR.*;")) {//se valida el formato con un regex
            AnalizadorLexico.validarVariables(linea, bw);
            return true;
        } else {
            bw.write("        ERROR 030:La línea no cumple con el formato deseado");
            bw.newLine();
            return false;
        }

    }

}
