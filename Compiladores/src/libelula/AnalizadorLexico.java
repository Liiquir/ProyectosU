package libelula;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.IOException;
import java.util.List;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 *
 * @author Josue
 */
public class AnalizadorLexico {

    private static final List<String> palabrasReservadasLibelula = List.of("CHAR", "ELSE", "IF", "INTEGER",
            "Read", "ReadInt", "ReadReal", "REAL", "REPEAT", "RETURN", "THEN",
            "UNTIL", "Write", "WriteInt", "WriteLn", "WriteReal", "WriteString");

    private static final List<String> palabrasModula2 = List.of("RE", "READONLY", "RECORD", "REM", "RETRY", "REVEAL",
            "SET", "SIZE", "TO", "TRACED", "TRUE", "TRUNC", "TYPE", "UNINTERRUPTIBLE",
            "UNSAFEGUARDED", "VAL", "WHILE", "WITH", "FINALLY", "FLOAT", "FOR",
            "FORWARD", "GENERIC", "GUARD", "HALT", "HIGH", "IM",
            "IMPLEMENTATION", "IMPORT", "IN", "INC", "INCL", "INHERIT", "INT",
            "INTERRUPTIBLE", "LENGTH", "LFLOAT", "LONGCOMPLEX", "LONGREAL",
            "LOOP", "MAX", "MIN", "MOD", "NEW", "NIL", "NOT", "ODD", "OF", "OR", "ORD",
            "OVERRIDE", "PACKEDSET", "POINTER", "PROC", "PROCEDURE", "PROTECTION", "QUALIFIED",
            "ABS", "ABSTRACT", "AND", "ARRAY", "AS", "BITSET", "BOOLEAN", "BY", "CAP", "CARDINAL",
            "CASE", "CHR", "CLASS", "CMPLX", "COMPLEX", "CONST", "DEC", "DEFINITION", "DISPOSE",
            "DIV", "DO", "ELSIF", "EXCEPT", "EXCL", "EXIT", "EXPORT", "FALSE");

    private static final List<String> palabrasDeclarativas = List.of("MODULE", "FROM", "VAR", "END");

    private static boolean BeginCommand = false; // Para saber cuando está dentro de una seccion de comandos
    private static String nombrePrograma = "";

    //para verificar la sensibilidad de los comandos
    protected static boolean EsTokenReservado(String token, BufferedWriter bw) throws IOException {

        for (String palabra : palabrasDeclarativas) {
            if (palabra.toLowerCase().equals(token.toLowerCase())) {
                if (!palabra.equals(token)) {
                    bw.write("        ERROR 0055: El comando " + token + " no respeta la sensibilidad.\n");
                }
            }
        }
        for (String palabra : palabrasReservadasLibelula) {
            if (palabra.toLowerCase().equals(token.toLowerCase())) {
                if (!palabra.equals(token)) {
                    bw.write("        ERROR 0055: El comando " + token + " no respeta la sensibilidad.\n");
                }
                return true;
            }
        }

        for (String palabra : palabrasModula2) {
            if (palabra.toLowerCase().equals(token.toLowerCase())) {
                if (!palabra.equals(token)) {
                    bw.write("        ERROR 0055: El comando" + token + " no respeta la sensibilidad.\n");
                }
                return true;
            }
        }
        return false;
    }

