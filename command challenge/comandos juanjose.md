```bash
tac access.log
yes "hola"
watch -n 1 ls
nl access.log
ls | column
shuf access.log
basename /home/user/file.txt
stat access.log
```

tac muestra el contenido del archivo al revés, empezando por la última línea.
yes imprime una palabra de forma infinita, se usa mucho para pruebas o para alimentar otros comandos.
watch ejecuta un comando cada cierto tiempo. -n 1 indica que se ejecuta cada segundo.
nl muestra el contenido de un archivo numerando las líneas.
column organiza la salida en columnas, se usa normalmente con pipes.
shuf mezcla las líneas de un archivo de forma aleatoria.
basename extrae solo el nombre del archivo a partir de una ruta completa.
stat muestra información detallada de un archivo como permisos, tamaño y fechas.