using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Domain.Entities;
using ViacaoCalango.Infra.Data.Pagamentos;

namespace ViacaoCalango.Domain.Services
{
    public class PagamentoService
    {
       public List<Reserva> Fazerreserva(Passageiro passageiro, List<Viagem> viagens)
        {
            Pagamento pagamento = new Pagamento();
            pagamento.PassageiroID = passageiro.Id;

            ModuloPagador moduloPagador = new ModuloPagador();
            if(moduloPagador.EfetuarPagamento(passageiro.Id))
            {
                pagamento.Status = true;
            }

            List<Reserva> reservaList = new List<Reserva>();

            foreach (var viagem in viagens)
            {
                Reserva reserva = new Reserva();
                reserva.Id = 1;
                reserva.PassageiroID = pagamento.PassageiroID;
                reserva.RotaID = viagem.onibus.RotaId;
                reserva.TrechoOrigem = viagem.trechoOrigem;
                reserva.TrechoDestino = viagem.trechoDestino;
                reserva.Ida = viagem.ida;
                reserva.Volta = viagem.volta;
                reserva.Classe = viagem.classe;
                reserva.DataIda = viagem.dataIda;
                reserva.DataVolta = viagem.dataVolta;
                reserva.HoraEmbarque = viagem.horaEmbarque;
                reserva.Valor = viagem.valor;

                reservaList.Add(reserva);
            }

           return reservaList;

        }
    }
}