    protected static void VerificarBloqueBEGIN(String linea, BufferedWriter bw, boolean bloqueif) {
        try {
            String tokens[] = linea.split(" ");
            /*verifica si el primer token de la línea es diferente a "MODULE", "FROM", "VAR" o si la línea no contiene la palabra "END" seguida de un punto. 
            verifica si el primer token de la línea es un token reservado, es decir, si aparece en la lista de palabras reservadas del lenguaje.
            verifica si la variable booleana BeginCommand es falsa*/
            if ((!tokens[0].equals("MODULE") || !tokens[0].equals("FROM") || !tokens[0].equals("VAR") || !linea.matches(".*END.*\\.")) && EsTokenReservado(tokens[0], bw) && !BeginCommand) {
                bw.write("        ERROR 0033: Los comandos solo pueden estar decladrados dentro de un bloque BEGIN-END\n");
            }

            if (tokens[0].equals("BEGIN")) { //se pasa el beginCommand en true para saber que se inicia el bloque begin
                BeginCommand = true;
            }

            if (tokens[0].equals("MODULE")) { //se guarda en nombre del programa
                nombrePrograma = tokens[1];
            }
            if (tokens[0].contains("END") && tokens.length > 1 && linea.endsWith(";") && bloqueif == false) {

                bw.write("        ERROR 0179:La linea no debe terminar en ;\n");               

            }
            if (tokens[0].contains("END") && tokens.length > 1 && !linea.contains(";")) {
                if (!tokens[0].equalsIgnoreCase("END")) {
                    bw.write("        ERROR 0179: El comando " + tokens[0] + " no existe, queria escribir END?\n");
                }

                if (!linea.contains(".")) {
                    bw.write("        ERROR 0599: La linea debe terminar con un punto.\n");
                }
              
                if (!nombrePrograma.equals(tokens[1])) {
                    bw.write("        ERROR 0199: El nombre del programa del programa no coincide.\n");
                }

            }
        } catch (IOException e) {
            System.err.println("Error: " + e.getMessage());
        }
    }

    protected static void encontrarPalabra(String archivo, BufferedWriter bw, String palabra) throws IOException {
        boolean encontrado = false;
        BufferedReader br = new BufferedReader(new FileReader(archivo));
        String linea;
        while ((linea = br.readLine()) != null) {
            String[] tokens = linea.split("\\s+");
            for (String token : tokens) {
                if (token.equals(palabra)) {
                    if (encontrado) {
                        // Ya se encontró un módulo previamente
                        bw.write("        ERROR 001: Se encontro mas de un " + palabra + " en el archivo");
                        bw.newLine();
                        return;
                    }
                    encontrado = true;

                    break;
                }
            }
        }

    }

    protected static void ExistePalabra(String archivo, BufferedWriter bw, String palabra) throws IOException {
        boolean encontrado = false;
        BufferedReader br = new BufferedReader(new FileReader(archivo));
        String linea;
        while ((linea = br.readLine()) != null) {
            String[] tokens = linea.split("\\s+");
            for (String token : tokens) {
                if (token.equalsIgnoreCase(palabra)) {
                    if (encontrado) {
                        return;
                    }
                    encontrado = true;

                    break;
                }
            }
        }
        if (!encontrado) {
            // No se encontró un módulo en el archivo            
            bw.write("        ERROR 002: No se encontro ningun " + palabra + " en el archivo");
            bw.newLine();
        }
    }

    protected static void VerificarTamanioLineas(String leerArchivo, BufferedWriter bw) throws IOException {
        if (leerArchivo.length() > 100) { //este metodo verifica si la linea tiene mas de 100 caracteres
            bw.write("        ERROR 026:La línea anterior tiene más de 100 caracteres.");
            bw.newLine();
        }
    }

    protected static void ValidarIdentificadores(String identificador, BufferedWriter bw, String Tipo) throws IOException {
        // para validar los identificadores
        identificador = identificador.toLowerCase().trim();
        if (identificador.matches("^.*;+$")) {
            identificador = identificador.replaceAll(";+$", "");
        }
        if (identificador.length() > 20) { //que no tenga mas de 20 letras
            bw.write("        ERROR 004: La longitud de la" + Tipo + "excede el límite permitido de 20 caracteres");
            bw.newLine();
        }
        if (!Character.isLetter(identificador.charAt(0))) {//que empiece con una letra
            bw.write("        ERROR 005: La " + Tipo + " deben empezar con una letra");
            bw.newLine();
        }
        if (!identificador.matches("^[a-zA-Z0-9;]*[a-zA-Z0-9]$")) { //que solo tenga letras y numeros
            bw.write("        ERROR 006: La " + Tipo + " solo deben contener letras y numeros");
            bw.newLine();
        }
        if (!identificador.matches("^[a-zA-Z0-9]*$")) { //y sin caracteres especiales
            bw.write("        ERROR 007: La " + Tipo + " no se permiten con caracteres especiales");
            bw.newLine();
        }
    }

