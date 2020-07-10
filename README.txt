
           .-')                ('-.           _ .-') _     ('-.
          ( OO ).             ( OO ).-.      ( (  OO) )  _(  OO)
  ,-.-') (_)---\_) ,--.       / . --. /       \     .'_ (,------.,--.
  |  |OO)/    _ |  |  |.-')   | \-.  \        ,`'--..._) |  .---'|  |.-')
  |  |  \\  :` `.  |  | OO ).-'-'  |  |       |  |  \  ' |  |    |  | OO )
  |  |(_/ '..`''.) |  |`-' | \| |_.'  |       |  |   ' |(|  '--. |  |`-' |
 ,|  |_.'.-._)   \(|  '---.'  |  .-.  |       |  |   / : |  .--'(|  '---.'
(_|  |   \       / |      |   |  | |  |       |  '--'  / |  `---.|      |
  `--'    `-----'  `------'   `--' `--'       `-------'  `------'`------'
 .-') _     ('-.    .-')                _  .-')
(  OO) )  _(  OO)  ( OO ).             ( \( -O )
/     '._(,------.(_)---\_) .-'),-----. ,------.  .-'),-----.
|'--...__)|  .---'/    _ | ( OO'  .-.  '|   /`. '( OO'  .-.  '
'--.  .--'|  |    \  :` `. /   |  | |  ||  /  | |/   |  | |  |
   |  |  (|  '--.  '..`''.)\_) |  |\|  ||  |_.' |\_) |  |\|  |
   |  |   |  .--' .-._)   \  \ |  | |  ||  .  '.'  \ |  | |  |
   |  |   |  `---.\       /   `'  '-'  '|  |\  \    `'  '-'  '
   `--'   `------' `-----'      `-----' `--' '--'     `-----'              

// Isla del Tesoro by Xiutek
Se trata de unn juego basado en texto desarrollado en C#

Isla del Tesoro es un proyecto colaborativo por la Facultad XP de AME
Libre distribución, replica modificación con créditos al autor (Xiutek)



// Estructura del Repositorio:

REAMDE : Información e Instrucciones
Source : Código fuente
Isla del Tesoro: Acceso directo al Ejecutable

Source / IslaTesoro:
Isla_del_Tesoro.sln : Proyecto de Visual Studio
Isla_del_Tesoro.cs : Archivo MAIN, invoca al resto de los .cs

Sourse / IslaTesoro / bin / Release / netcoreapp3.1
Isla_del_Tesoro.exe : Archivo Ejecutable en Windows



// Instrucciones

1. Clonar este repositorio (descargar este repositorio como zip y descomprimirlo en tu ordenador)
2. Abrir el Acceso Directo al ejecutable o bien el ejecutable para iniciar el juego.

Información:
El repositorio cuenta en la carpeta principal con un acceso directo al archivo ejecutable, que se encuentra en (t_isla/Sourse/IslaTesoro/bin/Release/netcoreapp3.1/Isla_del_Tesoro.exe) 
Abrir el Acceso directo debería iniciar el juego, si esto no ocurre, navegar a la ruta del ejecutable y abrirlo directamente.
Esperar a que la consola inicie el juego preguntando si el usuario desea ver el tutorial y responder para iniciar el juego.


// Problemas al iniciar

Venta de avertencia que no se puede ejecutar el programa.
Solución: Ver más información y permitir la ejecución del programa.

Ni el acceso directo ni el ejecutable inician la aplicación de consola.
Solución: Verificar configuración del antivirus, ejecutar como administrador.

El juego se cierra después de abrir la aplicación de consola.
Solución: Instalar .NET framework y visual studio.


// Bugs conocidos

La aplicación se cierra inesperadamente al solicitar dificultad.
Solución: Esto puede ocurrir bajo circunstancias aún no indentificadas, volver a iniciar la aplicación podría solucionar el problema.

La aplicación se cierra inesperadamente al introducir un movimiento.
Causas: El movimiento ha excedido los límites del mapa ACSII sobre todo en dificultad 3
Solución: Evitar realizar este tipo de movimientos.
Información adicional: Existen filtros para prevenir este bug sin embargo llega a ocurrir pese a los filtros. Revisar en game.cs

No es posible introducir un movimiento válido.
Causas: Desconocidas.
Solución: Intentar un movimiento 0 o 1.

- - - - - - - - - - - - - - - - - - - - - - -



Colaboración: Solicitar colaborar en este proyecto en GitHub o bien con un correo a xiutek@gmail.com

Desarrollado por Xiutek (J Pablo Fdez M)
para "Lógica de la Programación" || XP

Licencia Creative Commons (cc)
http://github.com/xiutek/t_isla

Visita: https://open.spotify.com/artist/5qTnLG6ibaUhGHInogBQyy


▒██   ██▒ ██▓ █    ██ ▄▄▄█████▓▓█████  ██ ▄█▀
▒▒ █ █ ▒░▓██▒ ██  ▓██▒▓  ██▒ ▓▒▓█   ▀  ██▄█▒
░░  █   ░▒██▒▓██  ▒██░▒ ▓██░ ▒░▒███   ▓███▄░
 ░ █ █ ▒ ░██░▓▓█  ░██░░ ▓██▓ ░ ▒▓█  ▄ ▓██ █▄
▒██▒ ▒██▒░██░▒▒█████▓   ▒██▒ ░ ░▒████▒▒██▒ █▄
▒▒ ░ ░▓ ░░▓  ░▒▓▒ ▒ ▒   ▒ ░░   ░░ ▒░ ░▒ ▒▒ ▓▒
░░   ░▒ ░ ▒ ░░░▒░ ░ ░     ░     ░ ░  ░░ ░▒ ▒░
 ░    ░   ▒ ░ ░░░ ░ ░   ░         ░   ░ ░░ ░
 ░    ░   ░     ░                 ░  ░░  ░





