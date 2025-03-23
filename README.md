# Árbol Binario de Búsqueda

## Descripción
Este proyecto implementa un Árbol Binario de Búsqueda (ABB) en C#. Permite agregar, eliminar y recorrer el árbol en diferentes órdenes (PreOrden, InOrden y PostOrden). Cuenta con una interfaz de consola interactiva que permite al usuario gestionar el árbol de manera sencilla.

## Estructura del Proyecto
El proyecto consta de los siguientes archivos principales:

1. **Program.cs**
   - Punto de entrada del programa.
   - Inicia la ejecución llamando al menú de opciones.

2. **Nodo.cs**
   - Define la estructura del nodo del árbol.
   - Cada nodo contiene un dato, una referencia al hijo izquierdo y otra al hijo derecho.

3. **ArbolBinario.cs**
   - Implementa la estructura del Árbol Binario de Búsqueda.
   - Métodos principales:
     - `Add(int data)`: Agrega un nuevo nodo al árbol.
     - `Delete(int data)`: Elimina un nodo del árbol.
     - `PreOrder()`: Recorre el árbol en preorden.
     - `InOrder()`: Recorre el árbol en inorden.
     - `PostOrder()`: Recorre el árbol en postorden.

4. **Menu.cs**
   - Proporciona una interfaz de usuario en la consola.
   - Permite al usuario seleccionar operaciones sobre el árbol:
     - Insertar un valor.
     - Eliminar un valor.
     - Imprimir el árbol en diferentes órdenes.
     - Salir del programa.

## Funcionalidades
- **Agregar un valor al árbol**: Permite insertar nuevos elementos manteniendo la propiedad del ABB.
- **Eliminar un valor del árbol**: Permite eliminar nodos y reorganizar el árbol si es necesario.
- **Recorridos del árbol**:
  - **PreOrden**: Nodo → Izquierda → Derecha.
  - **InOrden**: Izquierda → Nodo → Derecha.
  - **PostOrden**: Izquierda → Derecha → Nodo.
- **Interfaz de usuario en consola**: Facilita la interacción con el programa mediante un menú de opciones.

## Cómo Ejecutar el Proyecto
1. Compila y ejecuta el programa en un entorno de desarrollo C# compatible (Visual Studio, JetBrains Rider, etc.).
2. Sigue las instrucciones del menú en la consola para realizar operaciones sobre el árbol.

## Ejemplo de Uso
```
Arbol De Busqueda Binario
=========================
1. Agregar un valor al arbol
2. Eliminar un valor del arbol
3. Imprimir En PreOrden
4. Imprimir En InOrden
5. Imprimir En PostOrden
6. Salir Del Programa
```

## Requisitos
- .NET Framework o .NET Core.
- Un compilador de C# compatible.

## Autor
Desarrollado por **Chepe Echen Paja**.