    protected static boolean noEsPalabraReservada(String palabra, BufferedWriter bw) throws IOException {
        // Lista de palabras reservadas de LIBELULA
        String[] palabrasReservadasLibelula = {"BEGIN", "CHAR", "ELSE", "END", "IF", "INTEGER",
            "MODULE", "Read", "ReadInt", "ReadReal", "REAL", "REPEAT", "RETURN", "THEN",
            "UNTIL", "VAR", "Write", "WriteInt", "WriteLn", "WriteReal", "WriteString"};

        // Lista de palabras reservadas de MODULA2
        String[] palabrasModula2 = {"RE", "READONLY", "RECORD", "REM", "RETRY", "REVEAL",
            "SET", "SIZE", "TO", "TRACED", "TRUE", "TRUNC", "TYPE", "UNINTERRUPTIBLE",
            "UNSAFEGUARDED", "VAL", "WHILE", "WITH", "FINALLY", "FLOAT", "FOR",
            "FORWARD", "FROM", "GENERIC", "GUARD", "HALT", "HIGH", "IM",
            "IMPLEMENTATION", "IMPORT", "IN", "INC", "INCL", "INHERIT", "INT",
            "INTERRUPTIBLE", "LENGTH", "LFLOAT", "LONGCOMPLEX", "LONGREAL",
            "LOOP", "MAX", "MIN", "MOD", "NEW", "NIL", "NOT", "ODD", "OF", "OR", "ORD",
            "OVERRIDE", "PACKEDSET", "POINTER", "PROC", "PROCEDURE", "PROTECTION", "QUALIFIED",
            "ABS", "ABSTRACT", "AND", "ARRAY", "AS", "BITSET", "BOOLEAN", "BY", "CAP", "CARDINAL",
            "CASE", "CHR", "CLASS", "CMPLX", "COMPLEX", "CONST", "DEC", "DEFINITION", "DISPOSE",
            "DIV", "DO", "ELSIF", "EXCEPT", "EXCL", "EXIT", "EXPORT", "FALSE"};

        for (String reservada : palabrasReservadasLibelula) {
            if (reservada.equalsIgnoreCase(palabra)) {
                bw.write("        ERROR 008: El identificador no puede ser una palabra reservada de libelula");
                return false;
            }
        }

        for (String reservada : palabrasModula2) {
            if (reservada.equalsIgnoreCase(palabra)) {
                bw.write("        ERROR 009: El identificador no puede ser una palabra reservada de modula2");
                return false;
            }
        }

        return true;
    }

    public static void puntoYComa(String leerArchivo, BufferedWriter bw) throws IOException {
        if (!leerArchivo.endsWith(";")) {
            bw.write("        ERROR 010: La linea no termina en ;");
            bw.newLine();
        }
    }

    public static boolean validarLineaReal(String linea) {
        // define un patrón que valide el formato deseado
        // define un patrón que valide el formato deseado para el tipo de dato indicado
        Pattern patron;

        patron = Pattern.compile("^([^\\s,]+(\\s*,\\s*[^\\s,]+)*)?\\s*:\\s*REAL ;$");

        // crea un matcher para la línea y verifica si cumple con el patrón
        Matcher matcher = patron.matcher(linea);
        return matcher.find();
    }

    public static boolean validarLineaChar(String linea) {
        // define un patrón que valide el formato deseado
        // define un patrón que valide el formato deseado para el tipo de dato indicado
        Pattern patron;

        patron = Pattern.compile("^([^\\s,]+(\\s*,\\s*[^\\s,]+)*)?\\s*:\\s*CHAR ;$");

        // crea un matcher para la línea y verifica si cumple con el patrón
        Matcher matcher = patron.matcher(linea);
        return matcher.find();
    }

