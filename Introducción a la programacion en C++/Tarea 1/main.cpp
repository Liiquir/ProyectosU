#include <iostream>
#include <stdlib.h>
#include <locale.h>
#include <time.h>

using namespace std;

int Turno(int jugador, string nombre)
{
    int respuesta;
    int numeros[3];
    int numRandom = (rand()%999)+1;//calculo de numero aleatorios

    numeros[0]=numRandom/100;
    numeros[1]=(numRandom - (numeros[0]*100))/10;
    numeros[2]=numRandom%10;

    cout <<"\nJugador "<<jugador<<":"<<nombre;
    cout <<"\n¿Cuántas centenas tiene el número "<<numRandom<<"?\n";
    cout <<"Respuesta: ";
    cin >> respuesta;

    if(respuesta==numeros[0])
    {
        cout <<"\n¿Cuántas decenas tiene el número "<<numRandom<<"?\n";
        cout <<"Respuesta: ";
        cin >> respuesta;
        if(respuesta==numeros[1])
        {
            cout <<"\n¿Cuántas unidades tiene el número "<<numRandom<<"?\n";
            cout <<"Respuesta: ";
            cin >> respuesta;
            if(respuesta==numeros[2])
            {
                cout<<"\nRespuestas correctas, ha ganado un punto!" <<"\n\n";
                return 1;
            }
        }
    }
    return 0;

}

int main()
{ system("cls");
    setlocale(LC_CTYPE, "Spanish");
    string nombre, nombre2;

    int puntuaciones[2]= {0,0};


    srand((unsigned) time(0));

    cout << "\t\tJuego de centenas, decenas y unidades\n\n";
    cout << "Escriba el nombre del jugador número 1: ";
    cin >> nombre;//pedir el nombre por teclado
    cout << "Escriba el nombre del jugador número 2: ";
    cin >> nombre2;


    for(int contador=1; contador<=20; contador++)
    {
        cout<<"\n\t\tRonda: "<<contador<<"\n";

        puntuaciones[0]=puntuaciones[0] + Turno(1,nombre);//juega jugador 1
        puntuaciones[1]=puntuaciones[1] + Turno(2,nombre2);//juega jugador 2


    }
    cout << "\nPuntuación jugador 1:"<< puntuaciones[0]<<"\n";
    cout << "Puntuación jugador 2:"<< puntuaciones[1]<<"\n";


    puntuaciones[0]==puntuaciones[1]?
    cout<< "No hay ganador, empate!"
        :
        cout << "El ganador es el jugador: "<< (puntuaciones[0]>puntuaciones[1]? nombre: nombre2);

    string res;
    cout << "\n\n¿Desea volver a jugar? (s/n): ";
    cin >>  res;
    res=="s" || res=="S" ? main() : NULL; // Forma corta del if
    cout << "¡Hasta luego!";
    return 0;
}

