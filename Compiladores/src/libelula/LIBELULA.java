package libelula;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Josue
 */
public class LIBELULA {

    private static AnalizadorLexico analizador;
    public static ArrayList<Variable> variables;
    public static boolean REPEAT;
    public static boolean IF;
    public static ArrayList<String> bloqueIF = null;

    /**
     * @param args the command line Argumentos
     */
    public static void main(String[] args) {
        // TODO code application logic here
        try {
            analizador = new AnalizadorLexico();
            String Argumento = args[0];
            Argumento = Argumento.toLowerCase();
            boolean ArgumentoValido = ValidarArgumento.Argumento(Argumento);

            if (ArgumentoValido) {
                //para leer el archivo
                File file = new File(args[0]);

                try (FileReader fr = new FileReader(file); BufferedReader br = new BufferedReader(fr); FileWriter fw = new FileWriter(Argumento.replace(".lid", "") + "-errores.txt"); BufferedWriter bw = new BufferedWriter(fw);) {
                    String lineaArchivo;
                    int fila = 1;
                    analizador.ExistePalabra(args[0], bw, "MODULE");
                    variables = new ArrayList<>();
                    boolean esComentario = false;
                    int contador = 0;
                    boolean error10 = false;

                    while ((lineaArchivo = br.readLine()) != null) {
                        //darle formato al archivo para procesarlo
                        lineaArchivo = lineaArchivo.trim();// elimina los espacios en blanco al principio y al final de la línea.
                        lineaArchivo = lineaArchivo.replaceAll("\\s{2,}", " ");//reemplaza dos o más espacios consecutivos por un solo espacio.
                        lineaArchivo = lineaArchivo.replaceAll(";", " ;");//agrega un espacio antes de cada punto y coma (;) en la línea.
                        lineaArchivo = lineaArchivo.replaceAll("\\([^\\*]", " \\( ");// agrega un espacio antes de cada paréntesis de apertura que 
                        //no esté precedido por un asterisco (*). Esto permite separar los paréntesis de las palabras cercanas
                        lineaArchivo = lineaArchivo.replaceAll("[^\\*]\\)", " \\) ");//agrega un espacio después de cada paréntesis de cierre que no esté precedido por un asterisco (*).
                        lineaArchivo = lineaArchivo.replaceAll(",", " , ");//agrega un espacio antes y después de cada coma (,) en la línea.
                        lineaArchivo = lineaArchivo.replaceAll(":=", " := ");//agrega un espacio antes y después de cada signo de asignación (:=) en la línea.
                        lineaArchivo = lineaArchivo.replaceAll("\\.", " .");
                        String tokens[] = lineaArchivo.split("[\\s]+");/*divide la línea en tokens utilizando cualquier número de espacios en blanco como separador. 
                                                                        Los tokens resultantes se almacenan en un array de Strings llamado tokens.*/
                        String penultimoToken = "";

                        if (lineaArchivo.contains(";") && esComentario) {
                            bw.write("        ERROR 011: No se cerro el comentario\n");
                            contador = 0;
                            error10 = false;
                            esComentario = false;
                        }
                        if (tokens[0].equals("(*")) {
                            if (esComentario) {
                                bw.write("        ERROR 011: No se cerro el comentario\n");
                            } else {
                                esComentario = true;
                            }
                        }

                        if (esComentario) {
                            contador++;
                            if (contador == 10) {
                                error10 = true;
                                esComentario = false;
                            }
                        }

                        bw.write(String.format("%05d", fila++) + " " + lineaArchivo);//para enumerar las filas
                        bw.newLine();
                        analizador.VerificarTamanioLineas(lineaArchivo, bw);
                        analizador.VerificarBloqueBEGIN(lineaArchivo, bw,IF);
                        if (tokens.length > 1) {
                            penultimoToken = tokens[tokens.length - 2];
                        }
                        switch (tokens[0]) {
                            case "MODULE":
                                String[] tokensmodule = lineaArchivo.split(" ");
                                if (tokensmodule.length >= 2 && tokensmodule[0].equals("MODULE") && !tokensmodule[1].isEmpty()) {

                                } else {
                                    bw.write("ERROR 0203: Debe asignar un nombre al programa\n");
                                }
                                ValidacionesModule.ValidacionesModule(Argumento, tokens[1], tokens, lineaArchivo, bw);
                                break;
                            case "BEGIN":
                                ValidacionesBegin.ValidacionesBegin(args[0], bw, "BEGIN");
                                break;
                            case "VAR":
                                break;
                            case "FROM":
                                analizador.puntoYComa(lineaArchivo, bw);
                                break;
                            case "Read":
                                try {
                                analizador.puntoYComa(lineaArchivo, bw);
                                analizador.VerifcarParentesis("Read", tokens, bw);
                            } catch (Exception e) {
                            }

                            break;
                            case "ReadInt":try {
                                analizador.puntoYComa(lineaArchivo, bw);
                                analizador.VerifcarParentesis("ReadInt", tokens, bw);
                            } catch (Exception e) {
                            }

                            break;
                            case "ReadReal":
                                try {
                                analizador.puntoYComa(lineaArchivo, bw);
                                analizador.VerifcarParentesis("ReadReal", tokens, bw);
                            } catch (Exception e) {
                            }

                            break;
                            case "WriteLn":try {
                                if (tokens.length > 1) {
                                    for (int k = 0; k < tokens.length; k++) {
                                        if (tokens[k].equals("WriteLn") && !tokens[k + 1].equals(";")) {
                                            bw.write("        ERROR 0083: No se puede declarar <" + tokens[k + 1] + ">  despues de WriteLn.");
                                            bw.newLine();
                                        }
                                    }
                                }
                            } catch (Exception e) {
                            }
                            /* el if se utiliza para verificar si el arreglo tokens tiene más de un elemento, y si es así, 
                                se procede a un ciclo for que recorre cada uno de los elementos del arreglo.
                                for, se verifica si el elemento actual es igual a "WriteLn" y si el 
                                siguiente elemento no es igual a ";". Si esta condición se cumple, 
                                se escribe un mensaje el error en el archivo de errores del compilador*/

                            analizador.puntoYComa(lineaArchivo, bw);
                            break;
                            case "Write":try {
                                analizador.puntoYComa(lineaArchivo, bw);
                                analizador.VerifcarParentesis("Write", tokens, bw);
                            } catch (Exception e) {
                            }

                            break;
                            case "WriteInt":
                                try {
                                analizador.puntoYComa(lineaArchivo, bw);
                                analizador.VerifcarParentesis("WriteInt", tokens, bw);
                                VerificarComaYTamanio(tokens, bw);
                            } catch (Exception e) {
                            }

                            break;
                            case "WriteString":try {
                                analizador.puntoYComa(lineaArchivo, bw);
                                analizador.VerifcarParentesis("WriteString", tokens, bw);
                                /*aqui se verifica si el arreglo "tokens" tiene más de un elemento. 
                                Si es así, el ciclo for recorre cada elemento del arreglo
                                for, se verifica si el elemento actual es igual a "(". 
                                Si esta condición se cumple y el siguiente elemento 
                                no comienza con una comilla simple, 
                                se escribe un mensaje de error correspondiente.
                                Luego, se utiliza la cláusula else if para verificar
                                si el elemento actual es igual a ")" y si el 
                                elemento anterior no termina con una comilla simple. */
                                if (tokens.length > 1) {
                                    for (int i = 1; i < tokens.length; i++) {
                                        if (tokens[i].equals("(") && !tokens[i + 1].matches("\'.*")) {
                                            bw.write("        ERROR 0037: Falta la comilla de apertura");
                                            bw.newLine();
                                        } else if (tokens[i].equals(")") && !tokens[i - 1].matches(".*\'")) {
                                            bw.write("        ERROR 0038: Falta la comilla de cierre.");
                                            bw.newLine();
                                        }
                                    }
                                }
                            } catch (Exception e) {
                            }

                            break;
                            case "WriteReal":
                                try {
                                analizador.puntoYComa(lineaArchivo, bw);
                                analizador.VerifcarParentesis("WriteReal", tokens, bw);
                                VerificarComaYTamanio(tokens, bw);
                            } catch (Exception e) {
                            }

                            break;
                            case "RETURN":
                                try {
                                analizador.puntoYComa(lineaArchivo, bw);
                                if (!tokens[1].equals(";")) {
                                    bw.write("        ERROR 0052: Este comando no acepta parametros.");
                                    bw.newLine();
                                }
                            } catch (Exception e) {
                            }

                            break;
                            case "REPEAT":
                                try {
                                if (tokens.length > 1) {
                                    bw.write("        ERROR 0072: La sintaxis del comando REPEAT es incorrecta.\n");
                                }
                                if (REPEAT || IF) {
                                    bw.write("        ERROR 0072: No puede haber un comando " + (REPEAT ? "REPEAT" : "IF") + " dentro del bloque REPEAT.\n");
                                } else {
                                    REPEAT = true;
                                }
                            } catch (Exception e) {
                            }
                                
                                break;
                            case "UNTIL":
                                try {
                                analizador.puntoYComa(lineaArchivo, bw);
                                String signos[] = {"<", ">", "=", ">=", "<="};
                                boolean haySigno = false;
                                if (lineaArchivo.contains(";") && tokens.length > 4) {
                                    for (String signo : signos) { //se comprueba si la línea contiene un signo de comparación, en la posición 2 del array tokens
                                        if (signo.equals(tokens[2])) {
                                            haySigno = true; //se pasa la booleana haySigno a true para usarse despues
                                        }
                                    }
                                    if (!haySigno) {
                                        bw.write("        ERROR 0072: La sintaxis del comando UNTIL no contiene signo de comparacion.\n"); //sino hay signo se escribe el error
                                    } else {
                                        boolean var1 = false;
                                        boolean var2 = false;
                                        for (Variable variable : variables) {
                                            if (tokens[1].equals(variable.getNombre())) {
                                                var1 = true;// si la variable existe se pasa a true
                                            }
                                            if (tokens[3].equals(variable.getNombre())) {
                                                var2 = true;// si la variable existe se pasa a true
                                            }
                                        }
                                        //el comando until lleva 2 variables por lo que por eso se usan 2 booleanas
                                        if (!var1) {
                                            bw.write("        ERROR 0039: La variable " + tokens[1] + " no está declarada.\n");//sino entonces se escribe el error
                                        }
                                        if (!var2) {
                                            bw.write("        ERROR 0039: La variable " + tokens[3] + " no está declarada.\n");
                                        }
                                    }
                                } else {
                                    bw.write("        ERROR 0072: La sintaxis del comando UNTIL es incorrecta.\n");
                                }
                                REPEAT = false; //se pasa el repeat a falso
                            } catch (Exception e) {
                            }
                                
                                break;
                            case "(*":
                                break;
                            case "*)":
                                break;
                            case "*":
                                break;
                            case "IF":
                                try {
                                bloqueIF = new ArrayList<>(); //se instancia el objeto arrayList vacio
                                if (IF || REPEAT) {//si el booleano REPEAT es verdadero,
                                    //el mensaje de error mostrará "No puede haber un comando REPEAT 
                                    //dentro del bloque IF". Si es falso, mostrará "No puede haber un comando IF dentro del bloque IF".
                                    bw.write("        ERROR 0072: No puede haber un comando " + (REPEAT ? "REPEAT" : "IF") + " dentro del bloque IF.\n");
                                }
                                if (lineaArchivo.contains(";")) {
                                    bw.write("        ERROR 0072: No debe haber un punto y coma en este comando.\n"); //por si le agregan punto y coma al if
                                }
                                if (!lineaArchivo.matches("IF\\s*\\(.*\\)\\s*THEN.*")) { //para verificar la sintaxis del comando if con un regex
                                    bw.write("        ERROR 0072: Error en sintaxis del comando IF.\n"); //mensaje de error sino se cumple
                                } else {
                                    IF = true; //si todo esbien se pasa el if a verdadero
                                }
                                analizador.VerifcarParentesis("IF", tokens, bw);
                            } catch (Exception e) {
                            }
                                
                                break;
                            case "ELSE":
                                try {
                                if (lineaArchivo.contains(";")) {
                                    bw.write("        ERROR 0072: No debe haber un punto y coma en este comando.\n"); //el else no debe tener punto y coma
                                }
                                if (!IF) { //por si no hay if antes se escribe el error
                                    bw.write("        ERROR 0051: Debe haber un comando IF antes.\n");
                                }
                            } catch (Exception e) {
                            }
                                
                                break;
                            case "END":
                                try {
                                IF = false;
                                
                            } catch (Exception e) {
                            }
                                

                                break;
                            case "GOTO":
                                analizador.puntoYComa(lineaArchivo, bw);
                                break;
                            case "NULL":
                                analizador.puntoYComa(lineaArchivo, bw);
                                break;
                            default:
                                switch (penultimoToken) {
                                    //agregar las  variables
                                    case "REAL":
                                        try {
                                        if (ValidacionesVariables.ValidarReal(lineaArchivo, bw)) {
                                            AgregarVariable(tokens, "REAL");

                                        }
                                    } catch (Exception e) {
                                    }

                                    break;
                                    case "INTEGER":
                                        try {
                                        if (ValidacionesVariables.ValidarInteger(lineaArchivo, bw)) {
                                            AgregarVariable(tokens, "INTEGER");
                                        }
                                    } catch (Exception e) {
                                    }

                                    break;
                                    case "CHAR":
                                        try {
                                        if (ValidacionesVariables.ValidarChar(lineaArchivo, bw)) {
                                            AgregarVariable(tokens, "CHAR");
                                        }
                                    } catch (Exception e) {
                                    }

                                    break;
                                    default:
                                        switch (tokens[tokens.length - 1]) {
                                            case "REAL":
                                                analizador.puntoYComa(lineaArchivo, bw);
                                                bw.newLine();
                                                break;
                                            case "INTEGER":
                                                analizador.puntoYComa(lineaArchivo, bw);
                                                bw.newLine();
                                                break;
                                            case "CHAR":
                                                analizador.puntoYComa(lineaArchivo, bw);
                                                bw.newLine();
                                                break;
                                            default:
                                                switch (tokens[0]) {
                                                    case "RE":
                                                    case "READONLY":
                                                    case "RECORD":
                                                    case "REM":
                                                    case "RETRY":
                                                    case "REVEAL":
                                                    case "SET":
                                                    case "SIZE":
                                                    case "TO":
                                                    case "TRACED":
                                                    case "TRUE":
                                                    case "TRUNC":
                                                    case "TYPE":
                                                    case "UNINTERRUPTIBLE":
                                                    case "UNSAFEGUARDED":
                                                    case "VAL":
                                                    case "WHILE":
                                                    case "WITH":
                                                    case "FINALLY":
                                                    case "FLOAT":
                                                    case "FOR":
                                                    case "FORWARD":
                                                    case "FROM":
                                                    case "GENERIC":
                                                    case "GUARD":
                                                    case "HALT":
                                                    case "HIGH":
                                                    case "IM":
                                                    case "IMPLEMENTATION":
                                                    case "IMPORT":
                                                    case "IN":
                                                    case "INC":
                                                    case "INCL":
                                                    case "INHERIT":
                                                    case "INT":
                                                    case "INTERRUPTIBLE":
                                                    case "LENGTH":
                                                    case "LFLOAT":
                                                    case "LONGCOMPLEX":
                                                    case "LONGREAL":
                                                    case "LOOP":
                                                    case "MAX":
                                                    case "MIN":
                                                    case "MOD":
                                                    case "NEW":
                                                    case "NIL":
                                                    case "NOT":
                                                    case "ODD":
                                                    case "OF":
                                                    case "OR":
                                                    case "ORD":
                                                    case "OVERRIDE":
                                                    case "PACKEDSET":
                                                    case "POINTER":
                                                    case "PROC":
                                                    case "PROCEDURE":
                                                    case "PROTECTION":
                                                    case "QUALIFIED":
                                                    case "ABS":
                                                    case "ABSTRACT":
                                                    case "AND":
                                                    case "ARRAY":
                                                    case "AS":
                                                    case "BITSET":
                                                    case "BOOLEAN":
                                                    case "BY":
                                                    case "CAP":
                                                    case "CARDINAL":
                                                    case "CASE":
                                                    case "CHR":
                                                    case "CLASS":
                                                    case "CMPLX":
                                                    case "COMPLEX":
                                                    case "CONST":
                                                    case "DEC":
                                                    case "DEFINITION":
                                                    case "DISPOSE":
                                                    case "DIV":
                                                    case "DO":
                                                    case "ELSIF":
                                                    case "EXCEPT":
                                                    case "EXCL":
                                                    case "EXIT":
                                                    case "EXPORT":
                                                    case "FALSE":
                                                        bw.write("        Advertencia: comando no es soportado por esta versión.");
                                                        bw.newLine();
                                                        break;
                                                    default:
                                                        if (lineaArchivo.trim().isEmpty()) {
                                                            continue;
                                                        } else {
                                                            //para que no de error si el primer token es una variable que ya se declaro
                                                            boolean var = false;
                                                            for (Variable variable : variables) {
                                                                if (variable.getNombre().equals(tokens[0])) {
                                                                    var = true;
                                                                }
                                                            }
                                                            if (!var && !tokens[0].matches("^\\*.*\\*$")) {
                                                                bw.write("        ERROR 066: Comando desconocido: " + tokens[0]);
                                                                bw.newLine();
                                                            }
                                                        }
                                                }
                                        }
                                }
                                break;
                        }
                        if (bloqueIF != null) { //se verifica si el bloque if es nulo
                            bloqueIF.add(lineaArchivo);//si es nulo se va agregando cada linea al arrayList(bloqueIF es un array)
                            boolean end = false;
                            boolean bloqueElse = false;
                            for (String linea : bloqueIF) {
                                /*este for se usa para busca end y else.*/
                                if (linea.contains("END")) {
                                    end = true;
                                }
                                if (linea.contains("ELSE")) {
                                    bloqueElse = true; // si las contiene se pasa a true
                                }
                            }
                            if (end) { //si end es true se hacen la verificaciones
                                if (bloqueElse && bloqueIF.size() < 4) { //se verifica si bloqueElse es verdadera y el tamaña de de bloqueIf es menor a 4
                                    bw.write("        ERROR 0011: Debe haber un comando dentro del bloque ELSE.\n");
                                    bloqueIF.removeIf((linea) -> (linea.contains("ELSE")));//Se elimina todas las líneas dentro de bloqueIF que contienen la palabra "ELSE".
                                }
                                if (bloqueIF.size() < 3) {// si el tamaño del bloque es menor a 3 se entiende que no hay comandos y se manda el error
                                    bw.write("        ERROR 0010: Debe haber un comando dentro del bloque IF.\n");
                                }
                                bloqueIF = null;
                            }
                        }

                        if (lineaArchivo.contains("*)")) {
                            esComentario = false;
                            if (error10) {
                                bw.write(
                                        "       ERROR 0612: El comentario tiene mas de 10 lineas fisicas");
                                bw.newLine();
                                error10 = false;
                            }
                            contador = 0;
                        }

                        if (lineaArchivo.matches(".*\\>[\\s]+\\=.*")) {//esta expresion es para que no hayan espacios en las comparaciones
                            bw.write("        ERROR 0094: El signo > no debe tener espacio antes del =.");
                            bw.newLine();
                        }
                        if (lineaArchivo.matches(".*\\<[\\s]+\\=.*")) {//esta expresion es para que no hayan espacios en las comparaciones
                            bw.write("        ERROR 0094: El signo < no debe tener espacio antes del =.");
                            bw.newLine();
                        }

                        //verifica si la línea contiene el operador  "=" y si no contiene ni el operador de comparación "<" ni ">"
                        if (lineaArchivo.contains("=") && !lineaArchivo.contains("<") && !lineaArchivo.contains(">")) { //se utilizan en la linea ejemplo: Factor1  :=   ( Factor1 * 1.07  );
                            analizador.VerificarVariablesAntesDelIgual(tokens, bw);//se verifican las variables
                            if (lineaArchivo.contains("(") || lineaArchivo.contains(")")) {
                                if (!lineaArchivo.contains("(")) {
                                    bw.write("        ERROR 2051: No hay parentesis de apertura.");
                                    bw.newLine();
                                }
                                if (!lineaArchivo.contains(")")) {
                                    bw.write("        ERROR 2041: No hay parentesis de cierre.");
                                    bw.newLine();
                                }
                            }
                        }
                    }
                    bw.close();
                    br.close();
                } catch (Exception e) {
                    System.err.println("No se ha podido encontrar el archivo especificado \nERROR: " + e.getMessage());
                }
                System.out.println("Archivo procesado correctamente.");
            }
        } catch (Exception e) {
            System.out.println("Error no existen Argumentos");
        }
    }