    public static boolean validarLineaInteger(String linea) {
        // define un patrón que valide el formato deseado
        // define un patrón que valide el formato deseado para el tipo de dato indicado
        Pattern patron;

        patron = Pattern.compile("^([^\\s,]+(\\s*,\\s*[^\\s,]+)*)?\\s*:\\s*INTEGER ;$");

        // crea un matcher para la línea y verifica si cumple con el patrón
        Matcher matcher = patron.matcher(linea);
        return matcher.find();
    }

    public static void validarVariables(String linea, BufferedWriter bw) throws IOException {
        // separa la línea en variables individuales
        String[] variables = linea.split(",");

        boolean declaracionFinalizada = false;
        // itera sobre cada variable y aplica las reglas de validación
        for (String variable : variables) {
            // elimina espacios en blanco al inicio y final de la variable
            variable = variable.trim();

            // si la variable contiene ":", se cambia el valor de la variable booleana
            if (variable.contains(":")) {
                declaracionFinalizada = true;
                variable = variable.split(":")[0];

            }

            // si todavía no se ha llegado al final de la declaración de variables, se valida la variable
            if (!declaracionFinalizada) {
                ValidarIdentificadores(variable, bw, "variables");

            }
            if (declaracionFinalizada) {
                ValidarIdentificadores(variable, bw, "variables");
            }
        }
    }

    static void VerifcarParentesis(String comando, String[] tokens, BufferedWriter bw) throws IOException {
        if (tokens.length > 1) { // si el arreglo tokens tiene más de un elemento. Si es así, el ciclo for recorre cada elemento del arreglo
            for (int i = 0; i < tokens.length; i++) {
                if (tokens[i].equals(comando) && !tokens[i + 1].equals("(")) {/*se verifica si el elemento actual es 
                                                                              igual al valor de "comando" y si el siguiente elemento no es igual a "(".*/
                    bw.write("        ERROR 0031: Error de sintaxis, el comando " + comando + " no tiene parentesis de apertura.");//sino es igual es escribe el error
                    bw.newLine();
                } else if (tokens[i].equals("(") && (!tokens[i + 1].equals("(") || !tokens[i].equals(")"))) {/* se verifica si el elemento actual es igual a 
                                                                            "(". Si esta condición se cumple, se verifica si el siguiente elemento no es igual
                                                                             a "(" o si el elemento actual no es igual a ")*/
                    String nombreVariable = tokens[i + 1];
                    if (!tokens[0].equals("WriteString")) {
                        ValidarIdentificadores(nombreVariable, bw, tokens[i + 1]); //verificar que las variables cumpla con la reglas de los identificadores
                        Variable existe = BuscarVariable(tokens[i + 1]);//valido si existe la variable
                        if (existe == null) {
                            bw.write("        EERROR 0039: La variable " + nombreVariable + " no está declarada.");//si no existe se escribe el error
                            bw.newLine();
                        } else if (!existe.readValido(comando)) { //si existe pero se esta intentando con una variable int a una real por ejemplo se escribe
                            bw.write("        ERROR 0046: El comando de lectura no es el correcto para la variable " + existe.getNombre() + " de tipo " + existe.getTipo());
                            bw.newLine();
                        }
                    }

                }
            }
        }
    }

    //para verificar que las variables esten declaradas antes del =
    static void VerificarVariablesAntesDelIgual(String[] tokens, BufferedWriter bw) throws IOException {
        for (int i = 0; i < tokens.length; i++) {
            if (tokens[i].contains("=")) {
                Variable existe = BuscarVariable(tokens[i - 1]);
                if (existe != null) {
                    ValidarIdentificadores(existe.getNombre(), bw, tokens[i - 1]);
                } else {
                    bw.write("        ERROR 0039: La variable " + tokens[i - 1] + " no está declarada.");
                    bw.newLine();
                }
            }
        }
    }

    //para buscar la variable
    private static Variable BuscarVariable(String token) {
        for (Variable variable : LIBELULA.variables) {
            if (variable.getNombre().equals(token)) {
                return variable;
            }
        }
        return null;
    }
}
