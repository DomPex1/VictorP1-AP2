using System;
using System.ComponentModel.DataAnnotations;

namespace VictorP1_AP2.Models{

    public class Articulos{

        [Key]
        public int ArticuloId{get; set;}
        [Required(ErrorMessage = "La descripcion es obligatoria")]
        public string Descripcion{get; set;}
        [Required,Range(minimum:1,maximum:int.MaxValue,ErrorMessage = "La existencia debe ser mayor de cero")]
        public int Existencia{get; set;}
        [Required,Range(minimum:1,maximum:int.MaxValue,ErrorMessage = "El costo debe ser mayor que cero")]
        public float Costo{get; set;}
        [Required,Range(minimum:1,maximum:int.MaxValue,ErrorMessage = "El valor del inventario debe ser mayor que cero")]
        public float ValorInventario{get; set;}

    }

}