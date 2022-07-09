using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Domain.Entities;

namespace ViacaoCalango.Domain.Interfaces
{
    public interface IReservaService { 

        //Lista as viagens disponiveis no dia
        public List<Viagem> listaReservasDia(DateTime diaorigem);
    
        //Criar a reserva a partir da Viagem escolhida para um lugar
        Reserva CriarReserva( int PassageiroID, Viagem viagem, Lugar lugar );

        //Verifica a quantidade de lugares no onibus
        public int VerQuantidadeLugar(Onibus onibus);

        //Verifica se um lugar está disponivel
        public bool VerificarLugaresDisponiveis(Onibus onibus, int nassento, Trecho atual);

        //Lista de Onibus por dia e rota
        public List<Onibus> listadeOnibusDiaRota(Rota rota, DateTime diaorigem);

        //Ver se o passageiro está no onibus
        public bool VerificarPassageiroOnibus( int PassageiroID, Onibus onibus );

        //Ver a lista de Lugares disponiveis em função do Trecho
        public List<Lugar> VerificarListaLugaresDisponiveis( Onibus onibus , Trecho atual );
      


    }
}
