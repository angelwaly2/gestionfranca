using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PruebaCSharp.Models
{
    public class TecnicoModel
    {
        DataClasses1DataContext contexto = new DataClasses1DataContext();

        public List<TecnicoSucursal> listar()
        {
            List<TecnicoSucursal> lista = new List<TecnicoSucursal>();
            var consulta = contexto.sp_gf_listar_tecnicos();
            foreach (var tec1 in consulta)
            {
                TecnicoSucursal tec2 = new TecnicoSucursal();
                tec2.identificacion = tec1.identificacion;
                tec2.codigo = Convert.ToInt16(tec1.codigo);
                tec2.tecnico = tec1.tecnico;
                tec2.sucursal = tec1.sucursal;
                tec2.total_elementos = Convert.ToInt16(tec1.total);
                tec2.nom_tecnico = tec1.tecnico;
                lista.Add(tec2);
            }
            return lista;
        }

        public class Sucursal
        {
            public double id {get;set;}
            public String sucursal{get;set;}
        }

        public List<Sucursal> listar_sucursales()
        {
            List<Sucursal> lista = new List<Sucursal>();
            var consulta = contexto.tbl_gf_sucursales;
            foreach (var s in consulta)
            {
                Sucursal s1 = new Sucursal();
                s1.id = s.id;
                s1.sucursal = s.nom_sucursal;
                lista.Add(s1);
            }
            return lista;
        }

        public List<Elementos> listar_Elementos()
        {
            List<Elementos> lista = new List<Elementos>();
            var consulta = contexto.tbl_gf_elementos;
            foreach (var s in consulta)
            {
                Elementos e1 = new Elementos();
                e1.id_elemento = s.id;
                e1.nom_elemento = s.nom_elemento;
                lista.Add(e1);
            }
            return lista;
        }

        public class TecnicoSucursal
        {
            public Double identificacion { get; set; }
            public int codigo{ get; set; }
            [Required(ErrorMessage = "Ingrese Nombre")]
            public String  tecnico{ get; set; }
            public String sucursal { get; set; }
            public int total_elementos { get; set; }

            public int cod_tecnico { get; set; }
            
            public String nom_tecnico { get; set; }
            public double id_sucursal { get; set; }
        }

        public class Elementos
        {
            public Double id_elemento { get; set; }
            public String nom_elemento { get; set; }
        }


        public class Tecnico
        {
            public int cod_tecnico { get; set; }
            [Required(ErrorMessage = "Ingrese Nombre")]
            public String nom_tecnico { get; set; }
            public double id_sucursal { get; set; }
        }

    }

}