#include <iostream>
#include <fstream>
#include <iomanip>
#include <ctype.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>
#include <ctime>
#include <cstdlib>
using namespace std;




//Funciones utilizadas
void Juego ();
void MostrarJugadores(int, const char * conts, const char * cont);
void LlenarMatriz (int matriz [10][10],int control [10][10]);
void MostrarMatriz (int matriz [10][10],int control [10][10]);
void Marcas (int matriz [10][10],int control [10][10],int res);
void pts (int control [10][10], int &puntos);
int Dado ();
int numAzar();
int cantidad();


//Variables
char menu = 0;
char resp;
char numCedula[]="";
int Cedula;
char nombre [30];
char apellido [30];
char volvermenu = 0;
char submenu = 0;
int matriz [10][10];
int control [10][10];




//Función principal
int main()
{
    system("cls");
    setlocale(LC_CTYPE, "Spanish");

    srand(time(NULL));

    do//Devuelve para empezar de nuevo la función main
    {
        system("CLS");   //Limpia la pantalla al volver al principio de main

        cout<<"Menú principal\n";
        cout<<"1. Jugar\n";
        cout<<"2. Los 10 mejores jugadores \n";
        cout<<"3. Reporte general de jugadores\n";
        cout<<"4. Ingresar jugadores\n";
        cout<<"5. Salir\n ";
        cout << "\n Seleccione una opción:";
        cin >> menu;
        cout<<"\n";
        switch (menu)//Empienza el switch
        {
        case '1':
        {
            Juego();
        }


        break;

        case '2'://Opción 2
            system("CLS");            //Limpia la pantalla
            {


                ifstream Ranking("ranking.txt", ios::in);// Lee y abre el archivo

                if (!Ranking)//Por si no puede abrir el archivo
                {
                    cout << "No se puede abrir el archivo ranking.txt" << endl; //Comentario mostrado en pantalla
                    exit(1);//Sale del programa
                }
            }
            break;

        case '3'://Opción 3

        {
            system("CLS");            //Limpia la pantalla

            ifstream regJugadores("Jugadores.txt", ios::in);// Lee y abre el archivo

            if (!regJugadores)//Por si no puede abrir el archivo
            {
                cout << "No se puede abrir el archivo Jugadores.txt" << endl; //Comentario mostrado en pantalla
                exit(1);//Sale del programa
            }
            cout <<"\nLos jugadores ingresados al sistema son\n\n";
            cout <<left << setw(10) << "Cedula" <<  setw(10) << "Nombre" <<  setw(10) << "Apellido"  <<  endl;
            while (regJugadores >> Cedula >> nombre >> apellido )
            {
                MostrarJugadores(Cedula, nombre, apellido);
            }

            cout <<"\nDigite una tecla para volver al menú: ";
            _getch();
        }

        break;

        case '4'://Opción 4
        {
            system("CLS");            //Limpia la pantalla



            ofstream registro("Jugadores.txt",ios::app);// Crea el archivo y lo abre

            if (!registro)//Por si no se abre el archivo
            {
                cout << "No se puede abrir el archivo Jugadores.txt" << endl; //Comentario mostrado en pantalla
                exit(1);//Sale del programa
            }



            cout << "Desea ingresar los datos del Jugador S/N: " ;
            cin >> resp;


            while (resp == 'S' or resp == 's' )

            {
                cout << "Cedula: ";
                cin >> numCedula;
                if (isdigit(numCedula[0]))//Válida que sean solo números
                {
                    Cedula = atoi (numCedula); //Convierte cadena de caracteres a numeros enteros, la idea se saco de este video https://www.youtube.com/watch?v=oNc_WK7-G7s
                }

                else
                {
                    cout << "\nSolo se permiten números, debe volver a iniciar\n\n";
                    remove ("jugadors.txt");
                    system("pause");
                    return 0;
                }

                cout << "Nombre: ";
                cin >>nombre;
                cout << "Apellido: ";
                cin >>apellido;

                registro << Cedula <<' ' << nombre <<' ' << apellido << endl;
                system("CLS");


                cout<<"Desea ingresar otro jugador S/N:";
                cin>>resp;
            }
        }

        break;

        case '5'://Opción 5

            exit(0); //salir del programa

            break;

        default: //Por si no ingresa la opcion correcta

            system("CLS"); //Limpia la pantalla

            cout << "\nLa selección no es válida\n";
            system("pause");
            break;
        }
    }
    while (volvermenu >= 0);   //Condición para volver a iniciar main )
}
//desarrollo de funciones
void Juego ()
{
    LlenarMatriz(matriz,control);
    ifstream regJugadores("Jugadores.txt", ios::in);// Lee y abre el archivo

    if (!regJugadores)//Por si no puede abrir el archivo
    {
        cout << "Los jugadores no se encuentran registrados, debe digitar primero la opción 4." << endl; //Comentario mostrado en pantalla
        exit(1);//Sale del programa
    }
    string Jugador1, jugador2, JugadorActual;
    int i=0;
    while (regJugadores >> Cedula >> nombre >> apellido )
    {
        if (i==0)
        {
            Jugador1=nombre;
            i++;
            JugadorActual=Jugador1;
        }
        else
        {
            jugador2=nombre;
        }
    }


    int Puntos=0;
    int puntuacion1=0, puntuacion2=0;

    for(int j=0; j<20; j++)
    {
        system("CLS");
        MostrarMatriz(matriz,control);
        int Dado1= Dado();
        int Dado2= Dado();
        cout<<"Jugador:"<<JugadorActual<<endl;
        cout<<"Puntos:"<<Puntos<<endl;
        cout<<"Turno:"<<j+1<<endl;

        cout<<"Primer Dado:"<<Dado1<<endl;
        cout<<"Segundo Dado:"<<Dado2<<endl;


        int res=0;
        do
        {
            cout<<"El resultado es:";
            cin>>res;

            if (cin.fail())
            {
                cout<<"Digite solo valores numericos\n\n";

            }
        }
        while(res==0 or cin.fail());

        if(res==(12))
        {
            cout<<"Correcto\n";
            Marcas(matriz,control,res);
            pts(control,(JugadorActual==Jugador1? puntuacion1:puntuacion2));
            cout<<"Presione una tecla para continuar";


        }
        else
        {
            cout<<"Respuesta incorrecta\n";
            cout<<"El resultado era:"<<(Dado1*Dado2)<<endl;
            cout<<"\nPresione una tecla para continuar\n";

        }_getch();
        if (JugadorActual==Jugador1)
        {

            JugadorActual=jugador2;
        }
        else
        {
            JugadorActual=Jugador1;
        }
        Puntos=(JugadorActual==Jugador1? puntuacion1:puntuacion2);


        ofstream Archivo ("juego.dat");
        Archivo<<Jugador1<<puntuacion1<<"\n";
        Archivo<<jugador2<<puntuacion2;
        Archivo.close();
        }
if(puntuacion1==puntuacion2){
cout<<"\nPuntuación de "<<Jugador1<<":"<<puntuacion1;
cout<<"\nPuntuación de "<<jugador2<<":"<<puntuacion2;
    cout<<"\nEs un empate";
}
if(puntuacion1>puntuacion2){
cout<<"\nPuntuación de "<<Jugador1<<":"<<puntuacion1;
cout<<"\nPuntuación de "<<jugador2<<":"<<puntuacion2;
    cout<<"\nEl ganador es:"<<Jugador1;
}
if(puntuacion1<puntuacion2){
cout<<"\nPuntuación de "<<Jugador1<<":"<<puntuacion1;
cout<<"\nPuntuación de "<<jugador2<<":"<<puntuacion2;
    cout<<"\nEl ganador es:"<<jugador2;
}
_getch();
}
//funcion para mostrar los datos de los jugadores
void MostrarJugadores(int Cedula, const char * const nombre, const char * const apellido )
{
    cout <<left << setw(10) << Cedula << setw(10) << nombre << setw(10) << apellido << endl;
}
//funciones de llenar las matrices de juego y de control
void LlenarMatriz (int matriz [10][10],int control [10][10])
{
    for (int i =0; i<10; i++)
    {
        for (int j=0; j<10; j++)
        {
            matriz[i][j]= numAzar();
            control[i][j]= 0;
        }

    }
}
//funcion de mostrar la matriz
void MostrarMatriz (int matriz [10][10],int control [10][10])
{
    for (int i =0; i<10; i++)
    {
        for (int j=0; j<10; j++)
        {
            cout<<matriz[i][j];
            for(int k=0; k<control[i][j]; k++)
            {
                cout<<"+";
            }
            cout<<"\t";
        }
        cout<<"\n"<<endl;
    }
}
//funcion para elegir numeros de los multiplos deseados
int numAzar()
{
    int num = 1+ rand()% 36;
    while(num%2!=0 && num%3!=0 && num%4!=0 && num%5!=0 && num%6!=0)
    {
        num = 1+ rand()% 36;
    }
    return num;

}
//funcion para lanzar el dado y generar los numeros aleatorios ente 1 y 6
int Dado()
{
    return 1 + rand() % 6;
}
//funcion que pone las marcas en los aciertos de lo jugadores
void Marcas (int matriz [10][10],int control [10][10], int res)
{
    for (int i =0; i<10; i++)
    {
        for (int j=0; j<10; j++)
        {
            if(matriz [i][j]== res)
            {
                control[i][j]++;

            }
        }

    }
}
//funcion que luego de 4 aciertos asigna los puntos
void pts (int control [10][10], int &puntos)
{
    for (int i =0; i<10; i++)
    {
        for (int j=0; j<10; j++)
        {
            if(control [i][j]== 4)
            {
                cout<<"Posición["<<i<<"]["<<j<<"] +1 Punto"<<endl;
                puntos++;
                control [i][j]=0;
            }
        }

    }
}
//funcion para el ranking
int cantidad()
{
    ifstream lectura("Jugadores.txt");
    int filas=0;
    string linea;
    while (getline(lectura,linea))
    {
        filas++;
    }
    return filas;
}