    private static void AgregarVariable(String[] tokens, String tipo) {//recibe el arreglo de tokens y el tipo de variable
        for (int i = 0; i < tokens.length; i++) {
            if (!tokens[i].equals(tipo) && !tokens[i].equals(":") && !tokens[i].equals(";") && !tokens[i].equals(",")) {
                variables.add(new Variable(tokens[i], tipo));
                //System.out.println(tokens[i]);
                /*se recorre cada uno de los elementos del arreglo de tokens. 
                Si un token no coincide con el tipo de variable, ni con los 
                caracteres ":" , ";" y "," entonces se agrega a la lista de 
                variables con el tipo especificado.*/
            }
        }
    }

    private static void VerificarComaYTamanio(String tokens[], BufferedWriter bw) throws IOException {
        List<String> ignorados = List.of(":", ";", "(", ")", ",");
        int tamanio = 0;
        for (int i = 1; i < tokens.length; i++) {
            try {
                tamanio = Integer.parseInt(tokens[i]);
                if (tamanio > 20) {
                    bw.write("        ERROR 1039: El tamano es mayor a 20.");
                    bw.newLine();
                }
            } catch (NumberFormatException ex) {
                if (!ignorados.contains(tokens[i]) && !tokens[i + 1].equals(",")) {
                    bw.write("        ERROR 1040: Falta la coma despues de " + tokens[i]);
                    bw.newLine();
                }
            }
        }
    }
}
