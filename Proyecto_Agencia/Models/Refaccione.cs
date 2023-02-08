/********************************************************  
 *    Autor:Pérez Hernández Jazziel.                    *
 *    Fecha creación: 06 de febrero del 2023.           *
 *    Fecha actualización: 08 de febrero del 2023.      *
 *    Descripción: Actualización de la clase Refaccione.*
 ********************************************************/
using System;
using System.Collections.Generic;

namespace Proyecto_Agencia.Models;

//Clase Refaccione
public partial class Refaccione
{
    //Método IdRefaccion (Get, Set)
    public int IdRefaccion { get; set; }

    //Método Nombre (Get, Set)
    public string Nombre { get; set; } = null!;

    //Método Marca (Get, Set)
    public string? Marca { get; set; }

    //Método Precio (Get, Set)
    public decimal Precio { get; set; }

    //Método Descripción (Get, Set)
    public string? Descripcion { get; set; }

    //Método Cantidad (Get, Set)
    public decimal? Cantidad { get; set; }
}
