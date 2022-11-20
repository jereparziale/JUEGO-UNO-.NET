# parcial_labo2 Parziale Jeremias Laboratorio II Div. D.
## Titulo de la aplicacion
Administrador de salas del juego uno

## Flujo del programa
Todo el flujo del programa se desarrollará dentro del form principal, en donde a partir de este y su barra superior se podrán acceder a las distintas opciones posibles. El mismo cuenta con la barra superior anteriormente mencionada, en la zona izquierda un listbox que contendrá todas las salas que estan activas hasta el momento y se podrán seleccionar, la que sea seleccionada tendrá el foco para acceder a la zona centro-derecha y principal del form la cual contiene un groupbox con el nombre de la sala en foco, los boton de accion "jugar" y "pausa", un picturebox que mostrara la carta en mesa al momento y por último un textbox en donde se muestran todos el historial de manos de la partida.
![foto de diagrama](https://github.com/jereparziale/tp2.parziale.jeremias/blob/main/assets/menuPrincipal.jpeg)
![foto de diagrama](https://github.com/jereparziale/tp2.parziale.jeremias/blob/main/assets/botonCrearSala.jpeg)
###Crear Sala
El botón "crear sala", llamando al método AgregarSala de la clase estática Sistema y la sala se guardará en una Lista de salas de juego, en donde en su constructor estático se conectara a la base de datos a la tabla "Usuarios" y cargando el atributo de la clase Listado de Usuarios y se traen dos jugadores aleatorios creando así la sala.
![foto de diagrama](https://github.com/jereparziale/tp2.parziale.jeremias/blob/main/assets/ejemploBotonesFocoSala.jpeg)
Dando click a la sala, la misma se "pone en foco" y las acciones dentro del groupbox (jugar,cancelar) afectarán a la misma.
Al presionar el botón Jugar, se lanza en un nuevo hilo el método Jugar de la clase SalaDeJuego, instanciando una Partida y guardando la misma en el listado de partidas de sala (Las Salas de Juego contienen un listado de partidas ya que se pueden jugar ilimitadas veces dentro de una misma). En caso de presionar el botón Jugar en una sala con una partida activa se lanzará una excepción que no detendrá el programa. Ejemplo: 
![foto de diagrama](https://github.com/jereparziale/tp2.parziale.jeremias/blob/main/assets/ejemploExcepcionPartidaEnJuego.jpeg)
La clase partida cuenta con un Stringbuilder para almacenar todo el flujo de la partida en cuanto acciones de los jugadores, la instancia de los dos jugadores y la del posible jugador ganador, también el estado, el pozo de descarte de las distintas cartas en la mesa y demás atributos utilizados en las estadísticas. Además en su constructor se copia y se mezcla la baraja que fue deserializada en la clase sistema, a su vez se reparten 7 cartas a cada jugador. 
La baraja se compone de 3 tipos de cartas: Cartas Especiales, Cartas Comodín y Cartas Numéricas y todas aplican el contrato de la interfaz ICarta.

‘public void Jugar(CancellationToken cT)
        {
            int contador = 0;
            listadoDePartidas.Add(new Partida(Jugador1, Jugador2));
            PartidaEnJuego.InicioDelJuego();
            do
            {
                Task.Delay(2000).Wait();
                PartidaEnJuego.JugarMano();
                contador++;
            } while (contador < Sistema.Configuracion.CantidadDeManos && (jugador1.CartasRestantes > 0 
            && jugador2.CartasRestantes > 0) && !cT.IsCancellationRequested);
’


Continuando con el flujo del programa en el método Jugar de la SalaDeJuego para simular la partida se tiene un bucle do-while que finalizara en caso de que algún jugador se quede con 0 cartas, se alcance el límite de manos a jugar o se cancele la misma, en cada bucle se pausa la Task durante 2 segundos y se juega una mano con el método JugarMano de la clase partida, dentro el jugador mano entra al método EvaluarCaso en donde según la carta en mesa y las cartas que tiene en su mano retornara un número de caso (por ejemplo si combinan los números y/o el color de dos cartas numéricas el jugador tira, en caso de tirar una carta especial se vuelve a tirar, en caso de ser la primera vez que no tiene opciones para jugar levanta una carta). Luego de que se retorne el número de caso, el mismo pasa por parametro al metodo JugarCasoEvaluado y el mismo realiza la acción correspondiente cargando a su vez el StringBuilder del historial de la partida.
Volviendo al flujo de la SalaDeJuego, en caso de que la misma finalice por una cancelación se cambia el estado de la partida a cancelada. Por terminar el bucle en los otros casos se evalúa el ganador cargando con la instancia del jugador correspondiente el atributo jugador ganador y a su vez se guarda la partida en la tabla SQL partidas. 
Para solucionar la “limitación” de contar con un único textbox y utilizar la multitarea se tenía el error de que todas las partidas intentaban escribir en este al mismo tiempo, para eso cada partida tiene asociada 3 eventos para controlar esto según qué sala contenga el foco en el form principal. desuscribiendo a todas a la vez y luego suscribiendo a la que cuenta con el foco.
Uno de estos eventos muestra el Historial de partida en el textbox y envia la carta en mesa en el momento para que la misma pueda acceder al path y mostrar la imagen, otro hace referencia a la estadística a mostrar una vez se finaliza la partida y lanzando el form con estas y en caso de la sala en foco se podrá acceder a la acción volver a jugar, caso contrario estará deshabilitado.
![foto de diagrama](https://github.com/jereparziale/tp2.parziale.jeremias/blob/main/assets/ejemploFormEstadistica.jpeg)

###Listado De Jugadores
Mostrará en un form y un data grid toda la información de los usuarios y si se encuentran dentro de una sala en ese momento.
![foto de diagrama](https://github.com/jereparziale/tp2.parziale.jeremias/blob/main/assets/ejemploListadoJugadores.jpeg)

###Estadísticas De Sala
La misma mostrará todas las estadísticas únicamente de la sala en foco en ese momento y de las partidas jugadas en esa instancia de sala sin utilizar SQL y basandose en el listado de partidas de la sala.
![foto de diagrama](https://github.com/jereparziale/tp2.parziale.jeremias/blob/main/assets/ejemploEstadisticasSala.jpeg)

###Estadísticas Globales
(Consultar Clase PartidasDAO )
Utilizando SQL se dan 6 opciones de estadísticas a ver, a través de las tablas partidas y usuarios.
Jugadores mas ganados, agrupando partidas y usuarios y ordenando al principio al jugador con mas partidas ganadas.
Cantidad de partidas jugadas, trae el número de registros de partidas.
Cantidad de Cartas Especiales más utilizadas y ordenando de mayor a menor.
Cantidad de partidas finalizadas en donde el ganador quedó con 0 cartas.
Cantidad de partidas con empate.
Historial entre jugadores en donde se seleccionan dos jugadores en un combobox y se trae el historial de partidas ganadas ENTRE ambos.
![foto de diagrama](https://github.com/jereparziale/tp2.parziale.jeremias/blob/main/assets/ejemploEstadisticasGlobales.jpeg)

###Configuración
Se puede configurar la cantidad de manos a jugar en cada partida, el mismo al iniciar se setea desde el archivo de config.json en Sistema.Configuración y al guardar la modificación del mismo se guarda tanto en Sistema.Configuración como en el archivo json. Aplicando serialización y deserealizacion.
![foto de diagrama](https://github.com/jereparziale/tp2.parziale.jeremias/blob/main/assets/ejemploConfiguracion.jpeg)



## DIAGRAMA DE CLASES
![foto de diagrama](https://github.com/jereparziale/tp2.parziale.jeremias/blob/main/assets/diagramaDeClases.jpeg)

##TEMAS APLICADOS
###SQL
Aplicado en listado de usuarios y estadísticas globales, la base se compone de dos tablas, usuarios con su nombre, id (PK) y nombre de usuario y partidas que guarda la misma y todos los atributos para a través de query y FK idUsuario/idJugador se puedan obtener las estadísticas.
#####Referencias
PartidasDAO
UsuariosDAO

###EXCEPCIONES
Las mismas fueron aplicadas a lo largo de todo el sistema para evitar errores que no detendrán la ejecución del programa y a medida que se fueron aplicando los unit testing se fueron agregando aún más con sus try/catch correspondientes.

###GENERICS
Se aplicó en la serializadora en permitiendo reutilizar la clase para tanto los archivos de configuración como la baraja.
#####Referencias
Serializadora<T>

###SERIALIZACIÓN
Se aplico JSON en la funcionalidad Configuracion y en la Carga de la baraja al iniciar el programa y fue detallado en el flujo del programa, al no poder serializar las interfaces que aplica mi clase baraja, se debieron instanciar 3 listas por separadas de los 3 tipos de cartas y luego de deserializar se juntan en una lista y stack de tipo ICarta.
#####Referencias
Serializadora<T>
Sistema (constructor estatico)
Configuracion
Baraja

###ESCRITURA DE ARCHIVOS
Al finalizar el programa, todas las partidas que se encuentren en estado finalizado (no cancelado) se guardará su historial en la carpeta del escritorio, con la fecha y la descripción de la sala.
#####Referencias
ManejadorDeArchivos
Evento Cerrar del form principal

###Interfaces
Se aplicó una única interfaz de tipo ICarta para no solo generar un contrato con respecto a las propiedades sino para mejorar el agrupamiento de los 3 tipos de cartas distintas. 
El contrato consta de dos propiedades que es necesario que las cartas apliquen, si pueden ser primer carta al iniciar la partida y traer una carta a la meza y el path de la ruta para que el form principal pueda acceder al mismo.

#####Referencias
ICarta
Baraja

###Delegados/Eventos
Fue aplicado para generar los eventos y métodos para poder permitir que las distintas partidas escriban en el form principal. (Detallado en flujo del programa).
#####Referencias
Partidas

###Task
Fue aplicado para lanzar una nueva tarea al presionar el botón jugar y agregar la partida al listado de las salas de juego del programa.
(Detallado en flujo del programa).
#####Referencias
SalaDeJuego





 


