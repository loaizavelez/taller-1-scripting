### Comandos curiosos

```bash

echo hello world
cat access.log
tail -n 5 access.log 
touch take-the-command-challenge
mkdir -p tmp/files
mv take-the-command-challenge
ln -s tmp/files/take-the-command-challenge take-the-command-challenge
find . -delete
grep "GET" access.log
ls *
grep -roh --include="access.log*" '^[0-9]\{1,3\}\.[0-9]\{1,3\}\.[0-9]\{1,3\}\.[0-9]\{1,3\}' .


```

la n en tail es el numero de archivos.

touch es para crear archivos vacios.

mkdir comando para crear directorios.
-p crea también las carpetas intermedias necesarias.

ln para creas enlaces 
-s soft link, enalce simbolico 

grep para acceder a todos los archivos


