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
public class ValidacionesBegin {
     public static void ValidacionesBegin(String leerArchivo,BufferedWriter bw,String palabra) throws IOException {
        AnalizadorLexico.encontrarPalabra(leerArchivo, bw, palabra);
    }
}
