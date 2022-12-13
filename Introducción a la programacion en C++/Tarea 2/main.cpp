#include <iostream>
#include <stdlib.h>
#include <locale.h>
#include <time.h>
#include <array>
using namespace std;
int tablero1 [8][8];
int tablero2 [8][8];
int jugando = 1;

void InicializarTableros()
{
    srand(time(NULL));

    for (int fila = 0; fila < 8; fila++)
    {
        for (int columna = 0; columna < 8; columna++)
        {
            tablero1[fila][columna] = 1+ rand() % 19;

        }


    }

    for (int fila = 0; fila < 8; fila++)
    {
        for (int columna = 0; columna < 8; columna++)
        {
            tablero2[fila][columna] = 1+ rand() % 19;


        }


    }
}
void ImprimirTablero(int tablero[8][8], int num)
{

    cout <<"\nTablero "<<num<<"\n\n";
    for (int fila = 0; fila < 8; fila++)
    {
        for (int columna = 0; columna < 8; columna++)
        {
            cout << tablero[fila][columna] << "\t ";
        }
        cout<<endl;
    }
    cout<<endl;

}

array<int,2> NumeroElegido(int num)
{

    // ejm: num = 13, la matriz empieza en la posicion 0,0 por lo que se hace la resta
    int fila= (num/10)-1; // posicion 1
    int col = (num%10)-1; // posicion 2
    array<int,2> posiciones;
    posiciones[0] = fila;
    posiciones[1] = col;

    return posiciones;
}

void DeshabilitarCampos(array<int,3> campos,int tablero)
{
    array<int,2> posiciones;

    for(int i=0; i<3; i++)
    {
        if(campos[i]!=0)
        {
            posiciones = NumeroElegido(campos[i]);
            if(tablero==1)
            {
                tablero1[posiciones[0]][posiciones[1]]=0;
            }
            else
            {
                tablero2[posiciones[0]][posiciones[1]]=0;
            }
        }

    }
}

bool Jugar(int jugador, string nombre,int tablero[8][8])
{

    array<int,3> campos;
    array<int,2> posiciones;

    string respuesta="";
    int suma = 0;

    cout<<"Juega el jugador "<<jugador<<", "<<nombre<<endl;
    ImprimirTablero(tablero,jugador);
    cout<<"Info: Debe selecciona 2 o 3 campos del tablero que sumen 20."<<endl;

    for(int i=0; i<3; i++)
    {
        cout<<"Digite la fila y la columna del numero:"<<i+1<<" (0 para vacio): ";
        cin >> campos[i];

        if(campos[i]!=0)
        {
            while(campos[i]<10 || campos[i]>88)
            {
                cout<<"El campo seleccionado no existe! Digite uno que exista:";
                cin >> campos[i];
            }

            posiciones = NumeroElegido(campos[i]);

            if(jugador==1)
            {
                int valor = tablero1[posiciones[0]][posiciones[1]];
                cout<<"Valor seleccionado:"<<valor<<endl;
                suma+=valor;
            }
            else
            {
                int valor = tablero2[posiciones[0]][posiciones[1]];
                cout<<"Valor seleccionado:"<<valor<<endl;
                suma+=valor;
            }
        }
    }

    // se verifica que la suma sea 20
    if(suma==20)
    {
        cout<<endl<<"Muy bien!\n"<<endl;
        DeshabilitarCampos(campos,jugador);
        cout<<"Campos desactivados"<<endl;
        ImprimirTablero(tablero,jugador);
    }
    else
    {
        cout<<"Fallaste!, Suma: "<<suma<<endl;
    }

    // Se cambia de jugador
    if(jugando==1)
    {
        jugando=2;
    }
    else
    {
        jugando=1;
    }
    // Condicion para cerrar el juego
    cout<<"Desea continuar(s/n)?";
    cin>>respuesta;

    if(respuesta=="s")
    {
        return true;
    }
    else
    {
        return false;
    }

}

bool RevisarTablero(int jugador,int tablero[8][8])
{
    // Revisamos cuantos campos quedan en total disponibles
    int totalCampos = 0;
    for (int fila = 0; fila < 8; fila++)
    {
        for (int columna = 0; columna < 8; columna++)
        {
            if(tablero[fila][columna]!=0)
            {
                totalCampos++;
            }
        }
    }
    // Luego revisamos si son menos de 3, en caso contrario no hace falta hacer nada
    if(totalCampos==3)
    {
        // Sumamos los campos que quedan para saber si se puede conseguir un 20
        int suma=0;

        for (int fila = 0; fila < 8; fila++)
        {
            for (int columna = 0; columna < 8; columna++)
            {
                if(tablero[fila][columna]!=0)
                {
                    suma+=tablero[fila][columna];
                }
            }
        }

        if(suma<20)  // Ya no se puede hacer trios
        {
            return false;
        }

        return true;
    }

    if(totalCampos==2)// Ya no se puede hacer duos
    {
        // Sumamos los campos que quedan para saber si se puede conseguir un 20
        int suma=0;

        for (int fila = 0; fila < 8; fila++)
        {
            for (int columna = 0; columna < 8; columna++)
            {
                if(tablero[fila][columna]!=0)
                {
                    suma+=tablero[fila][columna];
                }
            }
        }

        if(suma<20)  // Ya no se puede hacer duos
        {
            return false;
        }

        return true;
    }

    return true;
}

int Ganador()
{
    // Se busca quien tiene mas movimientos disponibles
    int movsFaltantesT1=0;
    int movsFaltantesT2=0;

    // Revisa los dos tableros a la vez
    for (int fila = 0; fila < 8; fila++)
    {
        for (int columna = 0; columna < 8; columna++)
        {
            if(tablero1[fila][columna]!=0)
            {
                movsFaltantesT1+=tablero1[fila][columna];

                if(tablero2[fila][columna]!=0)
                {
                    movsFaltantesT2+=tablero2[fila][columna];
                }

            }
        }
    }


    if(movsFaltantesT1 > movsFaltantesT2)
    {
        return 1; // Gana jugador 1
    }

    if(movsFaltantesT1 < movsFaltantesT2)
    {
        return 2; // Gana jugador 2
    }
    return 0; // Empate
}
int main()
{
    bool sigue = true;

    system("cls");
    setlocale(LC_CTYPE, "Spanish");
    string nombre1, nombre2;

    cout << "\t\tParejas y tríos: suma a 20\n\n";
    cout << "Escriba el nombre del jugador número 1: ";
    cin >> nombre1;//pedir el nombre por teclado
    cout << "Escriba el nombre del jugador número 2: ";
    cin >> nombre2;
    cout<<endl;

    InicializarTableros();

    while(sigue)
    {
        if(jugando==1)
        {
            if(RevisarTablero(1,tablero1))
            {
                sigue = Jugar(1,nombre1,tablero1);
            }
            else
            {
                cout<<"Ya no puede hacer mas trios o duos! Gracias por jugar";
                return 0;
            }

        }
        else
        {
            if(RevisarTablero(2,tablero2))
            {
                sigue = Jugar(2,nombre2,tablero2);
            }
            else
            {
                cout<<"Ya no puede hacer mas trios o duos! Gracias por jugar";
                return 0;
            }
        }
    }

    switch(Ganador())
    {

    case 0:
        cout<<"Empate!"<<endl;
        break;
    case 1:
        cout<<"Gano el jugador: 1";
        break;
    case 2:
        cout<<"Gano el jugador: 2";
        break;

    }

    return 0;
}

