/***************************************************  
 *    Autor:Pérez Hernández Jazziel.               *
 *    Fecha creación: 06 de febrero del 2023.      *
 *    Fecha actualización: 08 de febrero del 2023. *
 *    Descripción: Actualización de la clase Moto. *
 ***************************************************/
using System;
using System.Collections.Generic;

namespace Proyecto_Agencia.Models;

//Clase Moto
public partial class Moto
{
    //Método de IdMoto (Get, Set)
    public int IdMoto { get; set; }

    //Método Modelo (Get, Set)
    public string Modelo { get; set; } = null!;

    //Método Color (Get, Set)
    public string? Color { get; set; }

    //Método Precio (Get, Set)
    public decimal Precio { get; set; }

    //Método Cantidad (Get, Set)
    public decimal? Cantidad { get; set; }
}
