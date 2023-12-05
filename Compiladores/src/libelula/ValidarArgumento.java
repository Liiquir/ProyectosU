/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package libelula;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 *
 * @author Josue
 */
public class ValidarArgumento {

    public static boolean Argumento(String Argumento) {
        boolean bandera1 = false;
        boolean bandera2 = false;
        boolean bandera3 = false;
        if (Argumento.length() > 20) {
            System.out.println("Advertencia: La longitud de la cadena excede el límite permitido de 20 caracteres");
            return false;
        } else {
            bandera1 = true;
        }

        // Validación 2: Verifica que sea sensible a mayúsculas/minúsculas
        // Se pasa a minúsculas para evitar problemas con la comparación
        Argumento = Argumento.toLowerCase();

        // Validación 3: Verifica que empiece con una letra
        if (!Character.isLetter(Argumento.charAt(0))) {
            System.out.println("Advertencia: La cadena debe empezar con una letra");
            return false;

        } else {
            bandera2 = true;
        }

        // Validación 4: Verifica que solo tenga letras y números, excuyendo el punto
        String ArgumentoSinPunto = Argumento.substring(0, Argumento.length() - 4);
        Pattern pattern = Pattern.compile("^[a-zA-Z0-9]+$");
        Matcher matcher = pattern.matcher(ArgumentoSinPunto);
        if (!matcher.matches()) {
            System.out.println("El argumento contiene caracteres especiales");
            return false;
        } else {
            bandera3 = true;
        }
        if (bandera1 && bandera2 && bandera3 == true) {
            return true;
        } else {
            return false;
        }

    }

}
