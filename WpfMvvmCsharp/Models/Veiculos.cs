using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmCsharp.Models
{
    public class Veiculos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public short Ano { get; set; }

        public List<Veiculos> ObterVeiculos()
        {
            List<Veiculos> listaVeiculos = new List<Veiculos>()
            {
                new Veiculos {Id=1, Nome="Ford Fiesta", Modelo="1.0 Hatch", Ano=2005},
                new Veiculos {Id=2,Nome="Honda CRV",Modelo="2.0 LX",Ano=2018},
                new Veiculos {Id=3,Nome="Land Rover Discovery 4",Modelo="3.0 SE 4x4",Ano=2021}
            };

            return listaVeiculos;
        }
    }
}
