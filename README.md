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

<img width="960" height="1034" alt="Screenshot 2026-08-02 012617" src="https://github.com/user-attachments/assets/9aae4971-611f-4fda-9e6b-aa61308874f7" />


### 2. Datos mostrados en pantalla

<img width="960" height="1080" alt="{583B4AB4-5B3E-46E4-A97F-CB864424B365}" src="https://github.com/user-attachments/assets/1f1d3859-e420-41d8-ac3e-954c7e9988c3" />


### 3. Contenido del archivo de texto

<img width="1920" height="1080" alt="{BEBDB17A-6560-436E-AC36-DE8698EC1D70}" src="https://github.com/user-attachments/assets/18312fab-9774-47fb-a25d-c72f6231b169" />


### 4. Ruta donde está alojado el archivo
C:\Users\Sanchez\OneDrive\Documentos\Tarea_#3\libros.txt

## Enlace del repositorio
https://github.com/lender2/Ingreso-de-libros-en-archivos-de-texto
