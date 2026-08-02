# Registro de Libros - Algoritmos Computacionales

## Datos del estudiante
- Nombre: Lender Manuel Sanchez Monanci, Daysi Diaz 
- Matrícula: 25-SISN-2-047, 25-SISN-2-014
- Profesor: Gamalier Reyes del Carmen
- Asignatura: Algoritmos Computacionales

## Descripción de la actividad
Programa desarrollado en C# que implementa el uso de clases, objetos, arreglos
y archivos de texto. El programa define una clase `Libro` con las propiedades
código, título, autor, año, editorial y número de páginas. Se crea un arreglo
de 5 objetos `Libro`, cuyos datos son ingresados por teclado, mostrados en
pantalla (identificando cada uno como "Libro 1", "Libro 2", etc.) y
finalmente almacenados en un archivo de texto (`libros.txt`).

## Estructura del proyecto
```
LibrosApp/
├── Libro.cs          # Clase Libro (propiedades y método ToString)
├── Program.cs        # Lógica principal: captura, muestra y guarda los datos
├── LibrosApp.csproj  # Archivo de proyecto de .NET
└── README.md
```

## Cómo compilar y ejecutar
Se requiere tener instalado el [.NET SDK](https://dotnet.microsoft.com/download).

```bash
cd LibrosApp
dotnet run
```

El programa solicitará por teclado los datos de 5 libros, los mostrará en
pantalla y los guardará en un archivo `libros.txt` ubicado en la carpeta
donde se ejecuta el programa (`bin/Debug/net8.0/`).

## Capturas de pantalla

### 1. Captura de datos por teclado
[Insertar aquí la captura de pantalla mostrando el ingreso de datos]

### 2. Datos mostrados en pantalla
[Insertar aquí la captura de pantalla mostrando el listado de los 5 libros]

### 3. Contenido del archivo de texto
[Insertar aquí la captura de pantalla mostrando el contenido de libros.txt]

### 4. Ruta donde está alojado el archivo
C:\Users\Sanchez\OneDrive\Documentos\Tarea_#3\libros.txt

## Enlace del repositorio
https://github.com/lender2/Ingreso-de-libros-en-archivos-de-texto
