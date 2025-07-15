# Rick & Morty Visualizador - Blazor WebAssembly

Aplicación desarrollada como prueba técnica para Aprendiz QA/Dev – CubiQ.  
Permite visualizar personajes de la serie *Rick and Morty* y votar con Likes/Dislikes.  
Construido con **Blazor WebAssembly** y **.NET**.

## Descripción general del proyecto

Esta aplicación consume la API pública de [Rick and Morty](https://rickandmortyapi.com/) para listar personajes en una galería visual.  
Cada personaje puede recibir votos de "Like" y "Dislike", y se muestra su puntaje individual.  
Los votos son persistidos localmente usando `localStorage`.

## Instrucciones para ejecutar la app

1. Clona este repositorio:
   git clone https://github.com/tu-usuario/rick-and-morty-blazor.git
   cd rick-and-morty-blazor
2. Abre el proyecto en Visual Studio VS Code
3. Ejecuta la aplicacion 
    dotnet run
4. El navegador se abre en la direccion de su localhost y muestra la app


## Cómo se consumió la API?

Se utilizó HttpClient para obtener datos desde:
    GET https://rickandmortyapi.com/api/character
La respuesta se deserializa en un modelo Character.cs, y se visualiza como tarjetas (cards) en un grill responsive.

El consumo se encapsula en un servicio llamado CharacterService.cs.

## Estructura del código
RickAndMortyVisualizador/
│
├── wwwroot/
│   └── js/localStorage.js      → JSInterop para persistencia local
│
├── Models/
│   └── Character.cs            → Modelo base del personaje
│
├── Services/
│   ├── CharacterService.cs     → Lógica para consumir la API
│   └── LocalStorageService.cs → Interop JS para manejar localStorage
│
├── Pages/
│   └── Index.razor             → Página principal con lógica UI
│
├── Layout/
│   ├── MainLayout.razor        → Layout base
│   └── NavMenu.razor           → Navbar superior
│
├── App.razor                   → Sistema de enrutamiento
├── Program.cs                  → Registro de servicios
└── README.md                   → Este archivo


## Funcionalidades adicionales
Filtros combinados por:

Nombre del personaje

Estado (vivo/muerto/desconocido)

Especie

Orden por Likes/Dislikes

Persistencia local de votos con localStorage

Responsive usando Bootstrap 5

Interfaz limpia y navegación simplificada

## Decisiones técnicas

Se utilizó Blazor WebAssembly para aprovechar C# en el frontend.

Se usó Bootstrap 5 por su facilidad de integración y diseño responsive.

Se implementó JSInterop para manejar localStorage, ya que Blazor por defecto no tiene API directa para ello.

El código se estructuró en componentes reutilizables con clara separación de responsabilidades.

## Propuesta de mejora
Si hubiera contado con más tiempo, hubiera implementado las siguientes mejoras:

Despliegue más accesible: crear un entorno de despliegue aún más amigable (por ejemplo con un link directo público en Vercel, Netlify o GitHub Pages), permitiendo que usuarios sin conocimientos técnicos puedan acceder fácilmente a la aplicación sin necesidad de instalar herramientas o entender GitHub.

API o backend propio: en lugar de depender solamente de la API pública de Rick and Morty, se podría haber creado un servicio intermedio (API REST propia en .NET) para manejar la lógica de votos, estadísticas, favoritos, y almacenar datos reales con una base de datos.

Vinculación con episodios: permitir hacer clic sobre un personaje y ver en qué episodios aparece, integrando múltiples endpoints de la API oficial.